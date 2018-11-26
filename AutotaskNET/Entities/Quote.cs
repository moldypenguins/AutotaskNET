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
            this.BillToLocationID = int.Parse(entity.BillToLocationID.ToString());
            this.EffectiveDate = DateTime.Parse(entity.EffectiveDate.ToString());
            this.ExpirationDate = DateTime.Parse(entity.ExpirationDate.ToString());
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
            this.OpportunityID = int.Parse(entity.OpportunityID.ToString());
            this.AccountID = entity.AccountID == null ? default(int?) : int.Parse(entity.AccountID.ToString());
            this.CalculateTaxSeparately = entity.CalculateTaxSeparately == null ? default(bool?) : bool.Parse(entity.CalculateTaxSeparately.ToString());
            this.Comment = entity.Comment == null ? default(string) : entity.Comment.ToString();
            this.ContactID = entity.ContactID == null ? default(int?) : int.Parse(entity.ContactID.ToString());
            this.CreateDate = entity.CreateDate == null ? default(DateTime?) : DateTime.Parse(entity.CreateDate.ToString());
            this.CreatorResourceID = entity.CreatorResourceID == null ? default(int?) : int.Parse(entity.CreatorResourceID.ToString());
            this.Description = entity.Description.ToString() == null ? default(string) : entity.Description.ToString();
            this.eQuoteActive = entity.eQuoteActive == null ? default(bool?) : bool.Parse(entity.eQuoteActive.ToString());
            this.ExternalQuoteNumber = entity.ExternalQuoteNumber == null ? default(string) : entity.ExternalQuoteNumber.ToString();
            this.GroupByID = entity.GroupByID == null ? default(int?) : int.Parse(entity.GroupByID.ToString());
            this.GroupByProductCategory = entity.GroupByProductCategory == null ? default(bool?) : bool.Parse(entity.GroupByProductCategory.ToString());
            this.LastActivityDate = entity.LastActivityDate == null ? default(DateTime?) : DateTime.Parse(entity.LastActivityDate.ToString());
            this.LastModifiedBy = entity.LastModifiedBy == null ? default(int?) : int.Parse(entity.LastModifiedBy.ToString());
            this.PaymentTerm = entity.PaymentTerm == null ? default(int?) : int.Parse(entity.PaymentTerm.ToString());
            this.PaymentType = entity.PaymentType == null ? default(int?) : int.Parse(entity.PaymentType.ToString());
            this.PrimaryQuote = entity.PrimaryQuote == null ? default(bool?) : bool.Parse(entity.PrimaryQuote.ToString());
            this.ProposalProjectID = entity.ProposalProjectID == null ? default(int?) : int.Parse(entity.ProposalProjectID.ToString());
            this.PurchaseOrderNumber = entity.PurchaseOrderNumber == null ? default(string) : entity.PurchaseOrderNumber.ToString();
            this.QuoteNumber = entity.QuoteNumber == null ? default(int?) : int.Parse(entity.QuoteNumber.ToString());
            this.QuoteTemplateID = entity.QuoteTemplateID == null ? default(int?) : int.Parse(entity.QuoteTemplateID.ToString());
            this.ShippingType = entity.ShippingType == null ? default(int?) : int.Parse(entity.ShippingType.ToString());
            this.ShipToLocationID = int.Parse(entity.ShipToLocationID.ToString());
            this.ShowEachTaxInGroup = entity.ShowEachTaxInGroup == null ? default(bool?) : bool.Parse(entity.ShowEachTaxInGroup.ToString());
            this.ShowTaxCategory = entity.ShowTaxCategory == null ? default(bool?) : bool.Parse(entity.ShowTaxCategory.ToString());
            this.SoldToLocationID = int.Parse(entity.SoldToLocationID.ToString());
            this.TaxGroup = entity.TaxGroup == null ? default(int?) : int.Parse(entity.TaxGroup.ToString());
        } //end Quote(net.autotask.webservices.Quote entity)

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
