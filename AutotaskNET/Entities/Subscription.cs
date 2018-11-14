using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Subscription : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public Subscription() : base() { } //end Subscription()
        public Subscription(net.autotask.webservices.Subscription entity) : base(entity)
        {

        } //end Account(net.autotask.webservices.Account entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.Subscription()
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

        public int MaterialCodeID; //Required [AllocationCode]
        public string Description; //Length:2000
        public string SubscriptionName; //Required Length:100
        public DateTime ExpirationDate; //Required
        public DateTime EffectiveDate; //Required
        public decimal TotalCost; //ReadOnly
        public decimal TotalPrice; //ReadOnly
        public int InstalledProductID; //ReadOnly Required [InstalledProduct]
        public string PurchaseOrderNumber; //Length:50
        public string PeriodType; //Required PickList Length:0
        public int Status; //Required PickList
        public decimal PeriodCost;
        public decimal PeriodPrice; //Required
        public int? VendorID; //[Account]
        public int? BusinessDivisionSubdivisionID; //ReadOnly [BusinessDivisionSubdivision]

    } //end Subscription

}
