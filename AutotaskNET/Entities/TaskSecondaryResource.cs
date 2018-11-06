using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a secondary resource assigned to a project Task.<br />
    /// Secondary resources are different from the primary resource.<br />
    /// A Task can have more than one Secondary Resource assigned, and a task can have secondary resources without a primary resource assigned.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TaskSecondaryResource : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #region Required Fields

        public int TaskID { get; set; } //Required [Task]
        public int ResourceID { get; set; } //Required [Resource]
        public int RoleID { get; set; } //Required [Role]

        #endregion //Required Fields
        
    } //end TaskSecondaryResource

}
