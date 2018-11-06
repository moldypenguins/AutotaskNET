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
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields

        public bool? SystemRole { get; set; } //ReadOnly
        public int? RoleType { get; set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public string Name { get; set; } //Required Length:200
        public decimal HourlyFactor { get; set; } //Required
        public decimal HourlyRate { get; set; } //Required
        public bool Active { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public string Description { get; set; } //Length:200
        public int? QuoteItemDefaultTaxCategoryId { get; set; } //[TaxCategory]
        public bool? IsExcludedFromNewContracts { get; set; }

        #endregion //Optional Fields
       
    } //end Role

}
