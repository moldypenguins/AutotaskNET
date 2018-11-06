using System;
using System.Linq;
using System.Text;
using System.Net;
using System.Collections.Generic;
using AutotaskNET.net.autotask.webservices;

namespace AutotaskNET
{
    public class WebService
    {
        /// <summary>
        /// The Autotask Web Service Object
        /// </summary>
        private readonly ATWS _atws;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebService" /> class.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <exception cref="ArgumentException">Connection parameters are not defined.</exception>
        /// <exception cref="Exception">
        /// Error getting zone information.
        /// Login Error.
        /// </exception>
        public WebService(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Connection parameters are not defined.");
            }

            this._atws = new ATWS() { Url = Properties.Settings.Default.Autotask_Net_Webservices_ATWS };
            try
            {
                ATWSZoneInfo zoneInfo = this._atws.getZoneInfo(username);
                if (zoneInfo.ErrorCode >= 0)
                {
                    this._atws = new ATWS() { Url = zoneInfo.URL };
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







        #region Query

        /// <summary>
        /// Queries entities using type
        /// </summary>
        /// <param name="entity_type">type of entity to query</param>
        /// <param name="filters">query filters</param>
        /// <returns></returns>
        public List<Entities.Entity> Query(Type entity_type, List<EntityFilter> filters = null)
        {
            return this.Query((Entities.Entity)Activator.CreateInstance(entity_type), filters);
        } //end Query(Type entity_type, List<EntityFilter> filters = null)

        /// <summary>
        /// Queries entities using instance
        /// </summary>
        /// <param name="entity">instance of entity to query</param>
        /// <param name="filters">query filters</param>
        /// <returns></returns>
        public List<Entities.Entity> Query(Entities.Entity entity, List<EntityFilter> filters = null)
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
                        EntityFilter filter = filters.Find(f => f.FieldName == "id");
                        query.Append($"<field>Id<expression op=\"{filter.Operation}\">{filter.Value.ToString()}</expression></field>");
                    }
                    else
                    {
                        query.Append($"<field>Id<expression op=\"greaterthan\">{current_id}</expression></field>");
                    }
                    if (filters != null)
                    {
                        foreach (EntityFilter filter in filters.Where(f => f.FieldName != "id"))
                        {
                            query.Append($"<field>{filter.FieldName}<expression op=\"{filter.Operation}\">{filter.Value.ToString()}</expression></field>");
                        }
                    }
                    query.Append("</query>");
                    query.Append("</queryxml>");

                    //submit query
                    ATWSResponse response = this._atws.query(query.ToString());

                    //parse response
                    if (response.ReturnCode > 0 && response.EntityResults.Length > 0)
                    {
                        List<Entities.Entity> temp_entities = new List<Entities.Entity>();
                        foreach (Entity atws_entity in response.EntityResults)
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

        } //end Query(Entities.Entity entity, List<EntityFilter> filters = null)

        #endregion //Query













        /// <summary>
        /// 
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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity">entity to create</param>
        /// <returns></returns>
        public Entities.Entity Create(Entities.Entity entity)
        {
            Entities.Entity createdEntity = null;
            if (!true)//entity.CanCreate)
            {
                throw new AutotaskNETException($"The {entity.GetType()} entity can not be updated.");
            }
            else
            {
                //create entity

            }
            return createdEntity;
        } //end Create


        /// <summary>
        /// 
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





        /// <summary>
        /// This method searches for fields.
        /// </summary>
        /// <param name="Entity">Contains the Entity name to return fields for</param>
        /// <returns>a list of fields.</returns>
        public List<Field> GetEntityFields(string Entity)
        {
            return this._atws.GetFieldInfo(Entity).ToList();
        }
        //end GetEntityFields





        /*
        foreach (PropertyInfo prop in this.Entity.GetType().GetProperties())
        {
            Console.WriteLine("{0}={1}", prop.Name, prop.GetValue(this.Entity, null));
        }
        */















        /*
        #region Accounts

        /// <summary>
        /// This method searches for accounts.
        /// </summary>
        /// <param name="filters">Contains the AccountFilters object to search with</param>
        /// <returns>a list of matching accounts.</returns>
        public List<Account> GetAccounts(AccountFilters filters = null)
        {
            List<Account> accounts = new List<Account>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strAccount = new StringBuilder();
                strAccount.Append("<queryxml version=\"1.0\">");
                strAccount.Append("<entity>Account</entity>");
                strAccount.Append("<query>");
                if (filters != null && filters.Id.HasValue)
                {
                    strAccount.Append("<field>Id<expression op=\"equals\">");
                    strAccount.Append(filters.Id);
                    strAccount.Append("</expression></field>");
                }
                else
                {
                    strAccount.Append("<field>Id<expression op=\"greaterthan\">");
                    strAccount.Append(currentId);
                    strAccount.Append("</expression></field>");
                }
                if (filters != null && !string.IsNullOrEmpty(filters.AccountName))
                {
                    strAccount.Append("<field>AccountName<expression op=\"equals\">");
                    strAccount.Append(filters.AccountName);
                    strAccount.Append("</expression></field>");
                }
                if (filters != null && filters.Active.HasValue)
                {
                    strAccount.Append("<field>Active<expression op=\"equals\">");
                    strAccount.Append(filters.Active.Value ? "1" : "0");
                    strAccount.Append("</expression></field>");
                }
                strAccount.Append("</query>");
                strAccount.Append("</queryxml>");

                ATWSResponse respAccount = this._atws.query(strAccount.ToString());

                if (respAccount.ReturnCode > 0 && respAccount.EntityResults.Length > 0)
                {
                    List<Account> temp = respAccount.EntityResults.Cast<Account>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    accounts.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return accounts;
        }
        //end GetAccounts

        /// <summary>
        /// This method searches for account todos.
        /// </summary>
        /// <param name="filters">Contains the AccountToDoFilters object to search with</param>
        /// <returns>a list of matching account todos.</returns>
        public List<AccountToDo> GetAccountToDos(AccountToDoFilters filters = null)
        {
            List<AccountToDo> accounttodos = new List<AccountToDo>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strAccountToDo = new StringBuilder();
                strAccountToDo.Append("<queryxml version=\"1.0\">");
                strAccountToDo.Append("<entity>AccountToDo</entity>");
                strAccountToDo.Append("<query>");
                if (filters != null && filters.Id.HasValue)
                {
                    strAccountToDo.Append("<field>Id<expression op=\"equals\">");
                    strAccountToDo.Append(filters.Id.Value.ToString());
                    strAccountToDo.Append("</expression></field>");
                }
                else
                {
                    strAccountToDo.Append("<field>Id<expression op=\"greaterthan\">");
                    strAccountToDo.Append(currentId);
                    strAccountToDo.Append("</expression></field>");
                }
                if (filters != null && filters.AccountID.HasValue)
                {
                    strAccountToDo.Append("<field>AccountID<expression op=\"equals\">");
                    strAccountToDo.Append(filters.AccountID.Value.ToString());
                    strAccountToDo.Append("</expression></field>");
                }
                if (filters != null && filters.TicketID.HasValue)
                {
                    strAccountToDo.Append("<field>TicketID<expression op=\"equals\">");
                    strAccountToDo.Append(filters.TicketID.Value.ToString());
                    strAccountToDo.Append("</expression></field>");
                }
                strAccountToDo.Append("</query>");
                strAccountToDo.Append("</queryxml>");

                ATWSResponse respAccountToDo = this._atws.query(strAccountToDo.ToString());

                if (respAccountToDo.ReturnCode > 0 && respAccountToDo.EntityResults.Length > 0)
                {
                    List<AccountToDo> temp = respAccountToDo.EntityResults.Cast<AccountToDo>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    accounttodos.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return accounttodos;
        }
        //end GetAccountToDos

        #endregion //Accounts

        #region Action Types

        /// <summary>
        /// This method searches for action types.
        /// </summary>
        /// <param name="filters">Contains the ActionTypeFilters object to search with</param>
        /// <returns>a list of matching action types.</returns>
        public List<ActionType> GetActionTypes(ActionTypeFilters filters = null)
        {
            List<ActionType> actiontypes = new List<ActionType>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strActionType = new StringBuilder();
                strActionType.Append("<queryxml version=\"1.0\">");
                strActionType.Append("<entity>ActionType</entity>");
                strActionType.Append("<query>");
                if (filters != null && filters.Id.HasValue)
                {
                    strActionType.Append("<field>Id<expression op=\"equals\">");
                    strActionType.Append(filters.Id);
                    strActionType.Append("</expression></field>");
                }
                else
                {
                    strActionType.Append("<field>Id<expression op=\"greaterthan\">");
                    strActionType.Append(currentId);
                    strActionType.Append("</expression></field>");
                }
                if (filters != null && filters.Active.HasValue)
                {
                    strActionType.Append("<field>Active<expression op=\"equals\">");
                    strActionType.Append(filters.Active.Value ? "1" : "0");
                    strActionType.Append("</expression></field>");
                }
                strActionType.Append("</query>");
                strActionType.Append("</queryxml>");

                ATWSResponse respActionType = this._atws.query(strActionType.ToString());

                if (respActionType.ReturnCode > 0 && respActionType.EntityResults.Length > 0)
                {
                    List<ActionType> temp = respActionType.EntityResults.Cast<ActionType>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    actiontypes.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return actiontypes;
        }
        //end GetActionTypes

        #endregion //Action Types

        #region Countries

        /// <summary>
        /// This method searches for countries.
        /// </summary>
        /// <param name="filters">Contains the CountryFilters object to search with</param>
        /// <returns>a list of matching countries.</returns>
        public List<Country> GetCountries(CountryFilters filters = null)
        {
            List<Country> countries = new List<Country>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strCountry = new StringBuilder();
                strCountry.Append("<queryxml version=\"1.0\">");
                strCountry.Append("<entity>Country</entity>");
                strCountry.Append("<query>");
                if (filters != null && filters.Id.HasValue)
                {
                    strCountry.Append("<field>Id<expression op=\"equals\">");
                    strCountry.Append(filters.Id);
                    strCountry.Append("</expression></field>");
                }
                else
                {
                    strCountry.Append("<field>Id<expression op=\"greaterthan\">");
                    strCountry.Append(currentId);
                    strCountry.Append("</expression></field>");
                }
                strCountry.Append("</query>");
                strCountry.Append("</queryxml>");

                ATWSResponse respDepartment = this._atws.query(strCountry.ToString());

                if (respDepartment.ReturnCode > 0 && respDepartment.EntityResults.Length > 0)
                {
                    List<Country> temp = respDepartment.EntityResults.Cast<Country>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    countries.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return countries;
        }
        //end GetCountries

        #endregion //Countries

        #region Departments

        /// <summary>
        /// This method searches for departments.
        /// </summary>
        /// <param name="filters">Contains the DepartmentFilters object to search with</param>
        /// <returns>a list of matching departments.</returns>
        public List<Department> GetDepartments(DepartmentFilters filters = null)
        {
            List<Department> departments = new List<Department>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strDepartment = new StringBuilder();
                strDepartment.Append("<queryxml version=\"1.0\">");
                strDepartment.Append("<entity>Department</entity>");
                strDepartment.Append("<query>");
                if (filters != null && filters.Id.HasValue)
                {
                    strDepartment.Append("<field>Id<expression op=\"equals\">");
                    strDepartment.Append(filters.Id);
                    strDepartment.Append("</expression></field>");
                }
                else
                {
                    strDepartment.Append("<field>Id<expression op=\"greaterthan\">");
                    strDepartment.Append(currentId);
                    strDepartment.Append("</expression></field>");
                }
                if (filters != null && !string.IsNullOrEmpty(filters.Name))
                {
                    strDepartment.Append("<field>Name<expression op=\"equals\">");
                    strDepartment.Append(filters.Name);
                    strDepartment.Append("</expression></field>");
                }
                strDepartment.Append("</query>");
                strDepartment.Append("</queryxml>");

                ATWSResponse respDepartment = this._atws.query(strDepartment.ToString());

                if (respDepartment.ReturnCode > 0 && respDepartment.EntityResults.Length > 0)
                {
                    List<Department> temp = respDepartment.EntityResults.Cast<Department>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    departments.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return departments;
        }
        //end GetDepartments

        #endregion //Departments
            
        #region Resources

        /// <summary>
        /// This method searches for resources.
        /// </summary>
        /// <param name="filters">Contains the ResourceFilters object to search with</param>
        /// <returns>a list of matching resources.</returns>
        public List<Resource> GetResources(ResourceFilters filters = null)
        {
            List<Resource> resources = new List<Resource>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strResource = new StringBuilder();
                strResource.Append("<queryxml version=\"1.0\">");
                strResource.Append("<entity>Resource</entity>");
                strResource.Append("<query>");
                if (filters != null && filters.Id.HasValue)
                {
                    strResource.Append("<field>Id<expression op=\"equals\">");
                    strResource.Append(filters.Id);
                    strResource.Append("</expression></field>");
                }
                else
                {
                    strResource.Append("<field>Id<expression op=\"greaterthan\">");
                    strResource.Append(currentId);
                    strResource.Append("</expression></field>");
                }
                if (filters != null && !string.IsNullOrEmpty(filters.UserName))
                {
                    strResource.Append("<field>UserName<expression op=\"equals\">");
                    strResource.Append(filters.UserName);
                    strResource.Append("</expression></field>");
                }
                strResource.Append("</query>");
                strResource.Append("</queryxml>");

                ATWSResponse respResource = this._atws.query(strResource.ToString());

                if (respResource.ReturnCode > 0 && respResource.EntityResults.Length > 0)
                {
                    List<Resource> temp = respResource.EntityResults.Cast<Resource>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    resources.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return resources;
        }
        //end GetResources

        /// <summary>
        /// This method searches for resource roles.
        /// </summary>
        /// <param name="filters">Contains the ResourceRoleFilters object to search with</param>
        /// <returns>a list of matching resources roles.</returns>
        public List<ResourceRole> GetResourceRoles(ResourceRoleFilters filters = null)
        {
            List<ResourceRole> resourceroles = new List<ResourceRole>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strResource = new StringBuilder();
                strResource.Append("<queryxml version=\"1.0\">");
                strResource.Append("<entity>ResourceRole</entity>");
                strResource.Append("<query>");
                if (filters != null && filters.Id.HasValue)
                {
                    strResource.Append("<field>Id<expression op=\"equals\">");
                    strResource.Append(filters.Id);
                    strResource.Append("</expression></field>");
                }
                else
                {
                    strResource.Append("<field>Id<expression op=\"greaterthan\">");
                    strResource.Append(currentId);
                    strResource.Append("</expression></field>");
                }
                strResource.Append("</query>");
                strResource.Append("</queryxml>");

                ATWSResponse respResource = this._atws.query(strResource.ToString());

                if (respResource.ReturnCode > 0 && respResource.EntityResults.Length > 0)
                {
                    List<ResourceRole> temp = respResource.EntityResults.Cast<ResourceRole>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    resourceroles.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return resourceroles;
        }
        //end GetResourceRoles

        /// <summary>
        /// This method searches for roles.
        /// </summary>
        /// <param name="filters">Contains the RoleFilters object to search with</param>
        /// <returns>a list of matching roles.</returns>
        public List<Role> GetRoles(RoleFilters filters = null)
        {
            List<Role> roles = new List<Role>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strRole = new StringBuilder();
                strRole.Append("<queryxml version=\"1.0\">");
                strRole.Append("<entity>Role</entity>");
                strRole.Append("<query>");
                if (filters != null && filters.Id.HasValue)
                {
                    strRole.Append("<field>Id<expression op=\"equals\">");
                    strRole.Append(filters.Id);
                    strRole.Append("</expression></field>");
                }
                else
                {
                    strRole.Append("<field>Id<expression op=\"greaterthan\">");
                    strRole.Append(currentId);
                    strRole.Append("</expression></field>");
                }
                if (filters != null && !string.IsNullOrEmpty(filters.Name))
                {
                    strRole.Append("<field>Name<expression op=\"equals\">");
                    strRole.Append(filters.Name);
                    strRole.Append("</expression></field>");
                }
                if (filters != null && filters.Active.HasValue)
                {
                    strRole.Append("<field>Active<expression op=\"equals\">");
                    strRole.Append(filters.Active.Value ? "1" : "0");
                    strRole.Append("</expression></field>");
                }
                if (filters != null && filters.RoleType.HasValue)
                {
                    strRole.Append("<field>RoleType<expression op=\"equals\">");
                    strRole.Append(filters.RoleType.Value);
                    strRole.Append("</expression></field>");
                }
                strRole.Append("</query>");
                strRole.Append("</queryxml>");

                ATWSResponse respRole = this._atws.query(strRole.ToString());

                if (respRole.ReturnCode > 0 && respRole.EntityResults.Length > 0)
                {
                    List<Role> temp = respRole.EntityResults.Cast<Role>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    roles.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return roles;
        }
        //end GetRoles

        #endregion //Resources

        #region Contacts

        /// <summary>
        /// This method searches for contacts.
        /// </summary>
        /// <param name="filters">Contains the ContactFilters object to search with</param>
        /// <returns>a list of matching contacts.</returns>
        public List<Contact> GetContacts(ContactFilters filters = null)
        {
            List<Contact> contacts = new List<Contact>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strContact = new StringBuilder();
                strContact.Append("<queryxml version=\"1.0\">");
                strContact.Append("<entity>Contact</entity>");
                strContact.Append("<query>");
                if (filters != null && filters.Id.HasValue)
                {
                    strContact.Append("<field>Id<expression op=\"equals\">");
                    strContact.Append(filters.Id);
                    strContact.Append("</expression></field>");
                }
                else
                {
                    strContact.Append("<field>Id<expression op=\"greaterthan\">");
                    strContact.Append(currentId);
                    strContact.Append("</expression></field>");
                }
                if (filters != null && !string.IsNullOrEmpty(filters.EMailAddress))
                {
                    strContact.Append("<field>EMailAddress<expression op=\"equals\">");
                    strContact.Append(filters.EMailAddress);
                    strContact.Append("</expression></field>");
                }
                strContact.Append("</query>");
                strContact.Append("</queryxml>");

                ATWSResponse respContact = this._atws.query(strContact.ToString());

                if (respContact.ReturnCode > 0 && respContact.EntityResults.Length > 0)
                {
                    List<Contact> temp = respContact.EntityResults.Cast<Contact>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    contacts.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return contacts;
        }
        //end GetContacts

        #endregion //Contacts
        
        #region Tickets

        /// <summary>
        /// This method searches for tickets.
        /// </summary>
        /// <param name="filters">Contains the TicketFilters object to search with</param>
        /// <returns>a list of matching tickets.</returns>
        public List<Ticket> GetTickets(TicketFilters filters = null)
        {
            List<Ticket> tickets = new List<Ticket>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strTicket = new StringBuilder();
                strTicket.Append("<queryxml version=\"1.0\">");
                strTicket.Append("<entity>Ticket</entity>");
                strTicket.Append("<query>");
                if (filters != null && !string.IsNullOrEmpty(filters.TicketNumber))
                {
                    strTicket.Append("<field>TicketNumber<expression op=\"equals\">");
                    strTicket.Append(filters.TicketNumber);
                    strTicket.Append("</expression></field>");
                }
                if (filters != null && filters.LastActivityDate.HasValue && !string.IsNullOrEmpty(filters.opLastActivityDate))
                {
                    strTicket.Append("<field>LastActivityDate<expression op=\"");
                    strTicket.Append(filters.opLastActivityDate);
                    strTicket.Append("\">");
                    strTicket.Append(filters.LastActivityDate.Value.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
                    strTicket.Append("</expression></field>");
                }
                if (filters != null && filters.Id.HasValue)
                {
                    strTicket.Append("<field>Id<expression op=\"equals\">");
                    strTicket.Append(filters.Id);
                    strTicket.Append("</expression></field>");
                }
                else
                {
                    strTicket.Append("<field>Id<expression op=\"greaterthan\">");
                    strTicket.Append(currentId);
                    strTicket.Append("</expression></field>");
                }
                strTicket.Append("</query>");
                strTicket.Append("</queryxml>");

                ATWSResponse respTicket = this._atws.query(strTicket.ToString());

                if (respTicket.ReturnCode > 0 && respTicket.EntityResults.Length > 0)
                {
                    List<Ticket> temp = respTicket.EntityResults.Cast<Ticket>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    tickets.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return tickets;
        }
        //end GetTickets

        /// <summary>
        /// This method searches for ticket notes.
        /// </summary>
        /// <param name="filters">Contains the TicketNoteFilters object to search with</param>
        /// <returns>a list of matching ticket notes.</returns>
        public List<TicketNote> GetTicketNotes(TicketNoteFilters filters = null)
        {
            List<TicketNote> ticketnotes = new List<TicketNote>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strTicket = new StringBuilder();
                strTicket.Append("<queryxml version=\"1.0\">");
                strTicket.Append("<entity>TicketNote</entity>");
                strTicket.Append("<query>");
                if (filters != null && filters.TicketID.HasValue)
                {
                    strTicket.Append("<field>TicketID<expression op=\"equals\">");
                    strTicket.Append(filters.TicketID);
                    strTicket.Append("</expression></field>");
                }
                if (filters != null && filters.LastActivityDate.HasValue && !string.IsNullOrEmpty(filters.opLastActivityDate))
                {
                    strTicket.Append("<field>LastActivityDate<expression op=\"");
                    strTicket.Append(filters.opLastActivityDate);
                    strTicket.Append("\">");
                    strTicket.Append(filters.LastActivityDate.Value.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
                    strTicket.Append("</expression></field>");
                }
                if (filters != null && filters.Id.HasValue)
                {
                    strTicket.Append("<field>Id<expression op=\"equals\">");
                    strTicket.Append(filters.Id);
                    strTicket.Append("</expression></field>");
                }
                else
                {
                    strTicket.Append("<field>Id<expression op=\"greaterthan\">");
                    strTicket.Append(currentId);
                    strTicket.Append("</expression></field>");
                }
                strTicket.Append("</query>");
                strTicket.Append("</queryxml>");

                ATWSResponse respTicket = this._atws.query(strTicket.ToString());

                if (respTicket.ReturnCode > 0 && respTicket.EntityResults.Length > 0)
                {
                    List<TicketNote> temp = respTicket.EntityResults.Cast<TicketNote>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    ticketnotes.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return ticketnotes;
        }
        //end GetTicketNotes

        /// <summary>
        /// This method searches for ticket secondary resource.
        /// </summary>
        /// <param name="filters">Contains the TicketResourceFilters object to search with</param>
        /// <returns>a list of matching ticket secondary resources.</returns>
        public List<TicketSecondaryResource> GetTicketSecondaryResources(TicketResourceFilters filters = null)
        {
            List<TicketSecondaryResource> ticketresources = new List<TicketSecondaryResource>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strTicket = new StringBuilder();
                strTicket.Append("<queryxml version=\"1.0\">");
                strTicket.Append("<entity>TicketSecondaryResource</entity>");
                strTicket.Append("<query>");
                if (filters != null && filters.TicketID.HasValue)
                {
                    strTicket.Append("<field>TicketID<expression op=\"equals\">");
                    strTicket.Append(filters.TicketID);
                    strTicket.Append("</expression></field>");
                }
                if (filters != null && filters.ResourceID.HasValue)
                {
                    strTicket.Append("<field>ResourceID<expression op=\"equals\">");
                    strTicket.Append(filters.ResourceID);
                    strTicket.Append("</expression></field>");
                }
                if (filters != null && filters.Id.HasValue)
                {
                    strTicket.Append("<field>Id<expression op=\"equals\">");
                    strTicket.Append(filters.Id);
                    strTicket.Append("</expression></field>");
                }
                else
                {
                    strTicket.Append("<field>Id<expression op=\"greaterthan\">");
                    strTicket.Append(currentId);
                    strTicket.Append("</expression></field>");
                }
                strTicket.Append("</query>");
                strTicket.Append("</queryxml>");

                ATWSResponse respTicket = this._atws.query(strTicket.ToString());

                if (respTicket.ReturnCode > 0 && respTicket.EntityResults.Length > 0)
                {
                    List<TicketSecondaryResource> temp = respTicket.EntityResults.Cast<TicketSecondaryResource>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    ticketresources.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return ticketresources;
        }
        //end GetTicketSecondaryResources

        /// <summary>
        /// This method adds a ticket secondary resource.
        /// </summary>
        /// <param name="resource">Contains the TicketSecondaryResource to add</param>
        public ATWSResponse AddTicketSecondaryResource(TicketSecondaryResource resource)
        {
            return this._atws.create(new Entity[] { resource });
        }
        //end AddTicketSecondaryResource

        /// <summary>
        /// This method updates a ticket.
        /// </summary>
        /// <param name="ticket">Contains the Ticket to update</param>
        public ATWSResponse UpdateTicket(Ticket ticket)
        {
            return this._atws.update(new Entity[] { ticket });
        }
        //end UpdateTicket

        /// <summary>
        /// This method closes a ticket.
        /// </summary>
        /// <param name="ticket">Contains the Ticket to close</param>
        public ATWSResponse CloseTicket(Ticket ticket)
        {
            ticket.Status = 5;
            return this._atws.update(new Entity[] { ticket });
        }
        //end CloseTicket

        /// <summary>
        /// This method closes a ticket quietly.
        /// </summary>
        /// <param name="ticket">Contains the Ticket to close quietly</param>
        public ATWSResponse QuietCloseTicket(Ticket ticket)
        {
            ticket.Status = 23;
            return this._atws.update(new Entity[] { ticket });
        }
        //end QuietCloseTicket

        /// <summary>
        /// This method cancels a ticket.
        /// </summary>
        /// <param name="ticket">Contains the Ticket to cancel</param>
        public ATWSResponse CancelTicket(Ticket ticket)
        {
            ticket.Status = 16;
            return this._atws.update(new Entity[] { ticket });
        }
        //end CancelTicket

        /// <summary>
        /// This method cancels a ticket.
        /// </summary>
        /// <param name="ticket">Contains the Ticket to merge into</param>
        /// <param name="absorb">Contains the Ticket to absorb</param>
        public ATWSResponse MergeTickets(Ticket merge, Ticket absorb)
        {
            ATWSResponse resp;
            //add note for B
            TicketNote note = new TicketNote {
                    TicketID = absorb.id,
                    Title = "This ticket was completed and merged",
                    Description = $"This ticket was completed and merged into {merge.TicketNumber}.",
                    NoteType = 3,
                    Publish = 2,
                    CreatorResourceID = 4
                };
            resp = this._atws.create(new Entity[] { note });
            if (resp.Errors.Length <= 0)
            {
                absorb.Status = 5; //Completed
                absorb.QueueID = 29683481; //[WF] Merged
                resp = this._atws.update(new Entity[] { absorb });
            }
            return resp;
        }
        //end MergeTickets

        #endregion //Tickets

        #region Projects

        /// <summary>
        /// This method searches for projects.
        /// </summary>
        /// <param name="filters">Contains the ProjectFilters object to search with</param>
        /// <returns>a list of matching projects.</returns>
        public List<Project> GetProjects(ProjectFilters filters = null)
        {
            List<Project> projects = new List<Project>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strProject = new StringBuilder();
                strProject.Append("<queryxml version=\"1.0\">");
                strProject.Append("<entity>Project</entity>");
                strProject.Append("<query>");
                if (filters != null && !string.IsNullOrEmpty(filters.ProjectNumber))
                {
                    strProject.Append("<field>ProjectNumber<expression op=\"equals\">");
                    strProject.Append(filters.ProjectNumber);
                    strProject.Append("</expression></field>");
                }
                if (filters != null && filters.Id.HasValue)
                {
                    strProject.Append("<field>Id<expression op=\"equals\">");
                    strProject.Append(filters.Id);
                    strProject.Append("</expression></field>");
                }
                else
                {
                    strProject.Append("<field>Id<expression op=\"greaterthan\">");
                    strProject.Append(currentId);
                    strProject.Append("</expression></field>");
                }
                strProject.Append("</query>");
                strProject.Append("</queryxml>");

                ATWSResponse respProject = this._atws.query(strProject.ToString());

                if (respProject.ReturnCode > 0 && respProject.EntityResults.Length > 0)
                {
                    List<Project> temp = respProject.EntityResults.Cast<Project>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    projects.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return projects;
        }
        //end GetProjects

        /// <summary>
        /// This method searches for project notes.
        /// </summary>
        /// <param name="filters">Contains the ProjectNoteFilters object to search with</param>
        /// <returns>a list of matching project notes.</returns>
        public List<ProjectNote> GetProjectNotes(ProjectNoteFilters filters = null)
        {
            List<ProjectNote> projectnotes = new List<ProjectNote>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strTicket = new StringBuilder();
                strTicket.Append("<queryxml version=\"1.0\">");
                strTicket.Append("<entity>ProjectNote</entity>");
                strTicket.Append("<query>");
                if (filters != null && filters.ProjectID.HasValue)
                {
                    strTicket.Append("<field>ProjectID<expression op=\"equals\">");
                    strTicket.Append(filters.ProjectID);
                    strTicket.Append("</expression></field>");
                }
                if (filters != null && filters.LastActivityDate.HasValue && !string.IsNullOrEmpty(filters.opLastActivityDate))
                {
                    strTicket.Append("<field>LastActivityDate<expression op=\"");
                    strTicket.Append(filters.opLastActivityDate);
                    strTicket.Append("\">");
                    strTicket.Append(filters.LastActivityDate.Value.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
                    strTicket.Append("</expression></field>");
                }
                if (filters != null && filters.Id.HasValue)
                {
                    strTicket.Append("<field>Id<expression op=\"equals\">");
                    strTicket.Append(filters.Id);
                    strTicket.Append("</expression></field>");
                }
                else
                {
                    strTicket.Append("<field>Id<expression op=\"greaterthan\">");
                    strTicket.Append(currentId);
                    strTicket.Append("</expression></field>");
                }
                strTicket.Append("</query>");
                strTicket.Append("</queryxml>");

                ATWSResponse respTicket = this._atws.query(strTicket.ToString());

                if (respTicket.ReturnCode > 0 && respTicket.EntityResults.Length > 0)
                {
                    List<ProjectNote> temp = respTicket.EntityResults.Cast<ProjectNote>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    projectnotes.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return projectnotes;
        }
        //end GetProjectNotes

        #endregion //Projects
        
        #region Tasks

        /// <summary>
        /// This method searches for tasks.
        /// </summary>
        /// <param name="filters">Contains the TaskFilters object to search with</param>
        /// <returns>a list of matching tasks.</returns>
        public List<Task> GetTasks(TaskFilters filters = null)
        {
            List<Task> tasks = new List<Task>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strTask = new StringBuilder();
                strTask.Append("<queryxml version=\"1.0\">");
                strTask.Append("<entity>Task</entity>");
                strTask.Append("<query>");
                if (filters != null && filters.LastActivityDateTime.HasValue && !string.IsNullOrEmpty(filters.opLastActivityDateTime))
                {
                    strTask.Append("<field>LastActivityDateTime<expression op=\"");
                    strTask.Append(filters.opLastActivityDateTime);
                    strTask.Append("\">");
                    strTask.Append(filters.LastActivityDateTime.Value.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
                    strTask.Append("</expression></field>");
                }
                if (filters != null && filters.Id.HasValue)
                {
                    strTask.Append("<field>Id<expression op=\"equals\">");
                    strTask.Append(filters.Id);
                    strTask.Append("</expression></field>");
                }
                else
                {
                    strTask.Append("<field>Id<expression op=\"greaterthan\">");
                    strTask.Append(currentId);
                    strTask.Append("</expression></field>");
                }
                strTask.Append("</query>");
                strTask.Append("</queryxml>");

                ATWSResponse respTask = this._atws.query(strTask.ToString());

                if (respTask.ReturnCode > 0 && respTask.EntityResults.Length > 0)
                {
                    List<Task> temp = respTask.EntityResults.Cast<Task>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    tasks.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return tasks;
        }
        //end GetTasks

        /// <summary>
        /// This method searches for task notes.
        /// </summary>
        /// <param name="filters">Contains the TaskNoteFilters object to search with</param>
        /// <returns>a list of matching task notes.</returns>
        public List<TaskNote> GetTaskNotes(TaskNoteFilters filters = null)
        {
            List<TaskNote> tasknotes = new List<TaskNote>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strTaskNote = new StringBuilder();
                strTaskNote.Append("<queryxml version=\"1.0\">");
                strTaskNote.Append("<entity>TaskNote</entity>");
                strTaskNote.Append("<query>");
                if (filters != null && filters.TaskID.HasValue)
                {
                    strTaskNote.Append("<field>TaskID<expression op=\"equals\">");
                    strTaskNote.Append(filters.TaskID);
                    strTaskNote.Append("</expression></field>");
                }
                if (filters != null && filters.LastActivityDate.HasValue && !string.IsNullOrEmpty(filters.opLastActivityDate))
                {
                    strTaskNote.Append("<field>LastActivityDate<expression op=\"");
                    strTaskNote.Append(filters.opLastActivityDate);
                    strTaskNote.Append("\">");
                    strTaskNote.Append(filters.LastActivityDate.Value.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
                    strTaskNote.Append("</expression></field>");
                }
                if (filters != null && filters.Id.HasValue)
                {
                    strTaskNote.Append("<field>Id<expression op=\"equals\">");
                    strTaskNote.Append(filters.Id);
                    strTaskNote.Append("</expression></field>");
                }
                else
                {
                    strTaskNote.Append("<field>Id<expression op=\"greaterthan\">");
                    strTaskNote.Append(currentId);
                    strTaskNote.Append("</expression></field>");
                }
                strTaskNote.Append("</query>");
                strTaskNote.Append("</queryxml>");

                ATWSResponse respTaskNote = this._atws.query(strTaskNote.ToString());

                if (respTaskNote.ReturnCode > 0 && respTaskNote.EntityResults.Length > 0)
                {
                    List<TaskNote> temp = respTaskNote.EntityResults.Cast<TaskNote>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    tasknotes.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return tasknotes;
        }
        //end GetTaskNotes

        /// <summary>
        /// This method searches for task secondary resource.
        /// </summary>
        /// <param name="filters">Contains the TaskResourceFilters object to search with</param>
        /// <returns>a list of matching task secondary resources.</returns>
        public List<TaskSecondaryResource> GetTaskSecondaryResources(TaskResourceFilters filters = null)
        {
            List<TaskSecondaryResource> taskresources = new List<TaskSecondaryResource>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strTaskSecondaryResource = new StringBuilder();
                strTaskSecondaryResource.Append("<queryxml version=\"1.0\">");
                strTaskSecondaryResource.Append("<entity>TaskSecondaryResource</entity>");
                strTaskSecondaryResource.Append("<query>");
                if (filters != null && filters.TaskID.HasValue)
                {
                    strTaskSecondaryResource.Append("<field>TaskID<expression op=\"equals\">");
                    strTaskSecondaryResource.Append(filters.TaskID);
                    strTaskSecondaryResource.Append("</expression></field>");
                }
                if (filters != null && filters.ResourceID.HasValue)
                {
                    strTaskSecondaryResource.Append("<field>ResourceID<expression op=\"equals\">");
                    strTaskSecondaryResource.Append(filters.ResourceID);
                    strTaskSecondaryResource.Append("</expression></field>");
                }
                if (filters != null && filters.Id.HasValue)
                {
                    strTaskSecondaryResource.Append("<field>Id<expression op=\"equals\">");
                    strTaskSecondaryResource.Append(filters.Id);
                    strTaskSecondaryResource.Append("</expression></field>");
                }
                else
                {
                    strTaskSecondaryResource.Append("<field>Id<expression op=\"greaterthan\">");
                    strTaskSecondaryResource.Append(currentId);
                    strTaskSecondaryResource.Append("</expression></field>");
                }
                strTaskSecondaryResource.Append("</query>");
                strTaskSecondaryResource.Append("</queryxml>");

                ATWSResponse respTaskSecondaryResource = this._atws.query(strTaskSecondaryResource.ToString());

                if (respTaskSecondaryResource.ReturnCode > 0 && respTaskSecondaryResource.EntityResults.Length > 0)
                {
                    List<TaskSecondaryResource> temp = respTaskSecondaryResource.EntityResults.Cast<TaskSecondaryResource>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    taskresources.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return taskresources;
        }
        //end GetTaskSecondaryResources

        #endregion //Tasks
        
        #region Time Entries

        /// <summary>
        /// This method searches for time entries.
        /// </summary>
        /// <param name="filters">Contains the TimeEntryFilters object to search with</param>
        /// <returns>a list of matching time entries.</returns>
        public List<TimeEntry> GetTimeEntries(TimeEntryFilters filters = null)
        {
            List<TimeEntry> timeEntries = new List<TimeEntry>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strTimeEntry = new StringBuilder();
                strTimeEntry.Append("<queryxml version=\"1.0\">");
                strTimeEntry.Append("<entity>TimeEntry</entity>");
                strTimeEntry.Append("<query>");
                if (filters != null && filters.LastModifiedDateTime.HasValue && !string.IsNullOrEmpty(filters.opLastModifiedDateTime))
                {
                    strTimeEntry.Append("<field>LastModifiedDateTime<expression op=\"");
                    strTimeEntry.Append(filters.opLastModifiedDateTime);
                    strTimeEntry.Append("\">");
                    strTimeEntry.Append(filters.LastModifiedDateTime.Value.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
                    strTimeEntry.Append("</expression></field>");
                }
                if (filters != null && filters.TicketID.HasValue)
                {
                    strTimeEntry.Append("<field>TicketID<expression op=\"equals\">");
                    strTimeEntry.Append(filters.TicketID.ToString());
                    strTimeEntry.Append("</expression></field>");
                }
                if (filters != null && filters.TaskID.HasValue)
                {
                    strTimeEntry.Append("<field>TaskID<expression op=\"equals\">");
                    strTimeEntry.Append(filters.TaskID.ToString());
                    strTimeEntry.Append("</expression></field>");
                }
                if (filters != null && filters.Id.HasValue)
                {
                    strTimeEntry.Append("<field>Id<expression op=\"equals\">");
                    strTimeEntry.Append(filters.Id);
                    strTimeEntry.Append("</expression></field>");
                }
                else
                {
                    strTimeEntry.Append("<field>Id<expression op=\"greaterthan\">");
                    strTimeEntry.Append(currentId);
                    strTimeEntry.Append("</expression></field>");
                }
                strTimeEntry.Append("</query>");
                strTimeEntry.Append("</queryxml>");

                ATWSResponse respTimeEntry = this._atws.query(strTimeEntry.ToString());

                if (respTimeEntry.ReturnCode > 0 && respTimeEntry.EntityResults.Length > 0)
                {
                    List<TimeEntry> temp = respTimeEntry.EntityResults.Cast<TimeEntry>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    timeEntries.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }

            return timeEntries;
        }
        //end GetTimeEntries

        #endregion //Time Entries

        #region Service Calls

        /// <summary>
        /// This method searches for service calls.
        /// </summary>
        /// <param name="filters">Contains the ServiceCallFilters object to search with</param>
        /// <returns>a list of matching service calls.</returns>
        public List<ServiceCall> GetServiceCalls(ServiceCallFilters filters = null)
        {
            List<ServiceCall> serviceCalls = new List<ServiceCall>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strServiceCall = new StringBuilder();
                strServiceCall.Append("<queryxml version=\"1.0\">");
                strServiceCall.Append("<entity>ServiceCall</entity>");
                strServiceCall.Append("<query>");
                if (filters != null && filters.LastModifiedDateTime.HasValue && !string.IsNullOrEmpty(filters.opLastModifiedDateTime))
                {
                    strServiceCall.Append("<field>LastModifiedDateTime<expression op=\"");
                    strServiceCall.Append(filters.opLastModifiedDateTime);
                    strServiceCall.Append("\">");
                    strServiceCall.Append(filters.LastModifiedDateTime.Value.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
                    strServiceCall.Append("</expression></field>");
                }
                if (filters != null && filters.StartDateTime.HasValue && !string.IsNullOrEmpty(filters.opStartDateTime))
                {
                    strServiceCall.Append("<field>StartDateTime<expression op=\"");
                    strServiceCall.Append(filters.opStartDateTime);
                    strServiceCall.Append("\">");
                    strServiceCall.Append(filters.StartDateTime.Value.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
                    strServiceCall.Append("</expression></field>");
                }
                if (filters != null && filters.EndDateTime.HasValue && !string.IsNullOrEmpty(filters.opEndDateTime))
                {
                    strServiceCall.Append("<field>EndDateTime<expression op=\"");
                    strServiceCall.Append(filters.opEndDateTime);
                    strServiceCall.Append("\">");
                    strServiceCall.Append(filters.EndDateTime.Value.ToString("yyyy-MM-dd HH:mm:ss.ffff"));
                    strServiceCall.Append("</expression></field>");
                }
                if (filters != null && filters.Id.HasValue)
                {
                    strServiceCall.Append("<field>Id<expression op=\"equals\">");
                    strServiceCall.Append(filters.Id);
                    strServiceCall.Append("</expression></field>");
                }
                else
                {
                    strServiceCall.Append("<field>Id<expression op=\"greaterthan\">");
                    strServiceCall.Append(currentId);
                    strServiceCall.Append("</expression></field>");
                }
                strServiceCall.Append("</query>");
                strServiceCall.Append("</queryxml>");

                ATWSResponse respTimeEntry = this._atws.query(strServiceCall.ToString());

                if (respTimeEntry.ReturnCode > 0 && respTimeEntry.EntityResults.Length > 0)
                {
                    List<ServiceCall> temp = respTimeEntry.EntityResults.Cast<ServiceCall>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    serviceCalls.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }

            return serviceCalls;
        }
        //end GetServiceCalls

        /// <summary>
        /// This method searches for service call tasks.
        /// </summary>
        /// <param name="filters">Contains the ServiceCallTaskFilters object to search with</param>
        /// <returns>a list of matching service call tasks.</returns>
        public List<ServiceCallTask> GetServiceCallTasks(ServiceCallTaskFilters filters = null)
        {
            List<ServiceCallTask> servicecalltasks = new List<ServiceCallTask>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strServiceCallTask = new StringBuilder();
                strServiceCallTask.Append("<queryxml version=\"1.0\">");
                strServiceCallTask.Append("<entity>ServiceCallTask</entity>");
                strServiceCallTask.Append("<query>");
                if (filters != null && filters.ServiceCallID.HasValue)
                {
                    strServiceCallTask.Append("<field>ServiceCallID<expression op=\"equals\">");
                    strServiceCallTask.Append(filters.ServiceCallID);
                    strServiceCallTask.Append("</expression></field>");
                }
                if (filters != null && filters.TaskID.HasValue)
                {
                    strServiceCallTask.Append("<field>TaskID<expression op=\"equals\">");
                    strServiceCallTask.Append(filters.TaskID);
                    strServiceCallTask.Append("</expression></field>");
                }
                if (filters != null && filters.Id.HasValue)
                {
                    strServiceCallTask.Append("<field>Id<expression op=\"equals\">");
                    strServiceCallTask.Append(filters.Id);
                    strServiceCallTask.Append("</expression></field>");
                }
                else
                {
                    strServiceCallTask.Append("<field>Id<expression op=\"greaterthan\">");
                    strServiceCallTask.Append(currentId);
                    strServiceCallTask.Append("</expression></field>");
                }
                strServiceCallTask.Append("</query>");
                strServiceCallTask.Append("</queryxml>");

                ATWSResponse respServiceCallTask = this._atws.query(strServiceCallTask.ToString());

                if (respServiceCallTask.ReturnCode > 0 && respServiceCallTask.EntityResults.Length > 0)
                {
                    List<ServiceCallTask> temp = respServiceCallTask.EntityResults.Cast<ServiceCallTask>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    servicecalltasks.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return servicecalltasks;
        }
        //end GetServiceCallTasks

        /// <summary>
        /// This method searches for service call task resources.
        /// </summary>
        /// <param name="filters">Contains the ServiceCallTaskResourceFilters object to search with</param>
        /// <returns>a list of matching service call task resources.</returns>
        public List<ServiceCallTaskResource> GetServiceCallTaskResources(ServiceCallTaskResourceFilters filters = null)
        {
            List<ServiceCallTaskResource> servicecalltaskresources = new List<ServiceCallTaskResource>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strServiceCallTaskResource = new StringBuilder();
                strServiceCallTaskResource.Append("<queryxml version=\"1.0\">");
                strServiceCallTaskResource.Append("<entity>ServiceCallTaskResource</entity>");
                strServiceCallTaskResource.Append("<query>");
                if (filters != null && filters.ServiceCallTaskID.HasValue)
                {
                    strServiceCallTaskResource.Append("<field>ServiceCallTaskID<expression op=\"equals\">");
                    strServiceCallTaskResource.Append(filters.ServiceCallTaskID);
                    strServiceCallTaskResource.Append("</expression></field>");
                }
                if (filters != null && filters.ResourceID.HasValue)
                {
                    strServiceCallTaskResource.Append("<field>ResourceID<expression op=\"equals\">");
                    strServiceCallTaskResource.Append(filters.ResourceID);
                    strServiceCallTaskResource.Append("</expression></field>");
                }
                if (filters != null && filters.Id.HasValue)
                {
                    strServiceCallTaskResource.Append("<field>Id<expression op=\"equals\">");
                    strServiceCallTaskResource.Append(filters.Id);
                    strServiceCallTaskResource.Append("</expression></field>");
                }
                else
                {
                    strServiceCallTaskResource.Append("<field>Id<expression op=\"greaterthan\">");
                    strServiceCallTaskResource.Append(currentId);
                    strServiceCallTaskResource.Append("</expression></field>");
                }
                strServiceCallTaskResource.Append("</query>");
                strServiceCallTaskResource.Append("</queryxml>");

                ATWSResponse respServiceCallTaskResource = this._atws.query(strServiceCallTaskResource.ToString());

                if (respServiceCallTaskResource.ReturnCode > 0 && respServiceCallTaskResource.EntityResults.Length > 0)
                {
                    List<ServiceCallTaskResource> temp = respServiceCallTaskResource.EntityResults.Cast<ServiceCallTaskResource>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    servicecalltaskresources.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return servicecalltaskresources;
        }
        //end GetServiceCallTaskResources
        
        /// <summary>
        /// This method searches for service call tickets.
        /// </summary>
        /// <param name="filters">Contains the ServiceCallTicketFilters object to search with</param>
        /// <returns>a list of matching service call ticket.</returns>
        public List<ServiceCallTicket> GetServiceCallTickets(ServiceCallTicketFilters filters = null)
        {
            List<ServiceCallTicket> servicecalltickets = new List<ServiceCallTicket>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strServiceCallTicket = new StringBuilder();
                strServiceCallTicket.Append("<queryxml version=\"1.0\">");
                strServiceCallTicket.Append("<entity>ServiceCallTicket</entity>");
                strServiceCallTicket.Append("<query>");
                if (filters != null && filters.ServiceCallID.HasValue)
                {
                    strServiceCallTicket.Append("<field>ServiceCallID<expression op=\"equals\">");
                    strServiceCallTicket.Append(filters.ServiceCallID);
                    strServiceCallTicket.Append("</expression></field>");
                }
                if (filters != null && filters.TicketID.HasValue)
                {
                    strServiceCallTicket.Append("<field>TicketID<expression op=\"equals\">");
                    strServiceCallTicket.Append(filters.TicketID);
                    strServiceCallTicket.Append("</expression></field>");
                }
                if (filters != null && filters.Id.HasValue)
                {
                    strServiceCallTicket.Append("<field>Id<expression op=\"equals\">");
                    strServiceCallTicket.Append(filters.Id);
                    strServiceCallTicket.Append("</expression></field>");
                }
                else
                {
                    strServiceCallTicket.Append("<field>Id<expression op=\"greaterthan\">");
                    strServiceCallTicket.Append(currentId);
                    strServiceCallTicket.Append("</expression></field>");
                }
                strServiceCallTicket.Append("</query>");
                strServiceCallTicket.Append("</queryxml>");

                ATWSResponse respServiceCallTicket = this._atws.query(strServiceCallTicket.ToString());

                if (respServiceCallTicket.ReturnCode > 0 && respServiceCallTicket.EntityResults.Length > 0)
                {
                    List<ServiceCallTicket> temp = respServiceCallTicket.EntityResults.Cast<ServiceCallTicket>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    servicecalltickets.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return servicecalltickets;
        }
        //end GetServiceCallTickets

        /// <summary>
        /// This method searches for service call ticket resources.
        /// </summary>
        /// <param name="filters">Contains the ServiceCallTicketResourceFilters object to search with</param>
        /// <returns>a list of matching service call ticket resources.</returns>
        public List<ServiceCallTicketResource> GetServiceCallTicketResources(ServiceCallTicketResourceFilters filters = null)
        {
            List<ServiceCallTicketResource> servicecallticketresources = new List<ServiceCallTicketResource>();

            bool queryDone = false;
            long currentId = 0;
            while (!queryDone)
            {
                StringBuilder strServiceCallTicketResource = new StringBuilder();
                strServiceCallTicketResource.Append("<queryxml version=\"1.0\">");
                strServiceCallTicketResource.Append("<entity>ServiceCallTicketResource</entity>");
                strServiceCallTicketResource.Append("<query>");
                if (filters != null && filters.ServiceCallTicketID.HasValue)
                {
                    strServiceCallTicketResource.Append("<field>ServiceCallTicketID<expression op=\"equals\">");
                    strServiceCallTicketResource.Append(filters.ServiceCallTicketID);
                    strServiceCallTicketResource.Append("</expression></field>");
                }
                if (filters != null && filters.ResourceID.HasValue)
                {
                    strServiceCallTicketResource.Append("<field>ResourceID<expression op=\"equals\">");
                    strServiceCallTicketResource.Append(filters.ResourceID);
                    strServiceCallTicketResource.Append("</expression></field>");
                }
                if (filters != null && filters.Id.HasValue)
                {
                    strServiceCallTicketResource.Append("<field>Id<expression op=\"equals\">");
                    strServiceCallTicketResource.Append(filters.Id);
                    strServiceCallTicketResource.Append("</expression></field>");
                }
                else
                {
                    strServiceCallTicketResource.Append("<field>Id<expression op=\"greaterthan\">");
                    strServiceCallTicketResource.Append(currentId);
                    strServiceCallTicketResource.Append("</expression></field>");
                }
                strServiceCallTicketResource.Append("</query>");
                strServiceCallTicketResource.Append("</queryxml>");

                ATWSResponse respServiceCallTicketResource = this._atws.query(strServiceCallTicketResource.ToString());

                if (respServiceCallTicketResource.ReturnCode > 0 && respServiceCallTicketResource.EntityResults.Length > 0)
                {
                    List<ServiceCallTicketResource> temp = respServiceCallTicketResource.EntityResults.Cast<ServiceCallTicketResource>().ToList();
                    currentId = temp[temp.Count - 1].id;
                    servicecallticketresources.AddRange(temp);
                    temp = null;
                    if (filters != null && filters.Id.HasValue) { queryDone = true; }
                }
                else
                {
                    queryDone = true;
                }
            }
            return servicecallticketresources;
        }
        //end GetServiceCallTicketResources



        #endregion //Service Calls
        */
    }

    #region Filter Classes

    public class TimeEntryFilters
    {
        public long? Id { get; set; }
        public long? TicketID { get; set; }
        public long? TaskID { get; set; }
        public DateTime? LastModifiedDateTime { get; set; }
        public string opLastModifiedDateTime { get; set; }
    }

    public class TaskFilters
    {
        public long? Id { get; set; }
        public long? ProjectID { get; set; }
        public DateTime? LastActivityDateTime { get; set; }
        public string opLastActivityDateTime { get; set; }
    }

    public class TaskNoteFilters
    {
        public long? Id { get; set; }
        public long? TaskID { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public string opLastActivityDate { get; set; }
    }

    public class TaskResourceFilters
    {
        public long? Id { get; set; }
        public long? TaskID { get; set; }
        public long? ResourceID { get; set; }
    }

    public class ProjectFilters
    {
        public long? Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectNumber { get; set; }
    }

    public class ProjectNoteFilters
    {
        public long? Id { get; set; }
        public long? ProjectID { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public string opLastActivityDate { get; set; }
    }

    public class TicketFilters
    {
        public long? Id { get; set; }
        public string TicketNumber { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public string opLastActivityDate { get; set; }

    }

    public class TicketNoteFilters
    {
        public long? Id { get; set; }
        public long? TicketID { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public string opLastActivityDate { get; set; }
    }

    public class TicketResourceFilters
    {
        public long? Id { get; set; }
        public long? TicketID { get; set; }
        public long? ResourceID { get; set; }
    }

    public class ContactFilters
    {
        public long? Id { get; set; }
        public string EMailAddress { get; set; }

    }

    public class RoleFilters
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public bool? Active { get; set; }
        public int? RoleType { get; set; }
    }

    public class ResourceRoleFilters
    {
        public long? Id { get; set; }
    }

    public class ResourceFilters
    {
        public long? Id { get; set; }
        public string UserName { get; set; }

    }

    public class DepartmentFilters
    {
        public long? Id { get; set; }
        public string Name { get; set; }

    }

    public class CountryFilters
    {
        public long? Id { get; set; }
    }

    public class AccountToDoFilters
    {
        public long? Id { get; set; }
        public long? AccountID { get; set; }
        public long? TicketID { get; set; }

    }

    public class AccountFilters
    {
        public long? Id { get; set; }
        public string AccountName { get; set; }
        public bool? Active { get; set; }

    }

    public class ActionTypeFilters
    {
        public long? Id { get; set; }
        public bool? Active { get; set; }

    }

    public class ServiceCallFilters
    {
        public long? Id { get; set; }
        public DateTime? LastModifiedDateTime { get; set; }
        public string opLastModifiedDateTime { get; set; }
        public DateTime? StartDateTime { get; set; }
        public string opStartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string opEndDateTime { get; set; }
    }

    public class ServiceCallTaskFilters
    {
        public long? Id { get; set; }
        public long? ServiceCallID { get; set; }
        public long? TaskID { get; set; }

    }

    public class ServiceCallTicketFilters
    {
        public long? Id { get; set; }
        public long? ServiceCallID { get; set; }
        public long? TicketID { get; set; }

    }

    public class ServiceCallTaskResourceFilters
    {
        public long? Id { get; set; }
        public long? ServiceCallTaskID { get; set; }
        public long? ResourceID { get; set; }
    }

    public class ServiceCallTicketResourceFilters
    {
        public long? Id { get; set; }
        public long? ServiceCallTicketID { get; set; }
        public long? ResourceID { get; set; }
    }

    
    #endregion Filter Classes

}
