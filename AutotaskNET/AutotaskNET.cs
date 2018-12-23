using System;
using System.Linq;
using System.Text;
using System.Net;
using System.Collections.Generic;

namespace AutotaskNET
{
    public class ATWSInterface
    {
        /// <summary>
        /// The Autotask Web Service Object.
        /// </summary>
        private net.autotask.webservices.ATWS _atws;
        
        /// <summary>
        /// Indicates whether the interface has been connected.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the interface has been connected; otherwise, <c>false</c>.
        /// </value>
        public bool IsConnected { get; internal set; } = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="ATWSInterface"/> class.
        /// </summary>
        public ATWSInterface() { } //end ATWSInterface

        /// <summary>
        /// Connects using the specified username and password.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <exception cref="AutotaskNETException">Error getting zone information.</exception>
        public void Connect(string username, string password)
        {
            this._atws = new net.autotask.webservices.ATWS() { Url = Properties.Settings.Default.Autotask_Net_Webservices_ATWS };

            net.autotask.webservices.ATWSZoneInfo zoneInfo = this._atws.getZoneInfo(username);
            if (zoneInfo.ErrorCode >= 0)
            {
                this._atws = new net.autotask.webservices.ATWS() { Url = zoneInfo.URL };
                this._atws.Url = zoneInfo.URL;
                CredentialCache _cache = new CredentialCache
                {
                    { new Uri(this._atws.Url), "BASIC", new NetworkCredential(username, password) }
                };
                this._atws.Credentials = _cache;
                this.IsConnected = true;
            }
            else
            {
                throw new AutotaskNETException("Error getting zone information.");
            }
        }
        



        #region Query

        /// <summary>
        /// Queries entities using type
        /// </summary>
        /// <param name="entity_type">type of entity to query</param>
        /// <param name="filters">query filters</param>
        /// <returns></returns>
        public List<Entities.Entity> Query(Type entity_type, QueryFilter filters = null)
        {
            return this.Query((Entities.Entity)Activator.CreateInstance(entity_type), filters);
        } //end Query(Type entity_type, List<QueryFilter> filters = null)

        /// <summary>
        /// Queries entities using instance
        /// </summary>
        /// <param name="entity">instance of entity to query</param>
        /// <param name="filters">query filters</param>
        /// <returns></returns>
        public List<Entities.Entity> Query(Entities.Entity entity, QueryFilter filters = null)
        {
            List<Entities.Entity> entities = null;
            
            if (!entity.CanQuery)
            {
                throw new AutotaskNETException($"The {entity.GetType().Name} entity can not be queried.");
            }
            else
            {
                //query entity
                entities = new List<Entities.Entity>();
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
                    if (filters == null || !QueryFilter.ContainsCondition(new ConditionGroup(filters), "id"))
                    {
                        query.Append($"<field>Id<expression op=\"greaterthan\">{current_id}</expression></field>");
                    }
                    

                    //handle all other filters
                    if (filters != null)
                    {
                        string cond = this.ParseConditions(new ConditionGroup(filters));
                        query.Append(cond);
                    }


                    #endregion //QueryFilters



                    query.Append("</query>");
                    query.Append("</queryxml>");

                    //submit query
                    net.autotask.webservices.ATWSResponse response = this._atws.query(query.ToString());

                    //parse response
                    if (response.ReturnCode > 0 && response.EntityResults.Length > 0)
                    {
                        List<Entities.Entity> temp_entities = new List<Entities.Entity>();
                        foreach (net.autotask.webservices.Entity atws_entity in response.EntityResults)
                        {
                            temp_entities.Add((Entities.Entity)Activator.CreateInstance(entity.GetType(), new object[] { atws_entity }));
                        }
                        current_id = temp_entities.First(e => e.id == temp_entities.Max(m => m.id)).id;
                        entities.AddRange(temp_entities);
                        temp_entities = null;

                        //###########################################################################
                        if ((filters != null && QueryFilter.ContainsCondition(new ConditionGroup(filters), "id")) || response.EntityResults.Length < 500) { query_done = true; }

                    }
                    else
                    {
                        //no results or error
                        query_done = true;
                    }
                }
            }
            return entities;

        } //end Query(Entities.Entity entity, List<QueryFilter> filters = null)

        /// <summary>
        /// Parses the conditions.
        /// </summary>
        /// <param name="conditions">The conditions.</param>
        /// <returns>conditions parsed into query string.</returns>
        private string ParseConditions(ConditionGroup conditions)
        {
            StringBuilder query_string = new StringBuilder();
            foreach (ConditionGroup condition_group in conditions)
            {
                if (condition_group.GetType() == typeof(ConditionGroup))
                {
                    query_string.Append("<condition" + (string.IsNullOrEmpty(condition_group.Operation) ? "" : $" operator=\"{condition_group.Operation}\"") + ">" + this.ParseConditions(condition_group) + "</condition>");
                }
                else if (condition_group.GetType() == typeof(Condition))
                {
                    Condition condition = (Condition)condition_group;
                    query_string.Append($"<field>{condition.FieldName}<expression op=\"{condition.Operation}\">{condition.Value.ToString()}</expression></field>");
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
            if (!true)//entity.CanCreate)
            {
                throw new AutotaskNETException($"The {entity.GetType()} entity can not be created.");
            }
            else
            {
                //create entity
                net.autotask.webservices.ATWSResponse resp = this._atws.create(new net.autotask.webservices.Entity[] { entity.ToATWS() });
                if (resp.Errors.Length > 0)
                {
                    throw new AutotaskNETException(string.Join("\r\n", resp.Errors.Select(r => r.Message)));
                }
                else
                {
                    createdEntity = this.Query(entity.GetType(), new QueryFilter() { new Condition("id", ConditionOperation.Equals, entity.id) }).FirstOrDefault();
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
        public Entities.Entity Update(Entities.Entity entity)
        {
            Entities.Entity updatedEntity = null;
            if (!true)//entity.CanUpdate)
            {
                throw new AutotaskNETException($"The {entity.GetType()} entity can not be updated.");
            }
            else
            {
                //update entity
                net.autotask.webservices.ATWSResponse resp = this._atws.update(new net.autotask.webservices.Entity[] { entity.ToATWS() });
                if (resp.Errors.Length > 0)
                {
                    throw new AutotaskNETException(string.Join("\r\n", resp.Errors.Select(r => r.Message)));
                }
                else
                {
                    updatedEntity = this.Query(entity.GetType(), new QueryFilter() { new Condition("id", ConditionOperation.Equals, entity.id) }).FirstOrDefault();
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
            if (!true)//entity.CanDelete)
            {
                throw new AutotaskNETException($"The {entity.GetType()} entity can not be deleted.");
            }
            else
            {
                //delete entity
                net.autotask.webservices.ATWSResponse resp = this._atws.delete(new net.autotask.webservices.Entity[] { entity.ToATWS() });
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
        public List<EntityInformation> GetEntityInfo()
        {
            List<EntityInformation> entityInfo = new List<EntityInformation>();

            List<net.autotask.webservices.EntityInfo> eInfo = this._atws.getEntityInfo().ToList();
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

            List<net.autotask.webservices.Field> eInfo = this._atws.GetFieldInfo(entity.GetType().Name).ToList();
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
            return this.GetPicklistValues((Entities.Entity)Activator.CreateInstance(entity_type), field);
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
            net.autotask.webservices.Field fieldInfo = this._atws.GetFieldInfo(entity.GetType().Name).ToList().SingleOrDefault(f => f.Name == field);
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
        } //end GetPicklistValues(Type entity_type, string field)
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
            List<net.autotask.webservices.Field> fields = this._atws.getUDFInfo(entity.GetType().Name).ToList();
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


    } //end ATWSInterface

}
