using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// When the Organizational Structure is enabled in Autotask, this entity describes an organizational structure Branch.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class BusinessDivision : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region Required Fields

        public string Name { get; set; } //Required Length:50

        #endregion //Required Fields

        #region Optional Fields

        public string Description { get; set; } //Length:400
        public bool? Active { get; set; }

        #endregion //Optional Fields

    } //end BusinessDivision
}
