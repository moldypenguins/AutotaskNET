using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes notes created by an Autotask user and associated with a Ticket entity.<br />
    /// Autotask users manage ticket notes on Service Desk tickets.<br />
    /// Users can add notes to a new or existing ticket.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TicketNote : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields


        public int? CreatorResourceID { get; set; } //ReadOnly [Resource]
        public DateTime? LastActivityDate { get; set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public string Description { get; set; } //Required Length:32000
        public int NoteType { get; set; } //Required PickList
        public int Publish { get; set; } //Required PickList
        public int TicketID { get; set; } //Required [Ticket]
        public string Title { get; set; } //Required Length:250

        #endregion //Required Fields
        
    } //end TicketNote

}
