using System;

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

        } //end QuoteItem(net.autotask.webservices.QuoteItem entity)

        public static implicit operator net.autotask.webservices.QuoteItem(QuoteItem quoteitem)
        {
            return new net.autotask.webservices.QuoteItem()
            {
                id = quoteitem.id,

            };

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
        public double UnitPrice;
        public double UnitCost;
        public double Quantity; //Required
        public double UnitDiscount; //Required
        public double PercentageDiscount; //Required
        public bool? IsTaxable;
        public bool IsOptional; //Required
        public string PeriodType; //PickList Length:50
        public string Description; //Length:2000
        public double LineDiscount; //Required
        public double AverageCost; //ReadOnly
        public double HighestCost; //ReadOnly
        public int? TaxCategoryID; //[TaxCategory]
        public double TotalEffectiveTax; //ReadOnly
        public double MarkupRate; //ReadOnly
        public double InternalCurrencyUnitPrice; //ReadOnly
        public double InternalCurrencyUnitDiscount; //ReadOnly
        public double InternalCurrencyLineDiscount; //ReadOnly

    } //end QuoteItem

}
