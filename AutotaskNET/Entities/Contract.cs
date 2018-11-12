using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The Contract entity describes an Autotask Contract.<br />
    /// Contracts specify a billing arrangement with an Account.<br />
    /// Autotask users manage contracts through the Contracts module.<br />
    /// Autotask currently provides six contract types: Time and Materials, Fixed Price, Block Hours, Retainer, Incident, and Recurring Service.<br />
    /// When creating a Contract, you must specify a Contract Type(Contract.ContractType).
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Contract : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => true;

        #endregion //Properties

        #region Constructors

        public Contract() : base() { } //end Contract()
        public Contract(net.autotask.webservices.Contract entity) : base(entity)
        {

        } //end Contract(net.autotask.webservices.Contract entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public string ContractPeriodType { get; set; } //ReadOnly PickList Length:1
        public long ExclusionContractID { get; set; } //ReadOnly [Contract]
        public double InternalCurrencyOverageBillingRate { get; set; } //ReadOnly
        public double InternalCurrencySetupFee { get; set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int AccountID { get; set; } //ReadOnly Required [Account]
        public int ContractType { get; set; } //ReadOnly Required PickList

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public string ContractName { get; set; } //Required Length:100
        public DateTime EndDate { get; set; } //Required
        public DateTime StartDate { get; set; } //Required
        public int Status { get; set; } //Required PickList
        public int TimeReportingRequiresStartAndStopTimes { get; set; } //Required PickList

        #endregion //Required Fields

        #region Optional Fields

        public int? BillingPreference { get; set; } //PickList
        public bool? Compliance { get; set; }
        public string ContactName { get; set; } //Length:250
        public int? ContractCategory { get; set; } //PickList
        public string ContractNumber { get; set; } //Length:50
        public bool? IsDefaultContract { get; set; }
        public string Description { get; set; } //Length:2000
        public double EstimatedCost { get; set; }
        public double EstimatedHours { get; set; }
        public double EstimatedRevenue { get; set; }
        public double OverageBillingRate { get; set; }
        public int? ServiceLevelAgreementID { get; set; } //PickList
        public double SetupFee { get; set; }
        public string PurchaseOrderNumber { get; set; } //Length:50
        public int? OpportunityID { get; set; } //[Opportunity]
        public long RenewedContractID { get; set; }
        public long SetupFeeAllocationCodeID { get; set; }
        public int? ContactID { get; set; } //[Contact]
        public int? BusinessDivisionSubdivisionID { get; set; } //[BusinessDivisionSubdivision]

        #endregion //Optional Fields

        #endregion //Fields

    } //end Contract

}
