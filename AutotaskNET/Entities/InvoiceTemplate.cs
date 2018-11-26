using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask Invoice Template that defines the content and appearance of an Autotask Invoice.<br />
    /// Invoices include Billing Items that have been approved and posted and are being billed to a customer or presented for information purposes only.<br />
    /// The template determines what account, billing item, tax and financial related details the Autotask user wants to include on the invoice, and how the output will be grouped and presented.<br />
    /// Invoice templates are added through the UI in the Admin module: Contracts(and Billing) > Invoices > Templates.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class InvoiceTemplate : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public InvoiceTemplate() : base() { } //end InvoiceTemplate()
        public InvoiceTemplate(net.autotask.webservices.InvoiceTemplate entity) : base(entity)
        {
            this.DateFormat = int.Parse(entity.DateFormat.ToString());
            this.DisplayFixedPriceContractLabor = bool.Parse(entity.DisplayFixedPriceContractLabor.ToString());
            this.DisplayRecurringServiceContractLabor = bool.Parse(entity.DisplayRecurringServiceContractLabor.ToString());
            this.DisplaySeparateLineItemForEachTax = bool.Parse(entity.DisplaySeparateLineItemForEachTax.ToString());
            this.DisplayTaxCategory = bool.Parse(entity.DisplayTaxCategory.ToString());
            this.DisplayTaxCategorySuperscripts = bool.Parse(entity.DisplayZeroAmountRecurringServicesAndBundles.ToString());
            this.DisplayZeroAmountRecurringServicesAndBundles = bool.Parse(entity.DisplayZeroAmountRecurringServicesAndBundles.ToString());
            this.GroupBy = int.Parse(entity.GroupBy.ToString());
            this.ItemizeItemsInEachGroup = int.Parse(entity.ItemizeItemsInEachGroup.ToString());
            this.ItemizeServicesAndBundles = bool.Parse(entity.ItemizeServicesAndBundles.ToString());
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
            this.NonBillableLaborLabel = entity.NonBillableLaborLabel == null ? default(string) : entity.NonBillableLaborLabel.ToString());
            this.NumberFormat = int.Parse(entity.NumberFormat.ToString());
            this.PageLayout = int.Parse(entity.PageLayout.ToString());
            this.PageNumberFormat = int.Parse(entity.PageLayout.ToString());
            this.PaymentTerms = int.Parse(entity.PaymentTerms.ToString());
            this.ShowGridHeader = bool.Parse(entity.ShowGridHeader.ToString());
            this.ShowVerticalGridLines = bool.Parse(entity.ShowVerticalGridLines.ToString());
            this.SortBy = int.Parse(entity.SortBy.ToString());
            this.TimeFormat = int.Parse(entity.TimeFormat.ToString());
            this.CoveredByBlockRetainerContractLabel = entity.CoveredByBlockRetainerContractLabel == null ? default(string) : entity.CoveredByBlockRetainerContractLabel.ToString();
            this.CoveredByRecurringServiceFixedPricePerTicketContractLabel = entity.CoveredByRecurringServiceFixedPricePerTicketContractLabel == null ? default(string) : entity.CoveredByRecurringServiceFixedPricePerTicketContractLabel.ToString();
            this.CurrencyNegativeFormat = entity.CurrencyNegativeFormat == null ? default(string) : entity.CurrencyNegativeFormat.ToString();
            this.CurrencyPositiveFormat = entity.CurrencyPositiveFormat == null ? default(string) : entity.CurrencyPositiveFormat.ToString();
            this.RateCostExpression = entity.RateCostExpression == null ? default(string) : entity.RateCostExpression.ToString();
        } //end InvoiceTemplate(net.autotask.webservices.InvoiceTemplate entity)

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

        public bool DisplayTaxCategory; //ReadOnly Required
        public bool DisplayTaxCategorySuperscripts; //ReadOnly Required
        public bool DisplaySeparateLineItemForEachTax; //ReadOnly Required
        public int GroupBy; //ReadOnly Required PickList
        public int ItemizeItemsInEachGroup; //ReadOnly Required PickList
        public int SortBy; //ReadOnly Required PickList
        public bool ItemizeServicesAndBundles; //ReadOnly Required
        public bool DisplayZeroAmountRecurringServicesAndBundles; //ReadOnly Required
        public bool DisplayRecurringServiceContractLabor; //ReadOnly Required
        public bool DisplayFixedPriceContractLabor; //ReadOnly Required
        public string RateCostExpression; //ReadOnly Length:50
        public string CoveredByRecurringServiceFixedPricePerTicketContractLabel; //ReadOnly Length:50
        public string CoveredByBlockRetainerContractLabel; //ReadOnly Length:50
        public string NonBillableLaborLabel; //ReadOnly Length:50
        public int PageLayout; //ReadOnly Required PickList
        public int PaymentTerms; //ReadOnly Required [PaymentTerm]
        public int PageNumberFormat; //ReadOnly Required PickList
        public int DateFormat; //ReadOnly Required PickList
        public int NumberFormat; //ReadOnly Required PickList
        public int TimeFormat; //ReadOnly Required PickList
        public string Name; //ReadOnly Required Length:50
        public bool ShowGridHeader; //ReadOnly Required
        public bool ShowVerticalGridLines; //ReadOnly Required
        public string CurrencyPositiveFormat; //ReadOnly Required Length:10
        public string CurrencyNegativeFormat; //ReadOnly Required Length:10

    } //end InvoiceTemplate

}
