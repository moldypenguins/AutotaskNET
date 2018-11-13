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
                List<Account> customer_accounts = atAPI.Query(typeof(Account), new List<QueryFilter> {
                    new QueryFilter() { FieldName = "AccountType", Operation = "Equals", Value = account_types.Find(type => type.Label == "Customer").Value }
                }).OfType<Account>().ToList();
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tClient Accounts: {customer_accounts.Count}");
                Console.WriteLine();

                //Tickets Updated Today
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Tickets Updated Today...");
                List<Ticket> tickets_updated_today = atAPI.Query(typeof(Ticket), new List<QueryFilter> {
                    new QueryFilter() { FieldName = "LastActivityDate", Operation = "greaterthan", Value = DateTime.Today }
                }).OfType<Ticket>().ToList();
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tTickets Updated Today: {tickets_updated_today.Count}");
                Console.WriteLine();

                
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
