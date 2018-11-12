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

        } //end ExpenseItem(net.autotask.webservices.ExpenseItem entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public string GLCode { get; set; } //ReadOnly Length:20
        public bool? Reimbursable { get; set; } //ReadOnly
        public bool? Rejected { get; set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public int ExpenseReportID { get; set; } //Required [ExpenseReport]
        public string Description { get; set; } //Required Length:128
        public DateTime ExpenseDate { get; set; } //Required
        public int ExpenseCategory { get; set; } //Required PickList
        public int PaymentType { get; set; } //Required PickList
        public bool HaveReceipt { get; set; } //Required
        public bool BillableToAccount { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public int? WorkType { get; set; } //PickList
        public double ExpenseAmount { get; set; }
        public int? AccountID { get; set; } //[Account]
        public int? ProjectID { get; set; } //[Project]
        public int? TaskID { get; set; } //[Task]
        public int? TicketID { get; set; } //[Ticket]
        public string EntertainmentLocation { get; set; } //Length:128
        public double Miles { get; set; }
        public string Origin { get; set; } //Length:128
        public string Destination { get; set; } //Length:128
        public string PurchaseOrderNumber { get; set; } //Length:50
        public double OdometerStart { get; set; }
        public double OdometerEnd { get; set; }
        public int? ExpenseCurrencyID { get; set; } //[Currency]
        public double ReceiptAmount { get; set; }
        public double ReimbursementAmount { get; set; }
        public double ReimbursementCurrencyReimbursementAmount { get; set; }

        #endregion //Optional Fields

        #endregion //Fields

    } //end ExpenseItem

}
