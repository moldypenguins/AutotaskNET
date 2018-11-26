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
            this.IsActive = bool.Parse(entity.IsActive.ToString());
            this.IsDeleted = bool.Parse(entity.IsDeleted.ToString());
            this.IsTemplateJob = bool.Parse(entity.IsTemplateJob.ToString());
            this.AccountID = long.Parse(entity.AccountID.ToString());
            this.EntityNumber = entity.EntityNumber == null ? default(string) : entity.EntityNumber.ToString();
            this.EntityTitle = entity.EntityTitle == null ? default(string) : entity.EntityTitle.ToString();
            this.InitiatingContactID = long.Parse(entity.InitiatingContactID.ToString());
            this.InitiatingResourceID = long.Parse(entity.InitiatingResourceID.ToString());
            this.NotificationHistoryTypeID = entity.NotificationHistoryTypeID == null ? default(int?) : int.Parse(entity.NotificationHistoryTypeID.ToString());
            this.NotificationSentTime = entity.NotificationSentTime == null ? default(DateTime?) : DateTime.Parse(entity.NotificationSentTime.ToString());
            this.OpportunityID = long.Parse(entity.OpportunityID.ToString());
            this.ProjectID = long.Parse(entity.ProjectID.ToString());
            this.QuoteID = long.Parse(entity.QuoteID.ToString());
            this.RecipientDisplayName = entity.RecipientDisplayName == null ? default(string) : entity.RecipientDisplayName.ToString();
            this.RecipientEmailAddress = entity.RecipientEmailAddress == null ? default(string) : entity.RecipientEmailAddress.ToString();
            this.TaskID = long.Parse(entity.TaskID.ToString());
            this.TemplateName = entity.TemplateName == null ? default(string) : entity.TemplateName.ToString();
            this.TicketID = long.Parse(entity.TicketID.ToString());
            this.TimeEntryID = long.Parse(entity.TimeEntryID.ToString());
        } //end NotificationHistory(net.autotask.webservices.NotificationHistory entity)

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

        public DateTime? NotificationSentTime; //ReadOnly
        public string TemplateName; //ReadOnly Length:100
        public int? NotificationHistoryTypeID; //ReadOnly PickList
        public string EntityTitle; //ReadOnly PickList Length:2000
        public string EntityNumber; //ReadOnly PickList Length:50
        public bool IsDeleted; //ReadOnly Required
        public bool IsActive; //ReadOnly Required
        public bool IsTemplateJob; //ReadOnly Required
        public long InitiatingResourceID; //ReadOnly [Resource]
        public long InitiatingContactID; //ReadOnly [Contact]
        public string RecipientEmailAddress; //ReadOnly Length:2000
        public string RecipientDisplayName; //ReadOnly Length:200
        public long AccountID; //ReadOnly [Account]
        public long QuoteID; //ReadOnly [Quote]
        public long OpportunityID; //ReadOnly [Opportunity]
        public long ProjectID; //ReadOnly [Project]
        public long TaskID; //ReadOnly [Task]
        public long TicketID; //ReadOnly [Ticket]
        public long TimeEntryID; //ReadOnly [TimeEntry]

    } //end NotificationHistory
}
