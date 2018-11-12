using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a currency available for use with the Autotask Multi-currency installed module.<br />
    /// The currency entity is used in Autotask only when the Multi-currency installed module is enabled.<br />
    /// It allows selected currency related fields to be queried and updated through the API.<br />
    /// Currencies cannot be created or deleted.<br />
    /// <br />
    /// In Autotask, when the Multi-currency installed module is enabled, currencies are managed from the Currencies page, available to Administrators in the Autotask menu under Admin > Finance, Accounting & Invoicing.<br />
    /// They allow you to use different currencies for customer invoicing while setting your own internal currency.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Currency : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public Currency() : base() { } //end Currency()
        public Currency(net.autotask.webservices.Currency entity) : base(entity)
        {

        } //end Currency(net.autotask.webservices.Currency entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public int? UpdateResourceId { get; set; } //ReadOnly [Resource]

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public string Name { get; set; } //ReadOnly Required Length:3
        public string Description { get; set; } //ReadOnly Required Length:100
        public int DisplaySymbol { get; set; } //ReadOnly Required PickList
        public bool IsInternalCurrency { get; set; } //ReadOnly Required
        public bool Active { get; set; } //ReadOnly Required
        public string CurrencyPositiveFormat { get; set; } //ReadOnly Required Length:10
        public string CurrencyNegativeFormat { get; set; } //ReadOnly Required Length:10

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public decimal ExchangeRate { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public DateTime? LastModifiedDateTime { get; set; }

        #endregion //Optional Fields

        #endregion //Fields

    } //end Currency

}
