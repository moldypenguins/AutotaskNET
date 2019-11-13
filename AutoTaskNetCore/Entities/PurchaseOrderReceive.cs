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

        } //end PurchaseOrderReceive(net.autotask.webservices.PurchaseOrderReceive entity)

        public static implicit operator net.autotask.webservices.PurchaseOrderReceive(PurchaseOrderReceive purchaseorderreceive)
        {
            return new net.autotask.webservices.PurchaseOrderReceive()
            {
                id = purchaseorderreceive.id,

            };

        } //end implicit operator net.autotask.webservices.PurchaseOrderReceive(PurchaseOrderReceive purchaseorderreceive)

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

        #endregion //Fields

        public long PurchaseOrderItemID; //ReadOnly Required [PurchaseOrderItem]
        public int? QuantityPreviouslyReceived; //ReadOnly
        public int QuantityNowReceiving; //ReadOnly Required
        public DateTime? ReceiveDate; //ReadOnly
        public int? QuantityBackOrdered; //ReadOnly
        public int? ReceivedByResourceID; //ReadOnly [Resource]
        public string SerialNumber; //ReadOnly Length:50

    } //end PurchaseOrderReceive

}
