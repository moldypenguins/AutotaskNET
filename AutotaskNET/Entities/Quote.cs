using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Quote : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public Quote() : base() { } //end Quote()
        public Quote(net.autotask.webservices.Quote entity) : base(entity)
        {

        } //end Quote(net.autotask.webservices.Quote entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.Quote()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

        #endregion //Fields

        public int OpportunityID; //ReadOnly Required [Opportunity]
        public string Name; //Required Length:100
        public bool? eQuoteActive;
        public DateTime EffectiveDate; //Required
        public DateTime ExpirationDate; //Required
        public DateTime? CreateDate; //ReadOnly
        public int? CreatorResourceID; //ReadOnly [Resource]
        public int? ContactID; //[Contact]
        public int? TaxGroup; //PickList
        public int? ProposalProjectID; //[Project]
        public int BillToLocationID; //Required [QuoteLocation]
        public int ShipToLocationID; //Required [QuoteLocation]
        public int SoldToLocationID; //Required [QuoteLocation]
        public int? ShippingType; //PickList
        public int? PaymentType; //PickList
        public int? PaymentTerm; //PickList
        public string ExternalQuoteNumber; //Length:50
        public string PurchaseOrderNumber; //Length:50
        public string Comment; //Length:1000
        public string Description; //Length:2000
        public int? AccountID; //[Account]
        public bool? CalculateTaxSeparately;
        public bool? GroupByProductCategory;
        public bool? ShowEachTaxInGroup;
        public bool? ShowTaxCategory;
        public bool? PrimaryQuote;
        public DateTime? LastActivityDate; //ReadOnly
        public int? LastModifiedBy; //ReadOnly [Resource]
        public int? QuoteTemplateID; //[QuoteTemplate]
        public int? GroupByID; //PickList
        public int? QuoteNumber; //ReadOnly

    } //end Quote

}
