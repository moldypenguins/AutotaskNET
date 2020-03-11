using System;
using System.Linq;

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
            this.id = entity.id;
            this.Title = entity.Title?.ToString();
            this.AccountID = entity.AccountID == null ? 0 : int.Parse(entity.AccountID.ToString());
            this.AdvancedField1 = entity.AdvancedField1 == null ? default : decimal.Parse(entity.AdvancedField1.ToString());
            this.AdvancedField2 = entity.AdvancedField2 == null ? default : decimal.Parse(entity.AdvancedField2.ToString());
            this.AdvancedField3 = entity.AdvancedField3 == null ? default : decimal.Parse(entity.AdvancedField3.ToString());
            this.AdvancedField4 = entity.AdvancedField4 == null ? default : decimal.Parse(entity.AdvancedField4.ToString());
            this.AdvancedField5 = entity.AdvancedField5 == null ? default : decimal.Parse(entity.AdvancedField5.ToString());

            this.Amount = entity.Amount == null ? default : decimal.Parse(entity.Amount.ToString());
            this.AssessmentScore = entity.AssessmentScore == null ? default : float.Parse(entity.AssessmentScore.ToString());
            this.Barriers = entity.Barriers?.ToString();
            this.BusinessDivisionSubdivisionID = entity.BusinessDivisionSubdivisionID == null ? default : int.Parse(entity.BusinessDivisionSubdivisionID.ToString());
            this.ClosedDate = entity.ClosedDate == null ? default : DateTime.Parse(entity.ClosedDate.ToString());
            this.ContactID = entity.ContactID == null ? default : int.Parse(entity.ContactID.ToString());
            this.Cost = entity.Cost == null ? default : decimal.Parse(entity.Cost.ToString());
            this.CreateDate = entity.CreateDate == null ? default : DateTime.Parse(entity.CreateDate.ToString());
            this.DateStamp = entity.DateStamp == null ? default : DateTime.Parse(entity.DateStamp.ToString());
            this.HelpNeeded = entity.HelpNeeded?.ToString();
            this.LastActivity = entity.LastActivity == null ? default : DateTime.Parse(entity.LastActivity.ToString());
            this.LeadReferral = entity.LeadReferral == null ? default : int.Parse(entity.LeadReferral.ToString());
            this.LossReason = entity.LossReason == null ? default : int.Parse(entity.LossReason.ToString());
            this.LossReasonDetail = entity.LossReasonDetail?.ToString();
            this.Market = entity.Market?.ToString();
            this.MonthlyCost = entity.MonthlyCost == null ? default : decimal.Parse(entity.MonthlyCost.ToString());
            this.MonthlyRevenue = entity.MonthlyRevenue == null ? default : decimal.Parse(entity.MonthlyRevenue.ToString());
            this.NextStep = entity.NextStep.ToString();
            this.OnetimeCost = entity.OnetimeCost == null ? default : decimal.Parse(entity.OnetimeCost.ToString());
            this.OnetimeRevenue = entity.OnetimeRevenue == null ? default : decimal.Parse(entity.OnetimeRevenue.ToString());
            this.OwnerResourceID = entity.OwnerResourceID == null ? default : int.Parse(entity.OwnerResourceID.ToString());
            this.PrimaryCompetitor = entity.PrimaryCompetitor == null ? default : int.Parse(entity.PrimaryCompetitor.ToString());
            this.Probability = entity.Probability == null ? default : int.Parse(entity.Probability.ToString());
            this.ProductID = entity.ProductID == null ? default : int.Parse(entity.ProductID.ToString());
            this.ProjectedCloseDate = entity.ProjectedCloseDate == null ? default: DateTime.Parse(entity.ProjectedCloseDate.ToString());
            this.ProjectedLiveDate = entity.ProjectedLiveDate == null ? default : DateTime.Parse(entity.ProjectedLiveDate.ToString());
            this.PromotionName = entity.PromotionName?.ToString();
            this.QuarterlyCost = entity.QuarterlyCost == null ? default : decimal.Parse(entity.QuarterlyCost.ToString());
            this.QuarterlyRevenue = entity.QuarterlyRevenue == null ? default : decimal.Parse(entity.QuarterlyRevenue.ToString());
            this.Rating = entity.Rating == null ? default : int.Parse(entity.Rating.ToString());
            this.RelationshipAssessmentScore = entity.RelationshipAssessmentScore == null ? default : float.Parse(entity.RelationshipAssessmentScore.ToString());
            this.RevenueSpread = entity.RevenueSpread == null ? default : int.Parse(entity.RevenueSpread.ToString());
            this.RevenueSpreadUnit = entity.RevenueSpreadUnit?.ToString();
            this.SemiannualRevenue = entity.SemiannualRevenue == null ? default : decimal.Parse(entity.SemiannualRevenue.ToString());
            this.SemiannualCost = entity.SemiannualCost == null ? default : decimal.Parse(entity.SemiannualCost.ToString());
            this.SalesOrderID = entity.SalesOrderID == null ? default : int.Parse(entity.SalesOrderID.ToString());
            this.SalesProcessPercentComplete = entity.SalesProcessPercentComplete == null ? default : int.Parse(entity.SalesProcessPercentComplete.ToString());
            this.Stage = entity.Stage == null ? default : int.Parse(entity.Stage.ToString());
            this.Status = entity.Status == null ? default : int.Parse(entity.Status.ToString());
            this.TechnicalAssessmentScore = entity.TechnicalAssessmentScore == null ? default : int.Parse(entity.TechnicalAssessmentScore.ToString());
            this.ThroughDate = entity.ThroughDate == null ? default : DateTime.Parse(entity.ThroughDate.ToString());
            this.TotalAmountMonths = entity.TotalAmountMonths == null ? default : int.Parse(entity.TotalAmountMonths.ToString());
            this.UseQuoteTotals = entity.UseQuoteTotals == null ? default: bool.Parse(entity.UseQuoteTotals.ToString());
            this.WinReasonDetail = entity.WinReasonDetail?.ToString();
            this.WinReason = entity.WinReason == null ? default : int.Parse(entity.WinReason.ToString());
            this.YearlyCost = entity.YearlyCost == null ? default : decimal.Parse(entity.YearlyCost.ToString());
            this.YearlyRevenue = entity.YearlyRevenue == null ? default : decimal.Parse(entity.YearlyRevenue.ToString());
            this.UserDefinedFields = entity.UserDefinedFields?.Select(udf => new UserDefinedField { Name = udf.Name, Value = udf.Value }).ToList();


        } //end Opportunity(net.autotask.webservices.Opportunity entity)

        public static implicit operator net.autotask.webservices.Opportunity(Opportunity opportunity)
        {
            return new net.autotask.webservices.Opportunity()
            {
                id = opportunity.id,
                Title = opportunity.Title,
                AccountID = opportunity.AccountID,
                AdvancedField1 = opportunity.AdvancedField1,
                AdvancedField2 = opportunity.AdvancedField2,
                AdvancedField3 = opportunity.AdvancedField3,
                AdvancedField4 = opportunity.AdvancedField4,
                AdvancedField5 = opportunity.AdvancedField5,
                Amount = opportunity.Amount,
                AssessmentScore = opportunity.AssessmentScore,
                Barriers = opportunity.Barriers,
                BusinessDivisionSubdivisionID = opportunity.BusinessDivisionSubdivisionID,
                ClosedDate = opportunity.ClosedDate,
                ContactID = opportunity.ContactID,
                Cost = opportunity.Cost,
                CreateDate = opportunity.CreateDate,
                DateStamp = opportunity.DateStamp,
                HelpNeeded = opportunity.HelpNeeded,
                LastActivity = opportunity.LastActivity,
                LeadReferral = opportunity.LeadReferral,
                LossReason = opportunity.LossReason,
                LossReasonDetail = opportunity.LossReasonDetail,
                Market = opportunity.Market,
                MonthlyCost = opportunity.MonthlyCost,
                MonthlyRevenue = opportunity.MonthlyRevenue,
                NextStep = opportunity.NextStep,
                OnetimeCost = opportunity.OnetimeCost,
                OnetimeRevenue = opportunity.OnetimeRevenue,
                OwnerResourceID = opportunity.OwnerResourceID,
                PrimaryCompetitor = opportunity.PrimaryCompetitor,
                Probability = opportunity.Probability,
                ProductID = opportunity.ProductID,
                ProjectedCloseDate = opportunity.ProjectedCloseDate,
                ProjectedLiveDate = opportunity.ProjectedLiveDate,
                PromotionName = opportunity.PromotionName,
                QuarterlyCost = opportunity.QuarterlyCost,
                Rating = opportunity.Rating,
                QuarterlyRevenue = opportunity.QuarterlyRevenue,
                RelationshipAssessmentScore = opportunity.RelationshipAssessmentScore,
                RevenueSpread = opportunity.RevenueSpread,
                RevenueSpreadUnit = opportunity.RevenueSpreadUnit,
                SemiannualRevenue = opportunity.SemiannualRevenue,
                SalesOrderID = opportunity.SalesOrderID,
                SalesProcessPercentComplete = opportunity.SalesProcessPercentComplete,
                SemiannualCost = opportunity.SemiannualCost,
                Stage = opportunity.Stage,
                Status = opportunity.Status,
                TechnicalAssessmentScore = opportunity.TechnicalAssessmentScore,
                ThroughDate = opportunity.ThroughDate,
                TotalAmountMonths = opportunity.TotalAmountMonths,
                UseQuoteTotals = opportunity.UseQuoteTotals,
                WinReason = opportunity.WinReason,
                WinReasonDetail = opportunity.WinReasonDetail,
                YearlyCost = opportunity.YearlyCost,
                YearlyRevenue = opportunity.YearlyRevenue,
                UserDefinedFields = Array.ConvertAll(opportunity.UserDefinedFields.ToArray(), new Converter<UserDefinedField, net.autotask.webservices.UserDefinedField>(UserDefinedField.ToATWS))
            };

        } //end implicit operator net.autotask.webservices.Opportunity(Opportunity opportunity)

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
