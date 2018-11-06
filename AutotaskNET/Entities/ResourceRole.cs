using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ResourceRole : Entity
    {
        public override bool CanCreate => false;
        public override bool CanUpdate => false;
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

        public long ResourceID { get; set; } //ReadOnly Required [Resource]
        public long DepartmentID { get; set; } //ReadOnly [Department]
        public long QueueID { get; set; } //ReadOnly PickList
        public long RoleID { get; set; } //ReadOnly Required [Role]
        public bool? Active { get; set; } //ReadOnly

    } //end ResourceRole

}
