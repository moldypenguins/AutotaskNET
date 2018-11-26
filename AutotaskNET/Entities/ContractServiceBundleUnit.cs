using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes the number of units of a specific service bundle that are associated with a Recurring Service contract for a specific date range.They provide information used in billing for the service bundle.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractServiceBundleUnit : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ContractServiceBundleUnit() : base() { } //end ContractServiceBundleUnit()
        public ContractServiceBundleUnit(net.autotask.webservices.ContractServiceBundleUnit entity) : base(entity)
        {
            this.ContractID = int.Parse(entity.ContractID.ToString());
            this.EndDate = DateTime.Parse(entity.EndDate.ToString());
            this.ServiceBundleID = int.Parse(entity.ServiceBundleID.ToString());
            this.StartDate = DateTime.Parse(entity.StartDate.ToString());
            this.Units = int.Parse(entity.Units.ToString());
            this.ApproveAndPostDate = entity.ApproveAndPostDate == null ? default(DateTime?) : DateTime.Parse(entity.ApproveAndPostDate.ToString());
            this.ContractServiceBundleID = entity.ContractServiceBundleID == null ? default(int?) : int.Parse(entity.ContractServiceBundleID.ToString());
            this.Cost= double.Parse(entity.Cost.ToString());
            this.InternalCurrencyPrice = double.Parse(entity.InternalCurrencyPrice.ToString());
            this.Price = double.Parse(entity.Price.ToString());
        } //end ContractServiceBundleUnit(net.autotask.webservices.ContractServiceBundleUnit entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public double Price; //ReadOnly
        public DateTime? ApproveAndPostDate; //ReadOnly
        public double Cost; //ReadOnly
        public int? ContractServiceBundleID; //ReadOnly [ContractServiceBundle]
        public double InternalCurrencyPrice; //ReadOnly
        public int? BusinessDivisionSubdivisionID; //ReadOnly [BusinessDivisionSubdivision]

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int ContractID; //ReadOnly Required [Contract]
        public int ServiceBundleID; //ReadOnly Required [ServiceBundle]
        public DateTime StartDate; //ReadOnly Required
        public DateTime EndDate; //ReadOnly Required
        public int Units; //ReadOnly Required

        #endregion //ReadOnly Required Fields

        #endregion //Fields

    } //end ContractServiceBundleUnit

}
