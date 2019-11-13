using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// When the Organizational Structure feature is enabled in Autotask, this entity describes the association between an organizational structure Branch and Line of Business.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class BusinessDivisionSubdivision : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public BusinessDivisionSubdivision() : base() { } //end BusinessDivisionSubdivision()
        public BusinessDivisionSubdivision(net.autotask.webservices.BusinessDivisionSubdivision entity) : base(entity)
        {

        } //end BusinessDivisionSubdivision(net.autotask.webservices.BusinessDivisionSubdivision entity)

        public static implicit operator net.autotask.webservices.BusinessDivisionSubdivision(BusinessDivisionSubdivision businessdivisionsubdivision)
        {
            return new net.autotask.webservices.BusinessDivisionSubdivision()
            {
                id = businessdivisionsubdivision.id,

            };

        } //end implicit operator net.autotask.webservices.BusinessDivisionSubdivision(BusinessDivisionSubdivision businessdivisionsubdivision)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public int BusinessDivisionID; //ReadOnly Required [BusinessDivision]
        public int BusinessSubdivisionID; //ReadOnly Required [BusinessSubdivision]

        #endregion //ReadOnly Required Fields

        #region Optional Fields

        public bool? Active;

        #endregion //Optional Fields

        #endregion //Fields

    } //end BusinessDivisionSubdivision

}
