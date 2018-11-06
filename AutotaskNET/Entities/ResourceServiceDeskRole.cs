using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a Resource - Service Desk Role association.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ResourceServiceDeskRole : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Required Fields

        public int ResourceID { get; set; } //ReadOnly Required [Resource]

        #endregion //ReadOnly Required Fields

        #region Obsolete Fields

        public bool? Active { get; set; } //(Obsolete)
        public bool? Default { get; set; } //(Obsolete)
        public int RoleID { get; set; } //Required [Role] (Obsolete)

        #endregion //Obsolete Fields
        
    } //end ResourceServiceDeskRole

}
