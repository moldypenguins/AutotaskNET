using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a cost associated with an Autotask Contract.<br />
    /// A cost is a billing item for products or materials.<br />
    /// Cost items can be billable or non-billable.Billable cost items appear in Approve and Post.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractCost : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => this.Billed == false;
        public override bool CanQuery => true;
        public override bool CanDelete => this.Billed == false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields

        public double ExtendedCost { get; set; } //ReadOnly
        public double BillableAmount { get; set; } //ReadOnly
        public bool? Billed { get; set; } //ReadOnly
        public long Status { get; set; } //ReadOnly PickList
        public long StatusLastModifiedBy { get; set; } //ReadOnly
        public DateTime? StatusLastModifiedDate { get; set; } //ReadOnly
        public DateTime? CreateDate { get; set; } //ReadOnly
        public long CreatorResourceID { get; set; } //ReadOnly [Resource]
        public double InternalCurrencyBillableAmount { get; set; } //ReadOnly
        public double InternalCurrencyUnitPrice { get; set; } //ReadOnly
        public int? BusinessDivisionSubdivisionID { get; set; } //ReadOnly [BusinessDivisionSubdivision]

        #endregion //ReadOnly Fields

        #region Required Fields

        public long ContractID { get; set; } //Required [Contract]
        public string Name { get; set; } //Required Length:100
        public DateTime DatePurchased { get; set; } //Required
        public int CostType { get; set; } //Required PickList
        public double UnitQuantity { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public long ProductID { get; set; } //[Product]
        public long AllocationCodeID { get; set; } //[AllocationCode]
        public string Description { get; set; } //Length:2000
        public string PurchaseOrderNumber { get; set; } //Length:50
        public string InternalPurchaseOrderNumber { get; set; } //Length:50
        public double UnitCost { get; set; }
        public double UnitPrice { get; set; }
        public bool? BillableToAccount { get; set; }
        public long ContractServiceID { get; set; } //[ContractService]
        public long ContractServiceBundleID { get; set; } //[ContractServiceBundle]

        #endregion //Optional Fields
        
    } //end ContractCost

}
