using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Task : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => true;

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

        public int? AllocationCodeID { get; set; } //[AllocationCode]
        public int? AssignedResourceID { get; set; } //[Resource]
        public int? AssignedResourceRoleID { get; set; } //[Role]
        public bool? CanClientPortalUserCompleteTask { get; set; }
        public DateTime? CompletedDateTime { get; set; } //ReadOnly
        public DateTime? CreateDateTime { get; set; } //ReadOnly
        public int? CreatorResourceID { get; set; } //ReadOnly [Resource]
        public int? DepartmentID { get; set; } //PickList
        public string Description { get; set; } //Length:8000
        public DateTime? EndDateTime { get; set; }
        public float EstimatedHours { get; set; }
        public string ExternalID { get; set; } //Length:50
        public float HoursToBeScheduled { get; set; } //ReadOnly
        public bool? IsVisibleInClientPortal { get; set; }
        public DateTime? LastActivityDateTime { get; set; } //ReadOnly
        public int? PhaseID { get; set; } //[Phase]
        public int? Priority { get; set; }
        public int ProjectID { get; set; } //Required [Project]
        public string PurchaseOrderNumber { get; set; } //Length:50
        public float RemainingHours { get; set; }
        public DateTime? StartDateTime { get; set; }
        public int Status { get; set; } //Required PickList
        public int? PriorityLabel { get; set; } //PickList
        public bool? TaskIsBillable { get; set; } //ReadOnly
        public string TaskNumber { get; set; } //ReadOnly Length:50
        public int TaskType { get; set; } //Required PickList
        public string Title { get; set; } //Required Length:255
        public int? CreatorType { get; set; } //ReadOnly PickList
        public int? CompletedByResourceID { get; set; } //ReadOnly [Resource]
        public int? CompletedByType { get; set; } //ReadOnly PickList
        public int? LastActivityPersonType { get; set; } //ReadOnly PickList
        public int? LastActivityResourceID { get; set; } //ReadOnly [Resource]

    } //end Task

}
