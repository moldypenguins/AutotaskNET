using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The TaxRegion entity describes a geographic area where billing items have the same tax rate.<br />
    /// The TaxRegion together with the TaxCategory determine the total tax charged to customers.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TaxRegion : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public TaxRegion() : base() { } //end TaxRegion()
        public TaxRegion(net.autotask.webservices.TaxRegion entity) : base(entity)
        {
            this.Active = entity.Active == null ? default(bool?) : bool.Parse(entity.Active.ToString());
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
        } //end TaxRegion(net.autotask.webservices.TaxRegion entity)

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public string Name; //Required Length:200

        #endregion //Required Fields

        #region Optional Fields

        public bool? Active;

        #endregion //Optional Fields

        #endregion //Fields

    } //end TaxRegion

}
