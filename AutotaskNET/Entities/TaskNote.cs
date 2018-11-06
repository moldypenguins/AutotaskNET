using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes notes created by an Autotask user and associated with a Task entity.<br />
    /// Autotask users manage Task Notes on Project Tasks.<br />
    /// Users can add notes to a new or existing task.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TaskNote : Entity
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
        public int TaskID { get; set; } //Required [Task]
        public string Title { get; set; } //Required Length:250

        #endregion //Required Fields
        
    } //end TaskNote

}
