using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a To-Do created by an Autotask user and associated with an Autotask Account.<br />
    /// In Autotask, a To-Do is a scheduled item that appears on the user's Autotask calendar and can be assigned to another resource.<br />
    /// It requires an Action Type and can be associated with an Opportunity, Ticket, or Contract that is associated with the same Account as the To-Do.<br />
    /// Autotask users manage Account To Dos through the CRM module(CRM > To-Dos).
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class AccountToDo : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields

        public DateTime? CreateDateTime { get; internal set; } //ReadOnly
        public long CreatorResourceID { get; internal set; } //ReadOnly [Resource]
        public DateTime? LastModifiedDate { get; internal set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public long AccountID { get; set; } //Required [Account]
        public long AssignedToResourceID { get; set; } //Required [Resource]
        public DateTime StartDateTime { get; set; } //Required
        public DateTime EndDateTime { get; set; } //Required
        public int ActionType { get; set; } //Required PickList

        #endregion //Required Fields

        #region Optional Fields

        public long ContactID { get; set; } //[Contact]
        public long OpportunityID { get; set; } //[Opportunity]
        public long TicketID { get; set; } //[Ticket]
        public long ContractID { get; set; } //[Contract]
        public string ActivityDescription { get; set; } //Length:32000
        public DateTime? CompletedDate { get; set; }

        #endregion //Optional Fields

    } //end AccountToDo

}
