using System;

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
            this.AccountName = entity.AccountName.ToString();
            this.AccountNumber = entity.AccountNumber.ToString();
            this.AccountType = short.Parse(entity.AccountType.ToString());
            this.Active = entity.Active is null ? default(bool?) : bool.Parse(entity.Active.ToString());
            this.AdditionalAddressInformation = entity.AdditionalAddressInformation is null ? default(string) : entity.AdditionalAddressInformation.ToString();
            this.Address1 = entity.Address1 is null ? default(string) : entity.Address1.ToString();
            this.Address2 = entity.Address2 is null ? default(string) : entity.Address2.ToString();
            this.AlternatePhone1 = entity.AlternatePhone1 is null ? default(string) : entity.AlternatePhone1.ToString();
            this.AlternatePhone2 = entity.AlternatePhone2 is null ? default(string) : entity.AlternatePhone2.ToString();
            this.AssetValue = entity.AssetValue is null ? default(double?) : double.Parse(entity.AssetValue.ToString());
            this.BillToAccountPhysicalLocationID = entity.BillToAccountPhysicalLocationID is null ? default(int?) : int.Parse(entity.BillToAccountPhysicalLocationID.ToString());
            this.BillToAdditionalAddressInformation = entity.BillToAdditionalAddressInformation is null ? default(string) : entity.BillToAdditionalAddressInformation.ToString();
            this.BillToAddress1 = entity.BillToAddress1 is null ? default(string) : entity.BillToAddress1.ToString();
            this.BillToAddress2 = entity.BillToAddress2 is null ? default(string) : entity.BillToAddress2.ToString();
            this.BillToAddressToUse = entity.BillToAddressToUse is null ? default(int?) : int.Parse(entity.BillToAddressToUse.ToString());
            this.BillToAttention = entity.BillToAttention is null ? default(string) : entity.BillToAttention.ToString();
            this.BillToCity = entity.BillToCity is null ? default(string) : entity.BillToCity.ToString();
            this.BillToCountryID = entity.BillToCountryID is null ? default(int?) : int.Parse(entity.BillToCountryID.ToString());
            this.BillToState = entity.BillToState is null ? default(string) : entity.BillToState.ToString();
            this.BillToZipCode = entity.BillToZipCode is null ? default(string) : entity.BillToZipCode.ToString();
            this.City = entity.City is null ? default(string) : entity.City.ToString();
            this.ClientPortalActive = entity.ClientPortalActive is null ? default(bool?) : bool.Parse(entity.ClientPortalActive.ToString());
            this.CompetitorID = entity.CompetitorID is null ? default(int?) : int.Parse(entity.CompetitorID.ToString());
            this.Country = entity.Country is null ? default(string) : entity.Country.ToString();
            this.CountryID = entity.CountryID is null ? default(int?) : int.Parse(entity.CountryID.ToString());
            this.CreateDate = entity.CreateDate is null ? default(DateTime?) : DateTime.Parse(entity.CreateDate.ToString());
            this.CurrencyID = entity.CurrencyID is null ? default(int?) : int.Parse(entity.CurrencyID.ToString());
            this.Fax = entity.Fax is null ? default(string) : entity.Fax.ToString();
            this.InvoiceEmailMessageID = entity.InvoiceEmailMessageID is null ? default(int?) : int.Parse(entity.InvoiceEmailMessageID.ToString());
            this.InvoiceMethod = entity.InvoiceMethod is null ? default(int?) : int.Parse(entity.InvoiceMethod.ToString());
            this.InvoiceNonContractItemsToParentAccount = entity.InvoiceNonContractItemsToParentAccount is null ? default(bool?) : bool.Parse(entity.InvoiceNonContractItemsToParentAccount.ToString());
            this.InvoiceTemplateID = entity.InvoiceTemplateID is null ? default(int?) : int.Parse(entity.InvoiceTemplateID.ToString());
            this.KeyAccountIcon = entity.KeyAccountIcon is null ? default(int?) : int.Parse(entity.KeyAccountIcon.ToString());
            this.LastActivityDate = entity.LastActivityDate is null ? default(DateTime?) : DateTime.Parse(entity.LastActivityDate.ToString());
            this.MarketSegmentID = entity.MarketSegmentID is null ? default(int?) : int.Parse(entity.MarketSegmentID.ToString());
            this.OwnerResourceID = int.Parse(entity.OwnerResourceID.ToString());
            this.ParentAccountID = entity.ParentAccountID is null ? default(int?) : int.Parse(entity.ParentAccountID.ToString());
            this.Phone = entity.Phone is null ? default(string) : entity.Phone.ToString();
            this.PostalCode = entity.PostalCode is null ? default(string) : entity.PostalCode.ToString();
            this.QuoteEmailMessageID = entity.QuoteEmailMessageID is null ? default(int?) : int.Parse(entity.QuoteEmailMessageID.ToString());
            this.QuoteTemplateID = entity.QuoteTemplateID is null ? default(int?) : int.Parse(entity.QuoteTemplateID.ToString());
            this.SICCode = entity.SICCode is null ? default(string) : entity.SICCode.ToString();
            this.State = entity.State is null ? default(string) : entity.State.ToString();
            this.StockMarket = entity.StockMarket is null ? default(string) : entity.StockMarket.ToString();
            this.StockSymbol = entity.StockSymbol is null ? default(string) : entity.StockSymbol.ToString();
            //this.SurveyAccountRating = double.Parse(entity.SurveyAccountRating.ToString());
            this.TaskFireActive = entity.TaskFireActive is null ? default(bool?) : bool.Parse(entity.TaskFireActive.ToString());
            this.TaxExempt = entity.TaxExempt is null ? default(bool?) : bool.Parse(entity.TaxExempt.ToString());
            this.TaxID = entity.TaxID is null ? default(string) : entity.TaxID.ToString();
            this.TaxRegionID = entity.TaxRegionID is null ? default(int?) : int.Parse(entity.TaxRegionID.ToString());
            this.TerritoryID = entity.TerritoryID is null ? default(int?) : int.Parse(entity.TerritoryID.ToString());
            this.WebAddress = entity.WebAddress is null ? default(string) : entity.WebAddress.ToString();

        } //end Account(net.autotask.webservices.Account entity)

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
