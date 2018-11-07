![Autotask PSA](https://www.risolv.ca/images/AutotaskPSA.png)

## AutotaskNET
*Autotask Web Services API Interface*

![GitHub License](https://img.shields.io/github/license/risolv/AutotaskNET.svg?style=flat)
![GitHub Downloads](https://img.shields.io/github/downloads/risolv/AutotaskNET/latest/total.svg?style=flat)
![GitHub Issues](https://img.shields.io/github/issues-raw/risolv/AutotaskNET.svg?style=flat)
![GitHub Pull Requests](https://img.shields.io/github/issues-pr-raw/risolv/AutotaskNET.svg?style=flat)

![GitHub Release](https://img.shields.io/github/release/risolv/AutotaskNET.svg?logo=GitHub&style=flat)
![GitHub Last Commit](https://img.shields.io/github/last-commit/risolv/AutotaskNET.svg?logo=GitHub&style=flat)
![Travis Build Status](https://img.shields.io/travis/com/risolv/AutotaskNET.svg?logo=Travis&style=flat)

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.6.1-blue.svg)
![Autotask Web Services](https://img.shields.io/badge/Autotask%20Web%20Services-1.5.14-red.svg)


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

##### Get Client Accounts
```csharp
List<Account> client_accounts = atAPI.Query(typeof(Account), new List<QueryFilter> {
    new QueryFilter() { FieldName = "AccountType", Operation = "Equals", Value = 1 }
}).OfType<Account>().ToList();
```

##### Get Recently Updated Tickets
```csharp
List<Ticket> recently_updated_tickets = atAPI.Query(typeof(Ticket), new List<QueryFilter> {
    new QueryFilter() { FieldName = "LastActivityDate", Operation = "greaterthan", Value = DateTime.Today } //search from the start of today
}).OfType<Ticket>().ToList();
```



