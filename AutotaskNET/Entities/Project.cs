using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask Project.<br />
    /// A project defines and organizes a group of related tasks, events, and documents.<br />
    /// Each Project is specific to one Account and can include phases.<br />
    /// Autotask users manage Projects through the Projects module.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Project : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => true;

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

        public string ProjectName { get; set; } //Required Length:100
        public int AccountID { get; set; } //ReadOnly Required [Account]
        public int Type { get; set; } //Required PickList
        public int? ExtProjectType { get; set; }
        public string ExtPNumber { get; set; } //Length:50
        public string ProjectNumber { get; set; } //ReadOnly Length:50
        public string Description { get; set; } //Length:2000
        public DateTime? CreateDateTime { get; set; } //ReadOnly
        public int? CreatorResourceID { get; set; } //ReadOnly [Resource]
        public DateTime StartDateTime { get; set; } //Required
        public DateTime EndDateTime { get; set; } //Required
        public int? Duration { get; set; } //ReadOnly
        public float ActualHours { get; set; } //ReadOnly
        public float ActualBilledHours { get; set; } //ReadOnly
        public float EstimatedTime { get; set; } //ReadOnly
        public float LaborEstimatedRevenue { get; set; }
        public float LaborEstimatedCosts { get; set; }
        public float LaborEstimatedMarginPercentage { get; set; } //ReadOnly
        public float ProjectCostsRevenue { get; set; }
        public float ProjectCostsBudget { get; set; }
        public float ProjectCostEstimatedMarginPercentage { get; set; } //ReadOnly
        public float ChangeOrdersRevenue { get; set; } //ReadOnly
        public float ChangeOrdersBudget { get; set; } //ReadOnly
        public float SGDA { get; set; }
        public float OriginalEstimatedRevenue { get; set; }
        public float EstimatedSalesCost { get; set; }
        public int Status { get; set; } //Required PickList
        public int? ContractID { get; set; } //[Contract]
        public int? ProjectLeadResourceID { get; set; } //[Resource]
        public int? CompanyOwnerResourceID { get; set; } //ReadOnly [Resource]
        public int? CompletedPercentage { get; set; } //ReadOnly
        public DateTime? CompletedDateTime { get; set; }
        public string StatusDetail { get; set; } //Length:2000
        public DateTime? StatusDateTime { get; set; }
        public int? Department { get; set; } //PickList
        public int? LineOfBusiness { get; set; } //PickList
        public string PurchaseOrderNumber { get; set; } //Length:50
        public int? BusinessDivisionSubdivisionID { get; set; } //[BusinessDivisionSubdivision]
        public int? LastActivityResourceID { get; set; } //ReadOnly [Resource]
        public DateTime? LastActivityDateTime { get; set; } //ReadOnly
        public int? LastActivityPersonType { get; set; } //ReadOnly

    } //end Project

}
