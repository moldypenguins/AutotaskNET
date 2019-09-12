using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask product that is associated with an Inventory Location in the Autotask Inventory module.<br />
    /// Once an InventoryItem entity has been created, you can track quantities for that item (quantity on hand, quantity on order) and provide a value for minimum and maximum quantity for use with the Auto-Fill Order feature.<br />
    /// You can assign serial numbers to instances of InventoryItems, add them to purchase orders, and “receive” them.<br />
    /// You can also transfer them between inventory locations or associate them with an account.<br />
    /// Inventory items are added and managed in Autotask through the Inventory module.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class InventoryItem : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public InventoryItem() : base() { } //end InventoryItem()
        public InventoryItem(net.autotask.webservices.InventoryItem entity) : base(entity)
        {

        } //end InventoryItem(net.autotask.webservices.InventoryItem entity)

        public static implicit operator net.autotask.webservices.InventoryItem(InventoryItem inventoryitem)
        {
            return new net.autotask.webservices.InventoryItem()
            {
                id = inventoryitem.id,

            };

        } //end implicit operator net.autotask.webservices.InventoryItem(InventoryItem inventoryitem)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public int? OnOrder { get; set; } //ReadOnly
        public int? BackOrder { get; set; } //ReadOnly
        public int? Reserved { get; set; } //ReadOnly
        public int? Picked { get; set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int ProductID { get; set; } //ReadOnly Required [Product]
        public int InventoryLocationID { get; set; } //ReadOnly Required [InventoryLocation]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public int QuantityOnHand { get; set; } //Required
        public int QuantityMinimum { get; set; } //Required
        public int QuantityMaximum { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public string ReferenceNumber { get; set; } //Length:50
        public string Bin { get; set; } //Length:50

        #endregion //Optional Fields

        #endregion //Fields

    } //end InventoryItem

}
