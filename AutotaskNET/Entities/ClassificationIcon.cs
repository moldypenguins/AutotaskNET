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
        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields

        public string Description { get; set; } //ReadOnly Length:100

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public string Name { get; set; } //ReadOnly Required Length:35
        public bool Active { get; set; } //ReadOnly Required
        public bool System { get; set; } //ReadOnly Required
        public string RelativeUrl { get; set; } //ReadOnly Required Length:100

        #endregion //ReadOnly Required Fields
        
    } //end ClassificationIcon

}
