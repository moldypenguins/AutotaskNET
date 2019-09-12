using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes visual identifiers used to categorize and search for Companies.<br />
    /// The icons appear with the company name throughout Autotask.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ClassificationIcon : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ClassificationIcon() : base() { } //end ClassificationIcon()
        public ClassificationIcon(net.autotask.webservices.ClassificationIcon entity) : base(entity)
        {

        } //end ClassificationIcon(net.autotask.webservices.ClassificationIcon entity)

        public static implicit operator net.autotask.webservices.ClassificationIcon(ClassificationIcon classificationicon)
        {
            return new net.autotask.webservices.ClassificationIcon()
            {
                id = classificationicon.id,

            };

        } //end implicit operator net.autotask.webservices.ClassificationIcon(ClassificationIcon classificationicon)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public string Description; //ReadOnly Length:100

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public string Name; //ReadOnly Required Length:35
        public bool Active; //ReadOnly Required
        public bool System; //ReadOnly Required
        public string RelativeUrl; //ReadOnly Required Length:100

        #endregion //ReadOnly Required Fields

        #endregion //Fields

    } //end ClassificationIcon

}
