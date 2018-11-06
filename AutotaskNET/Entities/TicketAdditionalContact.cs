using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes one or more account contacts assigned to a Ticket, other than the Ticket Contact (Ticket.ContactID).<br />
    /// Contacts must be associated with the ticket's Account (Ticket.AccountID).<br />
    /// A ticket can have additional contacts even if there is no Ticket Contact.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TicketAdditionalContact : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #region Required Fields

        public int TicketID { get; set; } //Required [Ticket]
        public int ContactID { get; set; } //Required [Contact]

        #endregion //Required Fields
        
    } //end TicketAdditionalContact

}
