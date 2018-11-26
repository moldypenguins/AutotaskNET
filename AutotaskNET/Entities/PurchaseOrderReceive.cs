using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class PurchaseOrderReceive : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public PurchaseOrderReceive() : base() { } //end PurchaseOrderReceive()
        public PurchaseOrderReceive(net.autotask.webservices.PurchaseOrderReceive entity) : base(entity)
        {
            this.PurchaseOrderItemID = long.Parse(entity.PurchaseOrderItemID.ToString());
            this.QuantityBackOrdered = entity.QuantityBackOrdered == null ? default(int?) : int.Parse(entity.QuantityBackOrdered.ToString());
            this.QuantityNowReceiving = int.Parse(entity.QuantityNowReceiving.ToString());
            this.QuantityPreviouslyReceived = entity.QuantityPreviouslyReceived == null ? default(int?) : int.Parse(entity.QuantityPreviouslyReceived.ToString());
            this.ReceiveDate = entity.ReceiveDate == null ? default(DateTime?) : DateTime.Parse(entity.ReceiveDate.ToString());
            this.ReceivedByResourceID = entity.ReceivedByResourceID == null ? default(int?) : int.Parse(entity.ReceivedByResourceID.ToString());
            this.SerialNumber = entity.SerialNumber == null ? default(string) : entity.SerialNumber.ToString();
        } //end PurchaseOrderReceive(net.autotask.webservices.PurchaseOrderReceive entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

        public long PurchaseOrderItemID; //ReadOnly Required [PurchaseOrderItem]
        public int? QuantityPreviouslyReceived; //ReadOnly
        public int QuantityNowReceiving; //ReadOnly Required
        public DateTime? ReceiveDate; //ReadOnly
        public int? QuantityBackOrdered; //ReadOnly
        public int? ReceivedByResourceID; //ReadOnly [Resource]
        public string SerialNumber; //ReadOnly Length:50

        #endregion //Fields

    } //end PurchaseOrderReceive

}
