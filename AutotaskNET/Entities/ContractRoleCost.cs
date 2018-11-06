using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a per hour cost for labor that is set at the contract level.<br />
    /// This cost overrides a resource's Admin level internal cost rate for time entries posted against the contract.<br />
    /// Time entry dates must fall within the active dates of the contract.<br />
    /// The cost rate is associated with a resource and a role.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractRoleCost : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Required Fields

        public int ContractID { get; set; } //ReadOnly Required [Contract]
        public int ResourceID { get; set; } //ReadOnly Required [Resource]
        public int RoleID { get; set; } //ReadOnly Required [Role]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public double Rate { get; set; } //Required

        #endregion //Required Fields
        
    } //end ContractRoleCost

}
