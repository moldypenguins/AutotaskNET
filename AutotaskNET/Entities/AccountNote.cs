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
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

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

    } //end AccountNote

}
