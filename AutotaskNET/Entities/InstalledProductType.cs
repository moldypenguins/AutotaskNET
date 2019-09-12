using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a Type, for example, printer, server, or workstation, assigned to a Configuration Item in Autotask.<br />
    /// The InstalledProductType associates one or more User-defined Fields with configuration items of the same type.<br />
    /// The Userdefined Fields allow the user to capture key information for configuration items of the specified type, for example, make and model, or replacement part numbers.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class InstalledProductType : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public InstalledProductType() : base() { } //end InstalledProductType()
        public InstalledProductType(net.autotask.webservices.InstalledProductType entity) : base(entity)
        {

        } //end InstalledProductType(net.autotask.webservices.InstalledProductType entity)

        public static implicit operator net.autotask.webservices.InstalledProductType(InstalledProductType installedproducttype)
        {
            return new net.autotask.webservices.InstalledProductType()
            {
                id = installedproducttype.id,

            };

        } //end implicit operator net.autotask.webservices.InstalledProductType(InstalledProductType installedproducttype)

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public string Name { get; set; } //Required Length:100
        public bool Active { get; set; } //Required

        #endregion //Required Fields

        #endregion //Fields

    } //end InstalledProductType

}
