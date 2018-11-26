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
            this.InventoryLocationID = int.Parse(entity.InventoryLocationID.ToString());
            this.ProductID = int.Parse(entity.ProductID.ToString());
            this.QuantityMaximum = int.Parse(entity.QuantityMaximum.ToString());
            this.QuantityMinimum = int.Parse(entity.QuantityMinimum.ToString());
            this.QuantityOnHand = int.Parse(entity.QuantityOnHand.ToString());
            this.BackOrder = entity.BackOrder == null ? default(int?) : int.Parse(entity.BackOrder.ToString());
            this.Bin = entity.Bin == null ? default(string) : entity.Bin.ToString();
            this.OnOrder = entity.OnOrder == null ? default(int?) : int.Parse(entity.OnOrder.ToString());
            this.Picked = entity.Picked == null ? default(int?) : int.Parse(entity.Picked.ToString());
            this.ReferenceNumber = entity.ReferenceNumber == null ? default(string) : entity.ReferenceNumber.ToString();
            this.Reserved = entity.Reserved == null ? default(int?) : int.Parse(entity.Reserved.ToString());
        } //end InventoryItem(net.autotask.webservices.InventoryItem entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public int? OnOrder; //ReadOnly
        public int? BackOrder; //ReadOnly
        public int? Reserved; //ReadOnly
        public int? Picked; //ReadOnly

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int ProductID; //ReadOnly Required [Product]
        public int InventoryLocationID; //ReadOnly Required [InventoryLocation]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public int QuantityOnHand; //Required
        public int QuantityMinimum; //Required
        public int QuantityMaximum; //Required

        #endregion //Required Fields

        #region Optional Fields

        public string ReferenceNumber; //Length:50
        public string Bin; //Length:50

        #endregion //Optional Fields

        #endregion //Fields

    } //end InventoryItem

}
