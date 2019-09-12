using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a record of approval for a ticket change request.<br />
    /// The change request approval process is part of the Autotask Change Management feature set.<br />
    /// Change Management features are only available in the Autotask UI when the Change Management module is enabled.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TicketChangeRequestApproval : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public TicketChangeRequestApproval() : base() { } //end TicketChangeRequestApproval()
        public TicketChangeRequestApproval(net.autotask.webservices.TicketChangeRequestApproval entity) : base(entity)
        {

        } //end TicketChangeRequestApproval(net.autotask.webservices.TicketChangeRequestApproval entity)

        public static implicit operator net.autotask.webservices.TicketChangeRequestApproval(TicketChangeRequestApproval ticketchangerequestapproval)
        {
            return new net.autotask.webservices.TicketChangeRequestApproval()
            {
                id = ticketchangerequestapproval.id,

            };

        } //end implicit operator net.autotask.webservices.TicketChangeRequestApproval(TicketChangeRequestApproval ticketchangerequestapproval)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public DateTime? ApproveRejectDateTime { get; set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public int TicketID { get; set; } //Required [Ticket]

        #endregion //Required Fields

        #region Optional Fields

        public int? ResourceID { get; set; } //[Resource]
        public int? ContactID { get; set; } //[Contact]
        public string ApproveRejectNote { get; set; } //Length:2000
        public bool? IsApproved { get; set; }

        #endregion //Optional Fields

        #endregion //Fields

    } //end TicketChangeRequestApproval

}
