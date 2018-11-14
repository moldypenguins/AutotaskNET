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

        } //end Project(net.autotask.webservices.Project entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.Project()
            {
                id = this.id,

            };

        } //end ToATWS()

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
