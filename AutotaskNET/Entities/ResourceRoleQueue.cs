using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a Resource - Queue relationship.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ResourceRoleQueue : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Required Fields

        public int ResourceID { get; set; } //ReadOnly Required [Resource]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public int QueueID { get; set; } //Required PickList

        #endregion //Required Fields

        #region Obsolete Fields

        public bool? Active { get; set; } //ReadOnly (Obsolete)
        public bool? Default { get; set; } //ReadOnly (Obsolete)
        public int? RoleID { get; set; } //ReadOnly [Role] (Obsolete)

        #endregion //Obsolete Fields
        
    } //end ResourceRoleQueue

}
