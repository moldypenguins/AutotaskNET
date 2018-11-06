using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Action Type assigned to a CRM Note or To-Do.<br />
    /// The Action Type specifies the type of activity scheduled by the to-do or associated with the note.<br />
    /// The View associated with the Action Type controls where in Autotask the user can view the note or to-do.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ActionType : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields

        public bool? SystemActionType { get; internal set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public string Name { get; set; } //Required Length:32
        public int View { get; set; } //Required PickList
        public bool Active { get; set; } //Required

        #endregion //Required Fields

    } //end ActionType

}
