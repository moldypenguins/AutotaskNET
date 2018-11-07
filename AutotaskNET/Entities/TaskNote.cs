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
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public TaskNote() : base() { } //end TaskNote()
        public TaskNote(net.autotask.webservices.TaskNote entity) : base(entity)
        {

        } //end TaskNote(net.autotask.webservices.TaskNote entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public int? CreatorResourceID; //ReadOnly [Resource]
        public DateTime? LastActivityDate; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public string Description; //Required Length:32000
        public int NoteType; //Required PickList
        public int Publish; //Required PickList
        public int TaskID; //Required [Task]
        public string Title; //Required Length:250

        #endregion //Required Fields

        #endregion //Fields

    } //end TaskNote

}
