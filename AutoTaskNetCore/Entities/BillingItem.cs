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

        public static implicit operator net.autotask.webservices.BillingItem(BillingItem billingitem)
        {
            return new net.autotask.webservices.BillingItem()
            {
                id = billingitem.id,

            };

        } //end implicit operator net.autotask.webservices.BillingItem(BillingItem billingitem)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public string ItemName; //ReadOnly Length:255
        public string Description; //ReadOnly Length:2000
        public double Quantity; //ReadOnly
        public double Rate; //ReadOnly
        public double TotalAmount; //ReadOnly
        public double OurCost; //ReadOnly
        public DateTime? ItemDate; //ReadOnly
        public DateTime? ApprovedTime; //ReadOnly
        public int? InvoiceID; //ReadOnly [Invoice]
        public int? ItemApproverID; //ReadOnly [Resource]
        public int? AccountID; //ReadOnly [Account]
        public int? TicketID; //ReadOnly [Ticket]
        public int? TaskID; //ReadOnly [Task]
        public int? ProjectID; //ReadOnly [Project]
        public int? AllocationCodeID; //ReadOnly [AllocationCode]
        public int? RoleID; //ReadOnly [Role]
        public int? TimeEntryID; //ReadOnly [TimeEntry]
        public int? ContractID; //ReadOnly [Contract]
        public double TaxDollars; //ReadOnly
        public string PurchaseOrderNumber; //ReadOnly Length:50
        public double ExtendedPrice; //ReadOnly
        public int? ExpenseItemID; //ReadOnly [ExpenseItem]
        public long ContractCostID; //ReadOnly [ContractCost]
        public long ProjectCostID; //ReadOnly [ProjectCost]
        public long TicketCostID; //ReadOnly [TicketCost]
        public long LineItemID; //ReadOnly
        public long MilestoneID; //ReadOnly [ContractMilestone]
        public long ServiceID; //ReadOnly [Service]
        public long ServiceBundleID; //ReadOnly [ServiceBundle]
        public long VendorID; //ReadOnly [Account]
        public string LineItemFullDescription; //ReadOnly Length:8000
        public string LineItemGroupDescription; //ReadOnly Length:8000
        public long InstalledProductID; //ReadOnly [InstalledProduct]
        public double InternalCurrencyExtendedPrice; //ReadOnly
        public double InternalCurrencyRate; //ReadOnly
        public double InternalCurrencyTaxDollars; //ReadOnly
        public double InternalCurrencyTotalAmount; //ReadOnly
        public int? AccountManagerWhenApprovedID; //ReadOnly [Resource]
        public int? BusinessDivisionSubdivisionID; //ReadOnly [BusinessDivisionSubdivision]

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int Type; //ReadOnly Required PickList
        public int SubType; //ReadOnly Required PickList
        public int NonBillable; //ReadOnly Required

        #endregion //ReadOnly Required Fields

        #region Optional Fields

        public DateTime? WebServiceDate;

        #endregion //Optional Fields

        #endregion //Fields

    } //end BillingItem

}
