using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Quote : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

        public int OpportunityID { get; set; } //ReadOnly Required [Opportunity]
        public string Name { get; set; } //Required Length:100
        public bool? eQuoteActive { get; set; }
        public DateTime EffectiveDate { get; set; } //Required
        public DateTime ExpirationDate { get; set; } //Required
        public DateTime? CreateDate { get; set; } //ReadOnly
        public int? CreatorResourceID { get; set; } //ReadOnly [Resource]
        public int? ContactID { get; set; } //[Contact]
        public int? TaxGroup { get; set; } //PickList
        public int? ProposalProjectID { get; set; } //[Project]
        public int BillToLocationID { get; set; } //Required [QuoteLocation]
        public int ShipToLocationID { get; set; } //Required [QuoteLocation]
        public int SoldToLocationID { get; set; } //Required [QuoteLocation]
        public int? ShippingType { get; set; } //PickList
        public int? PaymentType { get; set; } //PickList
        public int? PaymentTerm { get; set; } //PickList
        public string ExternalQuoteNumber { get; set; } //Length:50
        public string PurchaseOrderNumber { get; set; } //Length:50
        public string Comment { get; set; } //Length:1000
        public string Description { get; set; } //Length:2000
        public int? AccountID { get; set; } //[Account]
        public bool? CalculateTaxSeparately { get; set; }
        public bool? GroupByProductCategory { get; set; }
        public bool? ShowEachTaxInGroup { get; set; }
        public bool? ShowTaxCategory { get; set; }
        public bool? PrimaryQuote { get; set; }
        public DateTime? LastActivityDate { get; set; } //ReadOnly
        public int? LastModifiedBy { get; set; } //ReadOnly [Resource]
        public int? QuoteTemplateID { get; set; } //[QuoteTemplate]
        public int? GroupByID { get; set; } //PickList
        public int? QuoteNumber { get; set; } //ReadOnly

    } //end Quote

}
