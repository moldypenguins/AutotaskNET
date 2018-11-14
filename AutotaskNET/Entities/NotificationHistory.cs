using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask Notification, as listed in the Notification History page.<br />
    /// In the UI, users with Admin security level permission to access "Application-wide (Shared) Features" can access Notification History.<br />
    /// From this page, you can view a list of notifications sent from Autotask in the previous 30 days.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class NotificationHistory : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public NotificationHistory() : base() { } //end NotificationHistory()
        public NotificationHistory(net.autotask.webservices.NotificationHistory entity) : base(entity)
        {

        } //end NotificationHistory(net.autotask.webservices.NotificationHistory entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.NotificationHistory()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

        #endregion //Fields

        public DateTime? NotificationSentTime { get; set; } //ReadOnly
        public string TemplateName { get; set; } //ReadOnly Length:100
        public int? NotificationHistoryTypeID { get; set; } //ReadOnly PickList
        public string EntityTitle { get; set; } //ReadOnly PickList Length:2000
        public string EntityNumber { get; set; } //ReadOnly PickList Length:50
        public bool IsDeleted { get; set; } //ReadOnly Required
        public bool IsActive { get; set; } //ReadOnly Required
        public bool IsTemplateJob { get; set; } //ReadOnly Required
        public long InitiatingResourceID { get; set; } //ReadOnly [Resource]
        public long InitiatingContactID { get; set; } //ReadOnly [Contact]
        public string RecipientEmailAddress { get; set; } //ReadOnly Length:2000
        public string RecipientDisplayName { get; set; } //ReadOnly Length:200
        public long AccountID { get; set; } //ReadOnly [Account]
        public long QuoteID { get; set; } //ReadOnly [Quote]
        public long OpportunityID { get; set; } //ReadOnly [Opportunity]
        public long ProjectID { get; set; } //ReadOnly [Project]
        public long TaskID { get; set; } //ReadOnly [Task]
        public long TicketID { get; set; } //ReadOnly [Ticket]
        public long TimeEntryID { get; set; } //ReadOnly [TimeEntry]

    } //end NotificationHistory
}
