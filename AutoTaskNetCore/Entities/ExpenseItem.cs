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

        public static implicit operator net.autotask.webservices.ExpenseItem(ExpenseItem expenseitem)
        {
            return new net.autotask.webservices.ExpenseItem()
            {
                id = expenseitem.id,

            };

        } //end implicit operator net.autotask.webservices.ExpenseItem(ExpenseItem expenseitem)

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
