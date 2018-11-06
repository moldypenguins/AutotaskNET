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

        public DateTime? CompletedDateTime { get; internal set; } //ReadOnly
        public DateTime? LastModifiedDate { get; internal set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public int AccountID { get; set; } //Required [Account]
        public int ActionType { get; set; } //Required PickList
        public int AssignedResourceID { get; set; } //Required [Resource]
        public DateTime EndDateTime { get; set; } //Required
        public DateTime StartDateTime { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public int? ContactID { get; set; } //[Contact]
        public string Name { get; set; } //Length:128
        public string Note { get; set; } //Length:32000
        public int? OpportunityID { get; set; } //[Opportunity]
        
        #endregion //Optional Fields

    } //end AccountNote

}
