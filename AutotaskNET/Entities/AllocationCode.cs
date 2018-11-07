using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The AllocationCode entity describes an Autotask Allocation Code. An allocation code represents a billing item category.<br />
    /// There are six types of allocation codes: Work Types, Material, Internal Time, Expense Categories, Recurring Contract Service, and Milestone.<br />
    /// Administrators add and manage allocation codes through the Admin module(Admin >Site Setup > Billing Codes).
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class AllocationCode : Entity
    {
        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields

        public double MarkupRate; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public bool Active { get; set; } //Required
        public double UnitCost { get; set; } //Required
        public double UnitPrice { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public int? GeneralLedgerCode { get; set; } //PickList
        public int? Department { get; set; }
        public string Name { get; set; } //Length:200
        public string ExternalNumber { get; set; } //Length:100
        public int? Type { get; set; } //PickList
        public int? UseType { get; set; } //PickList
        public string Description { get; set; } //Length:500
        public int? AllocationCodeType { get; set; } //PickList
        public bool? Taxable { get; set; }
        public int? TaxCategoryID { get; set; } //[TaxCategory]
        public bool? IsExcludedFromNewContracts { get; set; }

        #endregion //Optional Fields
        
    } //end AllocationCode

}
