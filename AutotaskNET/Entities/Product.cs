using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an instance of hardware, software, or a material item in Autotask that a company sells or supports for customers.<br />
    /// You can "install" Products to customer Accounts and once installed, users can support Products through Ser - vice Desk tickets, bill for products, and manage the products through the customer Account.<br />
    /// With the Autotask Inventory module, Products can be added to inventory as Inventory Items.<br />
    /// <br />
    /// In Autotask, Administrators manage Products through the Admin module: Products and Services > Products > Products.<br />
    /// If the Inventory module is enabled, users with the correct permission can manage Products through Inventory > Manage Products.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity"/>
    class Product : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => true;

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

        public string Name { get; set; } //Required Length:100
        public string Description { get; set; } //Length:2000
        public string SKU { get; set; } //Length:50
        public string Link { get; set; } //Length:500
        public int? ProductCategory { get; set; } //PickList
        public string ExternalProductID { get; set; } //Length:50
        public double UnitCost { get; set; }
        public double UnitPrice { get; set; }
        public double MSRP { get; set; }
        public int? DefaultVendorID { get; set; } //[Account]
        public string VendorProductNumber { get; set; } //Length:50
        public string ManufacturerName { get; set; } //Length:100
        public string ManufacturerProductName { get; set; } //Length:50
        public bool Active { get; set; } //Required
        public string PeriodType { get; set; } //PickList Length:10
        public int ProductAllocationCodeID { get; set; } //Required [AllocationCode]
        public bool Serialized { get; set; } //Required
        public int? CostAllocationCodeID { get; set; } //[AllocationCode]
        public bool? DoesNotRequireProcurement { get; set; }
        public double MarkupRate { get; set; } //ReadOnly
        public string InternalProductID { get; set; } //Length:50

    } //end Product

}
