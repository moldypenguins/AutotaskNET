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
            this.AllocationCodeID = entity.AllocationCodeID == null ? default(int?) : int.Parse(entity.AllocationCodeID.ToString());
            this.BillingApprovalDateTime = entity.BillingApprovalDateTime == null ? default(DateTime?) : DateTime.Parse(entity.BillingApprovalDateTime.ToString());
            this.BillingApprovalLevelMostRecent = entity.BillingApprovalLevelMostRecent == null ? default(int?) : int.Parse(entity.BillingApprovalLevelMostRecent.ToString());
            this.BillingApprovalResourceID = entity.BillingApprovalResourceID == null ? default(int?) : int.Parse(entity.BillingApprovalResourceID.ToString());
            this.ContractID = entity.ContractID == null ? default(int?) : int.Parse(entity.ContractID.ToString());
            this.ContractServiceBundleID = long.Parse(entity.ContractServiceBundleID.ToString());
            this.ContractServiceID = long.Parse(entity.ContractServiceID.ToString());
            this.CreateDateTime = entity.CreateDateTime == null ? default(DateTime?) : DateTime.Parse(entity.CreateDateTime.ToString());
            this.CreatorUserID = entity.CreatorUserID == null ? default(int?) : int.Parse(entity.CreatorUserID.ToString());
            this.DateWorked = DateTime.Parse(entity.DateWorked.ToString());
            this.EndDateTime = entity.EndDateTime == null ? default(DateTime?) : DateTime.Parse(entity.EndDateTime.ToString());
            this.HoursToBill = double.Parse(entity.HoursToBill.ToString());
            this.HoursWorked = double.Parse(entity.HoursWorked.ToString());
            this.InternalAllocationCodeID = entity.InternalAllocationCodeID == null ? default(int?) : int.Parse(entity.InternalAllocationCodeID.ToString());
            this.InternalNotes = entity.InternalNotes == null ? default(string) : entity.InternalNotes.ToString();
            this.LastModifiedDateTime = entity.LastModifiedDateTime == null ? default(DateTime?) : DateTime.Parse(entity.LastModifiedDateTime.ToString());
            this.LastModifiedUserID = entity.LastModifiedUserID == null ? default(int?) : int.Parse(entity.LastModifiedUserID.ToString());
            this.NonBillable = entity.NonBillable == null ? default(bool?) : bool.Parse(entity.NonBillable.ToString());
            this.OffsetHours = double.Parse(entity.OffsetHours.ToString());
            this.ResourceID = int.Parse(entity.ResourceID.ToString());
            this.RoleID = entity.RoleID == null ? default(int?) : int.Parse(entity.RoleID.ToString());
            this.ShowOnInvoice = entity.ShowOnInvoice == null ? default(bool?) : bool.Parse(entity.ShowOnInvoice.ToString());
            this.StartDateTime = entity.StartDateTime == null ? default(DateTime?) : DateTime.Parse(entity.StartDateTime.ToString());
            this.SummaryNotes = entity.SummaryNotes == null ? default(string) : entity.SummaryNotes.ToString();
            this.TaskID = entity.TaskID == null ? default(int?) : int.Parse(entity.TaskID.ToString());
            this.TicketID = entity.TicketID == null ? default(int?) : int.Parse(entity.TicketID.ToString());
            this.Type = entity.Type == null ? default(int?) : int.Parse(entity.Type.ToString());

        } //end TimeEntry(net.autotask.webservices.TimeEntry entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.TimeEntry()
            {
                id = this.id,

            };

        } //end ToATWS()

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
