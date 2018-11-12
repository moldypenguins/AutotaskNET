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

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public long QuoteItemID { get; set; } //ReadOnly [QuoteItem]
        public double InternalCurrencyUnitPrice { get; set; } //ReadOnly
        public double InternalCurrencyAdjustedPrice { get; set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int ContractID { get; set; } //ReadOnly Required [Contract]
        public int ServiceBundleID { get; set; } //ReadOnly Required [ServiceBundle]

        #endregion //ReadOnly Required Fields

        #region Optional Fields

        public double UnitPrice { get; set; }
        public double AdjustedPrice { get; set; }
        public string InvoiceDescription { get; set; } //Length:1000
        public string InternalDescription { get; set; } //Length:100

        #endregion //Optional Fields

        #endregion //Fields

    } //end ContractServiceBundle

}
