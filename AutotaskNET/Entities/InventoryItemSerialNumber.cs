using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a serial number associated with an Inventory Item.<br />
    /// It allows users to track and manage Inventory Items created from serialized Products, that is, Autotask Products that require a unique serial number.<br />
    /// An InventoryItemSerialNumber entity can be associated with only one InventoryItem.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class InventoryItemSerialNumber : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public InventoryItemSerialNumber() : base() { } //end InventoryItemSerialNumber()
        public InventoryItemSerialNumber(net.autotask.webservices.InventoryItemSerialNumber entity) : base(entity)
        {
            this.InventoryItemID = long.Parse(entity.InventoryItemID.ToString());
            this.SerialNumber = entity.SerialNumber == null ? default(string) : entity.SerialNumber.ToString();
        } //end InventoryItemSerialNumber(net.autotask.webservices.InventoryItemSerialNumber entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public long InventoryItemID; //ReadOnly Required [InventoryItem]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public string SerialNumber; //Required Length:100

        #endregion //Required Fields

        #endregion //Fields

    } //end InventoryItemSerialNumber

}
