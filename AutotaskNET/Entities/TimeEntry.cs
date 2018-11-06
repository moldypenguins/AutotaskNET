using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask Time Entry.<br />
    /// A time entry allows an Autotask resource to enter time against a Ticket or Task and to enter General or Regular time, for example, in-house meeting, travel, or training time.<br />
    /// Users enter time through a number of modules including Home, Contracts, CRM, Directory, Projects, Service Desk, and Timesheets.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TimeEntry : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

        public int? TaskID { get; set; } //[Task]
        public int? TicketID { get; set; } //[Ticket]
        public int? InternalAllocationCodeID { get; set; } //[AllocationCode]
        public int? Type { get; set; } //ReadOnly PickList
        public DateTime DateWorked { get; set; } //Required
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public double HoursWorked { get; set; }
        public double HoursToBill { get; set; } //ReadOnly
        public double OffsetHours { get; set; }
        public string SummaryNotes { get; set; } //Length:8000
        public string InternalNotes { get; set; } //Length:8000
        public int? RoleID { get; set; } //[Role]
        public DateTime? CreateDateTime { get; set; } //ReadOnly
        public int ResourceID { get; set; } //Required [Resource]
        public int? CreatorUserID { get; set; } //ReadOnly
        public int? LastModifiedUserID { get; set; } //ReadOnly
        public DateTime? LastModifiedDateTime { get; set; } //ReadOnly
        public int? AllocationCodeID { get; set; } //[AllocationCode]
        public int? ContractID { get; set; } //[Contract]
        public bool? ShowOnInvoice { get; set; }
        public bool? NonBillable { get; set; }
        public int? BillingApprovalLevelMostRecent { get; set; } //ReadOnly
        public int? BillingApprovalResourceID { get; set; } //[Resource]
        public DateTime? BillingApprovalDateTime { get; set; }
        public long ContractServiceID { get; set; } //[ContractService]
        public long ContractServiceBundleID { get; set; } //[ContractServiceBundle]

    } //end TimeEntry

}
