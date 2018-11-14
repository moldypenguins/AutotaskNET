using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask Service that has been added to a Recurring Service type contract.<br />
    /// In Autotask, users add and manage Autotask Services from the Admin module: Products and Services > Services > Services.<br />
    /// You add Services to a Contract when your create the contract or from the Contract Summary page.<br />
    /// <br />
    /// The entity specifies an AdjustedPrice if applicable.<br />
    /// It does not specify the number of units of the service that have been added to the contract.<br />
    /// To add Contract Service units to the contract, or remove units, use the ContractServiceAdjustment entity.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractService : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ContractService() : base() { } //end ContractService()
        public ContractService(net.autotask.webservices.ContractService entity) : base(entity)
        {

        } //end ContractService(net.autotask.webservices.ContractService entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.ContractService()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public double UnitPrice; //ReadOnly
        public long QuoteItemID; //ReadOnly [QuoteItem]
        public double InternalCurrencyUnitPrice; //ReadOnly
        public double InternalCurrencyAdjustedPrice; //ReadOnly

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int ContractID; //ReadOnly Required [Contract]
        public int ServiceID; //ReadOnly Required [Service]

        #endregion //ReadOnly Required Fields

        #region Optional Fields

        public double AdjustedPrice;
        public string InvoiceDescription; //Length:1000
        public string InternalDescription; //Length:100
        public double UnitCost;

        #endregion //Optional Fields

        #endregion //Fields

    } //end ContractService

}
