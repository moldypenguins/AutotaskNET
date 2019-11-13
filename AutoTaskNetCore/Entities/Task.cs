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
            this.AllocationCodeID = entity.AllocationCodeID == null ? default(int?) : int.Parse(entity.AllocationCodeID.ToString());
            this.AssignedResourceID = entity.AssignedResourceID == null ? default(int?) : int.Parse(entity.AssignedResourceID.ToString());
            this.AssignedResourceRoleID = entity.AssignedResourceRoleID == null ? default(int?) : int.Parse(entity.AssignedResourceRoleID.ToString());
            this.CanClientPortalUserCompleteTask = entity.CanClientPortalUserCompleteTask == null ? default(bool?) : bool.Parse(entity.CanClientPortalUserCompleteTask.ToString());
            this.CompletedByResourceID = entity.CompletedByResourceID == null ? default(int?) : int.Parse(entity.CompletedByResourceID.ToString());
            this.CompletedByType = entity.CompletedByType == null ? default(int?) : int.Parse(entity.CompletedByType.ToString());
            this.CompletedDateTime = entity.CompletedDateTime == null ? default(DateTime?) : DateTime.Parse(entity.CompletedDateTime.ToString());
            this.CreateDateTime = entity.CreateDateTime == null ? default(DateTime?) : DateTime.Parse(entity.CreateDateTime.ToString());
            this.CreatorResourceID = entity.CreatorResourceID == null ? default(int?) : int.Parse(entity.CreatorResourceID.ToString());
            this.CreatorType = entity.CreatorType == null ? default(int?) : int.Parse(entity.CreatorType.ToString());
            this.DepartmentID = entity.DepartmentID == null ? default(int?) : int.Parse(entity.DepartmentID.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.EndDateTime = entity.EndDateTime == null ? default(DateTime?) : DateTime.Parse(entity.EndDateTime.ToString());
            this.EstimatedHours = entity.EstimatedHours == null ? default(float) : float.Parse(entity.EstimatedHours.ToString());
            this.ExternalID = entity.ExternalID == null ? default(string) : entity.ExternalID.ToString();
            this.HoursToBeScheduled = entity.HoursToBeScheduled == null ? default(float) : float.Parse(entity.HoursToBeScheduled.ToString());
            this.IsVisibleInClientPortal = entity.IsVisibleInClientPortal == null ? default(bool?) : bool.Parse(entity.IsVisibleInClientPortal.ToString());
            this.LastActivityDateTime = entity.LastActivityDateTime == null ? default(DateTime?) : DateTime.Parse(entity.LastActivityDateTime.ToString());
            this.LastActivityPersonType = entity.LastActivityPersonType == null ? default(int?) : int.Parse(entity.LastActivityPersonType.ToString());
            this.LastActivityResourceID = entity.LastActivityResourceID == null ? default(int?) : int.Parse(entity.LastActivityResourceID.ToString());
            this.PhaseID = entity.PhaseID == null ? default(int?) : int.Parse(entity.PhaseID.ToString());
            this.Priority = entity.Priority == null ? default(int?) : int.Parse(entity.Priority.ToString());
            this.PriorityLabel = entity.PriorityLabel == null ? default(int?) : int.Parse(entity.PriorityLabel.ToString());
            this.ProjectID = int.Parse(entity.ProjectID.ToString());
            this.PurchaseOrderNumber = entity.PurchaseOrderNumber == null ? default(string) : entity.PurchaseOrderNumber.ToString();
            this.RemainingHours = entity.RemainingHours == null ? default(float) : float.Parse(entity.RemainingHours.ToString());
            this.StartDateTime = entity.StartDateTime == null ? default(DateTime?) : DateTime.Parse(entity.StartDateTime.ToString());
            this.Status = int.Parse(entity.Status.ToString());
            this.TaskIsBillable = entity.TaskIsBillable == null ? default(bool?) : bool.Parse(entity.TaskIsBillable.ToString());
            this.TaskNumber = entity.TaskNumber == null ? default(string) : entity.TaskNumber.ToString();
            this.TaskType = int.Parse(entity.TaskType.ToString());
            this.Title = entity.Title == null ? default(string) : entity.Title.ToString();

        } //end Task(net.autotask.webservices.Task entity)

        public static implicit operator net.autotask.webservices.Task(Task task)
        {
            return new net.autotask.webservices.Task()
            {
                id = task.id,

            };

        } //end implicit operator net.autotask.webservices.Task(Task task)

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
