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
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => this.Billed == false;
        public override bool CanQuery => true;
        public override bool CanDelete => this.Billed == false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ContractCost() : base() { } //end ContractCost()
        public ContractCost(net.autotask.webservices.ContractCost entity) : base(entity)
        {
            this.ContractID = long.Parse(entity.ContractID.ToString());
            this.CostType = int.Parse(entity.CostType.ToString());
            this.DatePurchased = DateTime.Parse(entity.DatePurchased.ToString());
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
            this.UnitQuantity = double.Parse(entity.UnitQuantity.ToString());
            this.AllocationCodeID = long.Parse(entity.AllocationCodeID.ToString());
            this.BillableAmount = double.Parse(entity.BillableAmount.ToString());
            this.BillableToAccount = entity.BillableToAccount == null ? default(bool?) : bool.Parse(entity.BillableToAccount.ToString());
            this.Billed = entity.Billed == null ? default(bool?) : bool.Parse(entity.Billed.ToString());
            this.ContractServiceBundleID = long.Parse(entity.ContractServiceBundleID.ToString());
            this.ContractServiceID = long.Parse(entity.ContractServiceID.ToString());
            this.CreateDate = entity.CreateDate == null ? default(DateTime?) : DateTime.Parse(entity.CreateDate.ToString()));
            this.CreatorResourceID = long.Parse(entity.CreatorResourceID.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
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
        } //end ContractCost(net.autotask.webservices.ContractCost entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public double ExtendedCost; //ReadOnly
        public double BillableAmount; //ReadOnly
        public bool? Billed; //ReadOnly
        public long Status; //ReadOnly PickList
        public long StatusLastModifiedBy; //ReadOnly
        public DateTime? StatusLastModifiedDate; //ReadOnly
        public DateTime? CreateDate; //ReadOnly
        public long CreatorResourceID; //ReadOnly [Resource]
        public double InternalCurrencyBillableAmount; //ReadOnly
        public double InternalCurrencyUnitPrice; //ReadOnly
        public int? BusinessDivisionSubdivisionID; //ReadOnly [BusinessDivisionSubdivision]

        #endregion //ReadOnly Fields

        #region Required Fields

        public long ContractID; //Required [Contract]
        public string Name; //Required Length:100
        public DateTime DatePurchased; //Required
        public int CostType; //Required PickList
        public double UnitQuantity; //Required

        #endregion //Required Fields

        #region Optional Fields

        public long ProductID; //[Product]
        public long AllocationCodeID; //[AllocationCode]
        public string Description; //Length:2000
        public string PurchaseOrderNumber; //Length:50
        public string InternalPurchaseOrderNumber; //Length:50
        public double UnitCost;
        public double UnitPrice;
        public bool? BillableToAccount;
        public long ContractServiceID; //[ContractService]
        public long ContractServiceBundleID; //[ContractServiceBundle]

        #endregion //Optional Fields

        #endregion //Fields

    } //end ContractCost

}
