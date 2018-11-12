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

        #endregion //Fields

        public DateTime PeriodDate { get; set; } //Required
        public DateTime? PostedDate { get; set; }
        public int SubscriptionID { get; set; } //ReadOnly Required [Subscription]
        public decimal PeriodPrice { get; set; } //ReadOnly Required
        public decimal PeriodCost { get; set; } //ReadOnly Required
        public string PurchaseOrderNumber { get; set; } //ReadOnly Length:50

    } //end SubscriptionPeriod

}
