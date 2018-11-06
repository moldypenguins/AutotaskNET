using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// When the Organizational Structure feature is enabled in Autotask, this entity describes an Autotask Resource association with an organizational structure pairing of BusinessDivision and BusinessSubdivision(BusinessDivisionSubdivision entity).
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class BusinessDivisionSubdivisionResource : Entity
    {
        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Required Fields

        public int BusinessDivisionSubdivisionID { get; set; } //ReadOnly Required [BusinessDivisionSubdivision]
        public int ResourceID { get; set; } //ReadOnly Required [Resource]

        #endregion //ReadOnly Required Fields

    } //end BusinessDivisionSubdivisionResource

}
