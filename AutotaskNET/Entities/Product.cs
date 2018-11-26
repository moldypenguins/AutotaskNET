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
            this.Active = bool.Parse(entity.Active.ToString());
            this.Name= entity.Name == null ? default(string) : entity.Name.ToString();
            this.ProductAllocationCodeID = int.Parse(entity.ProductAllocationCodeID.ToString());
            this.Serialized = bool.Parse(entity.Serialized.ToString());
            this.CostAllocationCodeID = entity.CostAllocationCodeID == null ? default(int?) : int.Parse(entity.CostAllocationCodeID.ToString();
            this.DefaultVendorID = entity.DefaultVendorID == null ? default(int?) : int.Parse(entity.DefaultVendorID.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.DoesNotRequireProcurement = entity.DoesNotRequireProcurement == null ? default(bool?) : bool.Parse(entity.DoesNotRequireProcurement.ToString());
            this.ExternalProductID = entity.ExternalProductID == null ? default(string) : entity.ExternalProductID.ToString();
            this.InternalProductID = entity.InternalProductID == null ? default(string) : entity.InternalProductID.ToString();
            this.Link = entity.Link == null ? default(string) : entity.Link.ToString();
            this.ManufacturerName = entity.ManufacturerName == null ? default(string) : entity.ManufacturerName.ToString();
            this.ManufacturerProductName = entity.ManufacturerProductName == null ? default(string) : entity.ManufacturerProductName.ToString();
            this.MarkupRate = double.Parse(entity.MarkupRate.ToString());
            this.MSRP = double.Parse(entity.MSRP.ToString()) ;
            this.PeriodType = entity.PeriodType == null ? default(string) : entity.PeriodType.ToString();
            this.ProductCategory = entity.ProductCategory == null ? default(int?) : int.Parse(entity.ProductCategory.ToString());
            this.SKU = entity.SKU == null ? default(string) : entity.SKU.ToString();
            this.UnitCost = double.Parse(entity.UnitCost.ToString());
            this.UnitPrice = double.Parse(entity.UnitPrice.ToString());
            this.VendorProductNumber = entity.VendorProductNumber == null ? default(string) : entity.VendorProductNumber.ToString();
        } //end Product(net.autotask.webservices.Product entity)

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
