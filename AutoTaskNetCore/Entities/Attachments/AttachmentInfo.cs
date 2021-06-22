using System;
using System.Linq;

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
            var thisType = GetType();
            var fields = GetType().GetFields();
            var entityReflection = entity.GetType();

            foreach (var i in fields)
            {
                Console.WriteLine($"Converting: {i.Name} -- {i.FieldType} -- {i.MemberType}");
                try
                {
                    if (i.Name == "UserDefinedFields")
                    {
                        // treat differently:
                        UserDefinedFields = entity.UserDefinedFields?.Select(udf => new UserDefinedField { Name = udf.Name, Value = udf.Value }).ToList();
                        continue;
                    }

                    var value = entityReflection.GetProperty(i.Name)?.GetValue(entity);
                    thisType.GetField(i.Name).SetValue(this, value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        } //end AttachmentInfo(net.autotask.webservices.AttachmentInfo entity)

        public static implicit operator net.autotask.webservices.AttachmentInfo(AttachmentInfo entity)
        {
            var newEntity = new net.autotask.webservices.AttachmentInfo();
            var entityReflection = newEntity.GetType();
            var thisType = entity.GetType();
            var fields = entity.GetType().GetFields();

            foreach (var i in entityReflection.GetProperties())
            {
                try
                {
                    if (i.Name == "UserDefinedFields")
                    {
                        newEntity.UserDefinedFields = entity.UserDefinedFields == null
                            ? default
                            : Array.ConvertAll(entity.UserDefinedFields?.ToArray(), UserDefinedField.ToATWS);
                        continue;
                    }

                    if (i.Name == "Fields")
                        continue;

                    var value = thisType.GetField(i.Name).GetValue(entity);
                    entityReflection.GetProperty(i.Name)?.SetValue(newEntity, value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(i.Name);
                    Console.WriteLine(e);
                    throw;
                }
            }

            return newEntity;

        } //end implicit operator net.autotask.webservices.AttachmentInfo(AttachmentInfo attachmentinfo)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public long ParentID; //ReadOnly
        public DateTime? AttachDate; //ReadOnly
        public decimal FileSize; //ReadOnly
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
