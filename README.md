![Autotask PSA](https://www.risolv.ca/images/AutotaskPSA.png)

## AutotaskNET ![GitHub License](https://img.shields.io/github/license/risolv/AutotaskNET.svg?logo=GNU&logoColor=white&style=flat) ![GitHub Release](https://img.shields.io/github/release/risolv/AutotaskNET.svg?logo=GitHub&logoColor=white&style=flat) ![GitHub Downloads](https://img.shields.io/github/downloads/risolv/AutotaskNET/latest/total.svg?logo=GitHub&logoColor=white&style=flat)
*Autotask Web Services API .NET Interface*

![GitHub Last Commit](https://img.shields.io/github/last-commit/risolv/AutotaskNET.svg?logo=GitHub&logoColor=white&style=flat)
![GitHub Issues](https://img.shields.io/github/issues-raw/risolv/AutotaskNET.svg?logo=GitHub&logoColor=white&style=flat)
![GitHub Pull Requests](https://img.shields.io/github/issues-pr-raw/risolv/AutotaskNET.svg?logo=GitHub&logoColor=white&style=flat)
![Travis Build Status](https://img.shields.io/travis/com/risolv/AutotaskNET.svg?logo=Travis&logoColor=white&style=flat)

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.6.1-blue.svg?logo=windows&logoColor=white)
![Autotask Web Services](https://img.shields.io/badge/Autotask%20Web%20Services%20API-1.5.14-red.svg)


### Documentation
[Autotask Web Services API Version 1.5 User Guide](https://www.autotask.net/help/Content/LinkedDOCUMENTS/WSAPI/T_WebServicesAPIv1_5.pdf)


### Bugs/Features/Contributing
Please open an issue or pull request in GitHub.

IRC Freenode [#AutotaskNET](https://webchat.freenode.net/?channels=asternet)


### Examples
##### Connect
```csharp
using AutotaskNET;
using AutotaskNET.Entities;

class Program
{
    private const string @USERNAME = "api.user@domain.com";
    private const string @PASSWORD = "P@ssw0rd";
    static void Main(string[] args)
    {
        try
        {
            ATWSInterface atAPI = new ATWSInterface(@USERNAME, @PASSWORD);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
```

#### Get Account Types
```csharp
List<PicklistValue> account_types = atAPI.GetPicklistValues(typeof(Account), "AccountType");
```

##### Get Customer Accounts
```csharp
int account_types_customer = account_types.Find(type => type.Label == "Customer").Value;

List<Account> customer_accounts = atAPI.Query(typeof(Account), new List<QueryFilter> {
    new QueryFilter() { FieldName = "AccountType", Operation = "Equals", Value = account_types_customer }
}).OfType<Account>().ToList();
```

##### Get Tickets Updated Today
```csharp
int activity_since = DateTime.Today; //search from the start of today

List<Ticket> tickets_updated_today = atAPI.Query(typeof(Ticket), new List<QueryFilter> {
    new QueryFilter() { FieldName = "LastActivityDate", Operation = "greaterthan", Value = activity_since }
}).OfType<Ticket>().ToList();
```

##### Get Tickets Updated Today For Specific Customer
```csharp
int activity_since = DateTime.Today; //search from the start of today

List<Ticket> tickets_updated_today = atAPI.Query(typeof(Ticket), new List<QueryFilter> {
    new QueryFilter() { FieldName = "LastActivityDate", Operation = "greaterthan", Value = activity_since }
	new QueryFilter() { FieldName = "Account", Operation = "equals", Value = customer_accounts.Find(account => account.AccountName == "Customer Name").id }
}).OfType<Ticket>().ToList();


