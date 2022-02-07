using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using net.autotask.webservices;
using Entity = AutotaskNET.Entities.Entity;
using Task = System.Threading.Tasks.Task;
using TicketHistory = AutotaskNET.Entities.TicketHistory;

namespace AutotaskNET
{

    public interface IATWSInterface
    {
        void Connect(string username, string password);
        IEnumerable<Entity> Query(Type entity_type, QueryFilter filters = null);
        IEnumerable<Entity> Query(Entities.Entity entity, QueryFilter filters = null);
        Entities.Entity Create(Entities.Entity entity);
        Entity Update(Entities.Entity entity);
        bool Delete(Entities.Entity entity);
        List<PicklistValue> GetPicklistValues(Type entity_type, string field);
        List<PicklistValue> GetPicklistValues(Entities.Entity entity, string field);
        List<FieldInformation> GetUDFInfo(Type entity_type);
        List<FieldInformation> GetUDFInfo(Entities.Entity entity);
        Task<List<EntityInformation>> GetEntityInfo();
        bool HasAuthenticated { get; }

        getThresholdAndUsageInfoResponse GetThreshold();
    }
    public class ATWSInterface : IATWSInterface
    {
        /// <summary>
        /// The Autotask Web Service Object.
        /// </summary>
        private net.autotask.webservices.ATWSSoap _atws;
        
        public string UserName { get; }
        public string Password { get; }
        public string IntegrationsCode { get; }

        private AutotaskIntegrations Integrations => new AutotaskIntegrations()
        {
            IntegrationCode = IntegrationsCode
        };


        public ATWSInterface(string userName, string password, string integrationCode)
        {
            UserName = userName;
            Password = password;
            IntegrationsCode = integrationCode;
        }

        /// <summary>
        /// Indicates whether the interface has been connected.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the interface has been connected; otherwise, <c>false</c>.
        /// </value>
        public bool HasAuthenticated { get; private set; } = false;

        public getThresholdAndUsageInfoResponse GetThreshold()
        {
            var result = _atws.getThresholdAndUsageInfoAsync(new getThresholdAndUsageInfoRequest()).Result;
            return result;
        }

        /// <summary>
        /// Connects using the specified username and password.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <exception cref="AutotaskNETException">Error getting zone information.</exception>
        [Obsolete]
        public void Connect(string username, string password)
        {
            throw new InvalidOperationException("This method is deprecated.  You must use the integrationCode.");
        }
        
        public void Connect()
        {

            _atws = new ATWSSoapClient()
            {
                ClientCredentials = { UserName = { UserName = UserName, Password = Password } },
            };
            
            ATWSSoapClient client = new ATWSSoapClient();
            var zoneInfoResponse = client.getZoneInfoAsync(UserName).Result;
            BasicHttpBinding basicHttpBinding = new BasicHttpBinding
            {
                Security =
                {
                    Mode = BasicHttpSecurityMode.Transport,
                    Transport =
                    {
                        ClientCredentialType = HttpClientCredentialType.Basic
                    }
                },
                MaxReceivedMessageSize = (long) int.MaxValue
            };
            EndpointAddress remoteAddress = new EndpointAddress(zoneInfoResponse.URL);
            Task.WaitAll(client.CloseAsync());
            client = new ATWSSoapClient((Binding) basicHttpBinding, remoteAddress);
            client.ClientCredentials.UserName.UserName = UserName;
            client.ClientCredentials.UserName.Password = Password;

            _atws = client;
            HasAuthenticated = true;
        }
        

        #region Query

        /// <summary>
        /// Queries entities using type
        /// </summary>
        /// <param name="entity_type">type of entity to query</param>
        /// <param name="filters">query filters</param>
        /// <returns></returns>
        public IEnumerable<Entity> Query(Type entity_type, QueryFilter filters = null)
        {
            return this.Query((Entities.Entity)Activator.CreateInstance(entity_type), filters);
        } //end Query(Type entity_type, List<QueryFilter> filters = null)

        /// <summary>
        /// Queries entities using instance
        /// </summary>
        /// <param name="entity">instance of entity to query</param>
        /// <param name="filters">query filters</param>
        /// <returns></returns>
        public IEnumerable<Entity> Query(Entities.Entity entity, QueryFilter filters = null)
        {
            //List<Entities.Entity> entities = null;
            
            if (!entity.CanQuery)
            {
                throw new AutotaskNETException($"The {entity.GetType().Name} entity can not be queried.");
            }
            else
            {
                //query entity
                //entities = new List<Entities.Entity>();
                bool query_done = false;
                long current_id = 0;
                while (!query_done)
                {
                    //create query
                    StringBuilder query = new StringBuilder();
                    query.Append("<queryxml version=\"1.0\">");
                    query.Append($"<entity>{entity.GetType().Name}</entity>");
                    query.Append("<query>");



                    #region QueryFilters


                    //use id to pull more than 500 records if id is not already a filter
                    if ((filters == null || !QueryFilter.ContainsCondition(new QueryCondition(filters), "id"))
                        && entity.GetType()!=typeof(TicketHistory))
                    {
                        query.Append($"<field>Id<expression op=\"greaterthan\">{current_id}</expression></field>");
                    }
                    

                    //handle all other filters
                    if (filters != null)
                    {
                        string cond = this.ParseConditions(new QueryCondition(filters));
                        query.Append(cond);
                    }


                    #endregion //QueryFilters



                    query.Append("</query>");
                    query.Append("</queryxml>");


                    //Console.WriteLine(query.ToString());

                    //submit query
                    ATWSResponse response = this._atws.queryAsync(new queryRequest(
                        Integrations, query.ToString())).Result.queryResult;

                    if (response.Errors.Any())
                    {
                        throw new AutotaskNETException(response.Errors.FirstOrDefault().Message);
                    }
                    
                    //parse response
                    if (response.ReturnCode > 0 && response.EntityResults.Length > 0)
                    {
                        List<Entities.Entity> temp_entities = new List<Entities.Entity>();
                        foreach (net.autotask.webservices.Entity atws_entity in response.EntityResults)
                        {
                            temp_entities.Add((Entities.Entity)Activator.CreateInstance(entity.GetType(), atws_entity));
                        }
                        current_id = temp_entities.First(e => e.id == temp_entities.Max(m => m.id)).id;
                        foreach (var i in temp_entities)
                            yield return i;
                        //entities.AddRange(temp_entities);
                        temp_entities = null;

                        //###########################################################################
                        if ((filters != null && QueryFilter.ContainsCondition(
                            new QueryCondition(filters), "id")) || response.EntityResults.Length < 500) { query_done = true; }

                    }
                    else
                    {
                        //no results or error
                        query_done = true;
                    }
                }
            }
            //return entities;

        } //end Query(Entities.Entity entity, List<QueryFilter> filters = null)

        /// <summary>
        /// Parses the conditions.
        /// </summary>
        /// <param name="conditions">The conditions.</param>
        /// <returns>conditions parsed into query string.</returns>
        private string ParseConditions(QueryCondition conditions)
        {
            bool containsUDF = false;
            StringBuilder query_string = new StringBuilder();
            foreach (QueryCondition condition_group in conditions)
            {
                if (condition_group.GetType() == typeof(QueryCondition))
                {
                    query_string.Append("<condition" + (string.IsNullOrEmpty(condition_group.Operation) ? "" : $" operator=\"{condition_group.Operation}\"") + ">" + this.ParseConditions(condition_group) + "</condition>");
                }
                else if (condition_group.GetType() == typeof(QueryField))
                {
                    QueryField condition = (QueryField)condition_group;
                    if (condition.IsUDF && containsUDF)
                    {
                        throw new ArgumentException("Queries can only contain 1 UDF filter.");
                    }
                    else if (condition.IsUDF)
                    {
                        containsUDF = true;
                        query_string.Append($"<field udf=\"true\">{condition.FieldName}<expression op=\"{condition.Operation}\">{condition.Value?.ToString()}</expression></field>");
                    }
                    else
                    {
                        query_string.Append($"<field>{condition.FieldName}<expression op=\"{condition.Operation}\">{condition.Value?.ToString()}</expression></field>");
                    }
                }
            }
            return query_string.ToString();

        } //end ParseConditions

        #endregion //Query




        #region Create

        /// <summary>
        /// Creates entities
        /// </summary>
        /// <param name="entity">entity to create</param>
        /// <returns></returns>
        public Entities.Entity Create(Entities.Entity entity)
        {
            Entities.Entity createdEntity = null;
            if (!entity.CanCreate)
            {
                throw new AutotaskNETException($"The {entity.GetType()} entity can not be created.");
            }
            else
            {
                dynamic typedEntity = Convert.ChangeType(entity, entity.GetType());

                //create entity
                var resp = this._atws.createAsync(
                    new createRequest(Integrations, new net.autotask.webservices.Entity[] {typedEntity})).Result.createResult;

                 if (resp.Errors.Length > 0 && resp.EntityReturnInfoResults.Length <= 0)
                {
                    throw new AutotaskNETException(string.Join("\r\n", resp.Errors.Select(r => r.Message)));
                }
                else
                {
                    createdEntity = this.Query(entity.GetType(), new QueryFilter()
                    {
                        new QueryField("id", QueryFieldOperation.Equals, resp.EntityReturnInfoResults[0].EntityId)
                    }).FirstOrDefault();
                }
            }
            return createdEntity;
        } //end Create

        #endregion //Create




        #region Update

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        /// <returns>the updated entity.</returns>
        /// <exception cref="AutotaskNETException">
        /// The entity cannot be updated.
        /// Response error.
        /// </exception>
        public Entity Update(Entities.Entity entity)
        {
            Entities.Entity updatedEntity = null;
            if (!entity.CanUpdate)
            {
                throw new AutotaskNETException($"The {entity.GetType()} entity can not be updated.");
            }
            else
            {
                dynamic typedEntity = Convert.ChangeType(entity, entity.GetType());

                //update entity
                net.autotask.webservices.ATWSResponse resp = this._atws.updateAsync(
                    new updateRequest(Integrations,new net.autotask.webservices.Entity[] {typedEntity})).Result.updateResult;
                
                if (resp.Errors.Length > 0 && resp.EntityReturnInfoResults.Length <= 0)
                {
                    throw new AutotaskNETException(string.Join("\r\n", resp.Errors.Select(r => r.Message)));
                }
                else
                {
                    updatedEntity = this.Query(entity.GetType(), new QueryFilter() { new QueryField("id", QueryFieldOperation.Equals, resp.EntityReturnInfoResults[0].EntityId) }).FirstOrDefault();
                }
            }
            return updatedEntity;
        } //end Update

        #endregion //Update




        #region Delete

        /// <summary>
        /// Deletes entities
        /// </summary>
        /// <param name="entity">entity to delete</param>
        /// <returns></returns>
        public bool Delete(Entities.Entity entity)
        {
            bool deletedEntity = false;
            if (!entity.CanDelete)
            {
                throw new AutotaskNETException($"The {entity.GetType()} entity can not be deleted.");
            }
            else
            {
                dynamic typedEntity = Convert.ChangeType(entity, entity.GetType());

                //delete entity
                net.autotask.webservices.ATWSResponse resp = _atws.deleteAsync(
                    new deleteRequest(Integrations, new net.autotask.webservices.Entity[] {typedEntity})).Result.deleteResult;
                if (resp.Errors.Length > 0)
                {
                    throw new AutotaskNETException(string.Join("\r\n", resp.Errors.Select(r => r.Message)));
                }
                else
                {
                    deletedEntity = true;
                }
            }
            return deletedEntity;
        } //end Delete

        #endregion //Delete
        



        #region Get Information
        
        /// <summary>
        /// Gets entity information.
        /// </summary>
        /// <returns>A list of entity information.</returns>
        public async Task<List<EntityInformation>> GetEntityInfo()
        {
            List<EntityInformation> entityInfo = new List<EntityInformation>();

            List<net.autotask.webservices.EntityInfo> eInfo = this._atws.
                getEntityInfoAsync(new GetEntityInfo(Integrations)).Result
                .GetEntityInfoResult.ToList();
            foreach(net.autotask.webservices.EntityInfo ent in eInfo)
            {
                entityInfo.Add(new EntityInformation(ent));
            }
            
            return entityInfo;

        } //end GetEntityInfo()


        /// <summary>
        /// Gets the field information.
        /// </summary>
        /// <param name="entity_type">The entity type.</param>
        /// <returns></returns>
        public List<FieldInformation> GetFieldInfo(Type entity_type)
        {
            return this.GetFieldInfo((Entities.Entity)Activator.CreateInstance(entity_type));

        } //end GetFieldInfo(Type entity_type)

        /// <summary>
        /// Gets the field information.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public List<FieldInformation> GetFieldInfo(Entities.Entity entity)
        {
            List<FieldInformation> fieldInfo = new List<FieldInformation>();

            List<net.autotask.webservices.Field> eInfo = this._atws.GetFieldInfoAsync(
                new GetFieldInfoRequest(Integrations, entity.GetType().Name)).Result.GetFieldInfoResult.ToList();
            foreach (net.autotask.webservices.Field fld in eInfo)
            {
                fieldInfo.Add(new FieldInformation(fld));
            }
            
            return fieldInfo;

        } //end GetFieldInfo(Entities.Entity entity)
        

        /// <summary>
        /// Gets the picklist values of a field.
        /// </summary>
        /// <param name="entity_type">The entity type.</param>
        /// <param name="field">The field name.</param>
        /// <returns></returns>
        public List<PicklistValue> GetPicklistValues(Type entity_type, string field)
        {
            var entity = Activator.CreateInstance(entity_type);
            return this.GetPicklistValues((Entity) entity, field);
        } //end GetPicklistValues(Type entity_type, string field)
        /// <summary>
        /// Gets the picklist values of a field.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="field">The field name.</param>
        /// <returns></returns>
        public List<PicklistValue> GetPicklistValues(Entities.Entity entity, string field)
        {
            List<PicklistValue> listValues = new List<PicklistValue>();
            net.autotask.webservices.Field fieldInfo = this._atws.GetFieldInfoAsync(
                new GetFieldInfoRequest(Integrations, entity.GetType().Name)).Result.GetFieldInfoResult.ToList().SingleOrDefault(f => f.Name == field);
            if (fieldInfo != null)
            {
                foreach (net.autotask.webservices.PickListValue plv in fieldInfo.PicklistValues)
                {
                    listValues.Add(new PicklistValue(plv));
                }
            }
            return listValues;

        } //end GetPicklistValues(Entities.Entity entity, string field)


        /// <summary>
        /// Gets UDF information.
        /// Currently, the following Autotask entities can include UDFs: 
        ///   Account
        ///   AccountLocation
        ///   Contact
        ///   InstalledProduct
        ///   Opportunity
        ///   Product
        ///   Project
        ///   Task
        ///   Ticket
        /// </summary>
        /// <param name="entity_type">The entity type.</param>
        /// <returns></returns>
        public List<FieldInformation> GetUDFInfo(Type entity_type)
        {
            return this.GetUDFInfo((Entities.Entity)Activator.CreateInstance(entity_type));
        } //end GetUDFInfo(Type entity_type)
        /// <summary>
        /// Gets UDF information.
        /// Currently, the following Autotask entities can include UDFs: 
        ///   Account
        ///   AccountLocation
        ///   Contact
        ///   InstalledProduct
        ///   Opportunity
        ///   Product
        ///   Project
        ///   Task
        ///   Ticket
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public List<FieldInformation> GetUDFInfo(Entities.Entity entity)
        {
            List<FieldInformation> UDFs = new List<FieldInformation>();
            List<net.autotask.webservices.Field> fields = this._atws.getUDFInfoAsync(
                new getUDFInfoRequest(Integrations, entity.GetType().Name)).Result.getUDFInfoResult.ToList();
            if (fields != null && fields.Count > 0)
            {
                foreach (net.autotask.webservices.Field field in fields)
                {
                    UDFs.Add(new FieldInformation(field));
                }
            }
            return UDFs;

        } //end getUDFInfo
        

        #endregion //Get Information

        /// <returns attachment></returns>
        public Attachment GetAttachment(long attachmentId)
        {
            
            Attachment attachment = this._atws.GetAttachmentAsync(
                new GetAttachmentRequest(Integrations, attachmentId)).Result.GetAttachmentResult;

            return attachment;

        } //end GetAttachment

        /// <summary>
        /// Gets UDF information.
        /// Creates an attachment and links it to a parent. 
        /// </summary>
        /// <param name="newAttachment">The attachment.</param>
        /// <returns attachmentId></returns>
        public long CreateAttachment(Attachment newAttachment)
        {

            long attachmentId = this._atws.CreateAttachmentAsync(
                new CreateAttachmentRequest(Integrations, newAttachment)).Result.CreateAttachmentResult;

            return attachmentId;

        } //end CreateAttachment

    } //end ATWSInterface

}
