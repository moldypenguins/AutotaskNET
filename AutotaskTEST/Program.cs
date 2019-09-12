using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using AutotaskNET;
using AutotaskNET.Entities;

namespace AutotaskTEST
{
    class Program
    {
        private const string @USERNAME = "api.user@domain.com";
        private const string @PASSWORD = "P@ssw0rd";
        private const int @ACCOUNTID = 0;
        private const string @PHONENUMBER = "123-555-1234";

        static void Main(string[] args)
        {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tVersion: {Assembly.GetExecutingAssembly().GetName().Version.ToString()}");
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tConnecting to AutoTask.");

            ATWSInterface atAPI = new ATWSInterface();

            try
            {
                atAPI.Connect(@USERNAME, @PASSWORD);
                
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tConnected.");
                Console.WriteLine();

                
                #region Accounts
                
                //Account Locations
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Account Locations...");
                List<AccountLocation> account_locations = atAPI.Query(typeof(AccountLocation)).OfType<AccountLocation>().ToList();
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tAccount Locations: {account_locations.Count}");
                Console.WriteLine();

                //Account Types
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Account Types...");
                List<PicklistValue> account_types = atAPI.GetPicklistValues(typeof(Account), "AccountType");
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tAccount Types: {account_types.Count}");
                foreach (PicklistValue account_type in account_types)
                {
                    Console.WriteLine($"\t\t - {account_type.Label}");
                }
                Console.WriteLine();
                
                //Customer Accounts
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Customer Accounts...");
                List<Account> customer_accounts = atAPI.Query(typeof(Account), new QueryFilter() {
                    new QueryField("AccountType", QueryFieldOperation.Equals, account_types.Find(type => type.Label == "Customer").Value)
                }).OfType<Account>().ToList();
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tCustomer Accounts: {customer_accounts.Count}");
                Console.WriteLine();

                //Specific Account and All Child Accounts
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Specific Account and All Children Accounts...");
                List<Account> accounts = atAPI.Query(typeof(Account), new QueryFilter() {
                    new QueryCondition(QueryConditionOperation.OR) {
                        new QueryField("id", QueryFieldOperation.Equals, @ACCOUNTID),
                        new QueryField("ParentAccountId", QueryFieldOperation.Equals, @ACCOUNTID)
                    }
                }).OfType<Account>().ToList();
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tAccounts Found: {accounts.Count}");
                Console.WriteLine();

                #endregion //Accounts
                

                #region Tickets

                //Ticket Statuses
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Ticket Statuses...");
                List<PicklistValue> ticket_statuses = atAPI.GetPicklistValues(typeof(Ticket), "Status");
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tTicket Statuses: {account_types.Count}");
                foreach (PicklistValue ticket_status in ticket_statuses)
                {
                    Console.WriteLine($"\t\t - {ticket_status.Label}");
                }
                Console.WriteLine();

                //Tickets for Specific Account
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Tickets for Specific Account...");
                List<Ticket> tickets = atAPI.Query(typeof(Ticket), new QueryFilter {
                    new QueryField("AccountId", QueryFieldOperation.Equals, @ACCOUNTID)
                }).OfType<Ticket>().ToList();
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tTickets Found: {tickets.Count}");
                Console.WriteLine();
                
                //Tickets Updated Today
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Tickets Updated Today...");
                List<Ticket> tickets_updated_today = atAPI.Query(typeof(Ticket), new QueryFilter {
                    new QueryField("LastActivityDate", QueryFieldOperation.GreaterThanorEquals, DateTime.Today)
                }).OfType<Ticket>().ToList();
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tTickets Updated Today: {tickets_updated_today.Count}");
                Console.WriteLine();

                //Tickets not completed or updated in last 7 days
                List<Ticket> tickets_recently_changed = atAPI.Query(typeof(Ticket), new QueryFilter
                {
                    new QueryField("AccountID", QueryFieldOperation.Equals, 0),
                    new QueryCondition(QueryConditionOperation.AND) {
                        new QueryField("Status", QueryFieldOperation.NotEqual, ticket_statuses.First(s => s.Label.ToLower().Contains("completed"))),
                        new QueryCondition(QueryConditionOperation.OR) {
                            new QueryField("LastActivityDate", QueryFieldOperation.GreaterThanorEquals, DateTime.Today.AddDays(-7))
                        }
                    }
                }).OfType<Ticket>().ToList();
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tTickets Found: {tickets_recently_changed.Count}");
                Console.WriteLine();

                #endregion //Tickets
                

                #region Contacts

                //All Contacts for Specific Acocunt
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting All Contacts for Specific Acocunt...");
                List<Contact> contacts = atAPI.Query(typeof(Contact), new QueryFilter
                {
                    new QueryField("AccountId", QueryFieldOperation.Equals, @ACCOUNTID),
                    new QueryField("Active", QueryFieldOperation.Equals, 1)
                }).OfType<Contact>().ToList();
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tContacts Found: {contacts.Count}");
                Console.WriteLine();

                //All Contacts by Phone Number
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Tickets Updated Today...");
                List<Contact> contacts_found = atAPI.Query(typeof(Contact), new QueryFilter
                {
                    new QueryField("Active", QueryFieldOperation.Equals, 1),
                    new QueryCondition(QueryConditionOperation.AND) {
                        new QueryField("Phone", QueryFieldOperation.Equals, @PHONENUMBER),
                        new QueryCondition(QueryConditionOperation.OR) {
                            new QueryField("AlternatePhone", QueryFieldOperation.Equals, @PHONENUMBER),
                        },
                        new QueryCondition(QueryConditionOperation.OR) {
                            new QueryField("MobilePhone", QueryFieldOperation.Equals, @PHONENUMBER)
                        }
                    }
                }).OfType<Contact>().ToList();
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tContacts Found: {contacts_found.Count}");
                Console.WriteLine();

                #endregion //Contacts

                
                /*

                //Entity Information
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Entity Information...");
                List<EntityInformation> eInformation = atAPI.GetEntityInfo();
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tEntities: {eInformation.Count}");
                foreach (EntityInformation eInfo in eInformation)
                {
                    Console.WriteLine($"\t\t - {eInfo.name} = HasUDF: {eInfo.hasUserDefinedFields}, CanQuery: {eInfo.canQuery}, CanCreate: {eInfo.canCreate}, CanUpdate: {eInfo.canUpdate}, CanDelete: {eInfo.canDelete}");
                }
                Console.WriteLine();

                //UDF Information
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Entity Information...");
                List<FieldInformation> udfInformation = atAPI.GetUDFInfo(typeof(Ticket));
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tEntities: {udfInformation.Count}");
                foreach (FieldInformation udfInfo in udfInformation)
                {
                    Console.WriteLine($"\t\t - {udfInfo.Name} = Type: {udfInfo.Type}");
                }
                Console.WriteLine();

                */

                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tDone.");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\t\tError: {e.Message}\r\n");
            }
            finally
            {
                Console.WriteLine("Press Enter");
                Console.ReadLine();
            }

        } //end Main

    } //end Program
}
