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
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => this.Billed == false;
        public override bool CanQuery => true;
        public override bool CanDelete => this.Billed == false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ProjectCost() : base() { } //end ProjectCost()
        public ProjectCost(net.autotask.webservices.ProjectCost entity) : base(entity)
        {
            this.CostType = int.Parse(entity.CostType.ToString());
            this.DatePurchased = DateTime.Parse(entity.DatePurchased.ToString());
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
            this.ProjectID = int.Parse(entity.ProductID.ToString());
            this.UnitQuantity = double.Parse(entity.UnitQuantity.ToString());
            this.AllocationCodeID = entity.AllocationCodeID == null ? default(long?) : long.Parse(entity.AllocationCodeID.ToString());
            this.BillableAmount = double.Parse(entity.BillableAmount.ToString());
            this.BillableToAccount = entity.BillableAmount == null ? default(bool?) : bool.Parse(entity.BillableAmount.ToString());
            this.Billed = entity.Billed == null ? default(bool?) : bool.Parse(entity.Billed.ToString());
            this.ContractServiceBundleID = long.Parse(entity.ContractServiceBundleID.ToString());
            this.ContractServiceID = long.Parse(entity.ContractServiceID.ToString());
            this.CreateDate = entity.CreateDate == null ? default(DateTime?) : DateTime.Parse(entity.CreateDate.ToString());
            this.CreatorResourceID = long.Parse(entity.CreatorResourceID.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString());
            this.EstimatedCost = double.Parse(entity.EstimatedCost.ToString());
            this.ExtendedCost = double.Parse(entity.ExtendedCost.ToString());
            this.InternalCurrencyBillableAmount = double.Parse(entity.InternalCurrencyBillableAmount.ToString());
            this.InternalCurrencyUnitPrice = double.Parse(entity.InternalCurrencyUnitPrice.ToString());
            this.InternalPurchaseOrderNumber = entity.InternalPurchaseOrderNumber == null ? default(string) : entity.InternalPurchaseOrderNumber.ToString();
            this.ProductID = long.Parse(entity.ProductID.ToString());
            this.PurchaseOrderNumber = entity.PurchaseOrderNumber == null ? default(string) : entity.PurchaseOrderNumber.ToString();
            this.Status = long.Parse(entity.Status.ToString());
            this.StatusLastModifiedBy = long.Parse(entity.StatusLastModifiedBy.ToString());
            this.StatusLastModifiedDate = entity.StatusLastModifiedDate == null ? default(DateTime?) : DateTime.Parse(entity.StatusLastModifiedDate.ToString());
            this.UnitCost = double.Parse(entity.UnitCost.ToString());
            this.UnitPrice = double.Parse(entity.UnitPrice.ToString());
        } //end ProjectCost(net.autotask.webservices.ProjectCost entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public double BillableAmount; //ReadOnly
        public bool? Billed; //ReadOnly
        public DateTime? CreateDate; //ReadOnly
        public long CreatorResourceID; //ReadOnly [Resource]
        public double ExtendedCost; //ReadOnly
        public double InternalCurrencyBillableAmount; //ReadOnly (Multi-currency module only)
        public double InternalCurrencyUnitPrice; //ReadOnly (Multi-currency module only)
        public long Status; //ReadOnly PickList
        public long StatusLastModifiedBy; //ReadOnly
        public DateTime? StatusLastModifiedDate; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public int CostType; //Required PickList
        public DateTime DatePurchased; //Required
        public string Name; //Required Length:100
        public int ProjectID; //Required [Project]
        public double UnitQuantity; //Required

        #endregion //Required Fields

        #region Optional Fields

        public long? AllocationCodeID; //[AllocationCode]
        public bool? BillableToAccount;
        public long ContractServiceBundleID; //[ContractServiceBundle]
        public long ContractServiceID; //[ContractService]
        public string Description; //Length:2000
        public double EstimatedCost;
        public string InternalPurchaseOrderNumber; //Length:50
        public long ProductID; //[Product]
        public string PurchaseOrderNumber; //Length:50
        public double UnitCost;
        public double UnitPrice;

        #endregion //Optional Fields

        #endregion //Fields

    } //end ProjectCost

}
