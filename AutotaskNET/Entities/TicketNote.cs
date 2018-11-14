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
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public TicketNote() : base() { } //end TicketNote()
        public TicketNote(net.autotask.webservices.TicketNote entity) : base(entity)
        {
            this.CreatorResourceID = entity.CreatorResourceID == null ? default(int?) : int.Parse(entity.CreatorResourceID.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.LastActivityDate = entity.LastActivityDate == null ? default(DateTime?) : DateTime.Parse(entity.LastActivityDate.ToString());
            this.NoteType = int.Parse(entity.NoteType.ToString());
            this.Publish = int.Parse(entity.Publish.ToString());
            this.TicketID = int.Parse(entity.TicketID.ToString());
            this.Title = entity.Title == null ? default(string) : entity.Title.ToString();

        } //end TicketNote(net.autotask.webservices.TicketNote entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.TicketNote()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields


        public int? CreatorResourceID; //ReadOnly [Resource]
        public DateTime? LastActivityDate; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public string Description; //Required Length:32000
        public int NoteType; //Required PickList
        public int Publish; //Required PickList
        public int TicketID; //Required [Ticket]
        public string Title; //Required Length:250

        #endregion //Required Fields

        #endregion //Fields

    } //end TicketNote

}
