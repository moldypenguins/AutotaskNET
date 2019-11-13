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

        } //end ContractCost(net.autotask.webservices.ContractCost entity)

        public static implicit operator net.autotask.webservices.ContractCost(ContractCost contractcost)
        {
            return new net.autotask.webservices.ContractCost()
            {
                id = contractcost.id,

            };

        } //end implicit operator net.autotask.webservices.ContractCost(ContractCost contractcost)

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
