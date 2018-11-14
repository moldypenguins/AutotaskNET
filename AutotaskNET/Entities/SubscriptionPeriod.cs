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

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.SubscriptionPeriod()
            {
                id = this.id,

            };

        } //end ToATWS()

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

        public DateTime PeriodDate; //Required
        public DateTime? PostedDate;
        public int SubscriptionID; //ReadOnly Required [Subscription]
        public decimal PeriodPrice; //ReadOnly Required
        public decimal PeriodCost; //ReadOnly Required
        public string PurchaseOrderNumber; //ReadOnly Length:50

    } //end SubscriptionPeriod

}
