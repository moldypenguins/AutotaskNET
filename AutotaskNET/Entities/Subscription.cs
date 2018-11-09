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

        public int MaterialCodeID { get; set; } //Required [AllocationCode]
        public string Description { get; set; } //Length:2000
        public string SubscriptionName { get; set; } //Required Length:100
        public DateTime ExpirationDate { get; set; } //Required
        public DateTime EffectiveDate { get; set; } //Required
        public decimal TotalCost { get; set; } //ReadOnly
        public decimal TotalPrice { get; set; } //ReadOnly
        public int InstalledProductID { get; set; } //ReadOnly Required [InstalledProduct]
        public string PurchaseOrderNumber { get; set; } //Length:50
        public string PeriodType { get; set; } //Required PickList Length:0
        public int Status { get; set; } //Required PickList
        public decimal PeriodCost { get; set; }
        public decimal PeriodPrice { get; set; } //Required
        public int? VendorID { get; set; } //[Account]
        public int? BusinessDivisionSubdivisionID { get; set; } //ReadOnly [BusinessDivisionSubdivision]

    } //end Subscription

}
