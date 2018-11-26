using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class SubscriptionPeriod : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public SubscriptionPeriod() : base() { } //end SubscriptionPeriod()
        public SubscriptionPeriod(net.autotask.webservices.SubscriptionPeriod entity) : base(entity)
        {
            this.PeriodCost = decimal.Parse(entity.PeriodCost.ToString());
            this.PeriodDate = DateTime.Parse(entity.PeriodDate.ToString());
            this.PeriodPrice = decimal.Parse(entity.PeriodPrice.ToString());
            this.PostedDate = entity.PostedDate == null ? default(DateTime?) : DateTime.Parse(entity.PostedDate.ToString());
            this.PurchaseOrderNumber = entity.PurchaseOrderNumber == null ? default(string) : entity.PurchaseOrderNumber.ToString();
            this.SubscriptionID = int.Parse(entity.SubscriptionID.ToString());
        } //end SubscriptionPeriod(net.autotask.webservices.SubscriptionPeriod entity)

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

        public DateTime PeriodDate; //Required
        public DateTime? PostedDate;
        public int SubscriptionID; //ReadOnly Required [Subscription]
        public decimal PeriodPrice; //ReadOnly Required
        public decimal PeriodCost; //ReadOnly Required
        public string PurchaseOrderNumber; //ReadOnly Length:50

        #endregion //Fields

    } //end SubscriptionPeriod

}
