using System;

/*
 * NEEDS TO BE REVIEWED
 */

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a cost associated with an Autotask Project.<br />
    /// A cost is a billing item for products or materials.<br />
    /// Cost items can be billable or non-billable.<br />
    /// Billable cost items appear in Approve and Post.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ProjectCost : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => this.Billed == false;
        public override bool CanQuery => true;
        public override bool CanDelete => this.Billed == false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields

        public double BillableAmount { get; set; } //ReadOnly
        public bool? Billed { get; set; } //ReadOnly
        public DateTime? CreateDate { get; set; } //ReadOnly
        public long CreatorResourceID { get; set; } //ReadOnly [Resource]
        public double ExtendedCost { get; set; } //ReadOnly
        public double InternalCurrencyBillableAmount { get; set; } //ReadOnly (Multi-currency module only)
        public double InternalCurrencyUnitPrice { get; set; } //ReadOnly (Multi-currency module only)
        public long Status { get; set; } //ReadOnly PickList
        public long StatusLastModifiedBy { get; set; } //ReadOnly
        public DateTime? StatusLastModifiedDate { get; set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public int CostType { get; set; } //Required PickList
        public DateTime DatePurchased { get; set; } //Required
        public string Name { get; set; } //Required Length:100
        public int ProjectID { get; set; } //Required [Project]
        public double UnitQuantity { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public long? AllocationCodeID { get; set; } //[AllocationCode]
        public bool? BillableToAccount { get; set; }
        public long ContractServiceBundleID { get; set; } //[ContractServiceBundle]
        public long ContractServiceID { get; set; } //[ContractService]
        public string Description { get; set; } //Length:2000
        public double EstimatedCost { get; set; }
        public string InternalPurchaseOrderNumber { get; set; } //Length:50
        public long ProductID { get; set; } //[Product]
        public string PurchaseOrderNumber { get; set; } //Length:50
        public double UnitCost { get; set; }
        public double UnitPrice { get; set; }

        #endregion //Optional Fields

    } //end ProjectCost

}
