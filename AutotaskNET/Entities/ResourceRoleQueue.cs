using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a Resource - Queue relationship.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ResourceRoleQueue : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ResourceRoleQueue() : base() { } //end ResourceRoleQueue()
        public ResourceRoleQueue(net.autotask.webservices.ResourceRoleQueue entity) : base(entity)
        {
            this.Active = entity.Active == null ? default(bool?) : bool.Parse(entity.Active.ToString());
            this.Default = entity.Default == null ? default(bool?) : bool.Parse(entity.Default.ToString());
            this.QueueID = int.Parse(entity.QueueID.ToString());
            this.ResourceID = int.Parse(entity.ResourceID.ToString());
            this.RoleID = entity.RoleID == null ? default(int?) : int.Parse(entity.RoleID.ToString());
        } //end ResourceRoleQueue(net.autotask.webservices.ResourceRoleQueue entity.)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public int ResourceID; //ReadOnly Required [Resource]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public int QueueID; //Required PickList

        #endregion //Required Fields

        #region Obsolete Fields

        public bool? Active; //ReadOnly (Obsolete)
        public bool? Default; //ReadOnly (Obsolete)
        public int? RoleID; //ReadOnly [Role] (Obsolete)

        #endregion //Obsolete Fields

        #endregion //Fields

    } //end ResourceRoleQueue

}
