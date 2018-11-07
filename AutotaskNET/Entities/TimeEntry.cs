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
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public TimeEntry() : base() { } //end TimeEntry()
        public TimeEntry(net.autotask.webservices.TimeEntry entity) : base(entity)
        {

        } //end TimeEntry(net.autotask.webservices.TimeEntry entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public int? Type; //ReadOnly PickList
        public double HoursToBill; //ReadOnly
        public DateTime? CreateDateTime; //ReadOnly
        public int? CreatorUserID; //ReadOnly
        public int? LastModifiedUserID; //ReadOnly
        public DateTime? LastModifiedDateTime; //ReadOnly
        public int? BillingApprovalLevelMostRecent; //ReadOnly

        #endregion //ReadOnly Fields
        
        #region Required Fields

        public DateTime DateWorked; //Required
        public int ResourceID; //Required [Resource]

        #endregion //Required Fields

        #region Optional Fields

        public int? TaskID; //[Task]
        public int? TicketID; //[Ticket]
        public int? InternalAllocationCodeID; //[AllocationCode]
        public DateTime? StartDateTime;
        public DateTime? EndDateTime;
        public double HoursWorked;
        public double OffsetHours;
        public string SummaryNotes; //Length:8000
        public string InternalNotes; //Length:8000
        public int? RoleID; //[Role]
        public int? AllocationCodeID; //[AllocationCode]
        public int? ContractID; //[Contract]
        public bool? ShowOnInvoice;
        public bool? NonBillable;
        public int? BillingApprovalResourceID; //[Resource]
        public DateTime? BillingApprovalDateTime;
        public long ContractServiceID; //[ContractService]
        public long ContractServiceBundleID; //[ContractServiceBundle]

        #endregion //Optional Fields

        #endregion //Fields

    } //end TimeEntry

}
