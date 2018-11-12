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
        /// Initializes a new instance of the <see cref="ATWSInterface" /> class.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <exception cref="ArgumentException">Connection parameters are not defined.</exception>
        /// <exception cref="Exception">
        /// Error getting zone information.
        /// Login Error.
        /// </exception>
        public ATWSInterface(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Connection parameters are not defined.");
            }

            this._atws = new net.autotask.webservices.ATWS() { Url = Properties.Settings.Default.Autotask_Net_Webservices_ATWS };
            try
            {
                net.autotask.webservices.ATWSZoneInfo zoneInfo = this._atws.getZoneInfo(username);
                if (zoneInfo.ErrorCode >= 0)
                {
                    this._atws = new net.autotask.webservices.ATWS() { Url = zoneInfo.URL };
                    this._atws.Url = zoneInfo.URL;
                    CredentialCache _cache = new CredentialCache();
                    _cache.Add(new Uri(this._atws.Url), "BASIC", new NetworkCredential(username, password));
                    this._atws.Credentials = _cache;
                }
                else
                {
                    throw new Exception("Error getting zone information.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Login Error: " + ex.Message);
            }
        } //end WebService
        
        /// <summary>
        /// The Autotask Web Service Object
        /// </summary>
        private readonly net.autotask.webservices.ATWS _atws;


        #region Query

        /// <summary>
        /// Queries entities using type
        /// </summary>
        /// <param name="entity_type">type of entity to query</param>
        /// <param name="filters">query filters</param>
        /// <returns></returns>
        public List<Entities.Entity> Query(Type entity_type, List<QueryFilter> filters = null)
        {
            return this.Query((Entities.Entity)Activator.CreateInstance(entity_type), filters);
        } //end Query(Type entity_type, List<QueryFilter> filters = null)

        /// <summary>
        /// Queries entities using instance
        /// </summary>
        /// <param name="entity">instance of entity to query</param>
        /// <param name="filters">query filters</param>
        /// <returns></returns>
        public List<Entities.Entity> Query(Entities.Entity entity, List<QueryFilter> filters = null)
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
                    if (filters != null && filters.Exists(f => f.FieldName == "id"))
                    {
                        QueryFilter filter = filters.Find(f => f.FieldName == "id");
                        query.Append($"<field>Id<expression op=\"{filter.Operation}\">{filter.Value.ToString()}</expression></field>");
                    }
                    else
                    {
                        query.Append($"<field>Id<expression op=\"greaterthan\">{current_id}</expression></field>");
                    }
                    if (filters != null)
                    {
                        foreach (QueryFilter filter in filters.Where(f => f.FieldName != "id"))
                        {
                            query.Append($"<field>{filter.FieldName}<expression op=\"{filter.Operation}\">{filter.Value.ToString()}</expression></field>");
                        }
                    }
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
                        if (filters != null && filters.Exists(f => f.FieldName == "id")) { query_done = true; }
                    }
                    else
                    {
                        query_done = true;
                    }
                }
            }
            return entities;

        } //end Query(Entities.Entity entity, List<QueryFilter> filters = null)

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

            }
            return createdEntity;
        } //end Create

        #endregion //Create


        #region Update

        /// <summary>
        /// Updates entities
        /// </summary>
        /// <param name="entity">entity to update</param>
        /// <returns></returns>
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
        public Entities.Entity Delete(Entities.Entity entity)
        {
            Entities.Entity createdEntity = null;
            if (!true)//entity.CanDelete)
            {
                throw new AutotaskNETException($"The {entity.GetType()} entity can not be deleted.");
            }
            else
            {
                //delete entity

            }
            return createdEntity;
        } //end Delete

        #endregion //Delete
        
        #region GetPicklistValues

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
        /// <param name="entity">The entity instance.</param>
        /// <param name="field">The field name.</param>
        /// <returns>a list of <see cref="AutotaskNET.PicklistValue"/>.</returns>
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

        #endregion //GetPicklistValues
        
    } //end ATWSInterface

}
