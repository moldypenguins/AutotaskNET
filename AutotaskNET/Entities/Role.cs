using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask Role.<br />
    /// Roles are associated with a department and have a standard billing rate.<br />
    /// Resources are associated with one or more department/role combinations.<br />
    /// Resources must specify a Role when entering time.<br />
    /// When billing for that time, the default rate for the role determines the billable rate unless it is overridden, for example, by a Contract or WorkType.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Role : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public Role() : base() { } //end Role()
        public Role(net.autotask.webservices.Role entity) : base(entity)
        {
            this.Active = bool.Parse(entity.Active.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.HourlyFactor = decimal.Parse(entity.Active.ToString());
            this.HourlyRate = decimal.Parse(entity.Active.ToString());
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
            this.QuoteItemDefaultTaxCategoryId = entity.QuoteItemDefaultTaxCategoryId == null ? default(int?) : int.Parse(entity.QuoteItemDefaultTaxCategoryId.ToString());
            this.RoleType = entity.RoleType == null ? default(int?) : int.Parse(entity.RoleType.ToString());
            this.SystemRole = entity.SystemRole == null ? default(bool?) : bool.Parse(entity.SystemRole.ToString());

        } //end Role(net.autotask.webservices.Role entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public bool? SystemRole; //ReadOnly
        public int? RoleType; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public string Name; //Required Length:200
        public decimal HourlyFactor; //Required
        public decimal HourlyRate; //Required
        public bool Active; //Required

        #endregion //Required Fields

        #region Optional Fields

        public string Description; //Length:200
        public int? QuoteItemDefaultTaxCategoryId; //[TaxCategory]
        public bool? IsExcludedFromNewContracts;

        #endregion //Optional Fields

        #endregion //Fields

    } //end Role

}
