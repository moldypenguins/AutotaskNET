using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes Expense Reports created in Autotask and is used to submit expense line items for approval and reimbursement.<br />
    /// This entity allows expense reports to be created, queried, and updated through the Web Services API.<br />
    /// <br />
    /// In Autotask, Expense Reports are created and managed through the Timehsheets module or under My Expense Reports in the left navigation menu of the Home module.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ExpenseReport : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ExpenseReport() : base() { } //end ExpenseReport()
        public ExpenseReport(net.autotask.webservices.ExpenseReport entity) : base(entity)
        {

        } //end ExpenseReport(net.autotask.webservices.ExpenseReport entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public int? Status { get; set; } //ReadOnly PickList
        public DateTime? SubmitDate { get; set; } //ReadOnly
        public int? ApproverID { get; set; } //ReadOnly [Resource]
        public double ExpenseTotal { get; set; } //ReadOnly
        public string RejectionReason { get; set; } //ReadOnly Length:2048
        public double AmountDue { get; set; } //ReadOnly
        public string DepartmentNumber { get; set; } //ReadOnly Length:50
        public DateTime? ApprovedDate { get; set; } //ReadOnly
        public int? ReimbursementCurrencyID { get; set; } //ReadOnly [Currency]
        public double ReimbursementCurrencyCashAdvanceAmount { get; set; } //ReadOnly
        public double ReimbursementCurrencyAmountDue { get; set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public string Name { get; set; } //Required Length:100
        public int SubmitterID { get; set; } //Required [Resource]
        public DateTime WeekEnding { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public bool? Submit { get; set; }
        public double CashAdvanceAmount { get; set; }
        public string QuickBooksReferenceNumber { get; set; } //Length:100
        public int? BusinessDivisionSubdivisionID { get; set; } //[BusinessDivisionSubdivision]

        #endregion //Optional Fields

        #endregion //Fields

    } //end ExpenseReport

}
