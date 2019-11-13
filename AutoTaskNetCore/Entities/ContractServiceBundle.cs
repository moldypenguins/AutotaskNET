using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask Service Bundle added to a Recurring Service type contract.<br />
    /// Autotask Service Bundles group multiple Services for purchase.<br />
    /// In Autotask, Administrators create and manage Autotask Service Bundles from the Admin module: Products and Services > Services > Service Bundles.<br />
    /// Service Bundles are added to a Contract when the contract is create or through the Contract Summary view.<br />
    /// <br />
    /// The entity specifies an AdjustedPrice where applicable.<br />
    /// It does not specify the number of units of the service bundle that have been added to the contract.<br />
    /// To add ContractServiceBundle units to the contract, or remove units, use the ContractServiceBundleAdjustment entity.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractServiceBundle : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ContractServiceBundle() : base() { } //end ContractServiceBundle()
        public ContractServiceBundle(net.autotask.webservices.ContractServiceBundle entity) : base(entity)
        {

        } //end ContractServiceBundle(net.autotask.webservices.ContractServiceBundle entity)

        public static implicit operator net.autotask.webservices.ContractServiceBundle(ContractServiceBundle contractservicebundle)
        {
            return new net.autotask.webservices.ContractServiceBundle()
            {
                id = contractservicebundle.id,

            };

        } //end implicit operator net.autotask.webservices.ContractServiceBundle(ContractServiceBundle contractservicebundle)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public long QuoteItemID; //ReadOnly [QuoteItem]
        public double InternalCurrencyUnitPrice; //ReadOnly
        public double InternalCurrencyAdjustedPrice; //ReadOnly

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int ContractID; //ReadOnly Required [Contract]
        public int ServiceBundleID; //ReadOnly Required [ServiceBundle]

        #endregion //ReadOnly Required Fields

        #region Optional Fields

        public double UnitPrice;
        public double AdjustedPrice;
        public string InvoiceDescription; //Length:1000
        public string InternalDescription; //Length:100

        #endregion //Optional Fields

        #endregion //Fields

    } //end ContractServiceBundle

}
