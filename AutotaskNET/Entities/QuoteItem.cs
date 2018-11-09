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

        public int QuoteID { get; set; } //ReadOnly Required [Quote]
        public int Type { get; set; } //Required PickList
        public int? ProductID { get; set; } //[Product]
        public int? CostID { get; set; } //[AllocationCode]
        public int? LaborID { get; set; } //[Role]
        public int? ExpenseID { get; set; } //[AllocationCode]
        public int? ShippingID { get; set; } //[ShippingType]
        public int? ServiceID { get; set; } //[Service]
        public int? ServiceBundleID { get; set; } //[ServiceBundle]
        public string Name { get; set; } //Length:100
        public double UnitPrice { get; set; }
        public double UnitCost { get; set; }
        public double Quantity { get; set; } //Required
        public double UnitDiscount { get; set; } //Required
        public double PercentageDiscount { get; set; } //Required
        public bool? IsTaxable { get; set; }
        public bool IsOptional { get; set; } //Required
        public string PeriodType { get; set; } //PickList Length:50
        public string Description { get; set; } //Length:2000
        public double LineDiscount { get; set; } //Required
        public double AverageCost { get; set; } //ReadOnly
        public double HighestCost { get; set; } //ReadOnly
        public int? TaxCategoryID { get; set; } //[TaxCategory]
        public double TotalEffectiveTax { get; set; } //ReadOnly
        public double MarkupRate { get; set; } //ReadOnly
        public double InternalCurrencyUnitPrice { get; set; } //ReadOnly
        public double InternalCurrencyUnitDiscount { get; set; } //ReadOnly
        public double InternalCurrencyLineDiscount { get; set; } //ReadOnly

    } //end QuoteItem

}
