using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The BillingItem entity describes a billable item in Autotask that has been approved and posted.<br />
    /// A billing item may or may not be included in an invoice and billed to the customer.<br />
    /// In Autotask, BillingItems are managed in the Contracts module.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class BillingItem : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public BillingItem() : base() { } //end BillingItem()
        public BillingItem(net.autotask.webservices.BillingItem entity) : base(entity)
        {

        } //end BillingItem(net.autotask.webservices.BillingItem entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public string ItemName { get; set; } //ReadOnly Length:255
        public string Description { get; set; } //ReadOnly Length:2000
        public double Quantity { get; set; } //ReadOnly
        public double Rate { get; set; } //ReadOnly
        public double TotalAmount { get; set; } //ReadOnly
        public double OurCost { get; set; } //ReadOnly
        public DateTime? ItemDate { get; set; } //ReadOnly
        public DateTime? ApprovedTime { get; set; } //ReadOnly
        public int? InvoiceID { get; set; } //ReadOnly [Invoice]
        public int? ItemApproverID { get; set; } //ReadOnly [Resource]
        public int? AccountID { get; set; } //ReadOnly [Account]
        public int? TicketID { get; set; } //ReadOnly [Ticket]
        public int? TaskID { get; set; } //ReadOnly [Task]
        public int? ProjectID { get; set; } //ReadOnly [Project]
        public int? AllocationCodeID { get; set; } //ReadOnly [AllocationCode]
        public int? RoleID { get; set; } //ReadOnly [Role]
        public int? TimeEntryID { get; set; } //ReadOnly [TimeEntry]
        public int? ContractID { get; set; } //ReadOnly [Contract]
        public double TaxDollars { get; set; } //ReadOnly
        public string PurchaseOrderNumber { get; set; } //ReadOnly Length:50
        public double ExtendedPrice { get; set; } //ReadOnly
        public int? ExpenseItemID { get; set; } //ReadOnly [ExpenseItem]
        public long ContractCostID { get; set; } //ReadOnly [ContractCost]
        public long ProjectCostID { get; set; } //ReadOnly [ProjectCost]
        public long TicketCostID { get; set; } //ReadOnly [TicketCost]
        public long LineItemID { get; set; } //ReadOnly
        public long MilestoneID { get; set; } //ReadOnly [ContractMilestone]
        public long ServiceID { get; set; } //ReadOnly [Service]
        public long ServiceBundleID { get; set; } //ReadOnly [ServiceBundle]
        public long VendorID { get; set; } //ReadOnly [Account]
        public string LineItemFullDescription { get; set; } //ReadOnly Length:8000
        public string LineItemGroupDescription { get; set; } //ReadOnly Length:8000
        public long InstalledProductID { get; set; } //ReadOnly [InstalledProduct]
        public double InternalCurrencyExtendedPrice { get; set; } //ReadOnly
        public double InternalCurrencyRate { get; set; } //ReadOnly
        public double InternalCurrencyTaxDollars { get; set; } //ReadOnly
        public double InternalCurrencyTotalAmount { get; set; } //ReadOnly
        public int? AccountManagerWhenApprovedID { get; set; } //ReadOnly [Resource]
        public int? BusinessDivisionSubdivisionID { get; set; } //ReadOnly [BusinessDivisionSubdivision]

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int Type { get; set; } //ReadOnly Required PickList
        public int SubType { get; set; } //ReadOnly Required PickList
        public int NonBillable { get; set; } //ReadOnly Required

        #endregion //ReadOnly Required Fields

        #region Optional Fields

        public DateTime? WebServiceDate { get; set; }

        #endregion //Optional Fields

        #endregion //Fields

    } //end BillingItem

}
