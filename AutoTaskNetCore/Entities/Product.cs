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
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => true;

        #endregion //Properties

        #region Constructors

        public Product() : base() { } //end Product()
        public Product(net.autotask.webservices.Product entity) : base(entity)
        {

        } //end Product(net.autotask.webservices.Product entity)

        public static implicit operator net.autotask.webservices.Product(Product product)
        {
            return new net.autotask.webservices.Product()
            {
                id = product.id,

            };

        } //end implicit operator net.autotask.webservices.Product(Product product)

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

        public string Name; //Required Length:100
        public string Description; //Length:2000
        public string SKU; //Length:50
        public string Link; //Length:500
        public int? ProductCategory; //PickList
        public string ExternalProductID; //Length:50
        public double UnitCost;
        public double UnitPrice;
        public double MSRP;
        public int? DefaultVendorID; //[Account]
        public string VendorProductNumber; //Length:50
        public string ManufacturerName; //Length:100
        public string ManufacturerProductName; //Length:50
        public bool Active; //Required
        public string PeriodType; //PickList Length:10
        public int ProductAllocationCodeID; //Required [AllocationCode]
        public bool Serialized; //Required
        public int? CostAllocationCodeID; //[AllocationCode]
        public bool? DoesNotRequireProcurement;
        public double MarkupRate; //ReadOnly
        public string InternalProductID; //Length:50

    } //end Product

}
