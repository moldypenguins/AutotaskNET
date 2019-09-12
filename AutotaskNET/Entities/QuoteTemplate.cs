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

        public static implicit operator net.autotask.webservices.QuoteTemplate(QuoteTemplate quotetemplate)
        {
            return new net.autotask.webservices.QuoteTemplate()
            {
                id = quotetemplate.id,

            };

        } //end implicit operator net.autotask.webservices.QuoteTemplate(QuoteTemplate quotetemplate)

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

        public bool? Active; //ReadOnly
        public bool? CalculateTaxSeparately; //ReadOnly
        public DateTime? CreateDate; //ReadOnly
        public int? CreatedBy; //ReadOnly [Resource]
        public int? DateFormat; //ReadOnly PickList
        public string Description; //ReadOnly Length:200
        public int? DisplayCurrencySymbol; //ReadOnly PickList
        public bool? DisplayTaxCategorySuperscripts; //ReadOnly
        public int? LastActivityBy; //ReadOnly [Resource]
        public DateTime? LastActivityDate; //ReadOnly
        public string Name; //ReadOnly Required Length:50
        public int? NumberFormat; //ReadOnly PickList
        public int? PageLayout; //ReadOnly PickList
        public int? PageNumberFormat; //ReadOnly PickList
        public bool? ShowEachTaxInGroup; //ReadOnly
        public bool? ShowGridHeader; //ReadOnly
        public bool? ShowTaxCategory; //ReadOnly
        public bool? ShowVerticalGridLines; //ReadOnly
        public string CurrencyPositiveFormat; //ReadOnly Required Length:10
        public string CurrencyNegativeFormat; //ReadOnly Required Length:10

    } //end QuoteTemplate

}
