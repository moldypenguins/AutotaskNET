using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// When the Organizational Structure feature is enabled in Autotask, this entity describes an organizational structure Line of Business.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class BusinessSubdivision : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public BusinessSubdivision() : base() { } //end BusinessSubdivision()
        public BusinessSubdivision(net.autotask.webservices.BusinessSubdivision entity) : base(entity)
        {

        } //end BusinessSubdivision(net.autotask.webservices.BusinessSubdivision entity)

        public static implicit operator net.autotask.webservices.BusinessSubdivision(BusinessSubdivision businesssubdivision)
        {
            return new net.autotask.webservices.BusinessSubdivision()
            {
                id = businesssubdivision.id,

            };

        } //end implicit operator net.autotask.webservices.BusinessSubdivision(BusinessSubdivision businesssubdivision)

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public string Name; //Required Length:50

        #endregion //Required Fields

        #region Optional Fields

        public string Description; //Length:400
        public bool? Active;

        #endregion //Optional Fields

        #endregion //Fields

    } //end BusinessSubdivision

}
