using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask Opportunity.<br />
    /// An opportunity is a forecasted piece of business: that is, an identifiable prospect that needs a product or service and offers a potential sale, project, or contract.<br />
    /// Autotask Opportunities allow you to describe the amount, due date, and probability of expected sales revenue from an opportunity, track the progress of the opportunity, and generate sales forecasts.<br />
    /// <br />
    /// You can track Opportunities for all account types and track multiple opportunities for each account.<br />
    /// Opportunities can also be associated with one or more Quotes or eQuotes generated in Autotask.<br />
    /// You add and manage Opportunities in Autotask in the CRM module.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Opportunity : Entity
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

        public int AccountID { get; set; } //Required [Account]
        public decimal AdvancedField1 { get; set; }
        public decimal AdvancedField2 { get; set; }
        public decimal AdvancedField3 { get; set; }
        public decimal AdvancedField4 { get; set; }
        public decimal AdvancedField5 { get; set; }
        public decimal Amount { get; set; } //Required
        public string Barriers { get; set; } //Length:500
        public int? ContactID { get; set; } //[Contact]
        public decimal Cost { get; set; } //Required
        public DateTime CreateDate { get; set; } //Required
        public string HelpNeeded { get; set; } //Length:500
        public int? LeadReferral { get; set; } //PickList
        public string Market { get; set; } //Length:500
        public string NextStep { get; set; } //Length:500
        public int OwnerResourceID { get; set; } //Required [Resource]
        public int? ProductID { get; set; } //[Product]
        public DateTime ProjectedCloseDate { get; set; } //Required
        public DateTime? ProjectedLiveDate { get; set; }
        public string PromotionName { get; set; } //Length:50
        public string RevenueSpreadUnit { get; set; } //PickList Length:0
        public int Stage { get; set; } //Required PickList
        public int Status { get; set; } //Required PickList
        public DateTime? ThroughDate { get; set; }
        public string Title { get; set; } //Required Length:128
        public int? Rating { get; set; } //PickList
        public DateTime? ClosedDate { get; set; }
        public float AssessmentScore { get; set; } //ReadOnly
        public float TechnicalAssessmentScore { get; set; } //ReadOnly
        public float RelationshipAssessmentScore { get; set; } //ReadOnly
        public int? PrimaryCompetitor { get; set; } //PickList
        public int? WinReason { get; set; } //PickList
        public int? LossReason { get; set; } //PickList
        public string WinReasonDetail { get; set; } //Length:500
        public string LossReasonDetail { get; set; } //Length:500
        public DateTime? LastActivity { get; set; } //ReadOnly
        public DateTime? DateStamp { get; set; } //ReadOnly
        public int Probability { get; set; } //Required
        public int? RevenueSpread { get; set; }
        public bool UseQuoteTotals { get; set; } //Required
        public int? TotalAmountMonths { get; set; }
        public int? SalesProcessPercentComplete { get; set; } //ReadOnly
        public int? SalesOrderID { get; set; } //ReadOnly [SalesOrder]
        public decimal OnetimeCost { get; set; }
        public decimal OnetimeRevenue { get; set; }
        public decimal MonthlyCost { get; set; }
        public decimal MonthlyRevenue { get; set; }
        public decimal QuarterlyCost { get; set; }
        public decimal QuarterlyRevenue { get; set; }
        public decimal SemiannualCost { get; set; }
        public decimal SemiannualRevenue { get; set; }
        public decimal YearlyCost { get; set; }
        public decimal YearlyRevenue { get; set; }
        public int? BusinessDivisionSubdivisionID { get; set; } //[BusinessDivisionSubdivision]

    } //end Opportunity

}
