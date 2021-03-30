using System;
using System.Linq;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask Service that has been added to a Recurring Service type contract.<br />
    /// In Autotask, users add and manage Autotask Services from the Admin module: Products and Services > Services > Services.<br />
    /// You add Services to a Contract when your create the contract or from the Contract Summary page.<br />
    /// <br />
    /// The entity specifies an AdjustedPrice if applicable.<br />
    /// It does not specify the number of units of the service that have been added to the contract.<br />
    /// To add Contract Service units to the contract, or remove units, use the ContractServiceAdjustment entity.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractService : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ContractService() : base() { } //end ContractService()
        public ContractService(net.autotask.webservices.ContractService entity) : base(entity)
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
        } //end ContractService(net.autotask.webservices.ContractService entity)

        public static implicit operator net.autotask.webservices.ContractService(ContractService entity)
        {
            var newEntity = new net.autotask.webservices.ContractService();
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

        } //end implicit operator net.autotask.webservices.ContractService(ContractService contractservice)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public double UnitPrice; //ReadOnly
        public long QuoteItemID; //ReadOnly [QuoteItem]
        public double InternalCurrencyUnitPrice; //ReadOnly
        public double InternalCurrencyAdjustedPrice; //ReadOnly

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int ContractID; //ReadOnly Required [Contract]
        public int ServiceID; //ReadOnly Required [Service]

        #endregion //ReadOnly Required Fields

        #region Optional Fields

        public double AdjustedPrice;
        public string InvoiceDescription; //Length:1000
        public string InternalDescription; //Length:100
        public double UnitCost;

        #endregion //Optional Fields

        #endregion //Fields

    } //end ContractService

}
