using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask Department.<br />
    /// A Department is an association used to manage resources, especially when assigning project tasks.<br />
    /// Every resource must be associated with at least one department and have at least one assigned role in that department.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Department : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region Required Fields

        public string Name { get; set; } //Required Length:100
        public int PrimaryLocationID { get; set; } //Required [BusinessLocation]

        #endregion //Required Fields

        #region Optional Fields

        public string Number { get; set; } //Length:50
        public string Description { get; set; } //Length:1000

        #endregion //Optional Fields
        
    } //end Department

}
