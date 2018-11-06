using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask Inventory Location, that is, a physical or virtual place where your company stores or assigns inventory items.<br />
    /// For example, an Inventory location can be an actual warehouse or retail outlet, or a virtual holding place such as "Lost Items" or "Returned Items".<br />
    /// Every Inventory Item must be associated with an Inventory Location.<br />
    /// You assign a Location to Inventory Items when you add the items to inventory or to a purchase order.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class InventoryLocation : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields

        public int? ResourceID { get; set; } //ReadOnly [Resource]

        #endregion //ReadOnly Fields

        #region Required Fields

        public string LocationName { get; set; } //Required Length:50
        public bool Active { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public bool? IsDefault { get; set; }

        #endregion //Optional Fields
        
    } //end InventoryLocation
}
