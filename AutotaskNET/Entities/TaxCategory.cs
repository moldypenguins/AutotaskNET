using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The TaxCategory entity describes the tax rate for a specific billing item.<br />
    /// A TaxCategory associated with a TaxRegion determines the tax charged to customers.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TaxCategory : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region Required Fields

        public string Name { get; set; } //Required Length:200

        #endregion //Required Fields

        #region Optional Fields

        public string Description { get; set; } //Length:200
        public bool? Active { get; set; }

        #endregion //Optional Fields
        
    } //end TaxCategory

}
