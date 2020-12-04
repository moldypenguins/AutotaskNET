using System;
using System.Linq;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class QuoteItem : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public QuoteItem() : base() { } //end QuoteItem()
        public QuoteItem(net.autotask.webservices.QuoteItem entity) : base(entity)
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

        } //end QuoteItem(net.autotask.webservices.QuoteItem entity)

        public static implicit operator net.autotask.webservices.QuoteItem(QuoteItem entity)
        {
            var newEntity = new net.autotask.webservices.QuoteItem();
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

        } //end implicit operator net.autotask.webservices.QuoteItem(QuoteItem quoteitem)

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

        public int QuoteID; //ReadOnly Required [Quote]
        public int Type; //Required PickList
        public int? ProductID; //[Product]
        public int? CostID; //[AllocationCode]
        public int? LaborID; //[Role]
        public int? ExpenseID; //[AllocationCode]
        public int? ShippingID; //[ShippingType]
        public int? ServiceID; //[Service]
        public int? ServiceBundleID; //[ServiceBundle]
        public string Name; //Length:100
        public decimal UnitPrice;
        public decimal UnitCost;
        public decimal Quantity; //Required
        public decimal UnitDiscount; //Required
        public decimal PercentageDiscount; //Required
        public bool? IsTaxable;
        public bool IsOptional; //Required
        public string PeriodType; //PickList Length:50
        public string Description; //Length:2000
        public decimal LineDiscount; //Required
        public decimal AverageCost; //ReadOnly
        public decimal HighestCost; //ReadOnly
        public int? TaxCategoryID; //[TaxCategory]
        public decimal TotalEffectiveTax; //ReadOnly
        public decimal MarkupRate; //ReadOnly
        public decimal InternalCurrencyUnitPrice; //ReadOnly
        public decimal InternalCurrencyUnitDiscount; //ReadOnly
        public decimal InternalCurrencyLineDiscount; //ReadOnly

    } //end QuoteItem

}
