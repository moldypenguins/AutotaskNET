using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TicketChecklistItem : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

        public bool? Completed { get; set; }
        public int? CompletedByResourceID { get; set; } //ReadOnly [Resource]
        public DateTime? CompletedDateTime { get; set; } //ReadOnly
        public bool? Important { get; set; }
        public string ItemName { get; set; } //Required Length:255
        public int? KnowledgebaseArticleID { get; set; } //PickList
        public int? Position { get; set; }
        public int TicketID { get; set; } //ReadOnly Required [Ticket]

    } //end TicketChecklistItem

}
