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
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public AccountToDo() : base() { } //end AccountToDo()
        public AccountToDo(net.autotask.webservices.AccountToDo entity) : base(entity)
        {
            this.AccountID = long.Parse(entity.AccountID.ToString());
            this.ActionType = int.Parse(entity.ActionType.ToString());
            this.ActivityDescription = entity.ActivityDescription == null ? default(string) : entity.ActivityDescription.ToString();
            this.AssignedToResourceID = long.Parse(entity.AssignedToResourceID.ToString());
            this.CompletedDate = entity.CompletedDate == null ? default(DateTime?) : DateTime.Parse(entity.CompletedDate.ToString());
            this.ContactID = entity.ContactID == null ? default(long?) : long.Parse(entity.ContactID.ToString());
            this.ContractID = entity.ContractID == null ? default(long?) : long.Parse(entity.ContractID.ToString());
            this.CreateDateTime = entity.CreateDateTime == null ? default(DateTime?) : DateTime.Parse(entity.CreateDateTime.ToString());
            this.CreatorResourceID = entity.CreatorResourceID == null ? default(long?) : long.Parse(entity.CreatorResourceID.ToString());
            this.EndDateTime = DateTime.Parse(entity.EndDateTime.ToString());
            this.LastModifiedDate = entity.LastModifiedDate == null ? default(DateTime?) : DateTime.Parse(entity.LastModifiedDate.ToString());
            this.OpportunityID = entity.OpportunityID == null ? default(long?) : long.Parse(entity.OpportunityID.ToString());
            this.StartDateTime = DateTime.Parse(entity.StartDateTime.ToString()); ;
            this.TicketID = entity.TicketID == null ? default(long?) : long.Parse(entity.TicketID.ToString());

        } //end AccountToDo(net.autotask.webservices.AccountToDo entity)

        public static implicit operator net.autotask.webservices.AccountToDo(AccountToDo accounttodo)
        {
            return new net.autotask.webservices.AccountToDo()
            {
                id = accounttodo.id,

            };

        } //end implicit operator net.autotask.webservices.AccountToDo(AccountToDo accounttodo)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public DateTime? CreateDateTime; //ReadOnly
        public long? CreatorResourceID; //ReadOnly [Resource]
        public DateTime? LastModifiedDate; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public long AccountID; //Required [Account]
        public long AssignedToResourceID; //Required [Resource]
        public DateTime StartDateTime; //Required
        public DateTime EndDateTime; //Required
        public int ActionType; //Required PickList

        #endregion //Required Fields

        #region Optional Fields

        public long? ContactID; //[Contact]
        public long? OpportunityID; //[Opportunity]
        public long? TicketID; //[Ticket]
        public long? ContractID; //[Contract]
        public string ActivityDescription; //Length:32000
        public DateTime? CompletedDate;

        #endregion //Optional Fields

        #endregion //Fields

    } //end AccountToDo

}
