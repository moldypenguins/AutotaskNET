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
            this.Active = bool.Parse(entity.Active.ToString());
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
            this.RelativeUrl = entity.RelativeUrl == null ? default(string) : entity.RelativeUrl.ToString();
            this.System = bool.Parse(entity.System.ToString());
        } //end ClassificationIcon(net.autotask.webservices.ClassificationIcon entity)

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
