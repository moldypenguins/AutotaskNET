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

        } //end ProjectCost(net.autotask.webservices.ProjectCost entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.ProjectCost()
            {
                id = this.id,

            };

        } //end ToATWS()

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
