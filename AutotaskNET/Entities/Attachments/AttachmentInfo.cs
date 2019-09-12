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
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public AttachmentInfo() : base() { } //end AttachmentInfo()
        public AttachmentInfo(net.autotask.webservices.AttachmentInfo entity)
        {

        } //end AttachmentInfo(net.autotask.webservices.AttachmentInfo entity)

        public static implicit operator net.autotask.webservices.AttachmentInfo(AttachmentInfo attachmentinfo)
        {
            return new net.autotask.webservices.AttachmentInfo()
            {
                id = attachmentinfo.id,

            };

        } //end implicit operator net.autotask.webservices.AttachmentInfo(AttachmentInfo attachmentinfo)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public long ParentID; //ReadOnly
        public DateTime? AttachDate; //ReadOnly
        public long FileSize; //ReadOnly
        public long AttachedByContactID; //ReadOnly [Contact]
        public long AttachedByResourceID; //ReadOnly [Resource]
        public string ContentType; //ReadOnly Length:100
        public long OpportunityID; //ReadOnly [Opportunity]

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int ParentType; //ReadOnly Required PickList
        public string Type; //ReadOnly Required PickList Length:30
        public string Title; //ReadOnly Required Length:255
        public string FullPath; //ReadOnly Required Length:255
        public int Publish; //ReadOnly Required PickList

        #endregion //ReadOnly Required Fields

        #endregion //Fields

    } //end AttachmentInfo

}
