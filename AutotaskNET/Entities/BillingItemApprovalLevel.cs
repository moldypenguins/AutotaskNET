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
        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region Required Fields

        public int TimeEntryID { get; set; } //Required [TimeEntry]
        public int ApprovalResourceID { get; set; } //Required [Resource]
        public DateTime ApprovalDateTime { get; set; } //Required
        public int ApprovalLevel { get; set; } //Required

        #endregion //Required Fields
        
    } //end BillingItemApprovalLevel

}
