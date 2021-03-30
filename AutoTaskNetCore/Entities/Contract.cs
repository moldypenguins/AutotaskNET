using System;
using System.Linq;

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
            var thisType = GetType();
            var fields = GetType().GetFields();
            var entityReflection = entity.GetType();

            foreach (var i in fields)
            {
                try
                {
                    if (i.Name == "UserDefinedFields")
                    {
                        // treat differently:
                        UserDefinedFields = entity.UserDefinedFields?.Select(udf => new UserDefinedField { Name = udf.Name, Value = udf.Value }).ToList();
                        continue;
                    }

                    var value = entityReflection.GetProperty(i.Name)?.GetValue(entity);
                    thisType.GetField(i.Name).SetValue(this, value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

        } //end Contract(net.autotask.webservices.Contract entity)

        public static implicit operator net.autotask.webservices.Contract(Contract entity)
        {
            var newEntity = new net.autotask.webservices.Contract();
            var entityReflection = newEntity.GetType();
            var thisType = entity.GetType();
            var fields = entity.GetType().GetFields();

            foreach (var i in entityReflection.GetProperties())
            {
                try
                {
                    if (i.Name == "UserDefinedFields")
                    {
                        newEntity.UserDefinedFields = entity.UserDefinedFields == null
                            ? default
                            : Array.ConvertAll(entity.UserDefinedFields?.ToArray(), UserDefinedField.ToATWS);
                        continue;
                    }

                    if (i.Name == "Fields")
                        continue;

                    var value = thisType.GetField(i.Name).GetValue(entity);
                    entityReflection.GetProperty(i.Name)?.SetValue(newEntity, value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(i.Name);
                    Console.WriteLine(e);
                    throw;
                }
            }

            return newEntity;

        } //end implicit operator net.autotask.webservices.Contract(Contract contract)

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
