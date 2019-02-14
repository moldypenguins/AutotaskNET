using System;

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
            this.AccountID = int.Parse(entity.AccountID.ToString());
            this.AccountPhysicalLocationID = entity.AccountPhysicalLocationID == null ? default(int?) : int.Parse(entity.AccountPhysicalLocationID.ToString());
            this.AEMAlertID = entity.AEMAlertID == null ? default(string) : entity.AEMAlertID.ToString();
            this.AllocationCodeID = entity.AllocationCodeID == null ? default(int?) : int.Parse(entity.AllocationCodeID.ToString());
            this.AssignedResourceID = entity.AssignedResourceID == null ? default(int?) : int.Parse(entity.AssignedResourceID.ToString());
            this.AssignedResourceRoleID = entity.AssignedResourceRoleID == null ? default(int?) : int.Parse(entity.AssignedResourceRoleID.ToString());
            this.BusinessDivisionSubdivisionID = entity.BusinessDivisionSubdivisionID == null ? default(int?) : int.Parse(entity.BusinessDivisionSubdivisionID.ToString());
            this.ChangeApprovalBoard = entity.ChangeApprovalBoard == null ? default(int?) : int.Parse(entity.ChangeApprovalBoard.ToString());
            this.ChangeApprovalStatus = entity.ChangeApprovalStatus == null ? default(int?) : int.Parse(entity.ChangeApprovalStatus.ToString());
            this.ChangeApprovalType = entity.ChangeApprovalType == null ? default(int?) : int.Parse(entity.ChangeApprovalType.ToString());
            this.ChangeInfoField1 = entity.ChangeInfoField1 == null ? default(string) : entity.ChangeInfoField1.ToString();
            this.ChangeInfoField2 = entity.ChangeInfoField2 == null ? default(string) : entity.ChangeInfoField2.ToString();
            this.ChangeInfoField3 = entity.ChangeInfoField3 == null ? default(string) : entity.ChangeInfoField3.ToString();
            this.ChangeInfoField4 = entity.ChangeInfoField4 == null ? default(string) : entity.ChangeInfoField4.ToString();
            this.ChangeInfoField5 = entity.ChangeInfoField5 == null ? default(string) : entity.ChangeInfoField5.ToString();
            this.CompletedByResourceID = entity.CompletedByResourceID == null ? default(int?) : int.Parse(entity.CompletedByResourceID.ToString());
            this.CompletedDate = entity.CompletedDate == null ? default(DateTime?) : DateTime.Parse(entity.CompletedDate.ToString());
            this.ContactID = entity.ContactID == null ? default(int?) : int.Parse(entity.ContactID.ToString());
            this.ContractID = entity.ContractID == null ? default(int?) : int.Parse(entity.ContractID.ToString());
            this.ContractServiceBundleID = entity.ContractServiceBundleID == null ? default(long?) : long.Parse(entity.ContractServiceBundleID.ToString());
            this.ContractServiceID = entity.ContractServiceID == null ? default(long?) : long.Parse(entity.ContractServiceID.ToString());
            this.CreateDate = entity.CreateDate == null ? default(DateTime?) : DateTime.Parse(entity.CreateDate.ToString());
            this.CreatorResourceID = entity.CreatorResourceID == null ? default(int?) : int.Parse(entity.CreatorResourceID.ToString());
            this.CreatorType = entity.CreatorType == null ? default(int?) : int.Parse(entity.CreatorType.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.DueDateTime = DateTime.Parse(entity.DueDateTime.ToString());
            this.EstimatedHours = entity.EstimatedHours == null ? default(double?) : double.Parse(entity.EstimatedHours.ToString());
            this.ExternalID = entity.ExternalID == null ? default(string) : entity.ExternalID.ToString();
            this.FirstResponseAssignedResourceID = entity.FirstResponseAssignedResourceID == null ? default(int?) : int.Parse(entity.FirstResponseAssignedResourceID.ToString());
            this.FirstResponseDateTime = entity.FirstResponseDateTime == null ? default(DateTime?) : DateTime.Parse(entity.FirstResponseDateTime.ToString());
            this.FirstResponseDueDateTime = entity.FirstResponseDueDateTime == null ? default(DateTime?) : DateTime.Parse(entity.FirstResponseDueDateTime.ToString());
            this.FirstResponseInitiatingResourceID = entity.FirstResponseInitiatingResourceID == null ? default(int?) : int.Parse(entity.FirstResponseInitiatingResourceID.ToString());
            this.HoursToBeScheduled = entity.HoursToBeScheduled == null ? default(double?) : double.Parse(entity.HoursToBeScheduled.ToString());
            this.InstalledProductID = entity.InstalledProductID == null ? default(int?) : int.Parse(entity.InstalledProductID.ToString());
            this.IssueType = entity.IssueType == null ? default(int?) : int.Parse(entity.IssueType.ToString());
            this.LastActivityDate = entity.LastActivityDate == null ? default(DateTime?) : DateTime.Parse(entity.LastActivityDate.ToString());
            this.LastActivityPersonType = entity.LastActivityPersonType == null ? default(int?) : int.Parse(entity.LastActivityPersonType.ToString());
            this.LastActivityResourceID = entity.LastActivityResourceID == null ? default(int?) : int.Parse(entity.LastActivityResourceID.ToString());
            this.LastCustomerNotificationDateTime = entity.LastCustomerNotificationDateTime == null ? default(DateTime?) : DateTime.Parse(entity.LastCustomerNotificationDateTime.ToString());
            this.LastCustomerVisibleActivityDateTime = entity.LastCustomerVisibleActivityDateTime == null ? default(DateTime?) : DateTime.Parse(entity.LastCustomerVisibleActivityDateTime.ToString());
            this.MonitorID = entity.MonitorID == null ? default(int?) : int.Parse(entity.MonitorID.ToString());
            this.MonitorTypeID = entity.MonitorTypeID == null ? default(int?) : int.Parse(entity.MonitorTypeID.ToString());
            this.OpportunityId = entity.OpportunityId == null ? default(int?) : int.Parse(entity.OpportunityId.ToString());
            this.Priority = int.Parse(entity.Priority.ToString());
            this.ProblemTicketId = entity.ProblemTicketId == null ? default(int?) : int.Parse(entity.ProblemTicketId.ToString());
            this.ProjectID = entity.ProjectID == null ? default(int?) : int.Parse(entity.ProjectID.ToString());
            this.PurchaseOrderNumber = entity.PurchaseOrderNumber == null ? default(string) : entity.PurchaseOrderNumber.ToString();
            this.QueueID = entity.QueueID == null ? default(int?) : int.Parse(entity.QueueID.ToString());
            this.Resolution = entity.Resolution == null ? default(string) : entity.Resolution.ToString();
            this.ResolutionPlanDateTime = entity.ResolutionPlanDateTime == null ? default(DateTime?) : DateTime.Parse(entity.ResolutionPlanDateTime.ToString());
            this.ResolutionPlanDueDateTime = entity.ResolutionPlanDueDateTime == null ? default(DateTime?) : DateTime.Parse(entity.ResolutionPlanDueDateTime.ToString());
            this.ResolvedDateTime = entity.ResolvedDateTime == null ? default(DateTime?) : DateTime.Parse(entity.ResolvedDateTime.ToString());
            this.ResolvedDueDateTime = entity.ResolvedDueDateTime == null ? default(DateTime?) : DateTime.Parse(entity.ResolvedDueDateTime.ToString());
            this.ServiceLevelAgreementHasBeenMet = entity.ServiceLevelAgreementHasBeenMet == null ? default(bool?) : bool.Parse(entity.ServiceLevelAgreementHasBeenMet.ToString());
            this.ServiceLevelAgreementID = entity.ServiceLevelAgreementID == null ? default(int?) : int.Parse(entity.ServiceLevelAgreementID.ToString());
            //this.ServiceLevelAgreementPausedNextEventHours = double.Parse(entity.ServiceLevelAgreementPausedNextEventHours.ToString());
            this.Source = entity.Source == null ? default(int?) : int.Parse(entity.Source.ToString());
            this.Status = int.Parse(entity.Status.ToString());
            this.SubIssueType = entity.SubIssueType == null ? default(int?) : int.Parse(entity.SubIssueType.ToString());
            this.TicketCategory = entity.TicketCategory == null ? default(int?) : int.Parse(entity.TicketCategory.ToString());
            this.TicketNumber = entity.TicketNumber.ToString();
            this.TicketType = entity.TicketType == null ? default(int?) : int.Parse(entity.TicketType.ToString());
            this.Title = entity.Title.ToString();

        } //end Ticket(net.autotask.webservices.Ticket entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.Ticket()
            {
                id = this.id,
                AccountID = this.AccountID,
                AccountPhysicalLocationID = this.AccountPhysicalLocationID,
                AEMAlertID = this.AEMAlertID,
                AllocationCodeID = this.AllocationCodeID,
                AssignedResourceID = this.AssignedResourceID,
                AssignedResourceRoleID = this.AssignedResourceRoleID,
                BusinessDivisionSubdivisionID = this.BusinessDivisionSubdivisionID,
                ChangeApprovalBoard = this.ChangeApprovalBoard,
                ChangeApprovalStatus = this.ChangeApprovalStatus,
                ChangeApprovalType = this.ChangeApprovalType,
                ChangeInfoField1 = this.ChangeInfoField1,
                ChangeInfoField2 = this.ChangeInfoField2,
                ChangeInfoField3 = this.ChangeInfoField3,
                ChangeInfoField4 = this.ChangeInfoField4,
                ChangeInfoField5 = this.ChangeInfoField5,
                CompletedByResourceID = this.CompletedByResourceID,
                CompletedDate = this.CompletedDate,
                ContactID = this.ContactID,
                ContractID = this.ContractID,
                ContractServiceBundleID = this.ContractServiceBundleID,
                ContractServiceID = this.ContractServiceID,
                CreateDate = this.CreateDate,
                CreatorResourceID = this.CreatorResourceID,
                CreatorType = this.CreatorType,
                Description = this.Description,
                DueDateTime = this.DueDateTime,
                EstimatedHours = this.EstimatedHours,
                ExternalID = this.ExternalID,
                FirstResponseAssignedResourceID = this.FirstResponseAssignedResourceID,
                FirstResponseDateTime = this.FirstResponseDateTime,
                FirstResponseDueDateTime = this.FirstResponseDueDateTime,
                FirstResponseInitiatingResourceID = this.FirstResponseInitiatingResourceID,
                HoursToBeScheduled = this.HoursToBeScheduled,
                InstalledProductID = this.InstalledProductID,
                IssueType = this.IssueType,
                LastActivityDate = this.LastActivityDate,
                LastActivityPersonType = this.LastActivityPersonType,
                LastActivityResourceID = this.LastActivityResourceID,
                LastCustomerNotificationDateTime = this.LastCustomerNotificationDateTime,
                LastCustomerVisibleActivityDateTime = this.LastCustomerVisibleActivityDateTime,
                MonitorID = this.MonitorID,
                MonitorTypeID = this.MonitorTypeID,
                OpportunityId = this.OpportunityId,
                Priority = this.Priority,
                ProblemTicketId = this.ProblemTicketId,
                ProjectID = this.ProjectID,
                PurchaseOrderNumber = this.PurchaseOrderNumber,
                QueueID = this.QueueID,
                Resolution = this.Resolution,
                ResolutionPlanDateTime = this.ResolutionPlanDateTime,
                ResolutionPlanDueDateTime = this.ResolutionPlanDueDateTime,
                ResolvedDateTime = this.ResolvedDateTime,
                ResolvedDueDateTime = this.ResolvedDueDateTime,
                ServiceLevelAgreementHasBeenMet = this.ServiceLevelAgreementHasBeenMet,
                ServiceLevelAgreementID = this.ServiceLevelAgreementID,
                //ServiceLevelAgreementPausedNextEventHours = this.ServiceLevelAgreementPausedNextEventHours,
                Source = this.Source,
                Status = this.Status,
                SubIssueType = this.SubIssueType,
                TicketCategory = this.TicketCategory,
                TicketNumber = this.TicketNumber,
                TicketType = this.TicketType,
                Title = this.Title
            };
        } //end ToATWS()

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
        public double? HoursToBeScheduled; //ReadOnly
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
        public double? EstimatedHours;
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
