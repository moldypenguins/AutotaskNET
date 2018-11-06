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
        public override bool CanCreate => false;
        public override bool CanUpdate => false;
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

        public bool DisplayTaxCategory { get; set; } //ReadOnly Required
        public bool DisplayTaxCategorySuperscripts { get; set; } //ReadOnly Required
        public bool DisplaySeparateLineItemForEachTax { get; set; } //ReadOnly Required
        public int GroupBy { get; set; } //ReadOnly Required PickList
        public int ItemizeItemsInEachGroup { get; set; } //ReadOnly Required PickList
        public int SortBy { get; set; } //ReadOnly Required PickList
        public bool ItemizeServicesAndBundles { get; set; } //ReadOnly Required
        public bool DisplayZeroAmountRecurringServicesAndBundles { get; set; } //ReadOnly Required
        public bool DisplayRecurringServiceContractLabor { get; set; } //ReadOnly Required
        public bool DisplayFixedPriceContractLabor { get; set; } //ReadOnly Required
        public string RateCostExpression { get; set; } //ReadOnly Length:50
        public string CoveredByRecurringServiceFixedPricePerTicketContractLabel { get; set; } //ReadOnly Length:50
        public string CoveredByBlockRetainerContractLabel { get; set; } //ReadOnly Length:50
        public string NonBillableLaborLabel { get; set; } //ReadOnly Length:50
        public int PageLayout { get; set; } //ReadOnly Required PickList
        public int PaymentTerms { get; set; } //ReadOnly Required [PaymentTerm]
        public int PageNumberFormat { get; set; } //ReadOnly Required PickList
        public int DateFormat { get; set; } //ReadOnly Required PickList
        public int NumberFormat { get; set; } //ReadOnly Required PickList
        public int TimeFormat { get; set; } //ReadOnly Required PickList
        public string Name { get; set; } //ReadOnly Required Length:50
        public bool ShowGridHeader { get; set; } //ReadOnly Required
        public bool ShowVerticalGridLines { get; set; } //ReadOnly Required
        public string CurrencyPositiveFormat { get; set; } //ReadOnly Required Length:10
        public string CurrencyNegativeFormat { get; set; } //ReadOnly Required Length:10

    } //end InvoiceTemplate

}
