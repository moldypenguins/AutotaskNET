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
            this.HourlyFactor = decimal.Parse(entity.HourlyFactor.ToString());
            this.HourlyRate = decimal.Parse(entity.HourlyRate.ToString());
            this.IsExcludedFromNewContracts = entity.IsExcludedFromNewContracts == null ? default(bool?) : bool.Parse(entity.IsExcludedFromNewContracts.ToString());
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
            this.QuoteItemDefaultTaxCategoryId = entity.QuoteItemDefaultTaxCategoryId == null ? default(int?) : int.Parse(entity.QuoteItemDefaultTaxCategoryId.ToString());
            this.RoleType = entity.RoleType == null ? default(int?) : int.Parse(entity.RoleType.ToString());
            this.SystemRole = entity.SystemRole == null ? default(bool?) : bool.Parse(entity.SystemRole.ToString());

        } //end Role(net.autotask.webservices.Role entity)

        public static implicit operator net.autotask.webservices.Role(Role role)
        {
            return new net.autotask.webservices.Role()
            {
                id = role.id,
                Active = role.Active,
                Description = role.Description,
                HourlyFactor = role.HourlyFactor,
                HourlyRate = role.HourlyRate,
                IsExcludedFromNewContracts = role.IsExcludedFromNewContracts,
                Name = role.Name,
                QuoteItemDefaultTaxCategoryId = role.QuoteItemDefaultTaxCategoryId,
                RoleType = role.RoleType,
                SystemRole = role.SystemRole
            };

        } //end implicit operator net.autotask.webservices.Role(Role role)

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
