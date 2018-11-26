using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// this. entity describes an Autotask Opportunity.<br />
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
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => true;

        #endregion //Properties

        #region Constructors

        public Opportunity() : base() { } //end Opportunity()
        public Opportunity(net.autotask.webservices.Opportunity entity) : base(entity)
        {
             this.AccountID = int.Parse(entity.AccountID.ToString());
             this.Amount = decimal.Parse(entity.Amount.ToString());
             this.Cost = decimal.Parse(entity.Cost.ToString());
             this.CreateDate = DateTime.Parse(entity.CreateDate.ToString());
             this.OwnerResourceID = int.Parse(entity.OwnerResourceID.ToString());
             this.AdvancedField1 = decimal.Parse(entity.AdvancedField1.ToString());
             this.AdvancedField2 = decimal.Parse(entity.AdvancedField2.ToString());
             this.AdvancedField3 = decimal.Parse(entity.AdvancedField3.ToString());
             this.AdvancedField4 = decimal.Parse(entity.AdvancedField4.ToString());
             this.AdvancedField5 = decimal.Parse(entity.AdvancedField5.ToString());
             this.AssessmentScore = float.Parse(entity.AssessmentScore.ToString());
             this.Barriers = entity.Barriers == null ? default(string) : entity.Barriers.ToString();
             this.BusinessDivisionSubdivisionID = entity.BusinessDivisionSubdivisionID == null ? default(int?) : int.Parse(entity.BusinessDivisionSubdivisionID.ToString());
             this.ClosedDate = entity.ClosedDate == null ? default(DateTime?) : DateTime.Parse(entity.ClosedDate.ToString());
             this.ContactID = entity.ContactID == null ? default(int?) : int.Parse(entity.ContactID.ToString());
             this.DateStamp = entity.DateStamp == null ? default(DateTime?) : DateTime.Parse(entity.DateStamp.ToString());
             this.HelpNeeded = entity.HelpNeeded == null ? default(string) : entity.HelpNeeded.ToString();
             this.LastActivity = entity.LastActivity == null ? default(DateTime?) : DateTime.Parse(entity.LastActivity.ToString());
             this.LeadReferral = entity.LeadReferral == null ? default(int?) : int.Parse(entity.LeadReferral.ToString());
             this.LossReason = entity.LossReason == null ? default(int?) : int.Parse(entity.LossReason.ToString());
             this.LossReasonDetail = entity.LossReasonDetail == null ? default(string) : entity.LossReasonDetail.ToString();
             this.Market = entity.Market == null ? default(string) : entity.Market.ToString();
             this.MonthlyCost = decimal.Parse(entity.MonthlyCost.ToString());
             this.MonthlyRevenue = decimal.Parse(entity.MonthlyRevenue.ToString());
             this.NextStep = entity.NextStep == null ? default(string) : entity.NextStep.ToString();
             this.OnetimeCost = decimal.Parse(entity.OnetimeCost.ToString());
             this.OnetimeRevenue = decimal.Parse(entity.OnetimeRevenue.ToString());
             this.PrimaryCompetitor = entity.PrimaryCompetitor == null ? default(int?) : int.Parse(entity.PrimaryCompetitor.ToString());
             this.Probability = int.Parse(entity.Probability.ToString());
             this.ProductID = entity.ProductID == null ? default(int?) : int.Parse(entity.ProductID.ToString());
             this.ProjectedCloseDate = DateTime.Parse(entity.ProjectedCloseDate.ToString());
             this.ProjectedLiveDate = entity.ProjectedLiveDate == null ? default(DateTime?) : DateTime.Parse(entity.ProjectedLiveDate.ToString());
             this.PromotionName = entity.PromotionName == null ? default(string) : entity.PromotionName.ToString();
             this.QuarterlyCost = decimal.Parse(entity.QuarterlyCost.ToString());
             this.QuarterlyRevenue = decimal.Parse(entity.QuarterlyRevenue.ToString());
             this.Rating = entity.Rating == null ? default(int?) : int.Parse(entity.Rating.ToString());
             this.RelationshipAssessmentScore = float.Parse(entity.RelationshipAssessmentScore.ToString());
             this.RevenueSpread = entity.RevenueSpread == null ? default(int?) : int.Parse(entity.RevenueSpread.ToString());
             this.RevenueSpreadUnit = entity.RevenueSpreadUnit == null ? default(string) : entity.RevenueSpreadUnit.ToString();
             this.SalesOrderID = entity.SalesOrderID == null ? default(int?) : int.Parse(entity.SalesOrderID.ToString());
             this.SalesProcessPercentComplete = entity.SalesProcessPercentComplete == null ? default(int?) : int.Parse(entity.SalesProcessPercentComplete.ToString());
             this.SemiannualCost = decimal.Parse(entity.SemiannualCost.ToString());
             this.SemiannualRevenue = decimal.Parse(entity.SemiannualRevenue.ToString());
             this.Stage = int.Parse(entity.Stage.ToString());
             this.Status = int.Parse(entity.Status.ToString());
             this.TechnicalAssessmentScore = float.Parse(entity.TechnicalAssessmentScore.ToString());
             this.ThroughDate = entity.ThroughDate == null ? default(DateTime?) : DateTime.Parse(entity.ThroughDate.ToString());
             this.Title = entity.Title == null ? default(string) : entity.Title.ToString();
             this.TotalAmountMonths = entity.TotalAmountMonths == null ? default(int?) : int.Parse(entity.TotalAmountMonths.ToString());
             this.UseQuoteTotals = bool.Parse(entity.UseQuoteTotals.ToString());
             this.WinReason = entity.WinReason == null ? default(int?) : int.Parse(entity.WinReason.ToString());
             this.WinReasonDetail = entity.WinReasonDetail == null ? default(string) : entity.WinReasonDetail.ToString();
             this.YearlyCost = decimal.Parse(entity.YearlyCost.ToString());
             this.YearlyRevenue = decimal.Parse(entity.YearlyRevenue.ToString());
        } //end Opportunity(net.autotask.webservices.Opportunity entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

        #endregion //Fields

        public int AccountID; //Required [Account]
        public decimal AdvancedField1;
        public decimal AdvancedField2;
        public decimal AdvancedField3;
        public decimal AdvancedField4;
        public decimal AdvancedField5;
        public decimal Amount; //Required
        public string Barriers; //Length:500
        public int? ContactID; //[Contact]
        public decimal Cost; //Required
        public DateTime CreateDate; //Required
        public string HelpNeeded; //Length:500
        public int? LeadReferral; //PickList
        public string Market; //Length:500
        public string NextStep; //Length:500
        public int OwnerResourceID; //Required [Resource]
        public int? ProductID; //[Product]
        public DateTime ProjectedCloseDate; //Required
        public DateTime? ProjectedLiveDate;
        public string PromotionName; //Length:50
        public string RevenueSpreadUnit; //PickList Length:0
        public int Stage; //Required PickList
        public int Status; //Required PickList
        public DateTime? ThroughDate;
        public string Title; //Required Length:128
        public int? Rating; //PickList
        public DateTime? ClosedDate;
        public float AssessmentScore; //ReadOnly
        public float TechnicalAssessmentScore; //ReadOnly
        public float RelationshipAssessmentScore; //ReadOnly
        public int? PrimaryCompetitor; //PickList
        public int? WinReason; //PickList
        public int? LossReason; //PickList
        public string WinReasonDetail; //Length:500
        public string LossReasonDetail; //Length:500
        public DateTime? LastActivity; //ReadOnly
        public DateTime? DateStamp; //ReadOnly
        public int Probability; //Required
        public int? RevenueSpread;
        public bool UseQuoteTotals; //Required
        public int? TotalAmountMonths;
        public int? SalesProcessPercentComplete; //ReadOnly
        public int? SalesOrderID; //ReadOnly [SalesOrder]
        public decimal OnetimeCost;
        public decimal OnetimeRevenue;
        public decimal MonthlyCost;
        public decimal MonthlyRevenue;
        public decimal QuarterlyCost;
        public decimal QuarterlyRevenue;
        public decimal SemiannualCost;
        public decimal SemiannualRevenue;
        public decimal YearlyCost;
        public decimal YearlyRevenue;
        public int? BusinessDivisionSubdivisionID; //[BusinessDivisionSubdivision]

    } //end Opportunity

}
