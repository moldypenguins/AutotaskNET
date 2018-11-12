using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class QuoteTemplate : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public QuoteTemplate() : base() { } //end QuoteTemplate()
        public QuoteTemplate(net.autotask.webservices.QuoteTemplate entity) : base(entity)
        {

        } //end QuoteTemplate(net.autotask.webservices.QuoteTemplate entity)

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

        public bool? Active { get; set; } //ReadOnly
        public bool? CalculateTaxSeparately { get; set; } //ReadOnly
        public DateTime? CreateDate { get; set; } //ReadOnly
        public int? CreatedBy { get; set; } //ReadOnly [Resource]
        public int? DateFormat { get; set; } //ReadOnly PickList
        public string Description { get; set; } //ReadOnly Length:200
        public int? DisplayCurrencySymbol { get; set; } //ReadOnly PickList
        public bool? DisplayTaxCategorySuperscripts { get; set; } //ReadOnly
        public int? LastActivityBy { get; set; } //ReadOnly [Resource]
        public DateTime? LastActivityDate { get; set; } //ReadOnly
        public string Name { get; set; } //ReadOnly Required Length:50
        public int? NumberFormat { get; set; } //ReadOnly PickList
        public int? PageLayout { get; set; } //ReadOnly PickList
        public int? PageNumberFormat { get; set; } //ReadOnly PickList
        public bool? ShowEachTaxInGroup { get; set; } //ReadOnly
        public bool? ShowGridHeader { get; set; } //ReadOnly
        public bool? ShowTaxCategory { get; set; } //ReadOnly
        public bool? ShowVerticalGridLines { get; set; } //ReadOnly
        public string CurrencyPositiveFormat { get; set; } //ReadOnly Required Length:10
        public string CurrencyNegativeFormat { get; set; } //ReadOnly Required Length:10

    } //end QuoteTemplate

}
