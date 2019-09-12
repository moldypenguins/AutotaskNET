using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a transaction where a specified quantity of one InventoryItem entity is transferred from the item’s currently assigned InventoryLocation to another InventoryLocation.<br />
    /// It also describes a note added when a user manually updates an inventory item's On Hand quantity.<br />
    /// These "audit" notes may or may not be required.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class InventoryTransfer : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public InventoryTransfer() : base() { } //end InventoryTransfer()
        public InventoryTransfer(net.autotask.webservices.InventoryTransfer entity) : base(entity)
        {

        } //end InventoryTransfer(net.autotask.webservices.InventoryTransfer entity)

        public static implicit operator net.autotask.webservices.InventoryTransfer(InventoryTransfer inventorytransfer)
        {
            return new net.autotask.webservices.InventoryTransfer()
            {
                id = inventorytransfer.id,

            };

        } //end implicit operator net.autotask.webservices.InventoryTransfer(InventoryTransfer inventorytransfer)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public int? TransferByResourceID { get; set; } //ReadOnly [Resource]
        public DateTime? TransferDate { get; set; } //ReadOnly
        public string Notes { get; set; } //ReadOnly Length:4000
        public string SerialNumber { get; set; } //ReadOnly Length:100
        public string UpdateNote { get; set; } //ReadOnly Length:500

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public long ProductID { get; set; } //ReadOnly Required [Product]
        public long FromLocationID { get; set; } //ReadOnly Required [InventoryLocation]
        public long ToLocationID { get; set; } //ReadOnly Required [InventoryLocation]
        public int QuantityTransferred { get; set; } //ReadOnly Required

        #endregion //ReadOnly Required Fields

        #endregion //Fields

    } //end InventoryTransfer

}
