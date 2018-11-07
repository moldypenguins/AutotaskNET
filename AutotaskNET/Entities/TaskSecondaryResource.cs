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
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public TaskSecondaryResource() : base() { } //end TaskSecondaryResource()
        public TaskSecondaryResource(net.autotask.webservices.TaskSecondaryResource entity) : base(entity)
        {
            this.ResourceID = int.Parse(entity.ResourceID.ToString());
            this.RoleID = int.Parse(entity.RoleID.ToString());
            this.TaskID = int.Parse(entity.TaskID.ToString());

        } //end TaskSecondaryResource(net.autotask.webservices.TaskSecondaryResource entity)

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public int TaskID; //Required [Task]
        public int ResourceID; //Required [Resource]
        public int RoleID; //Required [Role]

        #endregion //Required Fields

        #endregion //Fields

    } //end TaskSecondaryResource

}
