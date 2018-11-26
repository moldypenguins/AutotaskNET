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
            this.ApproveRejectDateTime = entity.ApproveRejectDateTime == null ? default(DateTime?) : DateTime.Parse(entity.ApproveRejectDateTime.ToString());
            this.ApproveRejectNote = entity.ApproveRejectNote == null ? default(string) : entity.ContactID.ToString();
            this.ContactID = entity.ContactID == null ? default(int?) : int.Parse(entity.ContactID.ToString());
            this.IsApproved = entity.IsApproved == null ? default(bool?) : bool.Parse(entity.IsApproved.ToString());
            this.ResourceID = entity.ResourceID == null ? default(int?) : int.Parse(entity.ResourceID.ToString());
            this.TicketID = int.Parse(entity.TicketID.ToString());
        } //end TicketChangeRequestApproval(net.autotask.webservices.TicketChangeRequestApproval entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public DateTime? ApproveRejectDateTime; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public int TicketID; //Required [Ticket]

        #endregion //Required Fields

        #region Optional Fields

        public int? ResourceID; //[Resource]
        public int? ContactID; //[Contact]
        public string ApproveRejectNote; //Length:2000
        public bool? IsApproved;

        #endregion //Optional Fields

        #endregion //Fields

    } //end TicketChangeRequestApproval

}
