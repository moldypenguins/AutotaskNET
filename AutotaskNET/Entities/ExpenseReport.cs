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
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
            this.SubmitterID = int.Parse(entity.SubmitterID.ToString());
            this.WeekEnding = DateTime.Parse(entity.WeekEnding.ToString());
            this.AmountDue = double.Parse(entity.ApprovedDate.ToString());
            this.ApprovedDate = entity.ApprovedDate == null ? default(DateTime?) : DateTime.Parse(entity.ApprovedDate.ToString());
            this.ApproverID = entity.ApproverID == null ? default(int?) : int.Parse(entity.ApproverID.ToString());
            this.BusinessDivisionSubdivisionID = entity.BusinessDivisionSubdivisionID == null ? default(int?) : int.Parse(entity.BusinessDivisionSubdivisionID.ToString());
            this.CashAdvanceAmount = double.Parse(entity.CashAdvanceAmount.ToString());
            this.DepartmentNumber = entity.DepartmentNumber == null ? default(string) : entity.DepartmentNumber.ToString();
            this.ExpenseTotal = double.Parse(entity.ExpenseTotal.ToString());
            this.QuickBooksReferenceNumber = entity.QuickBooksReferenceNumber == null ? default(string) : entity.QuickBooksReferenceNumber.ToString();
            this.ReimbursementCurrencyAmountDue = double.Parse(entity.ReimbursementCurrencyAmountDue.ToString());
            this.ReimbursementCurrencyCashAdvanceAmount = double.Parse(entity.ReimbursementCurrencyCashAdvanceAmount.ToString());
            this.ReimbursementCurrencyID = entity.ReimbursementCurrencyID == null ? default(int?) : int.Parse(entity.ReimbursementCurrencyID.ToString());
            this.RejectionReason = entity.RejectionReason == null ? default(string) : entity.RejectionReason.ToString());
            this.Status = entity.Status == null ? default(int?) : int.Parse(entity.Status.ToString());
            this.Submit = entity.Submit == null ? default(bool?) : bool.Parse(entity.Submit.ToString());
            this.SubmitDate = entity.SubmitDate == null ? default(DateTime?) : DateTime.Parse(entity .SubmitDate.ToString();
        } //end ExpenseReport(net.autotask.webservices.ExpenseReport entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public int? Status; //ReadOnly PickList
        public DateTime? SubmitDate; //ReadOnly
        public int? ApproverID; //ReadOnly [Resource]
        public double ExpenseTotal; //ReadOnly
        public string RejectionReason; //ReadOnly Length:2048
        public double AmountDue; //ReadOnly
        public string DepartmentNumber; //ReadOnly Length:50
        public DateTime? ApprovedDate; //ReadOnly
        public int? ReimbursementCurrencyID; //ReadOnly [Currency]
        public double ReimbursementCurrencyCashAdvanceAmount; //ReadOnly
        public double ReimbursementCurrencyAmountDue; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public string Name; //Required Length:100
        public int SubmitterID; //Required [Resource]
        public DateTime WeekEnding; //Required

        #endregion //Required Fields

        #region Optional Fields

        public bool? Submit;
        public double CashAdvanceAmount;
        public string QuickBooksReferenceNumber; //Length:100
        public int? BusinessDivisionSubdivisionID; //[BusinessDivisionSubdivision]

        #endregion //Optional Fields

        #endregion //Fields

    } //end ExpenseReport

}
