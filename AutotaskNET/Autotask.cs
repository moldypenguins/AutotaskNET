using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using AutotaskUpdater.net.autotask.webservices;

namespace Autotask
{
    class AutotaskAPI
    {
        private AutotaskApiService_1_5 _atwsServices;

        /// <summary>
        /// Public Constuctor for API.
        /// </summary>
        /// <param name="uri">Contains the Autotask API Service URI</param>
        /// <param name="user">Contains the Autotask API Service username</param>
        /// <param name="pass">Contains the Autotask API Service password</param>
        public AutotaskAPI(string uri, string user, string pass)
        {
            string zoneURL = string.Empty;

            this._atwsServices = new AutotaskApiService_1_5();
            this._atwsServices.Url = uri;

            CredentialCache cache = new CredentialCache();
            cache.Add(new Uri(this._atwsServices.Url), "BASIC", new NetworkCredential(user, pass));
            this._atwsServices.Credentials = cache;

            try
            {
                ATWSZoneInfo zoneInfo = new ATWSZoneInfo();
                zoneInfo = this._atwsServices.getZoneInfo(user);
                if (zoneInfo.ErrorCode >= 0)
                {
                    zoneURL = zoneInfo.URL;
                    this._atwsServices = new AutotaskApiService_1_5();
                    this._atwsServices.Url = zoneInfo.URL;
                    cache = new CredentialCache();
                    cache.Add(new Uri(this._atwsServices.Url), "BASIC", new NetworkCredential(user, pass));
                    this._atwsServices.Credentials = cache;
                }
                else
                {
                    throw new Exception("Error with getZoneInfo()");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error with getZoneInfo()- error: " + ex.Message);
            }
        }
        //end AutotaskAPI

        
        
        public List<Field> GetEntityFields(string Entity)
        {
            return this._atwsServices.GetFieldInfo(Entity).ToList();
        }



        /// <summary>
        /// This method searches for accounts.
        /// </summary>
        /// <param name="filters">Contains the AccountFilters object to search with</param>
        /// <returns>a list of matching accounts.</returns>
        public List<Account> GetAccounts(AccountFilters filters = null)
        {
            List<Account> accounts = new List<Account>();

            if (filters == null)
            {
                bool queryDone = false;
                long currentId = 0;
                while (!queryDone)
                {
                    StringBuilder strAccount = new StringBuilder();
                    strAccount.Append("<queryxml version=\"1.0\">");
                    strAccount.Append("<entity>Account</entity>");
                    strAccount.Append("<query>");
                    strAccount.Append("<field>Id<expression op=\"greaterthan\">");
                    strAccount.Append(currentId);
                    strAccount.Append("</expression></field>");
                    strAccount.Append("</query>");
                    strAccount.Append("</queryxml>");

                    ATWSResponse respAccount = this._atwsServices.query(strAccount.ToString());

                    if (respAccount.ReturnCode > 0 && respAccount.EntityResults.Length > 0)
                    {
                        List<Account> temp = respAccount.EntityResults.Cast<Account>().ToList();
                        currentId = temp[temp.Count - 1].id;
                        accounts.AddRange(temp);
                        temp = null;
                    }
                    else
                    {
                        queryDone = true;
                    }
                }
            }
            else
            {
                StringBuilder strAccount = new StringBuilder();
                strAccount.Append("<queryxml version=\"1.0\">");
                strAccount.Append("<entity>Account</entity>");
                strAccount.Append("<query>");
                if (filters.Id.HasValue)
                {
                    strAccount.Append("<field>Id<expression op=\"equals\">");
                    strAccount.Append(filters.Id);
                    strAccount.Append("</expression></field>");
                }
                if (!string.IsNullOrEmpty(filters.AccountName))
                {
                    strAccount.Append("<field>AccountName<expression op=\"equals\">");
                    strAccount.Append(filters.AccountName);
                    strAccount.Append("</expression></field>");
                }
                strAccount.Append("</query>");
                strAccount.Append("</queryxml>");

                ATWSResponse respAccount = this._atwsServices.query(strAccount.ToString());

                if (respAccount.ReturnCode > 0 && respAccount.EntityResults.Length > 0)
                {
                    accounts = respAccount.EntityResults.Cast<Account>().ToList();
                }
            }
            return accounts;
        }
        //end GetAccounts


        /// <summary>
        /// This method searches for resources.
        /// </summary>
        /// <param name="filters">Contains the ResourceFilters object to search with</param>
        /// <returns>a list of matching resources.</returns>
        public List<Resource> GetResources(ResourceFilters filters = null)
        {
            List<Resource> resources = new List<Resource>();

            if (filters == null)
            {
                bool queryDone = false;
                long currentId = 0;
                while (!queryDone)
                {
                    StringBuilder strResource = new StringBuilder();
                    strResource.Append("<queryxml version=\"1.0\">");
                    strResource.Append("<entity>Resource</entity>");
                    strResource.Append("<query>");
                    strResource.Append("<field>Id<expression op=\"greaterthan\">");
                    strResource.Append(currentId);
                    strResource.Append("</expression></field>");
                    strResource.Append("</query>");
                    strResource.Append("</queryxml>");

                    ATWSResponse respResource = this._atwsServices.query(strResource.ToString());

                    if (respResource.ReturnCode > 0 && respResource.EntityResults.Length > 0)
                    {
                        List<Resource> temp = respResource.EntityResults.Cast<Resource>().ToList();
                        currentId = temp[temp.Count - 1].id;
                        resources.AddRange(temp);
                        temp = null;
                    }
                    else
                    {
                        queryDone = true;
                    }
                }
            }
            else
            {
                StringBuilder strResource = new StringBuilder();
                strResource.Append("<queryxml version=\"1.0\">");
                strResource.Append("<entity>Resource</entity>");
                strResource.Append("<query>");
                if (filters.Id.HasValue)
                {
                    strResource.Append("<field>Id<expression op=\"equals\">");
                    strResource.Append(filters.Id);
                    strResource.Append("</expression></field>");
                }
                if (!string.IsNullOrEmpty(filters.UserName))
                {
                    strResource.Append("<field>UserName<expression op=\"equals\">");
                    strResource.Append(filters.UserName);
                    strResource.Append("</expression></field>");
                }
                strResource.Append("</query>");
                strResource.Append("</queryxml>");

                ATWSResponse respResource = this._atwsServices.query(strResource.ToString());

                if (respResource.ReturnCode > 0 && respResource.EntityResults.Length > 0)
                {
                    resources = respResource.EntityResults.Cast<Resource>().ToList();
                }
            }
            return resources;
        }
        //end GetResources


        /// <summary>
        /// This method searches for contacts.
        /// </summary>
        /// <param name="filters">Contains the ContactFilters object to search with</param>
        /// <returns>a list of matching contacts.</returns>
        public List<Contact> GetContacts(ContactFilters filters = null)
        {
            List<Contact> contacts = new List<Contact>();

            if (filters == null)
            {
                bool queryDone = false;
                long currentId = 0;
                while (!queryDone)
                {
                    StringBuilder strContact = new StringBuilder();
                    strContact.Append("<queryxml version=\"1.0\">");
                    strContact.Append("<entity>Contact</entity>");
                    strContact.Append("<query>");
                    strContact.Append("<field>Id<expression op=\"greaterthan\">");
                    strContact.Append(currentId);
                    strContact.Append("</expression></field>");
                    strContact.Append("</query>");
                    strContact.Append("</queryxml>");

                    ATWSResponse respContact = this._atwsServices.query(strContact.ToString());

                    if (respContact.ReturnCode > 0 && respContact.EntityResults.Length > 0)
                    {
                        List<Contact> temp = respContact.EntityResults.Cast<Contact>().ToList();
                        currentId = temp[temp.Count - 1].id;
                        contacts.AddRange(temp);
                        temp = null;
                    }
                    else
                    {
                        queryDone = true;
                    }
                }
            }
            else
            {
                StringBuilder strContact = new StringBuilder();
                strContact.Append("<queryxml version=\"1.0\">");
                strContact.Append("<entity>Contact</entity>");
                strContact.Append("<query>");
                if (!string.IsNullOrEmpty(filters.EMailAddress))
                {
                    strContact.Append("<field>EMailAddress<expression op=\"equals\">");
                    strContact.Append(filters.EMailAddress);
                    strContact.Append("</expression></field>");
                }
                strContact.Append("</query></queryxml>");

                ATWSResponse respContact = this._atwsServices.query(strContact.ToString());

                if (respContact.ReturnCode > 0 && respContact.EntityResults.Length > 0)
                {
                    contacts = respContact.EntityResults.Cast<Contact>().ToList();
                }
            }
            return contacts;
        }
        //end GetContacts


        /// <summary>
        /// This method searches for tickets.
        /// </summary>
        /// <param name="filters">Contains the TicketFilters object to search with</param>
        /// <returns>a list of matching tickets.</returns>
        public List<Ticket> GetTickets(TicketFilters filters = null)
        {
            List<Ticket> tickets = new List<Ticket>();

            if (filters == null)
            {
                bool queryDone = false;
                long currentId = 0;
                while (!queryDone)
                {
                    StringBuilder strTicket = new StringBuilder();
                    strTicket.Append("<queryxml version=\"1.0\">");
                    strTicket.Append("<entity>Ticket</entity>");
                    strTicket.Append("<query>");
                    strTicket.Append("<field>Id<expression op=\"greaterthan\">");
                    strTicket.Append(currentId);
                    strTicket.Append("</expression></field>");
                    strTicket.Append("</query>");
                    strTicket.Append("</queryxml>");

                    ATWSResponse respTicket = this._atwsServices.query(strTicket.ToString());

                    if (respTicket.ReturnCode > 0 && respTicket.EntityResults.Length > 0)
                    {
                        List<Ticket> temp = respTicket.EntityResults.Cast<Ticket>().ToList();
                        currentId = temp[temp.Count - 1].id;
                        tickets.AddRange(temp);
                        temp = null;
                    }
                    else
                    {
                        queryDone = true;
                    }
                }
            }
            else
            { 
                StringBuilder strTicket = new StringBuilder();
                strTicket.Append("<queryxml version=\"1.0\">");
                strTicket.Append("<entity>Ticket</entity>");
                strTicket.Append("<query>");
                if (!string.IsNullOrEmpty(filters.TicketNumber))
                {
                    strTicket.Append("<field>TicketNumber<expression op=\"equals\">");
                    strTicket.Append(filters.TicketNumber);
                    strTicket.Append("</expression></field>");
                }
                if (filters.LastActivityDate.HasValue && !string.IsNullOrEmpty(filters.opLastActivityDate))
                {
                    strTicket.Append("<field>TicketNumber<expression op=\"");
                    strTicket.Append(filters.opLastActivityDate);
                    strTicket.Append("\">");
                    strTicket.Append(filters.TicketNumber);
                    strTicket.Append("</expression></field>");
                }
                strTicket.Append("</query></queryxml>");

                ATWSResponse respTicket = this._atwsServices.query(strTicket.ToString());

                if (respTicket.ReturnCode > 0 && respTicket.EntityResults.Length > 0)
                {
                    tickets = respTicket.EntityResults.Cast<Ticket>().ToList();
                }
            }
            return tickets;
        }
        //end GetTickets


        /// <summary>
        /// This method searches for projects.
        /// </summary>
        /// <param name="filters">Contains the ProjectFilters object to search with</param>
        /// <returns>a list of matching projects.</returns>
        public List<Project> GetProjects(ProjectFilters filters = null)
        {
            List<Project> projects = new List<Project>();

            if (filters == null)
            {
                bool queryDone = false;
                long currentId = 0;
                while (!queryDone)
                {
                    StringBuilder strProject = new StringBuilder();
                    strProject.Append("<queryxml version=\"1.0\">");
                    strProject.Append("<entity>Project</entity>");
                    strProject.Append("<query>");
                    strProject.Append("<field>Id<expression op=\"greaterthan\">");
                    strProject.Append(currentId);
                    strProject.Append("</expression></field>");
                    strProject.Append("</query>");
                    strProject.Append("</queryxml>");

                    ATWSResponse respProject = this._atwsServices.query(strProject.ToString());

                    if (respProject.ReturnCode > 0 && respProject.EntityResults.Length > 0)
                    {
                        List<Project> temp = respProject.EntityResults.Cast<Project>().ToList();
                        currentId = temp[temp.Count - 1].id;
                        projects.AddRange(temp);
                        temp = null;
                    }
                    else
                    {
                        queryDone = true;
                    }
                }
            }
            else
            {
                StringBuilder strProject = new StringBuilder();
                strProject.Append("<queryxml version=\"1.0\">");
                strProject.Append("<entity>Project</entity>");
                strProject.Append("<query>");
                if (!string.IsNullOrEmpty(filters.ProjectNumber))
                {
                    strProject.Append("<field>ProjectNumber<expression op=\"equals\">");
                    strProject.Append(filters.ProjectNumber);
                    strProject.Append("</expression></field>");
                }
                strProject.Append("</query></queryxml>");

                ATWSResponse respProject = this._atwsServices.query(strProject.ToString());

                if (respProject.ReturnCode > 0 && respProject.EntityResults.Length > 0)
                {
                    projects = respProject.EntityResults.Cast<Project>().ToList();
                }
            }
            return projects;
        }
        //end GetProjects


        public List<Task> GetTasks(TaskFilters filters = null)
        {
            List<Task> tasks = new List<Task>();

            if (filters == null)
            {
                bool queryDone = false;
                long currentId = 0;
                while (!queryDone)
                {
                    StringBuilder strTask = new StringBuilder();
                    strTask.Append("<queryxml version=\"1.0\">");
                    strTask.Append("<entity>Task</entity>");
                    strTask.Append("<query>");
                    strTask.Append("<field>Id<expression op=\"greaterthan\">");
                    strTask.Append(currentId);
                    strTask.Append("</expression></field>");
                    strTask.Append("</query>");
                    strTask.Append("</queryxml>");

                    ATWSResponse respTask = this._atwsServices.query(strTask.ToString());

                    if (respTask.ReturnCode > 0 && respTask.EntityResults.Length > 0)
                    {
                        List<Task> temp = respTask.EntityResults.Cast<Task>().ToList();
                        currentId = temp[temp.Count - 1].id;
                        tasks.AddRange(temp);
                        temp = null;
                    }
                    else
                    {
                        queryDone = true;
                    }
                }
            }
            else
            {
                StringBuilder strTask = new StringBuilder();
                strTask.Append("<queryxml version=\"1.0\">");
                strTask.Append("<entity>Task</entity>");
                strTask.Append("<query>");
                if (filters.ProjectID.HasValue)
                {
                    strTask.Append("<field>ProjectID<expression op=\"equals\">");
                    strTask.Append(filters.ProjectID.ToString());
                    strTask.Append("</expression></field>");
                }
                strTask.Append("</query></queryxml>");

                ATWSResponse respTask = this._atwsServices.query(strTask.ToString());

                if (respTask.ReturnCode > 0 && respTask.EntityResults.Length > 0)
                {
                    tasks = respTask.EntityResults.Cast<Task>().ToList();
                }
            }
            return tasks;
        }
        //end GetTasks


        /// <summary>
        /// This method searches for time entries.
        /// </summary>
        /// <param name="filters">Contains the TimeEntryFilters object to search with</param>
        /// <returns>a list of matching time entries.</returns>
        public List<TimeEntry> GetTimeEntries(TimeEntryFilters filters = null)
        {
            List<TimeEntry> timeEntries = new List<TimeEntry>();

            if (filters == null)
            {
                bool queryDone = false;
                long currentId = 0;
                while (!queryDone)
                {
                    StringBuilder strTimeEntry = new StringBuilder();
                    strTimeEntry.Append("<queryxml version=\"1.0\">");
                    strTimeEntry.Append("<entity>TimeEntry</entity>");
                    strTimeEntry.Append("<query>");
                    strTimeEntry.Append("<field>Id<expression op=\"greaterthan\">");
                    strTimeEntry.Append(currentId);
                    strTimeEntry.Append("</expression></field>");
                    strTimeEntry.Append("</query>");
                    strTimeEntry.Append("</queryxml>");

                    ATWSResponse respTimeEntry = this._atwsServices.query(strTimeEntry.ToString());

                    if (respTimeEntry.ReturnCode > 0 && respTimeEntry.EntityResults.Length > 0)
                    {
                        List<TimeEntry> temp = respTimeEntry.EntityResults.Cast<TimeEntry>().ToList();
                        currentId = temp[temp.Count - 1].id;
                        timeEntries.AddRange(temp);
                        temp = null;
                    }
                    else
                    {
                        queryDone = true;
                    }
                }
            }
            else
            {
                StringBuilder strTimeEntry = new StringBuilder();
                strTimeEntry.Append("<queryxml version=\"1.0\">");
                strTimeEntry.Append("<entity>TimeEntry</entity>");
                strTimeEntry.Append("<query>");
                if (filters.TicketID.HasValue)
                {
                    strTimeEntry.Append("<field>TicketID<expression op=\"equals\">");
                    strTimeEntry.Append(filters.TicketID.ToString());
                    strTimeEntry.Append("</expression></field>");
                }
                if (filters.TaskID.HasValue)
                {
                    strTimeEntry.Append("<field>TaskID<expression op=\"equals\">");
                    strTimeEntry.Append(filters.TaskID.ToString());
                    strTimeEntry.Append("</expression></field>");
                }
                strTimeEntry.Append("</query></queryxml>");

                ATWSResponse respTimeEntry = this._atwsServices.query(strTimeEntry.ToString());

                if (respTimeEntry.ReturnCode > 0 && respTimeEntry.EntityResults.Length > 0)
                {
                    timeEntries = respTimeEntry.EntityResults.Cast<TimeEntry>().ToList();
                }
            }
            
            return timeEntries;
        }
        //end GetTimeEntries



    }



    #region Filter Classes

    public class TimeEntryFilters
    {
        public long? Id { get; set; }
        public long? TicketID { get; set; }
        public long? TaskID { get; set; }
    }

    public class TaskFilters
    {
        public long? Id { get; set; }
        public long? ProjectID { get; set; }
        public DateTime? LastActivityDateTime { get; set; }
    }

    public class ProjectFilters
    {
        public long? Id { get; set; }
        public string ProjectName { get; set; }
        public string ProjectNumber { get; set; }
    }

    public class TicketFilters
    {
        public long? Id { get; set; }
        public string TicketNumber { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public string opLastActivityDate { get; set; }

    }

    public class ContactFilters
    {
        public long? Id { get; set; }
        public string EMailAddress { get; set; }

    }

    public class ResourceFilters
    {
        public long? Id { get; set; }
        public string UserName { get; set; }

    }

    public class AccountFilters
    {
        public long? Id { get; set; }
        public string AccountName { get; set; }

    }


    

    #endregion Filter Classes



}
