using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask Inventory module Purchase Order.<br />
    /// Purchase orders allow users to track one or more products ordered and received from Vendor type accounts.<br />
    /// Purchase orders must be submitted(Status = Submitted) before items can be received.<br />
    /// Autotask users create and manage purchase orders from the Inventory module.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class PurchaseOrder : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public PurchaseOrder() : base() { } //end PurchaseOrder()
        public PurchaseOrder(net.autotask.webservices.PurchaseOrder entity) : base(entity)
        {
            this.CancelDateTime = entity.CancelDateTime == null ? default(DateTime?) : DateTime.Parse(entity.CancelDateTime.ToString());
            this.CreateDateTime = entity.CreateDateTime == null ? default(DateTime?) : DateTime.Parse(entity.CreateDateTime.ToString());
            this.CreatorResourceID = entity.CreatorResourceID == null ? default(int?) : int.Parse(entity.CreatorResourceID.ToString());
            this.ExternalPONumber = entity.ExternalPONumber.ToString();
            this.Fax = entity.Fax.ToString();
            this.Freight = double.Parse(entity.Freight.ToString());
            this.GeneralMemo = entity.GeneralMemo.ToString();
            this.LatestEstimatedArrivalDate = entity.LatestEstimatedArrivalDate == null ? default(DateTime?) : DateTime.Parse(entity.LatestEstimatedArrivalDate.ToString());
            this.PaymentTerm = entity.PaymentTerm == null ? default(int?) : int.Parse(entity.PaymentTerm.ToString());
            this.ShippingDate = entity.ShippingDate == null ? default(DateTime?) : DateTime.Parse(entity.CancelDateTime.ToString());
            this.ShippingType = entity.
            this.ShipToAddress1 = entity.ShipToAddress1.ToString();
            this.ShipToAddress2
            this.ShipToCity
            this.ShipToName
            this.ShipToPostalCode
            this.ShipToState
        } //end PurchaseOrder(net.autotask.webservices.PurchaseOrder entity)

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

        public int VendorID { get; set; } //ReadOnly Required [Account]
        public int Status { get; set; } //Required PickList
        public int? CreatorResourceID { get; set; } //ReadOnly [Resource]
        public DateTime? CreateDateTime { get; set; } //ReadOnly
        public DateTime? SubmitDateTime { get; set; } //ReadOnly
        public DateTime? CancelDateTime { get; set; } //ReadOnly
        public string ShipToName { get; set; } //Required Length:100
        public string ShipToAddress1 { get; set; } //Required Length:128
        public string ShipToAddress2 { get; set; } //Length:128
        public string ShipToCity { get; set; } //Required Length:30
        public string ShipToState { get; set; } //Required Length:25
        public string ShipToPostalCode { get; set; } //Required Length:10
        public string GeneralMemo { get; set; } //Length:4000
        public string Phone { get; set; } //Length:25
        public string Fax { get; set; } //Length:25
        public string VendorInvoiceNumber { get; set; } //Length:50
        public string ExternalPONumber { get; set; } //Length:50
        public int? PurchaseForAccountID { get; set; } //[Account]
        public int? ShippingType { get; set; } //[ShippingType]
        public DateTime? ShippingDate { get; set; }
        public double Freight { get; set; }
        public int? TaxGroup { get; set; } //PickList
        public int? PaymentTerm { get; set; } //PickList
        public bool? ShowTaxCategory { get; set; }
        public bool? ShowEachTaxInGroup { get; set; }
        public DateTime? LatestEstimatedArrivalDate { get; set; } //ReadOnly
        public int? UseItemDescriptionsFrom { get; set; } //PickList

    } //end PurchaseOrder

}
