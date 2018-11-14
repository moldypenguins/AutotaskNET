using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an adjustment to the quantity of units of a ContractService entity that are added to a Recurring Service type Contract.<br />
    /// It can only be created; it CANNOT be queried or updated.<br />
    /// Changes made to the Contract using the ContractServiceAdjustment entity affect only the quantity of units and not price/adjusted price of the Service.<br />
    /// <br />
    /// In Autotask, users specify the number of Service Units associated with a Contract through the Contracts module when creating or managing a Recurring Service type Contract: Contracts module > Contracts > New Recurring Service Contract, or Contracts module > Contracts > Search Contracts > Open Contract > Services.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractServiceAdjustment : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => false;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ContractServiceAdjustment() : base() { } //end ContractServiceAdjustment()
        public ContractServiceAdjustment(net.autotask.webservices.ContractServiceAdjustment entity) : base(entity)
        {

        } //end ContractServiceAdjustment(net.autotask.webservices.ContractServiceAdjustment entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.ContractServiceAdjustment()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public DateTime EffectiveDate; //Required

        #endregion //Required Fields

        #region Optional Fields

        public int? ContractID; //[Contract]
        public int? ServiceID; //[Service]
        public int? UnitChange;
        public double AdjustedUnitPrice;
        public double AdjustedUnitCost;
        public int? QuoteItemID; //[QuoteItem]
        public int? ContractServiceID; //[ContractService]
        public bool? AllowRepeatService;

        #endregion //Optional Fields

        #endregion //Fields

    } //end ContractServiceAdjustment
}
