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
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ActionType() : base() { } //end ActionType()
        public ActionType(net.autotask.webservices.ActionType entity) : base(entity)
        {
            this.Active = bool.Parse(entity.Active.ToString());
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
            this.SystemActionType = entity.SystemActionType == null ? default(bool?) : bool.Parse(entity.SystemActionType.ToString());
            this.View = int.Parse(entity.View.ToString());

        } //end ActionType(net.autotask.webservices.ActionType entity)

        public static implicit operator net.autotask.webservices.ActionType(ActionType actiontype)
        {
            return new net.autotask.webservices.ActionType()
            {
                id = actiontype.id,

            };

        } //end implicit operator net.autotask.webservices.ActionType(ActionType actiontype)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public bool? SystemActionType; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public string Name; //Required Length:32
        public int View; //Required PickList
        public bool Active; //Required

        #endregion //Required Fields

        #endregion //Fields

    } //end ActionType

}
