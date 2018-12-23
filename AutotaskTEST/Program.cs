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
        //private const string @USERNAME = "api.user@domain.com";
        //private const string @PASSWORD = "P@ssw0rd";
        private const string @USERNAME = "services@risolv.ca";
        private const string @PASSWORD = "L9prFxVlPb51m28TPiW5";

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



                //UDF Information
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Entity Information...");
                List<FieldInformation> udfInformation = atAPI.GetUDFInfo(typeof(Account));
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tEntities: {udfInformation.Count}");
                foreach (FieldInformation udfInfo in udfInformation)
                {
                    Console.WriteLine($"\t\t - {udfInfo.Name} = Type: {udfInfo.Type}");
                }
                Console.WriteLine();






                //Account
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting All Accounts...");
                List<Account> accounts = atAPI.Query(typeof(Account), new QueryFilter() {
                    new ConditionGroup(ConditionGroupOperation.OR) {
                        new Condition("id", ConditionOperation.Equals, 174),
                        new Condition("id", ConditionOperation.Equals, 175)
                    }
                }).OfType<Account>().ToList();
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tAll Accounts: {accounts.Count}");
                Console.WriteLine();



                //Account Locations
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Account Locations...");
                List<AccountLocation> account_locations = atAPI.Query(typeof(AccountLocation)).OfType<AccountLocation>().ToList();
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tAccount Locations: {account_locations.Count}");
                Console.WriteLine();


                

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
                    new Condition("AccountType", "Equals", account_types.Find(type => type.Label == "Customer").Value)
                }).OfType<Account>().ToList();
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tCustomer Accounts: {customer_accounts.Count}");
                Console.WriteLine();

                
                //Tickets Updated Today
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Tickets Updated Today...");
                List<Ticket> tickets_updated_today = atAPI.Query(typeof(Ticket), new List<QueryFilter> {
                    new QueryFilter() { FieldName = "LastActivityDate", Operation = "greaterthan", Value = DateTime.Today }
                }).OfType<Ticket>().ToList();
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tTickets Updated Today: {tickets_updated_today.Count}");
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
