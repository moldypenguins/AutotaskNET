using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes the number of units of a specific service that are associated with a Recurring Service contract for a specific date range.They provide information used in billing for the service bundle.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractServiceUnit : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ContractServiceUnit() : base() { } //end ContractServiceUnit()
        public ContractServiceUnit(net.autotask.webservices.ContractServiceUnit entity) : base(entity)
        {

        } //end ContractServiceUnit(net.autotask.webservices.ContractServiceUnit entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.ContractServiceUnit()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public float Price; //ReadOnly
        public DateTime? ApproveAndPostDate; //ReadOnly
        public float Cost; //ReadOnly
        public int? VendorAccountID; //ReadOnly [Account]
        public float InternalCurrencyPrice; //ReadOnly
        public int? BusinessDivisionSubdivisionID; //ReadOnly [BusinessDivisionSubdivision]

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int ContractID; //ReadOnly Required [Contract]
        public int ServiceID; //ReadOnly Required [Service]
        public DateTime StartDate; //ReadOnly Required
        public DateTime EndDate; //ReadOnly Required
        public int Units; //ReadOnly Required

        #endregion //ReadOnly Required Fields

        #region Optional Fields

        public int? ContractServiceID; //[ContractService]

        #endregion //Optional Fields

        #endregion //Fields

    } //end ContractServiceUnit

}
