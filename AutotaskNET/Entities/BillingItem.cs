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
            this.AccountID = entity.AccountID == null ? default(int?) : int.Parse(entity.AccountID.ToString());
            this.AccountManagerWhenApprovedID = entity.AccountManagerWhenApprovedID == null ? default(int?) : int.Parse(entity.AccountManagerWhenApprovedID.ToString());
            this.AllocationCodeID = entity.AllocationCodeID == null ? default(int?) : int.Parse(entity.AllocationCodeID.ToString());
            this.ApprovedTime = entity.ApprovedTime == null ? default(DateTime?) : DateTime.Parse(entity.ApprovedTime.ToString());
            this.BusinessDivisionSubdivisionID = entity.BusinessDivisionSubdivisionID == null ? default(int?) : int.Parse(entity.BusinessDivisionSubdivisionID.ToString());
            this.ContractCostID = long.Parse(entity.ContractCostID.ToString());
            this.ContractID = entity.ContractID == null ? default(int?) : int.Parse(entity.ContractID.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.ExpenseItemID = entity.ExpenseItemID == null ? default(int?) : int.Parse(entity.ExpenseItemID.ToString());
            this.ExtendedPrice = double.Parse(entity.ExtendedPrice.ToString());
            this.InstalledProductID = long.Parse(entity.InstalledProductID.ToString());
            this.InternalCurrencyExtendedPrice = double.Parse(entity.InternalCurrencyExtendedPrice.ToString());
            this.InternalCurrencyRate = double.Parse(entity.InternalCurrencyRate.ToString());
            this.InternalCurrencyTaxDollars = double.Parse(entity.InternalCurrencyTaxDollars.ToString());
            this.InternalCurrencyTotalAmount = double.Parse(entity.InternalCurrencyTotalAmount.ToString());
            this.InvoiceID = entity.InvoiceID == null ? default(int?) : int.Parse(entity.InvoiceID.ToString());
            this.ItemApproverID = entity.ItemApproverID == null ? default(int?) : int.Parse(entity.ItemApproverID.ToString());
            this.ItemDate = entity.ItemDate == null ? default(DateTime?) : DateTime.Parse(entity.ItemDate.ToString());
            this.ItemName = entity.ItemName == null ? default(string) : entity.ItemName.ToString();
            this.LineItemFullDescription = entity.LineItemFullDescription == null ? default(string) : entity.LineItemFullDescription.ToString();
            this.LineItemGroupDescription = entity.LineItemGroupDescription == null ? default(string) : entity.LineItemGroupDescription.ToString();
            this.LineItemID = long.Parse(entity.LineItemID.ToString());
            this.MilestoneID = long.Parse(entity.MilestoneID.ToString());
            this.NonBillable = int.Parse(entity.NonBillable.ToString());
            this.OurCost = double.Parse(entity.OurCost.ToString());
            this.ProjectCostID = long.Parse(entity.ProjectCostID.ToString());
            this.ProjectID = entity.ProjectID == null ? default(int?) : int.Parse(entity.ProjectID.ToString());
            this.PurchaseOrderNumber = entity.PurchaseOrderNumber == null ? default(string) : entity.PurchaseOrderNumber.ToString();
            this.Quantity = double.Parse(entity.Quantity.ToString());
            this.Rate = double.Parse(entity.Rate.ToString());
            this.RoleID = entity.RoleID == null ? default(int?) : int.Parse(entity.RoleID.ToString();
            this.ServiceBundleID = long.Parse(entity.ServiceBundleID.ToString());
            this.ServiceID = long.Parse(entity.ServiceID.ToString());
            this.SubType = int.Parse(entity.SubType.ToString());
            this.TaskID = entity.TaskID == null ? default(int?) : int.Parse(entity.TaskID.ToString());
            this.TaxDollars = double.Parse(entity.TaxDollars.ToString());
            this.TicketCostID = long.Parse(entity.TicketCostID.ToString());
            this.TicketID = entity.TicketID == null ? default(int?) : int.Parse(entity.TicketID.ToString());
            this.TimeEntryID = entity.TimeEntryID == null ? default(int?) : int.Parse(entity.TimeEntryID.ToString());
            this.TotalAmount = double.Parse(entity.TotalAmount.ToString());
            this.Type = int.Parse(entity.Type.ToString());
            this.VendorID = long.Parse(entity.VendorID.ToString());
            this.WebServiceDate = entity.WebServiceDate == null ? default(DateTime?) : DateTime.Parse(entity.WebServiceDate.ToString());
        } //end BillingItem(net.autotask.webservices.BillingItem entity)

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
