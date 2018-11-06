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
        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => false;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region Required Fields

        public DateTime EffectiveDate { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public int? ContractID { get; set; } //[Contract]
        public int? ServiceID { get; set; } //[Service]
        public int? UnitChange { get; set; }
        public double AdjustedUnitPrice { get; set; }
        public double AdjustedUnitCost { get; set; }
        public int? QuoteItemID { get; set; } //[QuoteItem]
        public int? ContractServiceID { get; set; } //[ContractService]
        public bool? AllowRepeatService { get; set; }

        #endregion //Optional Fields
        
    } //end ContractServiceAdjustment
}
