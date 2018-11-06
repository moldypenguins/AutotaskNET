using System;
using System.Collections.Generic;
using System.Linq;
using Autotask;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Reflection;

namespace AutotaskUpdater
{
    class Program
    {
        static void Main(string[] args)
        {
            //string logPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\log.txt";
            //if (!path.EndsWith("\\")) path += "\\";
            string logPath = "E:\\AutotaskPull\\log.txt";

            WriteLog(logPath, DateTime.Now.ToShortDateString() + "\r\n");
            WriteLog(logPath, "\t" + DateTime.Now.ToLongTimeString() + "\t" + "Connecting to AutoTask." + "\r\n");

            //login to autotask api
            AutotaskAPI atAPI = new AutotaskAPI(
                    Properties.Settings.Default.AutotaskAPI_URI,
                    Properties.Settings.Default.AutotaskAPI_Username,
                    Properties.Settings.Default.AutotaskAPI_Password
                );

            WriteLog(logPath, "\t" + DateTime.Now.ToLongTimeString() + "\t" + "Connected." + "\r\n");

            /*
            List<net.autotask.webservices.Field> fields = atAPI.GetEntityFields("Ticket");
            foreach (net.autotask.webservices.Field fld in fields)
            {
                Debug.WriteLine(fld.Name + " - " + fld.Type + "(" + fld.Length + ")" + (fld.IsRequired ? " R" : "") + (!string.IsNullOrEmpty(fld.ReferenceEntityType) ? " (FK: " + fld.ReferenceEntityType + ")" : ""));
                if (fld.IsPickList)
                {
                    foreach (net.autotask.webservices.PickListValue pl in fld.PicklistValues)
                    {
                        Debug.WriteLine("\t" + pl.Value + " - " + pl.Label);
                    }
                }
            }
            Debug.WriteLine("\n");
            */
            /**/

            //get accounts
            WriteLog(logPath, "\t" + DateTime.Now.ToLongTimeString() + "\t" + "Populating [Accounts]." + "\r\n");
            put_accounts(atAPI.GetAccounts());


            //get resources
            WriteLog(logPath, "\t" + DateTime.Now.ToLongTimeString() + "\t" + "Populating [Resources]." + "\r\n");
            put_resources(atAPI.GetResources());


            //get contacts
            WriteLog(logPath, "\t" + DateTime.Now.ToLongTimeString() + "\t" + "Populating [Contacts]." + "\r\n");
            put_contacts(atAPI.GetContacts());


            //get tickets
            WriteLog(logPath, "\t" + DateTime.Now.ToLongTimeString() + "\t" + "Populating [Tickets]." + "\r\n");
            //atAPI.GetTickets(new TicketFilters { LastActivityDate = DateTime.Now.AddDays(-1).AddHours(-1), opLastActivityDate = "greaterthan" });
            put_tickets(atAPI.GetTickets(new TicketFilters { LastActivityDate = DateTime.Now.AddDays(-1).AddHours(-1), opLastActivityDate = "greaterthan" }));
            //get ticket picker values
            WriteLog(logPath, "\t" + DateTime.Now.ToLongTimeString() + "\t" + "Populating [Tickets] Picker Values." + "\r\n");
            put_ticket_status(atAPI.GetEntityFields("Ticket").Single(f => f.Name == "Status"));
            put_ticket_issuetypes(atAPI.GetEntityFields("Ticket").Single(f => f.Name == "IssueType"));
            put_ticket_subissuetypes(atAPI.GetEntityFields("Ticket").Single(f => f.Name == "SubIssueType"));
            put_ticket_monitortypes(atAPI.GetEntityFields("Ticket").Single(f => f.Name == "MonitorTypeID"));
            put_ticket_ticketcategories(atAPI.GetEntityFields("Ticket").Single(f => f.Name == "TicketCategory"));
            put_ticket_tickettypes(atAPI.GetEntityFields("Ticket").Single(f => f.Name == "TicketType"));
            put_ticket_sources(atAPI.GetEntityFields("Ticket").Single(f => f.Name == "Source"));
            put_ticket_queues(atAPI.GetEntityFields("Ticket").Single(f => f.Name == "QueueID"));
            put_ticket_priorities(atAPI.GetEntityFields("Ticket").Single(f => f.Name == "Priority"));


            //get projects
            WriteLog(logPath, "\t" + DateTime.Now.ToLongTimeString() + "\t" + "Populating [Projects]." + "\r\n");
            put_projects(atAPI.GetProjects());


            //get tasks
            WriteLog(logPath, "\t" + DateTime.Now.ToLongTimeString() + "\t" + "Populating [Tasks]." + "\r\n");
            put_tasks(atAPI.GetTasks());


            //get time entries
            WriteLog(logPath, "\t" + DateTime.Now.ToLongTimeString() + "\t" + "Populating [TimeEntries]." + "\r\n");
            //atAPI.GetTimeEntries(new TimeEntryFilters { TicketID = tickets[0].id });
            put_timeentries(atAPI.GetTimeEntries());

            /**/
            WriteLog(logPath, "\t" + DateTime.Now.ToLongTimeString() + "\t" + "Done." + "\r\n" + "\r\n");

            //end Program.Main
        }

        static void WriteLog(string filePath, string message)
        {
            if (!File.Exists(filePath)) {
                FileStream fs = File.Create(filePath);
                fs.Close();
            }
            try
            {
                using (StreamWriter sWriter = File.AppendText(filePath))
                {
                    sWriter.Write(message);
                }
            }
            catch (Exception ex)
            {
                //do something with exception
                Console.Error.Write(ex.Message.ToString() + "\r\n");
            }
        }


        static void put_accounts(List<net.autotask.webservices.Account> accounts)
        {
            AutotaskDataContext atDataset = new AutotaskDataContext();

            foreach (net.autotask.webservices.Account acc in accounts)
            {
                Account account;
                //check if account exists in db
                bool exists = atDataset.Accounts.Where(r => r.id == acc.id).Any();
                if (!exists)
                {
                    account = new Account();
                    account.id = acc.id;
                }
                else
                {
                    account = atDataset.Accounts.Single(r => r.id == acc.id);
                }
                account.AccountName = Convert.ToString(acc.AccountName);
                account.AccountNumber = Convert.ToString(acc.AccountNumber);
                account.AccountType = Convert.ToInt16(acc.AccountType);
                account.Active = Convert.ToByte(acc.Active);
                account.AdditionalAddressInformation = Convert.ToString(acc.AdditionalAddressInformation);
                account.Address1 = Convert.ToString(acc.Address1);
                account.Address2 = Convert.ToString(acc.Address2);
                account.AlternatePhone1 = Convert.ToString(acc.AlternatePhone1);
                account.AlternatePhone2 = Convert.ToString(acc.AlternatePhone2);
                account.AssetValue = Convert.ToDouble(acc.AssetValue);
                account.BillToAdditionalAddressInformation = Convert.ToString(acc.BillToAdditionalAddressInformation);
                account.BillToAddress1 = Convert.ToString(acc.BillToAddress1);
                account.BillToAddress2 = Convert.ToString(acc.BillToAddress2);
                account.BillToAddressToUse = Convert.ToInt32(acc.BillToAddressToUse);
                account.BillToAttention = Convert.ToString(acc.BillToAttention);
                account.BillToCity = Convert.ToString(acc.BillToCity);
                account.BillToCountryID = Convert.ToInt64(acc.BillToCountryID);
                account.BillToState = Convert.ToString(acc.BillToState);
                account.BillToZipCode = Convert.ToString(acc.BillToZipCode);
                account.City = Convert.ToString(acc.City);
                account.ClientPortalActive = Convert.ToByte(acc.ClientPortalActive);
                account.CompetitorID = Convert.ToInt32(acc.CompetitorID);
                account.Country = Convert.ToString(acc.Country);
                account.CountryID = Convert.ToInt64(acc.CountryID);
                account.CreateDate = acc.CreateDate == null ? new DateTime?() : Convert.ToDateTime(acc.CreateDate);
                account.CurrencyID = Convert.ToInt64(acc.CurrencyID);
                account.Fax = Convert.ToString(acc.Fax);
                account.InvoiceEmailMessageID = Convert.ToInt32(acc.InvoiceEmailMessageID);
                account.InvoiceMethod = Convert.ToInt32(acc.InvoiceMethod);
                account.InvoiceNonContractItemsToParentAccount = Convert.ToByte(acc.InvoiceNonContractItemsToParentAccount);
                account.InvoiceTemplateID = Convert.ToInt64(acc.InvoiceTemplateID);
                account.KeyAccountIcon = Convert.ToInt32(acc.KeyAccountIcon);
                account.LastActivityDate = acc.LastActivityDate == null ? new DateTime?() : Convert.ToDateTime(acc.LastActivityDate);
                account.MarketSegmentID = Convert.ToInt32(acc.MarketSegmentID);
                account.OwnerResourceID = Convert.ToInt64(acc.OwnerResourceID);
                account.ParentAccountID = Convert.ToInt64(acc.ParentAccountID);
                account.Phone = Convert.ToString(acc.Phone);
                account.PostalCode = Convert.ToString(acc.PostalCode);
                account.QuoteEmailMessageID = Convert.ToInt32(acc.QuoteEmailMessageID);
                account.QuoteTemplateID = Convert.ToInt64(acc.QuoteTemplateID);
                account.SICCode = Convert.ToString(acc.SICCode);
                account.State = Convert.ToString(acc.State);
                account.StockMarket = Convert.ToString(acc.StockMarket);
                account.StockSymbol = Convert.ToString(acc.StockSymbol);
                account.TaskFireActive = Convert.ToByte(acc.TaskFireActive);
                account.TaxExempt = Convert.ToByte(acc.TaxExempt);
                account.TaxID = Convert.ToString(acc.TaxID);
                account.TaxRegionID = Convert.ToInt32(acc.TaxRegionID);
                account.TerritoryID = Convert.ToInt32(acc.TerritoryID);
                account.WebAddress = Convert.ToString(acc.WebAddress);
                if (!exists)
                {
                    atDataset.Accounts.InsertOnSubmit(account);
                }
            }
            atDataset.SubmitChanges();
        }
        //end put_accounts


        static void put_resources(List<net.autotask.webservices.Resource> resources)
        {
            AutotaskDataContext atDataset = new AutotaskDataContext();

            foreach (net.autotask.webservices.Resource res in resources)
            {
                Resource resource;
                //check if resource exists in db
                bool exists = atDataset.Resources.Where(r => r.id == res.id).Any();
                if (!exists)
                {
                    resource = new Resource();
                    resource.id = res.id;
                }
                else
                {
                    resource = atDataset.Resources.Single(r => r.id == res.id);
                }
                resource.AccountingReferenceID = Convert.ToString(res.AccountingReferenceID);
                resource.Active = Convert.ToByte(res.Active);
                resource.DateFormat = Convert.ToString(res.DateFormat);
                resource.DefaultServiceDeskRoleID = Convert.ToInt64(res.DefaultServiceDeskRoleID);
                resource.Email = Convert.ToString(res.Email);
                resource.Email2 = Convert.ToString(res.Email2);
                resource.Email3 = Convert.ToString(res.Email3);
                resource.EmailTypeCode = Convert.ToString(res.EmailTypeCode);
                resource.EmailTypeCode2 = Convert.ToString(res.EmailTypeCode2);
                resource.EmailTypeCode3 = Convert.ToString(res.EmailTypeCode3);
                resource.FirstName = Convert.ToString(res.FirstName);
                resource.Gender = Convert.ToString(res.Gender);
                resource.Greeting = Convert.ToInt32(res.Greeting);
                resource.HireDate = Convert.ToDateTime(res.HireDate) > new DateTime(1753, 1, 1) ? Convert.ToDateTime(res.HireDate) : new DateTime(1753, 1, 1);
                resource.HomePhone = Convert.ToString(res.HomePhone);
                resource.Initials = Convert.ToString(res.Initials);
                resource.InternalCost = Convert.ToDouble(res.InternalCost);
                resource.LastName = Convert.ToString(res.LastName);
                resource.LocationID = Convert.ToInt32(res.LocationID);
                resource.MiddleName = Convert.ToString(res.MiddleName);
                resource.MobilePhone = Convert.ToString(res.MobilePhone);
                resource.NumberFormat = Convert.ToString(res.NumberFormat);
                resource.OfficeExtension = Convert.ToString(res.OfficeExtension);
                resource.OfficePhone = Convert.ToString(res.OfficePhone);
                resource.Password = Convert.ToString(res.Password);
                resource.PayrollType = Convert.ToInt32(res.PayrollType);
                resource.ResourceType = Convert.ToString(res.ResourceType);
                resource.Suffix = Convert.ToString(res.Suffix);
                resource.TimeFormat = Convert.ToString(res.TimeFormat);
                resource.Title = Convert.ToString(res.Title);
                resource.TravelAvailabilityPct = Convert.ToString(res.TravelAvailabilityPct);
                resource.UserName = Convert.ToString(res.UserName);
                resource.UserType = Convert.ToInt32(res.UserType);
                if (!exists)
                {
                    atDataset.Resources.InsertOnSubmit(resource);
                }
            }
            atDataset.SubmitChanges();
        }
        //end put_resources


        static void put_contacts(List<net.autotask.webservices.Contact> contacts)
        {
            AutotaskDataContext atDataset = new AutotaskDataContext();

            foreach (net.autotask.webservices.Contact con in contacts)
            {
                Contact contact;
                //check if contact exists in db
                bool exists = atDataset.Contacts.Where(c => c.id == con.id).Any();
                if (!exists)
                {
                    contact = new Contact();
                    contact.id = con.id;
                }
                else
                {
                    contact = atDataset.Contacts.Single(c => c.id == con.id);
                }
                contact.AccountID = Convert.ToInt64(con.AccountID);
                contact.Active = Convert.ToByte(con.Active);
                contact.AdditionalAddressInformation = Convert.ToString(con.AdditionalAddressInformation);
                contact.AddressLine = Convert.ToString(con.AddressLine);
                contact.AddressLine1 = Convert.ToString(con.AddressLine1);
                contact.AlternatePhone = Convert.ToString(con.AlternatePhone);
                contact.BulkEmailOptOut = Convert.ToByte(con.BulkEmailOptOut);
                contact.BulkEmailOptOutTime = con.BulkEmailOptOutTime == null ? new DateTime?() : Convert.ToDateTime(con.BulkEmailOptOutTime);
                contact.City = Convert.ToString(con.City);
                contact.Country = Convert.ToString(con.Country);
                contact.CountryID = Convert.ToInt64(con.CountryID);
                contact.CreateDate = con.CreateDate == null ? new DateTime?() : Convert.ToDateTime(con.CreateDate);
                contact.EMailAddress = Convert.ToString(con.EMailAddress);
                contact.EMailAddress2 = Convert.ToString(con.EMailAddress2);
                contact.EMailAddress3 = Convert.ToString(con.EMailAddress3);
                contact.Extension = Convert.ToString(con.Extension);
                contact.ExternalID = Convert.ToString(con.ExternalID);
                contact.FacebookURL = Convert.ToString(con.FacebookUrl);
                contact.FaxNumber = Convert.ToString(con.FaxNumber);
                contact.FirstName = Convert.ToString(con.FirstName);
                contact.LastActivityDate = con.LastActivityDate == null ? new DateTime?() : Convert.ToDateTime(con.LastActivityDate);
                contact.LastModifiedDate = con.LastModifiedDate == null ? new DateTime?() : Convert.ToDateTime(con.LastModifiedDate);
                contact.LastName = Convert.ToString(con.LastName);
                contact.LinkedInURL = Convert.ToString(con.LinkedInUrl);
                contact.MiddleInitial = Convert.ToString(con.MiddleInitial);
                contact.MobilePhone = Convert.ToString(con.MobilePhone);
                contact.NamePrefix = Convert.ToInt32(con.NamePrefix);
                contact.NameSuffix = Convert.ToInt32(con.NameSuffix);
                contact.Note = Convert.ToString(con.Note);
                contact.Notification = Convert.ToByte(con.Notification);
                contact.Phone = Convert.ToString(con.Phone);
                contact.PrimaryContact = Convert.ToByte(con.PrimaryContact);
                contact.RoomNumber = Convert.ToString(con.RoomNumber);
                contact.State = Convert.ToString(con.State);
                contact.SurveyOptOut = Convert.ToByte(con.SurveyOptOut);
                contact.Title = Convert.ToString(con.Title);
                contact.TwitterURL = Convert.ToString(con.TwitterUrl);
                contact.ZipCode = Convert.ToString(con.ZipCode);
                if (!exists)
                {
                    atDataset.Contacts.InsertOnSubmit(contact);
                }
            }
            atDataset.SubmitChanges();
        }
        //end put_contacts


        static void put_tickets(List<net.autotask.webservices.Ticket> tickets)
        {
            AutotaskDataContext atDataset = new AutotaskDataContext();

            foreach (net.autotask.webservices.Ticket tic in tickets)
            {
                Ticket ticket;
                //check if ticket exists in db
                bool exists = atDataset.Tickets.Where(t => t.id == tic.id).Any();
                if (!exists)
                { 
                    ticket = new Ticket();
                    ticket.id = tic.id;
                }
                else
                {
                    ticket = atDataset.Tickets.Single(t => t.id == tic.id);
                }
                ticket.AccountID = Convert.ToInt64(tic.AccountID);
                ticket.AEMAlertID = Convert.ToString(tic.AEMAlertID);
                ticket.AllocationCodeID = Convert.ToInt64(tic.AllocationCodeID);
                ticket.AssignedResourceID = Convert.ToInt64(tic.AssignedResourceID);
                ticket.AssignedResourceRoleID = Convert.ToInt64(tic.AssignedResourceRoleID);
                ticket.ChangeApprovalBoard = Convert.ToInt32(tic.ChangeApprovalBoard);
                ticket.ChangeApprovalStatus = Convert.ToInt32(tic.ChangeApprovalStatus);
                ticket.ChangeApprovalType = Convert.ToInt32(tic.ChangeApprovalType);
                ticket.ChangeInfoField1 = Convert.ToString(tic.ChangeInfoField1);
                ticket.ChangeInfoField2 = Convert.ToString(tic.ChangeInfoField2);
                ticket.ChangeInfoField3 = Convert.ToString(tic.ChangeInfoField3);
                ticket.ChangeInfoField4 = Convert.ToString(tic.ChangeInfoField4);
                ticket.ChangeInfoField5 = Convert.ToString(tic.ChangeInfoField5);
                ticket.CompletedDate = tic.CompletedDate == null ? new DateTime?() : Convert.ToDateTime(tic.CompletedDate);
                ticket.ContactID = Convert.ToInt64(tic.ContactID);
                ticket.ContractID = Convert.ToInt64(tic.ContractID);
                ticket.ContractServiceBundleID = Convert.ToInt64(tic.ContractServiceBundleID);
                ticket.ContractServiceID = Convert.ToInt64(tic.ContractServiceID);
                ticket.CreateDate = tic.CreateDate == null ? new DateTime?() : Convert.ToDateTime(tic.CreateDate);
                ticket.CreatorResourceID = Convert.ToInt64(tic.CreatorResourceID);
                ticket.Description = Convert.ToString(tic.Description);
                ticket.DueDateTime = Convert.ToDateTime(tic.DueDateTime) > new DateTime(1753, 1, 1) ? Convert.ToDateTime(tic.DueDateTime) : new DateTime(1753, 1, 1);
                ticket.EstimatedHours = Convert.ToDouble(tic.EstimatedHours);
                ticket.ExternalID = Convert.ToString(tic.ExternalID);
                ticket.FirstResponseAssignedResourceID = Convert.ToInt32(tic.FirstResponseAssignedResourceID);
                ticket.FirstResponseDateTime = tic.FirstResponseDateTime == null ? new DateTime?() : Convert.ToDateTime(tic.FirstResponseDateTime);
                ticket.FirstResponseDueDateTime = tic.FirstResponseDueDateTime == null ? new DateTime?() : Convert.ToDateTime(tic.FirstResponseDueDateTime);
                ticket.FirstResponseInitiatingResourceID = Convert.ToInt32(tic.FirstResponseInitiatingResourceID);
                ticket.HoursToBeScheduled = Convert.ToDouble(tic.HoursToBeScheduled);
                ticket.InstalledProductID = Convert.ToInt64(tic.InstalledProductID);
                ticket.IssueType = Convert.ToInt32(tic.IssueType);
                ticket.LastActivityDate = tic.LastActivityDate == null ? new DateTime?() : Convert.ToDateTime(tic.LastActivityDate);
                ticket.LastCustomerNotificationDateTime = tic.LastCustomerNotificationDateTime == null ? new DateTime?() : Convert.ToDateTime(tic.LastCustomerNotificationDateTime);
                ticket.LastCustomerVisibleActivityDateTime = tic.LastCustomerVisibleActivityDateTime == null ? new DateTime?() : Convert.ToDateTime(tic.LastCustomerVisibleActivityDateTime);
                ticket.MonitorID = Convert.ToInt32(tic.MonitorID);
                ticket.MonitorTypeID = Convert.ToInt32(tic.MonitorTypeID);
                ticket.OpportunityId = Convert.ToInt64(tic.OpportunityId);
                ticket.Priority = Convert.ToInt32(tic.Priority);
                ticket.ProblemTicketId = Convert.ToInt64(tic.ProblemTicketId);
                ticket.ProjectID = Convert.ToInt64(tic.ProjectID);
                ticket.PurchaseOrderNumber = Convert.ToString(tic.PurchaseOrderNumber);
                ticket.QueueID = Convert.ToInt32(tic.QueueID);
                ticket.Resolution = Convert.ToString(tic.Resolution);
                ticket.ResolutionPlanDateTime = tic.ResolutionPlanDateTime == null ? new DateTime?() : Convert.ToDateTime(tic.ResolutionPlanDateTime);
                ticket.ResolutionPlanDueDateTime = tic.ResolutionPlanDueDateTime == null ? new DateTime?() : Convert.ToDateTime(tic.ResolutionPlanDueDateTime);
                ticket.ResolvedDateTime = tic.ResolvedDateTime == null ? new DateTime?() : Convert.ToDateTime(tic.ResolvedDateTime);
                ticket.ResolvedDueDateTime = tic.ResolvedDueDateTime == null ? new DateTime?() : Convert.ToDateTime(tic.ResolvedDueDateTime);
                ticket.ServiceLevelAgreementHasBeenMet = Convert.ToByte(tic.ServiceLevelAgreementHasBeenMet);
                ticket.ServiceLevelAgreementID = Convert.ToInt32(tic.ServiceLevelAgreementID);
                ticket.Source = Convert.ToInt32(tic.Source);
                ticket.Status = Convert.ToInt32(tic.Status);
                ticket.SubIssueType = Convert.ToInt32(tic.SubIssueType);
                ticket.TicketCategory = Convert.ToInt32(tic.TicketCategory);
                ticket.TicketNumber = Convert.ToString(tic.TicketNumber);
                ticket.TicketType = Convert.ToInt32(tic.TicketType);
                ticket.Title = Convert.ToString(tic.Title);
                if (!exists)
                {
                    atDataset.Tickets.InsertOnSubmit(ticket);
                }
            }
            atDataset.SubmitChanges();
        }
        //end put_tickets


        static void put_ticket_status(net.autotask.webservices.Field field)
        {
            AutotaskDataContext atDataset = new AutotaskDataContext();

            foreach (net.autotask.webservices.PickListValue plv in field.PicklistValues)
            {
                Ticket_Status status;
                //check if status exists in db
                bool exists = atDataset.Ticket_Status.Where(s => s.Value == Convert.ToInt32(plv.Value)).Any();
                if (!exists)
                {
                    status = new Ticket_Status();
                    status.Value = Convert.ToInt32(plv.Value);
                }
                else
                {
                    status = atDataset.Ticket_Status.Single(s => s.Value == Convert.ToInt32(plv.Value));
                }
                status.IsActive = Convert.ToByte(plv.IsActive);
                status.IsDefaultValue = Convert.ToByte(plv.IsDefaultValue);
                status.IsSystem = Convert.ToByte(plv.IsSystem);
                status.Label = plv.Label;
                status.ParentValue = plv.parentValue;
                status.SortOrder = plv.SortOrder;
                if (!exists)
                {
                    atDataset.Ticket_Status.InsertOnSubmit(status);
                }
            }
            atDataset.SubmitChanges();
        }
        //end put_ticket_status


        static void put_ticket_issuetypes(net.autotask.webservices.Field field)
        {
            AutotaskDataContext atDataset = new AutotaskDataContext();

            foreach (net.autotask.webservices.PickListValue plv in field.PicklistValues)
            {
                Ticket_IssueType issuetype;
                //check if status exists in db
                bool exists = atDataset.Ticket_IssueTypes.Where(s => s.Value == Convert.ToInt32(plv.Value)).Any();
                if (!exists)
                {
                    issuetype = new Ticket_IssueType();
                    issuetype.Value = Convert.ToInt32(plv.Value);
                }
                else
                {
                    issuetype = atDataset.Ticket_IssueTypes.Single(s => s.Value == Convert.ToInt32(plv.Value));
                }
                issuetype.IsActive = Convert.ToByte(plv.IsActive);
                issuetype.IsDefaultValue = Convert.ToByte(plv.IsDefaultValue);
                issuetype.IsSystem = Convert.ToByte(plv.IsSystem);
                issuetype.Label = plv.Label;
                issuetype.ParentValue = plv.parentValue;
                issuetype.SortOrder = plv.SortOrder;
                if (!exists)
                {
                    atDataset.Ticket_IssueTypes.InsertOnSubmit(issuetype);
                }
            }
            atDataset.SubmitChanges();
        }
        //end put_ticket_issuetypes


        static void put_ticket_subissuetypes(net.autotask.webservices.Field field)
        {
            AutotaskDataContext atDataset = new AutotaskDataContext();

            foreach (net.autotask.webservices.PickListValue plv in field.PicklistValues)
            {
                Ticket_SubIssueType subissuetype;
                //check if status exists in db
                bool exists = atDataset.Ticket_SubIssueTypes.Where(s => s.Value == Convert.ToInt32(plv.Value)).Any();
                if (!exists)
                {
                    subissuetype = new Ticket_SubIssueType();
                    subissuetype.Value = Convert.ToInt32(plv.Value);
                }
                else
                {
                    subissuetype = atDataset.Ticket_SubIssueTypes.Single(s => s.Value == Convert.ToInt32(plv.Value));
                }
                subissuetype.IsActive = Convert.ToByte(plv.IsActive);
                subissuetype.IsDefaultValue = Convert.ToByte(plv.IsDefaultValue);
                subissuetype.IsSystem = Convert.ToByte(plv.IsSystem);
                subissuetype.Label = plv.Label;
                subissuetype.ParentValue = plv.parentValue;
                subissuetype.SortOrder = plv.SortOrder;
                if (!exists)
                {
                    atDataset.Ticket_SubIssueTypes.InsertOnSubmit(subissuetype);
                }
            }
            atDataset.SubmitChanges();
        }
        //end put_ticket_subissuetypes


        static void put_ticket_monitortypes(net.autotask.webservices.Field field)
        {
            AutotaskDataContext atDataset = new AutotaskDataContext();

            foreach (net.autotask.webservices.PickListValue plv in field.PicklistValues)
            {
                Ticket_MonitorType monitortype;
                //check if monitor type exists in db
                bool exists = atDataset.Ticket_MonitorTypes.Where(s => s.Value == Convert.ToInt32(plv.Value)).Any();
                if (!exists)
                {
                    monitortype = new Ticket_MonitorType();
                    monitortype.Value = Convert.ToInt32(plv.Value);
                }
                else
                {
                    monitortype = atDataset.Ticket_MonitorTypes.Single(s => s.Value == Convert.ToInt32(plv.Value));
                }
                monitortype.IsActive = Convert.ToByte(plv.IsActive);
                monitortype.IsDefaultValue = Convert.ToByte(plv.IsDefaultValue);
                monitortype.IsSystem = Convert.ToByte(plv.IsSystem);
                monitortype.Label = plv.Label;
                monitortype.ParentValue = plv.parentValue;
                monitortype.SortOrder = plv.SortOrder;
                if (!exists)
                {
                    atDataset.Ticket_MonitorTypes.InsertOnSubmit(monitortype);
                }
            }
            atDataset.SubmitChanges();
        }
        //end put_ticket_monitortypes


        static void put_ticket_ticketcategories(net.autotask.webservices.Field field)
        {
            AutotaskDataContext atDataset = new AutotaskDataContext();

            foreach (net.autotask.webservices.PickListValue plv in field.PicklistValues)
            {
                Ticket_TicketCategory ticketcategory;
                //check if ticket category exists in db
                bool exists = atDataset.Ticket_TicketCategories.Where(s => s.Value == Convert.ToInt32(plv.Value)).Any();
                if (!exists)
                {
                    ticketcategory = new Ticket_TicketCategory();
                    ticketcategory.Value = Convert.ToInt32(plv.Value);
                }
                else
                {
                    ticketcategory = atDataset.Ticket_TicketCategories.Single(s => s.Value == Convert.ToInt32(plv.Value));
                }
                ticketcategory.IsActive = Convert.ToByte(plv.IsActive);
                ticketcategory.IsDefaultValue = Convert.ToByte(plv.IsDefaultValue);
                ticketcategory.IsSystem = Convert.ToByte(plv.IsSystem);
                ticketcategory.Label = plv.Label;
                ticketcategory.ParentValue = plv.parentValue;
                ticketcategory.SortOrder = plv.SortOrder;
                if (!exists)
                {
                    atDataset.Ticket_TicketCategories.InsertOnSubmit(ticketcategory);
                }
            }
            atDataset.SubmitChanges();
        }
        //end put_ticket_ticketcategories


        static void put_ticket_tickettypes(net.autotask.webservices.Field field)
        {
            AutotaskDataContext atDataset = new AutotaskDataContext();

            foreach (net.autotask.webservices.PickListValue plv in field.PicklistValues)
            {
                Ticket_TicketType tickettype;
                //check if ticket type exists in db
                bool exists = atDataset.Ticket_TicketTypes.Where(s => s.Value == Convert.ToInt32(plv.Value)).Any();
                if (!exists)
                {
                    tickettype = new Ticket_TicketType();
                    tickettype.Value = Convert.ToInt32(plv.Value);
                }
                else
                {
                    tickettype = atDataset.Ticket_TicketTypes.Single(s => s.Value == Convert.ToInt32(plv.Value));
                }
                tickettype.IsActive = Convert.ToByte(plv.IsActive);
                tickettype.IsDefaultValue = Convert.ToByte(plv.IsDefaultValue);
                tickettype.IsSystem = Convert.ToByte(plv.IsSystem);
                tickettype.Label = plv.Label;
                tickettype.ParentValue = plv.parentValue;
                tickettype.SortOrder = plv.SortOrder;
                if (!exists)
                {
                    atDataset.Ticket_TicketTypes.InsertOnSubmit(tickettype);
                }
            }
            atDataset.SubmitChanges();
        }
        //end put_ticket_tickettypes


        static void put_ticket_sources(net.autotask.webservices.Field field)
        {
            AutotaskDataContext atDataset = new AutotaskDataContext();

            foreach (net.autotask.webservices.PickListValue plv in field.PicklistValues)
            {
                Ticket_Source source;
                //check if source exists in db
                bool exists = atDataset.Ticket_Sources.Where(s => s.Value == Convert.ToInt32(plv.Value)).Any();
                if (!exists)
                {
                    source = new Ticket_Source();
                    source.Value = Convert.ToInt32(plv.Value);
                }
                else
                {
                    source = atDataset.Ticket_Sources.Single(s => s.Value == Convert.ToInt32(plv.Value));
                }
                source.IsActive = Convert.ToByte(plv.IsActive);
                source.IsDefaultValue = Convert.ToByte(plv.IsDefaultValue);
                source.IsSystem = Convert.ToByte(plv.IsSystem);
                source.Label = plv.Label;
                source.ParentValue = plv.parentValue;
                source.SortOrder = plv.SortOrder;
                if (!exists)
                {
                    atDataset.Ticket_Sources.InsertOnSubmit(source);
                }
            }
            atDataset.SubmitChanges();
        }
        //end put_ticket_sources


        static void put_ticket_queues(net.autotask.webservices.Field field)
        {
            AutotaskDataContext atDataset = new AutotaskDataContext();

            foreach (net.autotask.webservices.PickListValue plv in field.PicklistValues)
            {
                Ticket_Queue queue;
                //check if queue exists in db
                bool exists = atDataset.Ticket_Queues.Where(s => s.Value == Convert.ToInt32(plv.Value)).Any();
                if (!exists)
                {
                    queue = new Ticket_Queue();
                    queue.Value = Convert.ToInt32(plv.Value);
                }
                else
                {
                    queue = atDataset.Ticket_Queues.Single(s => s.Value == Convert.ToInt32(plv.Value));
                }
                queue.IsActive = Convert.ToByte(plv.IsActive);
                queue.IsDefaultValue = Convert.ToByte(plv.IsDefaultValue);
                queue.IsSystem = Convert.ToByte(plv.IsSystem);
                queue.Label = plv.Label;
                queue.ParentValue = plv.parentValue;
                queue.SortOrder = plv.SortOrder;
                if (!exists)
                {
                    atDataset.Ticket_Queues.InsertOnSubmit(queue);
                }
            }
            atDataset.SubmitChanges();
        }
        //end put_ticket_queues


        static void put_ticket_priorities(net.autotask.webservices.Field field)
        {
            AutotaskDataContext atDataset = new AutotaskDataContext();

            foreach (net.autotask.webservices.PickListValue plv in field.PicklistValues)
            {
                Ticket_Priority priority;
                //check if priority exists in db
                bool exists = atDataset.Ticket_Priorities.Where(s => s.Value == Convert.ToInt32(plv.Value)).Any();
                if (!exists)
                {
                    priority = new Ticket_Priority();
                    priority.Value = Convert.ToInt32(plv.Value);
                }
                else
                {
                    priority = atDataset.Ticket_Priorities.Single(s => s.Value == Convert.ToInt32(plv.Value));
                }
                priority.IsActive = Convert.ToByte(plv.IsActive);
                priority.IsDefaultValue = Convert.ToByte(plv.IsDefaultValue);
                priority.IsSystem = Convert.ToByte(plv.IsSystem);
                priority.Label = plv.Label;
                priority.ParentValue = plv.parentValue;
                priority.SortOrder = plv.SortOrder;
                if (!exists)
                {
                    atDataset.Ticket_Priorities.InsertOnSubmit(priority);
                }
            }
            atDataset.SubmitChanges();
        }
        //end put_ticket_priorities

        
        static void put_projects(List<net.autotask.webservices.Project> projects)
        {
            AutotaskDataContext atDataset = new AutotaskDataContext();

            foreach (net.autotask.webservices.Project pro in projects)
            {
                Project project;
                //check if project exists in db
                bool exists = atDataset.Projects.Where(p => p.id == pro.id).Any();
                if (!exists)
                {
                    project = new Project();
                    project.id = pro.id;
                }
                else
                {
                    project = atDataset.Projects.Single(p => p.id == pro.id);
                }
                project.AccountID = Convert.ToInt64(pro.AccountID);
                project.ActualBilledHours = Convert.ToDouble(pro.ActualBilledHours);
                project.ActualHours = Convert.ToDouble(pro.ActualHours);
                project.ChangeOrdersBudget = Convert.ToDouble(pro.ChangeOrdersBudget);
                project.ChangeOrdersRevenue = Convert.ToDouble(pro.ChangeOrdersRevenue);
                project.CompanyOwnerResourceID = Convert.ToInt64(pro.CompanyOwnerResourceID);
                project.CompletedDateTime = pro.CompletedDateTime == null ? new DateTime?() : Convert.ToDateTime(pro.CompletedDateTime);
                project.CompletedPercentage = Convert.ToInt32(pro.CompletedPercentage);
                project.ContractID = Convert.ToInt64(pro.ContractID);
                project.CreateDateTime = pro.CreateDateTime == null ? new DateTime?() : Convert.ToDateTime(pro.CreateDateTime);
                project.CreatorResourceID = Convert.ToInt64(pro.CreatorResourceID);
                project.Department = Convert.ToInt32(pro.Department);
                project.Description = Convert.ToString(pro.Description);
                project.Duration = Convert.ToInt32(pro.Duration);
                project.EndDateTime = Convert.ToDateTime(pro.EndDateTime) > new DateTime(1753, 1, 1) ? Convert.ToDateTime(pro.EndDateTime) : new DateTime(1753, 1, 1);
                project.EstimatedSalesCost = Convert.ToDouble(pro.EstimatedSalesCost);
                project.EstimatedTime = Convert.ToDouble(pro.EstimatedTime);
                project.ExtPNumber = Convert.ToString(pro.ExtPNumber);
                project.ExtProjectType = Convert.ToInt32(pro.ExtProjectType);
                project.LaborEstimatedCosts = Convert.ToDouble(pro.LaborEstimatedCosts);
                project.LaborEstimatedMarginPercentage = Convert.ToDouble(pro.LaborEstimatedMarginPercentage);
                project.LaborEstimatedRevenue = Convert.ToDouble(pro.LaborEstimatedRevenue);
                project.LineOfBusiness = Convert.ToInt32(pro.LineOfBusiness);
                project.OriginalEstimatedRevenue = Convert.ToDouble(pro.OriginalEstimatedRevenue);
                project.ProjectCostEstimatedMarginPercentage = Convert.ToDouble(pro.ProjectCostEstimatedMarginPercentage);
                project.ProjectCostsBudget = Convert.ToDouble(pro.ProjectCostsBudget);
                project.ProjectCostsRevenue = Convert.ToDouble(pro.ProjectCostsRevenue);
                project.ProjectLeadResourceID = Convert.ToInt64(pro.ProjectLeadResourceID);
                project.ProjectName = Convert.ToString(pro.ProjectName);
                project.ProjectNumber = Convert.ToString(pro.ProjectNumber);
                project.PurchaseOrderNumber = Convert.ToString(pro.PurchaseOrderNumber);
                project.SGDA = Convert.ToDouble(pro.SGDA);
                project.StartDateTime = Convert.ToDateTime(pro.StartDateTime) > new DateTime(1753, 1, 1) ? Convert.ToDateTime(pro.StartDateTime) : new DateTime(1753, 1, 1);
                project.Status = Convert.ToInt32(pro.Status);
                project.StatusDateTime = pro.StatusDateTime == null ? new DateTime?() : Convert.ToDateTime(pro.StatusDateTime);
                project.StatusDetail = Convert.ToString(pro.StatusDetail);
                project.Type = Convert.ToInt32(pro.Type);
                if (!exists)
                {
                    atDataset.Projects.InsertOnSubmit(project);
                }
            }
            atDataset.SubmitChanges();
        }
        //end put_projects


        static void put_tasks(List<net.autotask.webservices.Task> tasks)
        {
            AutotaskDataContext atDataset = new AutotaskDataContext();

            foreach (net.autotask.webservices.Task tas in tasks)
            {
                Task task;
                //check if task exists in db
                bool exists = atDataset.Tasks.Where(t => t.id == tas.id).Any();
                if (!exists)
                {
                    task = new Task();
                    task.id = tas.id;
                }
                else
                {
                    task = atDataset.Tasks.Single(t => t.id == tas.id);
                }
                task.AllocationCodeID = Convert.ToInt64(tas.AllocationCodeID);
                task.AssignedResourceID = Convert.ToInt64(tas.AssignedResourceID);
                task.AssignedResourceRoleID = Convert.ToInt64(tas.AssignedResourceRoleID);
                task.CanClientPortalUserCompleteTask = Convert.ToByte(tas.CanClientPortalUserCompleteTask);
                task.CompletedDateTime = tas.CompletedDateTime == null ? new DateTime?() : Convert.ToDateTime(tas.CompletedDateTime);
                task.CreateDateTime = tas.CreateDateTime == null ? new DateTime?() : Convert.ToDateTime(tas.CreateDateTime);
                task.CreatorResourceID = Convert.ToInt64(tas.CreatorResourceID);
                task.DepartmentID = Convert.ToInt32(tas.DepartmentID);
                task.Description = Convert.ToString(tas.Description);
                task.EndDateTime = tas.EndDateTime == null ? new DateTime?() : Convert.ToDateTime(tas.EndDateTime);
                task.EstimatedHours = Convert.ToDouble(tas.EstimatedHours);
                task.ExternalID = Convert.ToString(tas.ExternalID);
                task.HoursToBeScheduled = Convert.ToDouble(tas.HoursToBeScheduled);
                task.IsVisibleInClientPortal = Convert.ToByte(tas.IsVisibleInClientPortal);
                task.LastActivityDateTime = tas.LastActivityDateTime == null ? new DateTime?() : Convert.ToDateTime(tas.LastActivityDateTime);
                task.PhaseID = Convert.ToInt64(tas.PhaseID);
                task.Priority = Convert.ToInt32(tas.Priority);
                task.ProjectID = Convert.ToInt64(tas.ProjectID);
                task.PurchaseOrderNumber = Convert.ToString(tas.PurchaseOrderNumber);
                task.RemainingHours = Convert.ToDouble(tas.RemainingHours);
                task.StartDateTime = tas.StartDateTime == null ? new DateTime?() : Convert.ToDateTime(tas.StartDateTime);
                task.Status = Convert.ToInt32(tas.Status);
                task.TaskIsBillable = Convert.ToByte(tas.TaskIsBillable);
                task.TaskNumber = Convert.ToString(tas.TaskNumber);
                task.TaskType = Convert.ToInt32(tas.TaskType);
                task.Title = Convert.ToString(tas.Title);
                if (!exists)
                {
                    atDataset.Tasks.InsertOnSubmit(task);
                }
            }
            atDataset.SubmitChanges();
        }
        //end put_tasks


        static void put_timeentries(List<net.autotask.webservices.TimeEntry> timeentries)
        {
            AutotaskDataContext atDataset = new AutotaskDataContext();

            foreach (net.autotask.webservices.TimeEntry tim in timeentries)
            {
                TimeEntry timeentry;
                //check if time entry exists in db
                bool exists = atDataset.TimeEntries.Where(r => r.id == tim.id).Any();
                if (!exists)
                {
                    timeentry = new TimeEntry();
                    timeentry.id = tim.id;
                }
                else
                {
                    timeentry = atDataset.TimeEntries.Single(t => t.id == tim.id);
                }
                timeentry.AllocationCodeID = Convert.ToInt64(tim.AllocationCodeID);
                timeentry.BillingApprovalDateTime = tim.BillingApprovalDateTime == null ? new DateTime?() : Convert.ToDateTime(tim.BillingApprovalDateTime);
                timeentry.BillingApprovalLevelMostRecent = Convert.ToInt32(tim.BillingApprovalLevelMostRecent);
                timeentry.BillingApprovalResourceID = Convert.ToInt64(tim.BillingApprovalResourceID);
                timeentry.ContractID = Convert.ToInt64(tim.ContractID);
                timeentry.ContractServiceBundleID = Convert.ToInt64(tim.ContractServiceBundleID);
                timeentry.ContractServiceID = Convert.ToInt64(tim.ContractServiceID);
                timeentry.CreateDateTime = tim.CreateDateTime == null ? new DateTime?() : Convert.ToDateTime(tim.CreateDateTime);
                timeentry.CreatorUserID = Convert.ToInt32(tim.CreatorUserID);
                timeentry.DateWorked = Convert.ToDateTime(tim.DateWorked) > new DateTime(1753, 1, 1) ? Convert.ToDateTime(tim.DateWorked) : new DateTime(1753, 1, 1);
                timeentry.EndDateTime = tim.EndDateTime == null ? new DateTime?() : Convert.ToDateTime(tim.EndDateTime);
                timeentry.HoursToBill = Convert.ToDouble(tim.HoursToBill);
                timeentry.HoursWorked = Convert.ToDouble(tim.HoursWorked);
                timeentry.InternalAllocationCodeID = Convert.ToInt64(tim.InternalAllocationCodeID);
                timeentry.InternalNotes = Convert.ToString(tim.InternalNotes);
                timeentry.LastModifiedDateTime = tim.LastModifiedDateTime == null ? new DateTime?() : Convert.ToDateTime(tim.LastModifiedDateTime);
                timeentry.LastModifiedUserID = Convert.ToInt32(tim.LastModifiedUserID);
                timeentry.NonBillable = Convert.ToByte(tim.NonBillable);
                timeentry.OffsetHours = Convert.ToDouble(tim.OffsetHours);
                timeentry.ResourceID = Convert.ToInt64(tim.ResourceID);
                timeentry.RoleID = Convert.ToInt64(tim.RoleID);
                timeentry.ShowOnInvoice = Convert.ToByte(tim.ShowOnInvoice);
                timeentry.StartDateTime = tim.StartDateTime == null ? new DateTime?() : Convert.ToDateTime(tim.StartDateTime);
                timeentry.SummaryNotes = Convert.ToString(tim.SummaryNotes);
                timeentry.TaskID = Convert.ToInt64(tim.TaskID);
                timeentry.TicketID = Convert.ToInt64(tim.TicketID);
                timeentry.Type = Convert.ToInt32(tim.Type);
                if (!exists)
                {
                    atDataset.TimeEntries.InsertOnSubmit(timeentry);
                }
            }
            atDataset.SubmitChanges();
        }
        //end put_timeentries








    }
}
