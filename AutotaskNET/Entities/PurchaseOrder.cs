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
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

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
