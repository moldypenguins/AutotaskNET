using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The AccountNote entity describes any sort of note created by an Autotask user and associated with an Account entity or an Opportunity entity.<br />
    /// Autotask users manage Account Notes through the CRM module (CRM > Accounts).
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class AccountNote : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public AccountNote() : base() { } //end AccountNote()
        public AccountNote(net.autotask.webservices.AccountNote entity) : base(entity)
        {

        } //end AccountNote(net.autotask.webservices.AccountNote entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.AccountNote()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public DateTime? CompletedDateTime; //ReadOnly
        public DateTime? LastModifiedDate; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public int AccountID; //Required [Account]
        public int ActionType; //Required PickList
        public int AssignedResourceID; //Required [Resource]
        public DateTime EndDateTime; //Required
        public DateTime StartDateTime; //Required

        #endregion //Required Fields

        #region Optional Fields

        public int? ContactID; //[Contact]
        public string Name; //Length:128
        public string Note; //Length:32000
        public int? OpportunityID; //[Opportunity]

        #endregion //Optional Fields

        #endregion //Fields

    } //end AccountNote

}
