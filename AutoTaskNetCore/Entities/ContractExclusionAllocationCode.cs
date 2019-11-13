using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a Work Type billing (or allocation) code that has been excluded from a Contract; that is, time entries associated with the contract cannot use the excluded work type billing code.<br />
    /// If a resource attempts to save a time entry with a work type (or role) that is excluded by the associated contract, a warning message opens.<br />
    /// If the resource continues the save, the time entry is saved without an associated contract, unless a default exclusion contract has been set up (Contract.ExclusionContractID).
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractExclusionAllocationCode : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ContractExclusionAllocationCode() : base() { } //end ContractExclusionAllocationCode()
        public ContractExclusionAllocationCode(net.autotask.webservices.ContractExclusionAllocationCode entity) : base(entity)
        {

        } //end ContractExclusionAllocationCode(net.autotask.webservices.ContractExclusionAllocationCode entity)

        public static implicit operator net.autotask.webservices.ContractExclusionAllocationCode(ContractExclusionAllocationCode contractexclusionallocationcode)
        {
            return new net.autotask.webservices.ContractExclusionAllocationCode()
            {
                id = contractexclusionallocationcode.id,

            };

        } //end implicit operator net.autotask.webservices.ContractExclusionAllocationCode(ContractExclusionAllocationCode contractexclusionallocationcode)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public long ContractID; //ReadOnly Required [Contract]
        public long AllocationCodeID; //ReadOnly Required [AllocationCode]

        #endregion //ReadOnly Required Fields

        #endregion //Fields

    } //end ContractExclusionAllocationCode

}
