using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The ContractMilestone entity describes a billing milestone for an Autotask Fixed Price Contract.<br />
    /// Billing milestones describe tangible work or measured progress that must be completed before billing can take place, for example, "user approval on design specifications", or "ten workstations installed".<br />
    /// A fixed price contract can have multiple billing milestones.<br />
    /// In Autotask, you add and manage contract milestones from the Fixed Price Contract's Summary page.     /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractMilestone : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields

        public DateTime? CreateDate { get; set; } //ReadOnly
        public int? CreatorResourceID { get; set; } //ReadOnly [Resource]
        public double InternalCurrencyAmount { get; set; } //ReadOnly
        public int? BusinessDivisionSubdivisionID { get; set; } //ReadOnly [BusinessDivisionSubdivision]

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int ContractID { get; set; } //ReadOnly Required [Contract]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public int Status { get; set; } //Required PickList
        public DateTime DateDue { get; set; } //Required
        public double Amount { get; set; } //Required
        public string Title { get; set; } //Required Length:50
        public bool IsInitialPayment { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public string Description { get; set; } //Length:250
        public int? AllocationCodeID { get; set; } //[AllocationCode]

        #endregion //Optional Fields
        
    } //end ContractMilestone

}
