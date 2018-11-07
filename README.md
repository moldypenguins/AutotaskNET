![Autotask PSA](https://www.risolv.ca/images/AutotaskPSA.png)

## AutotaskNET v0.1.0
*Autotask Web Services API Interface*

![GitHub License](https://img.shields.io/github/license/risolv/AutotaskNET.svg?style=flat)
![GitHub Downloads](https://img.shields.io/github/downloads/risolv/AutotaskNET/latest/total.svg?style=flat)
![GitHub Issues](https://img.shields.io/github/issues-raw/risolv/AutotaskNET.svg?style=flat)
![GitHub Pull Requests](https://img.shields.io/github/issues-pr-raw/risolv/AutotaskNET.svg?style=flat)

![GitHub Release](https://img.shields.io/github/release/risolv/AutotaskNET.svg?logo=GitHub&style=flat)
![Travis Build Status](https://img.shields.io/travis/com/risolv/AutotaskNET.svg?logo=Travis&style=flat)
![GitHub Last Commit](https://img.shields.io/github/last-commit/risolv/AutotaskNET.svg?logo=GitHub&style=flat)

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.6.1-blue.svg)
![Autotask Web Services](https://img.shields.io/badge/Autotask%20Web%20Services-1.5.14-red.svg)


### Examples
##### Get Client Accounts
```csharp
List<Account> client_accounts = atAPI.Query(typeof(Account), new List<EntityFilter> {
    new EntityFilter() { FieldName = "AccountType", Operation = "Equals", Value = 1 }
}).OfType<Account>().ToList();
```
