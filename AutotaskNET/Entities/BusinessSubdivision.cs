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

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public string Name { get; set; } //Required Length:50

        #endregion //Required Fields

        #region Optional Fields

        public string Description { get; set; } //Length:400
        public bool? Active { get; set; }

        #endregion //Optional Fields

        #endregion //Fields

    } //end BusinessSubdivision

}
