using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a line item associated with an Expense Report entity.<br />
    /// It allows expense line items to be created, queried, and updated through the API.<br />
    /// <br />
    /// In Autotask, Expense Items can be added to an Expense Report from the Timesheets or Home modules, or a ticket, project, or task.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ExpenseItem : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ExpenseItem() : base() { } //end ExpenseItem()
        public ExpenseItem(net.autotask.webservices.ExpenseItem entity) : base(entity)
        {
            this.BillableToAccount = bool.Parse(entity.BillableToAccount.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.ExpenseAmount = double.Parse(entity.ExpenseAmount.ToString());
            this.ExpenseCategory = int.Parse(entity.ExpenseCategory.ToString());
            this.ExpenseDate = DateTime.Parse(entity.ExpenseDate.ToString());
            this.ExpenseReportID = int.Parse(entity.ExpenseReportID.ToString());
            this.HaveReceipt = bool.Parse(entity.HaveReceipt.ToString());
            this.PaymentType = int.Parse(entity.PaymentType.ToString());
            this.AccountID = entity.AccountID == null ? default(int?) : int.Parse(entity.AccountID.ToString());
            this.Destination = entity.Description == null ? default(string) : entity.Description.ToString();
            this.EntertainmentLocation = entity.EntertainmentLocation == null ? default(string) : entity.EntertainmentLocation.ToString();
            this.ExpenseCurrencyID = entity.ExpenseCurrencyID == null ? default(int?) : int.Parse(entity.ExpenseCurrencyID.ToString());
            this.GLCode = entity.GLCode == null ? default(string) : entity.GLCode.ToString();
            this.Miles = double.Parse(entity.Miles.ToString());
            this.OdometerEnd = double.Parse(entity.OdometerEnd.ToString());
            this.OdometerStart = double.Parse(entity.OdometerStart.ToString());
            this.Origin = entity.Origin == null ? default(string) : entity.Origin.ToString();
            this.ProjectID = entity.ProjectID == null ? default(int?) : int.Parse(entity.ProjectID.ToString());
            this.PurchaseOrderNumber = entity.PurchaseOrderNumber == null ? default(string) : entity.PurchaseOrderNumber.ToString();
            this.ReceiptAmount = double.Parse(entity.ReceiptAmount.ToString());
            this.Reimbursable = entity.Reimbursable == null ? default(bool?) : bool.Parse(entity.Reimbursable.ToString();
            this.ReimbursementAmount = double.Parse(entity.ReimbursementAmount.ToString());
            this.ReimbursementCurrencyReimbursementAmount = double.Parse(entity.ReimbursementCurrencyReimbursementAmount.ToString());
            this.Rejected = entity.Rejected == null ? default(bool?) : bool.Parse(entity.Rejected.ToString());
            this.TaskID = entity.TaskID == null ? default(int?) : int.Parse(entity.TaskID.ToString());
            this.TicketID = entity.TicketID == null ? default(int?) : int.Parse(entity.TicketID.ToString());
            this.WorkType = entity.WorkType == null ? default(int?) : int.Parse(entity.WorkType.ToString());
        } //end ExpenseItem(net.autotask.webservices.ExpenseItem entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public string GLCode; //ReadOnly Length:20
        public bool? Reimbursable; //ReadOnly
        public bool? Rejected; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public int ExpenseReportID; //Required [ExpenseReport]
        public string Description; //Required Length:128
        public DateTime ExpenseDate; //Required
        public int ExpenseCategory; //Required PickList
        public int PaymentType; //Required PickList
        public bool HaveReceipt; //Required
        public bool BillableToAccount; //Required

        #endregion //Required Fields

        #region Optional Fields

        public int? WorkType; //PickList
        public double ExpenseAmount;
        public int? AccountID; //[Account]
        public int? ProjectID; //[Project]
        public int? TaskID; //[Task]
        public int? TicketID; //[Ticket]
        public string EntertainmentLocation; //Length:128
        public double Miles;
        public string Origin; //Length:128
        public string Destination; //Length:128
        public string PurchaseOrderNumber; //Length:50
        public double OdometerStart;
        public double OdometerEnd;
        public int? ExpenseCurrencyID; //[Currency]
        public double ReceiptAmount;
        public double ReimbursementAmount;
        public double ReimbursementCurrencyReimbursementAmount;

        #endregion //Optional Fields

        #endregion //Fields

    } //end ExpenseItem

}
