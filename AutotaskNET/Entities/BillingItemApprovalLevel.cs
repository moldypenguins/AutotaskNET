using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The BillingItemApprovalLevel entity describes a multi-level approval record for an Autotask time entry.<br />
    /// It allows developers to use the API to implement multi-tier approval for Autotask time entries.<br />
    /// This option is only available through the Web Services API.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class BillingItemApprovalLevel : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public BillingItemApprovalLevel() : base() { } //end BillingItemApprovalLevel()
        public BillingItemApprovalLevel(net.autotask.webservices.BillingItemApprovalLevel entity) : base(entity)
        {

        } //end BillingItemApprovalLevel(net.autotask.webservices.BillingItemApprovalLevel entity)

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public int TimeEntryID { get; set; } //Required [TimeEntry]
        public int ApprovalResourceID { get; set; } //Required [Resource]
        public DateTime ApprovalDateTime { get; set; } //Required
        public int ApprovalLevel { get; set; } //Required

        #endregion //Required Fields

        #endregion //Fields

    } //end BillingItemApprovalLevel

}
