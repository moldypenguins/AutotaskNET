using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask Shipping Type. A Shipping Type defines a carrier for a product shipment and can be associated with a Quote entity.<br />
    /// <br />
    /// In Autotask, Shipping Types are set up in the Admin module and added to a Quote in the CRM module.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ShippingType : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ShippingType() : base() { } //end ShippingType()
        public ShippingType(net.autotask.webservices.ShippingType entity) : base(entity)
        {
            this.AllocationCodeID = entity.AllocationCodeID == null ? default(int?) : int.Parse(entity.AllocationCodeID.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.IsActive = entity.IsActive == null ? default(bool?) : bool.Parse(entity.IsActive.ToString());
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
        } //end ShippingType(net.autotask.webservices.ShippingType entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public string Name; //ReadOnly Length:100
        public bool? IsActive; //ReadOnly
        public string Description; //ReadOnly Length:2000
        public int? AllocationCodeID; //ReadOnly [AllocationCode]

        #endregion //ReadOnly Fields

        #endregion //Fields

    } //end ShippingType

}
