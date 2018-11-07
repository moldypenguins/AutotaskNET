using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Task : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => true;

        #endregion //Properties

        #region Constructors

        public Task() : base() { } //end Task()
        public Task(net.autotask.webservices.Task entity) : base(entity)
        {

        } //end Task(net.autotask.webservices.Task entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public DateTime? CompletedDateTime; //ReadOnly
        public DateTime? CreateDateTime; //ReadOnly
        public int? CreatorResourceID; //ReadOnly [Resource]
        public float HoursToBeScheduled; //ReadOnly
        public DateTime? LastActivityDateTime; //ReadOnly
        public bool? TaskIsBillable; //ReadOnly
        public string TaskNumber; //ReadOnly Length:50
        public int? CreatorType; //ReadOnly PickList
        public int? CompletedByResourceID; //ReadOnly [Resource]
        public int? CompletedByType; //ReadOnly PickList
        public int? LastActivityPersonType; //ReadOnly PickList
        public int? LastActivityResourceID; //ReadOnly [Resource]

        #endregion //ReadOnly Fields

        #region Required Fields

        public int ProjectID; //Required [Project]
        public int Status; //Required PickList
        public int TaskType; //Required PickList
        public string Title; //Required Length:255

        #endregion //Required Fields

        #region Optional Fields

        public int? AllocationCodeID; //[AllocationCode]
        public int? AssignedResourceID; //[Resource]
        public int? AssignedResourceRoleID; //[Role]
        public bool? CanClientPortalUserCompleteTask;
        public int? DepartmentID; //PickList
        public string Description; //Length:8000
        public DateTime? EndDateTime;
        public float EstimatedHours;
        public string ExternalID; //Length:50
        public bool? IsVisibleInClientPortal;
        public int? PhaseID; //[Phase]
        public int? Priority;
        public string PurchaseOrderNumber; //Length:50
        public float RemainingHours;
        public DateTime? StartDateTime;
        public int? PriorityLabel; //PickList

        #endregion //Optional Fields
        
        #endregion //Fields

    } //end Task

}
