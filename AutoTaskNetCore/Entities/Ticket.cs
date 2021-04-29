using System;
using System.Collections.Generic;
using System.Linq;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask Ticket.<br />
    /// Tickets define service requests within the Autotask system.<br />
    /// Autotask users manage Tickets through a number of modules including Service Desk, Home, Directory, CRM, and Contracts.<br />
    /// They can click New Ticket on the Autotask interface sub-navigation menu to open the New Ticket window.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Ticket : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => true;

        #endregion //Properties

        #region Constructors

        public Ticket() : base() { } //end Ticket()
        public Ticket(net.autotask.webservices.Ticket entity) : base(entity)
        {
            var thisType = GetType();
            var fields = GetType().GetFields();
            var entityReflection = entity.GetType();

            foreach (var i in fields)
            {
                //Console.WriteLine($"Converting: {i.Name} -- {i.FieldType} -- {i.MemberType}");
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

        } //end Ticket(net.autotask.webservices.Ticket entity)


        public static implicit operator net.autotask.webservices.Ticket(Ticket entity)
        {
            var newEntity = new net.autotask.webservices.Ticket();
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


        } //end implicit operator net.autotask.webservices.Ticket(Ticket ticket)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public DateTime? CompletedDate; //ReadOnly
        public DateTime? CreateDate; //ReadOnly
        public int? CreatorResourceID; //ReadOnly [Resource]
        public DateTime? LastActivityDate; //ReadOnly
        public string TicketNumber; //ReadOnly Length:50
        public DateTime? FirstResponseDateTime; //ReadOnly
        public DateTime? ResolutionPlanDateTime; //ReadOnly
        public DateTime? ResolvedDateTime; //ReadOnly
        public DateTime? FirstResponseDueDateTime; //ReadOnly
        public DateTime? ResolutionPlanDueDateTime; //ReadOnly
        public DateTime? ResolvedDueDateTime; //ReadOnly
        public bool? ServiceLevelAgreementHasBeenMet; //ReadOnly
        public DateTime? LastCustomerNotificationDateTime; //ReadOnly
        public DateTime? LastCustomerVisibleActivityDateTime; //ReadOnly
        public string AEMAlertID; //ReadOnly Length:50
        public decimal? HoursToBeScheduled; //ReadOnly
        public int? FirstResponseInitiatingResourceID; //ReadOnly
        public int? FirstResponseAssignedResourceID; //ReadOnly
        public int? CreatorType; //ReadOnly PickList
        public int? CompletedByResourceID; //ReadOnly [Resource]
        public int? LastActivityPersonType; //ReadOnly PickList
        public int? LastActivityResourceID; //ReadOnly [Resource]
        public double ServiceLevelAgreementPausedNextEventHours; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public int AccountID; //Required [Account]
        public DateTime DueDateTime; //Required
        public int Priority; //Required PickList
        public int Status; //Required PickList
        public string Title; //Required Length:255

        #endregion //Required Fields

        #region Optional Fields

        public int? AllocationCodeID; //[AllocationCode]
        public int? AssignedResourceID; //[Resource]
        public int? AssignedResourceRoleID; //[Role]
        public int? ContactID; //[Contact]
        public int? ContractID; //[Contract]
        public string Description; //Length:8000
        public decimal? EstimatedHours;
        public string ExternalID; //Length:50
        public int? InstalledProductID; //[InstalledProduct]
        public int? IssueType; //PickList
        public int? QueueID; //PickList
        public int? Source; //PickList
        public int? SubIssueType; //PickList
        public int? ServiceLevelAgreementID; //PickList
        public string Resolution; //Length:32000
        public string PurchaseOrderNumber; //Length:50
        public int? TicketType; //PickList
        public int? ProblemTicketId; //[Ticket]
        public int? OpportunityId; //[Opportunity]
        public int? ChangeApprovalBoard; //PickList
        public int? ChangeApprovalType; //PickList
        public int? ChangeApprovalStatus; //PickList
        public string ChangeInfoField1; //Length:8000
        public string ChangeInfoField2; //Length:8000
        public string ChangeInfoField3; //Length:8000
        public string ChangeInfoField4; //Length:8000
        public string ChangeInfoField5; //Length:8000
        public long? ContractServiceID; //[ContractService]
        public long? ContractServiceBundleID; //[ContractServiceBundle]
        public int? MonitorTypeID; //PickList
        public int? MonitorID;
        public int? TicketCategory; //PickList
        public int? ProjectID; //[Project]
        public int? BusinessDivisionSubdivisionID; //[BusinessDivisionSubdivision]
        public int? AccountPhysicalLocationID; //[AccountPhysicalLocation]

        #endregion //Optional Fields

        #endregion //Fields
        
    } //end Ticket

}
