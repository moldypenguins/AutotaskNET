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
            this.IsOptional = bool.Parse(entity.IsOptional.ToString());
            this.LineDiscount = double.Parse(entity.LineDiscount.ToString());
            this.PercentageDiscount = double.Parse(entity.PercentageDiscount.ToString());
            this.Quantity = double.Parse(entity.Quantity.ToString());
            this.QuoteID = int.Parse(entity.QuoteID.ToString());
            this.Type = int.Parse(entity.Type.ToString());
            this.UnitDiscount = double.Parse(entity.UnitDiscount.ToString());
            this.AverageCost = double.Parse(entity.AverageCost.ToString());
            this.CostID = entity.CostID == null ? default(int?) : int.Parse(entity.CostID.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.ExpenseID = entity.ExpenseID == null ? default(int?) : int.Parse(entity.ExpenseID.ToString());
            this.HighestCost = double.Parse(entity.HighestCost.ToString());
            this.InternalCurrencyLineDiscount = double.Parse(entity.InternalCurrencyLineDiscount.ToString());
            this.InternalCurrencyUnitDiscount = double.Parse(entity.InternalCurrencyLineDiscount.ToString());
            this.InternalCurrencyUnitPrice = double.Parse(entity.InternalCurrencyUnitPrice.ToString());
            this.IsTaxable = entity.IsTaxable == null ? default(bool?) : bool.Parse(entity.IsTaxable.ToString());
            this.LaborID = entity.LaborID == null ? default(int?) : int.Parse(entity.LaborID.ToString());
            this.MarkupRate = double.Parse(entity.MarkupRate.ToString());
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
            this.PeriodType = entity.PeriodType == null ? default(string) : entity.PeriodType.ToString();
            this.ProductID = entity.ProductID == null ? default(int?) : int.Parse(entity.ProductID.ToString());
            this.ServiceBundleID = entity.ServiceBundleID == null ? default(int?) : int.Parse(entity.ServiceBundleID.ToString());
            this.ServiceID = entity.ServiceID == null ? default(int?) : int.Parse(entity.ServiceID.ToString());
            this.ShippingID = entity.ShippingID == null ? default(int?) : int.Parse(entity.ShippingID.ToString());
            this.TaxCategoryID = entity.TaxCategoryID == null ? default(int?) : int.Parse(entity.TaxCategoryID.ToString());
            this.TotalEffectiveTax = double.Parse(entity.TotalEffectiveTax.ToString());
            this.UnitCost = double.Parse(entity.UnitCost.ToString());
            this.UnitPrice = double.Parse(entity.UnitPrice.ToString());
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

        #endregion //Fields

    } //end QuoteItem

}
