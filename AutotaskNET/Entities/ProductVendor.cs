using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a Vendor type Account that is associated with an Autotask Product.<br />
    /// Products can be associated with more than one Product Vendor.<br />
    /// A Product Vendor is not required unless the user intends to create an Inventory Item from the Product and add the Inventory Item to one or more purchase orders.<br />
    /// <br />
    /// In Autotask, users associate Vendors with Products and manage the Product Vendors through the Add/Edit Product window accessed through the Product Search list in the Admin or Inventory modules.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ProductVendor : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ProductVendor() : base() { } //end ProductVendor()
        public ProductVendor(net.autotask.webservices.ProductVendor entity) : base(entity)
        {

        } //end ProductVendor(net.autotask.webservices.ProductVendor entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public int ProductID { get; set; } //ReadOnly Required [Product]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public int VendorID { get; set; } //Required [Account]
        public bool Active { get; set; } //Required
        public bool IsDefault { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public double VendorCost { get; set; }
        public string VendorPartNumber { get; set; } //Length:50

        #endregion //Optional Fields

        #endregion //Fields

    } //end ProductVendor

}
