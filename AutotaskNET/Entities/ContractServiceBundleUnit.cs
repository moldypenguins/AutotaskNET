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

        } //end ContractServiceBundleUnit(net.autotask.webservices.ContractServiceBundleUnit entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.ContractServiceBundleUnit()
            {
                id = this.id,

            };

        } //end ToATWS()

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
