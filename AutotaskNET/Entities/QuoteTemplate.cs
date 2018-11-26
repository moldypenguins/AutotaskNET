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
            this.Active = entity.Active == null ? default(bool?) : bool.Parse(entity.Active.ToString());
            this.CalculateTaxSeparately = entity.CalculateTaxSeparately == null ? default(bool?) : bool.Parse(entity.CalculateTaxSeparately.ToString());
            this.CreateDate = entity.CreateDate == null ? default(DateTime?) : DateTime.Parse(entity.CreateDate.ToString());
            this.CreatedBy = entity.CreatedBy == null ? default(int?) : int.Parse(entity.CreatedBy.ToString());
            this.CurrencyNegativeFormat = entity.CurrencyNegativeFormat == null ? default(string) : entity.CurrencyNegativeFormat.ToString());
            this.CurrencyPositiveFormat = entity.CurrencyPositiveFormat == null ? default(string) : entity.CurrencyPositiveFormat.ToString());
            this.DateFormat = entity.DateFormat == null ? default(int?) : int.Parse(entity.DateFormat.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString());
            this.DisplayCurrencySymbol = entity.DisplayCurrencySymbol == null ? default(int?) : int.Parse(entity.DisplayCurrencySymbol.ToString());
            this.DisplayTaxCategorySuperscripts = entity.DisplayTaxCategorySuperscripts == null ? default(bool?) : bool.Parse(entity.DisplayTaxCategorySuperscripts.ToString());
            this.LastActivityBy = entity.LastActivityBy == null ? default(int?) : int.Parse(entity.LastActivityBy.ToString());
            this.LastActivityDate = entity.LastActivityDate == null ? default(DateTime?) : DateTime.Parse(entity.LastActivityDate.ToString());
            this.NumberFormat = entity.NumberFormat == null ? default(int?) : int.Parse(entity.NumberFormat.ToString());
            this.PageLayout = entity.PageLayout == null ? default(int?) : int.Parse(entity.PageLayout.ToString());
            this.PageNumberFormat = entity.PageNumberFormat == null ? default(int?) : int.Parse(entity.PageNumberFormat.ToString());
            this.ShowEachTaxInGroup = entity.ShowEachTaxInGroup == null ? default(bool?) : bool.Parse(entity.ShowEachTaxInGroup.ToString());
            this.ShowGridHeader = entity.ShowGridHeader == null ? default(bool?) : bool.Parse(entity.ShowGridHeader.ToString());
            this.ShowTaxCategory = entity.ShowTaxCategory == null ? default(bool?) : bool.Parse(entity.ShowTaxCategory.ToString());
            this.ShowVerticalGridLines = entity.ShowVerticalGridLines == null ? default(bool?) : bool.Parse(entity.ShowVerticalGridLines.ToString());
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
