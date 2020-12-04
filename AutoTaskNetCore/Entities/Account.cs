using System;
using System.Linq;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// In Autotask, an account represents a company or organization that you do business with.<br />
    /// Autotask users manage Accounts through the CRM module (CRM &gt; Accounts), or the Directory module (Directory &gt; Accounts).
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Account : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => true;

        #endregion //Properties

        #region Constructors

        public Account() : base() { } //end Account()
        public Account(net.autotask.webservices.Account entity) : base(entity)
        {
            this.AccountName = entity.AccountName == null ? default(string) : entity.AccountName.ToString();
            this.AccountNumber = entity.AccountNumber == null ? default(string) : entity.AccountNumber.ToString();
            this.AccountType = short.Parse(entity.AccountType.ToString());
            this.Active = entity.Active == null ? default(bool?) : bool.Parse(entity.Active.ToString());
            this.AdditionalAddressInformation = entity.AdditionalAddressInformation == null ? default(string) : entity.AdditionalAddressInformation.ToString();
            this.Address1 = entity.Address1 == null ? default(string) : entity.Address1.ToString();
            this.Address2 = entity.Address2 == null ? default(string) : entity.Address2.ToString();
            this.AlternatePhone1 = entity.AlternatePhone1 == null ? default(string) : entity.AlternatePhone1.ToString();
            this.AlternatePhone2 = entity.AlternatePhone2 == null ? default(string) : entity.AlternatePhone2.ToString();
            this.AssetValue = entity.AssetValue == null ? default(double?) : double.Parse(entity.AssetValue.ToString());
            this.BillToAccountPhysicalLocationID = entity.BillToAccountPhysicalLocationID == null ? default(int?) : int.Parse(entity.BillToAccountPhysicalLocationID.ToString());
            this.BillToAdditionalAddressInformation = entity.BillToAdditionalAddressInformation == null ? default(string) : entity.BillToAdditionalAddressInformation.ToString();
            this.BillToAddress1 = entity.BillToAddress1 == null ? default(string) : entity.BillToAddress1.ToString();
            this.BillToAddress2 = entity.BillToAddress2 == null ? default(string) : entity.BillToAddress2.ToString();
            this.BillToAddressToUse = entity.BillToAddressToUse == null ? default(int?) : int.Parse(entity.BillToAddressToUse.ToString());
            this.BillToAttention = entity.BillToAttention == null ? default(string) : entity.BillToAttention.ToString();
            this.BillToCity = entity.BillToCity == null ? default(string) : entity.BillToCity.ToString();
            this.BillToCountryID = entity.BillToCountryID == null ? default(int?) : int.Parse(entity.BillToCountryID.ToString());
            this.BillToState = entity.BillToState == null ? default(string) : entity.BillToState.ToString();
            this.BillToZipCode = entity.BillToZipCode == null ? default(string) : entity.BillToZipCode.ToString();
            this.City = entity.City == null ? default(string) : entity.City.ToString();
            this.ClientPortalActive = entity.ClientPortalActive == null ? default(bool?) : bool.Parse(entity.ClientPortalActive.ToString());
            this.CompetitorID = entity.CompetitorID == null ? default(int?) : int.Parse(entity.CompetitorID.ToString());
            this.Country = entity.Country == null ? default(string) : entity.Country.ToString();
            this.CountryID = entity.CountryID == null ? default(int?) : int.Parse(entity.CountryID.ToString());
            this.CreateDate = entity.CreateDate == null ? default(DateTime?) : DateTime.Parse(entity.CreateDate.ToString());
            this.CurrencyID = entity.CurrencyID == null ? default(int?) : int.Parse(entity.CurrencyID.ToString());
            this.Fax = entity.Fax == null ? default(string) : entity.Fax.ToString();
            this.InvoiceEmailMessageID = entity.InvoiceEmailMessageID == null ? default(int?) : int.Parse(entity.InvoiceEmailMessageID.ToString());
            this.InvoiceMethod = entity.InvoiceMethod == null ? default(int?) : int.Parse(entity.InvoiceMethod.ToString());
            this.InvoiceNonContractItemsToParentAccount = entity.InvoiceNonContractItemsToParentAccount == null ? default(bool?) : bool.Parse(entity.InvoiceNonContractItemsToParentAccount.ToString());
            this.InvoiceTemplateID = entity.InvoiceTemplateID == null ? default(int?) : int.Parse(entity.InvoiceTemplateID.ToString());
            this.KeyAccountIcon = entity.KeyAccountIcon == null ? default(int?) : int.Parse(entity.KeyAccountIcon.ToString());
            this.LastActivityDate = entity.LastActivityDate == null ? default(DateTime?) : DateTime.Parse(entity.LastActivityDate.ToString());
            this.MarketSegmentID = entity.MarketSegmentID == null ? default(int?) : int.Parse(entity.MarketSegmentID.ToString());
            this.OwnerResourceID = int.Parse(entity.OwnerResourceID.ToString());
            this.ParentAccountID = entity.ParentAccountID == null ? default(int?) : int.Parse(entity.ParentAccountID.ToString());
            this.Phone = entity.Phone == null ? default(string) : entity.Phone.ToString();
            this.PostalCode = entity.PostalCode == null ? default(string) : entity.PostalCode.ToString();
            this.QuoteEmailMessageID = entity.QuoteEmailMessageID == null ? default(int?) : int.Parse(entity.QuoteEmailMessageID.ToString());
            this.QuoteTemplateID = entity.QuoteTemplateID == null ? default(int?) : int.Parse(entity.QuoteTemplateID.ToString());
            this.SICCode = entity.SICCode == null ? default(string) : entity.SICCode.ToString();
            this.State = entity.State == null ? default(string) : entity.State.ToString();
            this.StockMarket = entity.StockMarket == null ? default(string) : entity.StockMarket.ToString();
            this.StockSymbol = entity.StockSymbol == null ? default(string) : entity.StockSymbol.ToString();
            //this.SurveyAccountRating = double.Parse(entity.SurveyAccountRating.ToString());
            this.TaskFireActive = entity.TaskFireActive == null ? default(bool?) : bool.Parse(entity.TaskFireActive.ToString());
            this.TaxExempt = entity.TaxExempt == null ? default(bool?) : bool.Parse(entity.TaxExempt.ToString());
            this.TaxID = entity.TaxID == null ? default(string) : entity.TaxID.ToString();
            this.TaxRegionID = entity.TaxRegionID == null ? default(int?) : int.Parse(entity.TaxRegionID.ToString());
            this.TerritoryID = entity.TerritoryID == null ? default(int?) : int.Parse(entity.TerritoryID.ToString());
            this.WebAddress = entity.WebAddress == null ? default(string) : entity.WebAddress.ToString();
            this.UserDefinedFields = entity.UserDefinedFields?.Select(udf => new UserDefinedField { Name = udf.Name, Value = udf.Value }).ToList();


        } //end Account(net.autotask.webservices.Account entity)

        public static implicit operator net.autotask.webservices.Account(Account account)
        {
            return new net.autotask.webservices.Account()
            {
                id = account.id,
                AccountName = account.AccountName,
                AccountNumber = account.AccountNumber,
                AccountType = account.AccountType,
                Active = account.Active,
                AdditionalAddressInformation = account.AdditionalAddressInformation,
                Address1 = account.Address1,
                Address2 = account.Address2,
                AlternatePhone1 = account.AlternatePhone1,
                AlternatePhone2 = account.AlternatePhone2,
                AssetValue = account.AssetValue,
                BillToAccountPhysicalLocationID = account.BillToAccountPhysicalLocationID,
                BillToAdditionalAddressInformation = account.BillToAdditionalAddressInformation,
                BillToAddress1 = account.BillToAddress1,
                BillToAddress2 = account.BillToAddress2,
                BillToAddressToUse = account.BillToAddressToUse,
                BillToAttention = account.BillToAttention,
                BillToCity = account.BillToCity,
                BillToCountryID = account.BillToCountryID,
                BillToState = account.BillToState,
                BillToZipCode = account.BillToZipCode,
                City = account.City,
                ClientPortalActive = account.ClientPortalActive,
                CompetitorID = account.CompetitorID,
                Country = account.Country,
                CountryID = account.CountryID,
                CreateDate = account.CreateDate,
                CurrencyID = account.CurrencyID,
                Fax = account.Fax,
                InvoiceEmailMessageID = account.InvoiceEmailMessageID,
                InvoiceMethod = account.InvoiceMethod,
                InvoiceNonContractItemsToParentAccount = account.InvoiceNonContractItemsToParentAccount,
                InvoiceTemplateID = account.InvoiceTemplateID,
                KeyAccountIcon = account.KeyAccountIcon,
                LastActivityDate = account.LastActivityDate,
                MarketSegmentID = account.MarketSegmentID,
                OwnerResourceID = account.OwnerResourceID,
                ParentAccountID = account.ParentAccountID,
                Phone = account.Phone,
                PostalCode = account.PostalCode,
                QuoteEmailMessageID = account.QuoteEmailMessageID,
                QuoteTemplateID = account.QuoteTemplateID,
                SICCode = account.SICCode,
                State = account.State,
                StockMarket = account.StockMarket,
                StockSymbol = account.StockSymbol,
                SurveyAccountRating = account.SurveyAccountRating,
                TaskFireActive = account.TaskFireActive,
                TaxExempt = account.TaxExempt,
                TaxID = account.TaxID,
                TaxRegionID = account.TaxRegionID,
                TerritoryID = account.TerritoryID,
                WebAddress = account.WebAddress,
                UserDefinedFields = account.UserDefinedFields==null ? default : Array.ConvertAll(account.UserDefinedFields?.ToArray(), UserDefinedField.ToATWS)
            };

        } //end implicit operator net.autotask.webservices.Account(Account account)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public DateTime? CreateDate; //ReadOnly
        public DateTime? LastActivityDate; //ReadOnly
        public bool? TaskFireActive; //ReadOnly
        public bool? ClientPortalActive; //ReadOnly
        /// <summary>
        /// The bill to address to use<br/>
        /// <ol>
        ///     <li>Account Address</li>
        ///     <li>Account Billing</li>
        ///     <li>Parent Account</li>
        ///     <li>Parent Account Billing</li>
        /// </ol>
        /// </summary>
        public int? BillToAddressToUse; //ReadOnly PickList
        public string BillToAddress1; //ReadOnly Length:150
        public string BillToAddress2; //ReadOnly Length:150
        public string BillToCity; //ReadOnly Length:50
        public string BillToState; //ReadOnly Length:128
        public string BillToZipCode; //ReadOnly Length:50
        public int? BillToCountryID; //ReadOnly [Country]
        public string BillToAdditionalAddressInformation; //ReadOnly Length:100
        public double SurveyAccountRating; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public string AccountName; //Required Length:100
        public short AccountType; //Required PickList
        public int OwnerResourceID; //Required [Resource]
        public string Phone; //Required Length:25

        #endregion //Required Fields

        #region Optional Fields

        public string Address1; //Length:128
        public string Address2; //Length:128
        public string City; //Length:30
        public string State; //Length:40
        public string PostalCode; //Length:10
        public string Country; //Length:100
        public string AlternatePhone1; //Length:25
        public string AlternatePhone2; //Length:25
        public string Fax; //Length:25
        public string WebAddress; //Length:255
        public int? KeyAccountIcon; //PickList
        public int? TerritoryID; //PickList
        public int? MarketSegmentID; //PickList
        public int? CompetitorID; //PickList
        public int? ParentAccountID; //[Account]
        public string StockSymbol; //Length:10
        public string StockMarket; //Length:10
        public string SICCode; //Length:32
        public double? AssetValue;
        public string AccountNumber; //Length:50
        public bool? Active;
        public int? TaxRegionID; //[TaxRegion]
        public bool? TaxExempt;
        public string TaxID; //Length:50
        public string AdditionalAddressInformation; //Length:100
        public int? CountryID; //[Country]
        public string BillToAttention; //Length:50
        public int? InvoiceMethod; //PickList
        public bool? InvoiceNonContractItemsToParentAccount;
        public int? QuoteTemplateID; //[QuoteTemplate]
        public int? QuoteEmailMessageID;
        public int? InvoiceTemplateID; //[InvoiceTemplate]
        public int? InvoiceEmailMessageID;
        public int? CurrencyID; //[Currency]
        public int? BillToAccountPhysicalLocationID; //[AccountPhysicalLocation]

        #endregion //Optional Fields

        #endregion //Fields
        
    } //end Account

}
