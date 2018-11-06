![Autotask PSA](https://vip.soonr.com/convertedfile/bt4vrkm-k6a-igq-i-cwa37bu44-qdwa7nchespsurwk5khg5pf7rn53u4wl)

## AutotaskNET v0.1.0
*Autotask Web Services API Interface*

![GitHub License](https://img.shields.io/github/license/risolv/autotasknet.svg?style=flat)
![GitHub Downloads](https://img.shields.io/github/downloads/risolv/autotasknet/latest/total.svg?style=flat)


![GitHub Release](https://img.shields.io/github/release/risolv/autotasknet.svg?logo=GitHub&style=flat)
![Travis Build Status](https://img.shields.io/travis/risolv/AutotaskNET.svg?logo=Travis&style=flat)
![GitHub Last Commit](https://img.shields.io/github/last-commit/risolv/autotasknet.svg?logo=GitHub&style=flat)


![GitHub Issues](https://img.shields.io/github/issues-raw/risolv/autotasknet.svg?style=flat)
![GitHub Pull Requests](https://img.shields.io/github/issues-pr-raw/risolv/autotasknet.svg?style=flat)


.NET Framework 4.6.1

ATWS API Version 1.5.14




### Examples
##### Get Client Accounts
```csharp
List<Account> client_accounts = atAPI.Query(typeof(Account), new List<EntityFilter> {
    new EntityFilter() { FieldName = "AccountType", Operation = "Equals", Value = 1 }
}).OfType<Account>().ToList();
```


