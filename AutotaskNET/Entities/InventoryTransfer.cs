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
            this.FromLocationID = long.Parse(entity.FromLocationID.ToString());
            this.ProductID = long.Parse(entity.ProductID.ToString());
            this.QuantityTransferred = int.Parse(entity.QuantityTransferred.ToString());
            this.ToLocationID = long.Parse(entity.ToLocationID.ToString());
            this.Notes = entity.Notes == null ? default(string) : entity.Notes.ToString();
            this.SerialNumber = entity.SerialNumber == null ? default(string) : entity.SerialNumber.ToString();
            this.TransferByResourceID = entity.TransferByResourceID == null ? default(int?) : int.Parse(entity.TransferByResourceID.ToString());
            this.TransferDate = entity.TransferDate == null ? default(DateTime?) : DateTime.Parse(entity.TransferDate.ToString());
            this.UpdateNote = entity.UpdateNote == null ? default(string) : entity.UpdateNote.ToString();
        } //end InventoryTransfer(net.autotask.webservices.InventoryTransfer entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public int? TransferByResourceID; //ReadOnly [Resource]
        public DateTime? TransferDate; //ReadOnly
        public string Notes; //ReadOnly Length:4000
        public string SerialNumber; //ReadOnly Length:100
        public string UpdateNote; //ReadOnly Length:500

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public long ProductID; //ReadOnly Required [Product]
        public long FromLocationID; //ReadOnly Required [InventoryLocation]
        public long ToLocationID; //ReadOnly Required [InventoryLocation]
        public int QuantityTransferred; //ReadOnly Required

        #endregion //ReadOnly Required Fields

        #endregion //Fields

    } //end InventoryTransfer

}
