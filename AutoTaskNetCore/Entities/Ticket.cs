﻿using System;
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
            this.AccountID = int.Parse(entity.AccountID.ToString());
            this.AccountPhysicalLocationID = entity.AccountPhysicalLocationID == null ? default(int?) : int.Parse(entity.AccountPhysicalLocationID.ToString());
            this.AEMAlertID = entity.AEMAlertID == null ? default(string) : entity.AEMAlertID.ToString();
            this.AllocationCodeID = entity.AllocationCodeID == null ? default(long?) : long.Parse(entity.AllocationCodeID.ToString());
            this.AssignedResourceID = entity.AssignedResourceID == null ? default(long?) : long.Parse(entity.AssignedResourceID.ToString());
            this.AssignedResourceRoleID = entity.AssignedResourceRoleID == null ? default(long?) : long.Parse(entity.AssignedResourceRoleID.ToString());
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
            this.ContactID = entity.ContactID == null ? default(long?) : long.Parse(entity.ContactID.ToString());
            this.ContractID = entity.ContractID == null ? default(long?) : long.Parse(entity.ContractID.ToString());
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
            this.UserDefinedFields = entity.UserDefinedFields?.Select(udf => new UserDefinedField { Name = udf.Name, Value = udf.Value }).ToList();

        } //end Ticket(net.autotask.webservices.Ticket entity)


        public static implicit operator net.autotask.webservices.Ticket(Ticket ticket)
        {
            return new net.autotask.webservices.Ticket()
            {
                id = ticket.id,
                AccountID = ticket.AccountID,
                AccountPhysicalLocationID = ticket.AccountPhysicalLocationID,
                AEMAlertID = ticket.AEMAlertID,
                AllocationCodeID = ticket.AllocationCodeID,
                AssignedResourceID = ticket.AssignedResourceID,
                AssignedResourceRoleID = ticket.AssignedResourceRoleID,
                BusinessDivisionSubdivisionID = ticket.BusinessDivisionSubdivisionID,
                ChangeApprovalBoard = ticket.ChangeApprovalBoard,
                ChangeApprovalStatus = ticket.ChangeApprovalStatus,
                ChangeApprovalType = ticket.ChangeApprovalType,
                ChangeInfoField1 = ticket.ChangeInfoField1,
                ChangeInfoField2 = ticket.ChangeInfoField2,
                ChangeInfoField3 = ticket.ChangeInfoField3,
                ChangeInfoField4 = ticket.ChangeInfoField4,
                ChangeInfoField5 = ticket.ChangeInfoField5,
                CompletedByResourceID = ticket.CompletedByResourceID,
                CompletedDate = ticket.CompletedDate,
                ContactID = ticket.ContactID,
                ContractID = ticket.ContractID,
                ContractServiceBundleID = ticket.ContractServiceBundleID,
                ContractServiceID = ticket.ContractServiceID,
                CreateDate = ticket.CreateDate,
                CreatorResourceID = ticket.CreatorResourceID,
                CreatorType = ticket.CreatorType,
                Description = ticket.Description,
                DueDateTime = ticket.DueDateTime,
                EstimatedHours = ticket.EstimatedHours,
                ExternalID = ticket.ExternalID,
                FirstResponseAssignedResourceID = ticket.FirstResponseAssignedResourceID,
                FirstResponseDateTime = ticket.FirstResponseDateTime,
                FirstResponseDueDateTime = ticket.FirstResponseDueDateTime,
                FirstResponseInitiatingResourceID = ticket.FirstResponseInitiatingResourceID,
                HoursToBeScheduled = ticket.HoursToBeScheduled,
                InstalledProductID = ticket.InstalledProductID,
                IssueType = ticket.IssueType,
                LastActivityDate = ticket.LastActivityDate,
                LastActivityPersonType = ticket.LastActivityPersonType,
                LastActivityResourceID = ticket.LastActivityResourceID,
                LastCustomerNotificationDateTime = ticket.LastCustomerNotificationDateTime,
                LastCustomerVisibleActivityDateTime = ticket.LastCustomerVisibleActivityDateTime,
                MonitorID = ticket.MonitorID,
                MonitorTypeID = ticket.MonitorTypeID,
                OpportunityId = ticket.OpportunityId,
                Priority = ticket.Priority,
                ProblemTicketId = ticket.ProblemTicketId,
                ProjectID = ticket.ProjectID,
                PurchaseOrderNumber = ticket.PurchaseOrderNumber,
                QueueID = ticket.QueueID,
                Resolution = ticket.Resolution,
                ResolutionPlanDateTime = ticket.ResolutionPlanDateTime,
                ResolutionPlanDueDateTime = ticket.ResolutionPlanDueDateTime,
                ResolvedDateTime = ticket.ResolvedDateTime,
                ResolvedDueDateTime = ticket.ResolvedDueDateTime,
                ServiceLevelAgreementHasBeenMet = ticket.ServiceLevelAgreementHasBeenMet,
                ServiceLevelAgreementID = ticket.ServiceLevelAgreementID,
                //ServiceLevelAgreementPausedNextEventHours = ticket.ServiceLevelAgreementPausedNextEventHours,
                Source = ticket.Source,
                Status = ticket.Status,
                SubIssueType = ticket.SubIssueType,
                TicketCategory = ticket.TicketCategory,
                TicketNumber = ticket.TicketNumber,
                TicketType = ticket.TicketType,
                Title = ticket.Title,
                UserDefinedFields = Array.ConvertAll(ticket.UserDefinedFields.ToArray(), new Converter<UserDefinedField, net.autotask.webservices.UserDefinedField>(UserDefinedField.ToATWS))
            };

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

        public long? AllocationCodeID; //[AllocationCode]
        public long? AssignedResourceID; //[Resource]
        public long? AssignedResourceRoleID; //[Role]
        public long? ContactID; //[Contact]
        public long? ContractID; //[Contract]
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
