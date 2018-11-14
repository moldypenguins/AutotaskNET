using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a billing Role that has been excluded from a Contract; that is, time entries associated with the contract cannot use the excluded role.<br />
    /// If a resource attempts to save a time entry with a role that is excluded by the associated contract, a warning message opens.<br />
    /// If the resource continues the save, the time entry is saved without an associated contract, unless a default exclusion contract has been set up (Contract.ExclusionContractID).
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractExclusionRole : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ContractExclusionRole() : base() { } //end ContractExclusionRole()
        public ContractExclusionRole(net.autotask.webservices.ContractExclusionRole entity) : base(entity)
        {

        } //end ContractExclusionRole(net.autotask.webservices.ContractExclusionRole entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.ContractExclusionRole()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public long ContractID; //ReadOnly Required [Contract]
        public long RoleID; //ReadOnly Required [Role]

        #endregion //ReadOnly Required Fields

        #endregion //Fields

    } //end ContractExclusionRole

}
