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
        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Required Fields

        public long ContractID { get; set; } //ReadOnly Required [Contract]
        public long AllocationCodeID { get; set; } //ReadOnly Required [AllocationCode]

        #endregion //ReadOnly Required Fields

    } //end ContractExclusionAllocationCode

}
