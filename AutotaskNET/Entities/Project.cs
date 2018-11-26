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
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => true;

        #endregion //Properties

        #region Constructors

        public Project() : base() { } //end Project()
        public Project(net.autotask.webservices.Project entity) : base(entity)
        {
            this.AccountID = int.Parse(entity.AccountID.ToString());
            this.EndDateTime = DateTime.Parse(entity.EndDateTime.ToString());
            this.ProjectName = entity.ProjectName == null ? default(string) : entity.ProjectName.ToString();
            this.StartDateTime = DateTime.Parse(entity.StartDateTime.ToString());
            this.Type = int.Parse(entity.Type.ToString());
            this.ActualBilledHours = float.Parse(entity.ActualBilledHours.ToString());
            this.ActualHours = float.Parse(entity.ActualHours.ToString());
            this.BusinessDivisionSubdivisionID = entity.BusinessDivisionSubdivisionID == null ? default(int?) : int.Parse(entity.BusinessDivisionSubdivisionID.ToString());
            this.ChangeOrdersBudget = float.Parse(entity.ChangeOrdersBudget.ToString());
            this.ChangeOrdersRevenue = float.Parse(entity.ChangeOrdersRevenue.ToString());
            this.CompanyOwnerResourceID = entity.CompanyOwnerResourceID == null ? default(int?) : int.Parse(entity.CompanyOwnerResourceID.ToString());
            this.CompletedDateTime = entity.CreateDateTime == null ? default(DateTime?) : DateTime.Parse(entity.CreateDateTime.ToString());
            this.CompletedPercentage = entity.CompletedPercentage == null ? default(int?) : int.Parse(entity.CompletedPercentage.ToString());
            this.ContractID = entity.ContractID == null ? default(int?) : int.Parse(entity.ContractID.ToString());
            this.CreateDateTime = entity.CreateDateTime == null ? default(DateTime?) : DateTime.Parse(entity.CreateDateTime.ToString());
            this.CreatorResourceID = entity.CreatorResourceID == null ? default(int?) : int.Parse(entity.CreatorResourceID.ToString());
            this.Department = entity.Department == null ? default(int?) : int.Parse(entity.Department.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.Duration = entity.Duration == null ? default(int?) : int.Parse(entity.Duration.ToString());
            this.EstimatedSalesCost = float.Parse(EstimatedSalesCost.ToString());
            this.EstimatedTime = float.Parse(entity.EstimatedTime.ToString());
            this.ExtPNumber = entity.ExtPNumber == null ? default(string) : entity.ExtPNumber.ToString();
            this.ExtProjectType = entity.ExtProjectType == null ? default(int?) : int.Parse(entity.ExtProjectType.ToString());
            this.LaborEstimatedCosts = float.Parse(entity.LaborEstimatedCosts.ToString());
            this.LaborEstimatedMarginPercentage = float.Parse(entity.LaborEstimatedMarginPercentage.ToString());
            this.LaborEstimatedRevenue = float.Parse(entity.LaborEstimatedRevenue.ToString());
            this.LineOfBusiness = entity.LineOfBusiness == null ? default(int?) : int.Parse(entity.LineOfBusiness.ToString());
            this.OriginalEstimatedRevenue = float.Parse(entity.OriginalEstimatedRevenue.ToString());
            this.ProjectCostEstimatedMarginPercentage = float.Parse(entity.ProjectCostEstimatedMarginPercentage.ToString());
            this.ProjectCostsBudget = float.Parse(entity.ProjectCostsBudget.ToString());
            this.ProjectCostsRevenue = float.Parse(entity.ProjectCostsRevenue.ToString());
            this.ProjectLeadResourceID = entity.ProjectLeadResourceID == null ? default(int?) : int.Parse(entity.ProjectLeadResourceID.ToString());
            this.ProjectNumber = entity.ProjectNumber == null ? default(string) : entity.ProjectNumber.ToString();
            this.PurchaseOrderNumber = entity.PurchaseOrderNumber == null ? default(string) : entity.PurchaseOrderNumber.ToString();
            this.SGDA = float.Parse(entity.SGDA.ToString());
            this.Status = int.Parse(entity.Status.ToString());
            this.StatusDateTime = entity.StatusDateTime == null ? default(DateTime?) : DateTime.Parse(entity.StatusDateTime.ToString());
            this.StatusDetail = entity.StatusDetail == null ? default(string) : entity.StatusDetail.ToString();
        } //end Project(net.autotask.webservices.Project entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public string ProjectNumber; //ReadOnly Length:50
        public DateTime? CreateDateTime; //ReadOnly
        public int? CreatorResourceID; //ReadOnly [Resource]
        public int? Duration; //ReadOnly
        public float ActualHours; //ReadOnly
        public float ActualBilledHours; //ReadOnly
        public float EstimatedTime; //ReadOnly
        public float LaborEstimatedMarginPercentage; //ReadOnly
        public float ProjectCostEstimatedMarginPercentage; //ReadOnly
        public float ChangeOrdersRevenue; //ReadOnly
        public float ChangeOrdersBudget; //ReadOnly
        public int? CompanyOwnerResourceID; //ReadOnly [Resource]
        public int? CompletedPercentage; //ReadOnly
        public int? LastActivityResourceID; //ReadOnly [Resource]
        public DateTime? LastActivityDateTime; //ReadOnly
        public int? LastActivityPersonType; //ReadOnly

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int AccountID; //ReadOnly Required [Account]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public string ProjectName; //Required Length:100
        public int Type; //Required PickList
        public DateTime StartDateTime; //Required
        public DateTime EndDateTime; //Required
        public int Status; //Required PickList

        #endregion //Required Fields

        #region Optional Fields

        public int? ExtProjectType;
        public string ExtPNumber; //Length:50
        public string Description; //Length:2000
        public float LaborEstimatedRevenue;
        public float LaborEstimatedCosts;
        public float ProjectCostsRevenue;
        public float ProjectCostsBudget;
        public float SGDA;
        public float OriginalEstimatedRevenue;
        public float EstimatedSalesCost;
        public int? ContractID; //[Contract]
        public int? ProjectLeadResourceID; //[Resource]
        public DateTime? CompletedDateTime;
        public string StatusDetail; //Length:2000
        public DateTime? StatusDateTime;
        public int? Department; //PickList
        public int? LineOfBusiness; //PickList
        public string PurchaseOrderNumber; //Length:50
        public int? BusinessDivisionSubdivisionID; //[BusinessDivisionSubdivision]

        #endregion //Optional Fields
        
        #endregion //Fields

    } //end Project

}
