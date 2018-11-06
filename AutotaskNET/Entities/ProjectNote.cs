using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes notes created by an Autotask user and associated with a Project entity.<br />
    /// Autotask users manage Project Notes through the Notes option accessed through the Project Menu on the Project Summary page.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ProjectNote : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields

        public int? CreatorResourceID { get; set; } //ReadOnly [Resource]
        public DateTime? LastActivityDate { get; set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public string Description { get; set; } //Required Length:32000
        public int NoteType { get; set; } //Required PickList
        public int Publish { get; set; } //Required PickList
        public int ProjectID { get; set; } //Required [Project]
        public string Title { get; set; } //Required Length:250
        public bool Announce { get; set; } //Required

        #endregion //Required Fields

    } //end ProjectNote

}
