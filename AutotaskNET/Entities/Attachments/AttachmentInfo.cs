using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The AttachmentInfo entity describes an Attachment in Autotask.<br />
    /// Attachments are external documents that are associated with an Autotask Account, Ticket, Project, or Opportunity entity.<br />
    /// Attachments in Autotask can be documents uploaded to the server, file links, folder links, and URLs.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class AttachmentInfo : Entity
    {
        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields

        public long ParentID { get; internal set; } //ReadOnly
        public DateTime? AttachDate { get; internal set; } //ReadOnly
        public long FileSize { get; internal set; } //ReadOnly
        public long AttachedByContactID { get; internal set; } //ReadOnly [Contact]
        public long AttachedByResourceID { get; internal set; } //ReadOnly [Resource]
        public string ContentType { get; internal set; } //ReadOnly Length:100
        public long OpportunityID { get; internal set; } //ReadOnly [Opportunity]

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int ParentType { get; internal set; } //ReadOnly Required PickList
        public string Type { get; internal set; } //ReadOnly Required PickList Length:30
        public string Title { get; internal set; } //ReadOnly Required Length:255
        public string FullPath { get; internal set; } //ReadOnly Required Length:255
        public int Publish { get; internal set; } //ReadOnly Required PickList

        #endregion //ReadOnly Required Fields
        
    } //end AttachmentInfo

}
