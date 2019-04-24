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
            this.AccountID = int.Parse(entity.AccountID.ToString());
            this.BillingPreference = entity.BillingPreference == null ? default(int?) : int.Parse(entity.BillingPreference.ToString());
            this.BusinessDivisionSubdivisionID = entity.BusinessDivisionSubdivisionID == null ? default(int?) : int.Parse(entity.BusinessDivisionSubdivisionID.ToString());
            this.Compliance = entity.Compliance == null ? default(bool?) : bool.Parse(entity.Compliance.ToString());
            this.ContractName = entity.ContractName == null ? default(string) : entity.ContractName.ToString();
            this.ContractType = int.Parse(entity.ContractType.ToString());
            this.EndDate = DateTime.Parse(entity.EndDate.ToString());
            this.StartDate = DateTime.Parse(entity.StartDate.ToString());
            this.Status = int.Parse(entity.Status.ToString());
            this.TimeReportingRequiresStartAndStopTimes = int.Parse(entity.TimeReportingRequiresStartAndStopTimes.ToString());
            this.ContactID = entity.ContactID == null ? default(int?) : int.Parse(entity.ContactID.ToString());
            this.ContactName = entity.ContactName == null ? default(string) : entity.ContactName.ToString();
            this.ContractCategory = entity.ContractCategory == null ? default(int?) : int.Parse(entity.ContractCategory.ToString());
            this.ContractNumber = entity.ContractNumber == null ? default(string) : entity.ContractNumber.ToString();
            this.ContractPeriodType = entity.ContractPeriodType == null ? default(string) : entity.ContractPeriodType.ToString();
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.EstimatedCost = entity.EstimatedCost == null ? default(double?) : double.Parse(entity.EstimatedCost.ToString());
            this.EstimatedHours = entity.EstimatedHours == null ? default(double?) : double.Parse(entity.EstimatedHours.ToString());
            this.EstimatedRevenue = entity.EstimatedRevenue == null ? default(double?) : double.Parse(entity.EstimatedRevenue.ToString());
            this.ExclusionContractID = entity.ExclusionContractID == null ? default(long?) : long.Parse(entity.ExclusionContractID.ToString());
            this.InternalCurrencyOverageBillingRate = entity.InternalCurrencyOverageBillingRate == null ? default(double?) : double.Parse(entity.InternalCurrencyOverageBillingRate.ToString());
            this.InternalCurrencySetupFee = entity.InternalCurrencySetupFee == null ? default(double?) : double.Parse(entity.InternalCurrencySetupFee.ToString());
            this.IsDefaultContract = entity.IsDefaultContract == null ? default(bool?) : bool.Parse(entity.IsDefaultContract.ToString());
            this.OpportunityID = entity.OpportunityID == null ? default(int?) : int.Parse(entity.OpportunityID.ToString());
            this.OverageBillingRate = entity.OverageBillingRate == null ? default(double?) : double.Parse(entity.OverageBillingRate.ToString());
            this.PurchaseOrderNumber = entity.PurchaseOrderNumber == null ? default(string) : entity.PurchaseOrderNumber.ToString();
            this.RenewedContractID = entity.RenewedContractID == null ? default(long?) : long.Parse(entity.RenewedContractID.ToString());
            this.ServiceLevelAgreementID = entity.ServiceLevelAgreementID == null ? default(int?) : int.Parse(entity.ServiceLevelAgreementID.ToString());
            this.SetupFee = entity.SetupFee == null ? default(double?) : double.Parse(entity.SetupFee.ToString());
            this.SetupFeeAllocationCodeID = entity.SetupFeeAllocationCodeID == null ? default(long?) : long.Parse(entity.SetupFeeAllocationCodeID.ToString());

        } //end Contract(net.autotask.webservices.Contract entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.Contract()
            {
                id = this.id,
                AccountID = this.AccountID,
                BillingPreference = this.BillingPreference,
                BusinessDivisionSubdivisionID = this.BusinessDivisionSubdivisionID,
                Compliance = this.Compliance,
                ContactID = this.ContactID,
                ContactName = this.ContactName,
                ContractCategory = this.ContractCategory,
                ContractName = this.ContractName,
                ContractNumber = this.ContractNumber,
                ContractPeriodType = this.ContractPeriodType,
                ContractType = this.ContractType,
                Description = this.Description,
                EndDate = this.EndDate,
                EstimatedCost = this.EstimatedCost,
                EstimatedHours = this.EstimatedHours,
                EstimatedRevenue = this.EstimatedRevenue,
                ExclusionContractID = this.ExclusionContractID,
                InternalCurrencyOverageBillingRate = this.InternalCurrencyOverageBillingRate,
                InternalCurrencySetupFee = this.InternalCurrencySetupFee,
                IsDefaultContract = this.IsDefaultContract,
                OpportunityID = this.OpportunityID,
                OverageBillingRate = this.OverageBillingRate,
                PurchaseOrderNumber = this.PurchaseOrderNumber,
                RenewedContractID = this.RenewedContractID,
                ServiceLevelAgreementID = this.ServiceLevelAgreementID,
                SetupFee = this.SetupFee,
                SetupFeeAllocationCodeID = this.SetupFeeAllocationCodeID,
                StartDate = this.StartDate,
                Status = this.Status,
                TimeReportingRequiresStartAndStopTimes = this.TimeReportingRequiresStartAndStopTimes
            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public string ContractPeriodType; //ReadOnly PickList Length:1
        public long? ExclusionContractID; //ReadOnly [Contract]
        public double? InternalCurrencyOverageBillingRate; //ReadOnly
        public double? InternalCurrencySetupFee; //ReadOnly

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int AccountID; //ReadOnly Required [Account]
        public int ContractType; //ReadOnly Required PickList

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public string ContractName; //Required Length:100
        public DateTime EndDate; //Required
        public DateTime StartDate; //Required
        public int Status; //Required PickList
        public int TimeReportingRequiresStartAndStopTimes; //Required PickList

        #endregion //Required Fields

        #region Optional Fields

        public int? BillingPreference; //PickList
        public bool? Compliance;
        public string ContactName; //Length:250
        public int? ContractCategory; //PickList
        public string ContractNumber; //Length:50
        public bool? IsDefaultContract;
        public string Description; //Length:2000
        public double? EstimatedCost;
        public double? EstimatedHours;
        public double? EstimatedRevenue;
        public double? OverageBillingRate;
        public int? ServiceLevelAgreementID; //PickList
        public double? SetupFee;
        public string PurchaseOrderNumber; //Length:50
        public int? OpportunityID; //[Opportunity]
        public long? RenewedContractID;
        public long? SetupFeeAllocationCodeID;
        public int? ContactID; //[Contact]
        public int? BusinessDivisionSubdivisionID; //[BusinessDivisionSubdivision]

        #endregion //Optional Fields

        #endregion //Fields

    } //end Contract

}
