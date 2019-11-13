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
            this.ExternalPONumber = entity.ExternalPONumber == null ? default(string) : entity.ExternalPONumber.ToString();
            this.Fax = entity.Fax == null ? default(string) : entity.Fax.ToString();
            this.Freight = double.Parse(entity.Freight.ToString());
            this.GeneralMemo = entity.GeneralMemo == null ? default(string) : entity.GeneralMemo.ToString();
            this.LatestEstimatedArrivalDate = entity.LatestEstimatedArrivalDate == null ? default(DateTime?) : DateTime.Parse(entity.LatestEstimatedArrivalDate.ToString());
            this.PaymentTerm = entity.PaymentTerm == null ? default(int?) : int.Parse(entity.PaymentTerm.ToString());
            this.Phone = entity.Phone == null ? default(string) : entity.Phone.ToString();
            this.PurchaseForAccountID = entity.PurchaseForAccountID == null ? default(int?) : int.Parse(entity.PurchaseForAccountID.ToString());
            this.ShippingDate = entity.ShippingDate == null ? default(DateTime?) : DateTime.Parse(entity.ShippingDate.ToString());
            this.ShippingType = entity.ShippingType == null ? default(int?) : int.Parse(entity.ShippingType.ToString());
            this.ShipToAddress1 = entity.ShipToAddress1 == null ? default(string) : entity.ShipToAddress1.ToString();
            this.ShipToAddress2 = entity.ShipToAddress2 == null ? default(string) : entity.ShipToAddress2.ToString();
            this.ShipToCity = entity.ShipToCity == null ? default(string) : entity.ShipToCity.ToString();
            this.ShipToName = entity.ShipToName == null ? default(string) : entity.ShipToName.ToString();
            this.ShipToPostalCode = entity.ShipToPostalCode == null ? default(string) : entity.ShipToPostalCode.ToString();
            this.ShipToState = entity.ShipToState == null ? default(string) : entity.ShipToState.ToString();
            this.ShowEachTaxInGroup = entity.ShowEachTaxInGroup == null ? default(bool?) : bool.Parse(entity.ShowEachTaxInGroup.ToString());
            this.ShowTaxCategory = entity.ShowTaxCategory == null ? default(bool?) : bool.Parse(entity.ShowTaxCategory.ToString());
            this.Status = int.Parse(entity.Status.ToString());
            this.SubmitDateTime = entity.SubmitDateTime == null ? default(DateTime?) : DateTime.Parse(entity.SubmitDateTime.ToString());
            this.TaxGroup = entity.TaxGroup == null ? default(int?) : int.Parse(entity.TaxGroup.ToString());
            this.UseItemDescriptionsFrom = entity.UseItemDescriptionsFrom == null ? default(int?) : int.Parse(entity.UseItemDescriptionsFrom.ToString());
            this.VendorID = int.Parse(entity.VendorID.ToString());
            this.VendorInvoiceNumber = entity.VendorInvoiceNumber == null ? default(string) : entity.VendorInvoiceNumber.ToString();
        } //end PurchaseOrder(net.autotask.webservices.PurchaseOrder entity)

        public static implicit operator net.autotask.webservices.PurchaseOrder(PurchaseOrder purchaseorder)
        {
            return new net.autotask.webservices.PurchaseOrder()
            {
                id = purchaseorder.id,

            };

        } //end implicit operator net.autotask.webservices.PurchaseOrder(PurchaseOrder purchaseorder)

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

        public int VendorID; //ReadOnly Required [Account]
        public int Status; //Required PickList
        public int? CreatorResourceID; //ReadOnly [Resource]
        public DateTime? CreateDateTime; //ReadOnly
        public DateTime? SubmitDateTime; //ReadOnly
        public DateTime? CancelDateTime; //ReadOnly
        public string ShipToName; //Required Length:100
        public string ShipToAddress1; //Required Length:128
        public string ShipToAddress2; //Length:128
        public string ShipToCity; //Required Length:30
        public string ShipToState; //Required Length:25
        public string ShipToPostalCode; //Required Length:10
        public string GeneralMemo; //Length:4000
        public string Phone; //Length:25
        public string Fax; //Length:25
        public string VendorInvoiceNumber; //Length:50
        public string ExternalPONumber; //Length:50
        public int? PurchaseForAccountID; //[Account]
        public int? ShippingType; //[ShippingType]
        public DateTime? ShippingDate;
        public double Freight;
        public int? TaxGroup; //PickList
        public int? PaymentTerm; //PickList
        public bool? ShowTaxCategory;
        public bool? ShowEachTaxInGroup;
        public DateTime? LatestEstimatedArrivalDate; //ReadOnly
        public int? UseItemDescriptionsFrom; //PickList

    } //end PurchaseOrder

}
