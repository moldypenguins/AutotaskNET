using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TicketChecklistItem : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public TicketChecklistItem() : base() { } //end TicketChecklistItem()
        public TicketChecklistItem(net.autotask.webservices.TicketChecklistItem entity) : base(entity)
        {
            this.Completed = entity.Completed == null ? default(bool?) : bool.Parse(entity.Completed.ToString());
            this.CompletedByResourceID = entity.CompletedByResourceID == null ? default(int?) : int.Parse(entity.CompletedByResourceID.ToString());
            this.CompletedDateTime = entity.CompletedDateTime == null ? default(DateTime?) : DateTime.Parse(entity.CompletedDateTime.ToString());
            //this.Important == null ? default(bool?) : bool.Parse(entity.Important.ToString());
            this.ItemName = entity.ItemName == null ? default(string) : entity.ItemName.ToString();
            this.KnowledgebaseArticleID = entity.KnowledgebaseArticleID == null ? default(int?) : int.Parse(entity.KnowledgebaseArticleID.ToString());
            this.Position = entity.Position == null ? default(int?) : int.Parse(entity.Position.ToString());
            this.TicketID = int.Parse(entity.TicketID.ToString());
        } //end Account(net.autotask.webservices.Account entity)

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

        public bool? Completed;
        public int? CompletedByResourceID; //ReadOnly [Resource]
        public DateTime? CompletedDateTime; //ReadOnly
        public bool? Important;
        public string ItemName; //Required Length:255
        public int? KnowledgebaseArticleID; //PickList
        public int? Position;
        public int TicketID; //ReadOnly Required [Ticket]

    } //end TicketChecklistItem

}
