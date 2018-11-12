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

        public long PurchaseOrderItemID { get; set; } //ReadOnly Required [PurchaseOrderItem]
        public int? QuantityPreviouslyReceived { get; set; } //ReadOnly
        public int QuantityNowReceiving { get; set; } //ReadOnly Required
        public DateTime? ReceiveDate { get; set; } //ReadOnly
        public int? QuantityBackOrdered { get; set; } //ReadOnly
        public int? ReceivedByResourceID { get; set; } //ReadOnly [Resource]
        public string SerialNumber { get; set; } //ReadOnly Length:50

    } //end PurchaseOrderReceive

}
