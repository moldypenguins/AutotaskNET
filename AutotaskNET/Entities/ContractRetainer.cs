using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a payment amount applied to a Retainer type contract and sets the time period covered by the purchase.<br />
    /// For example, a retainer purchase of $500 can be applied to three months of the Retainer contract.<br />
    /// <br />
    /// The retainer balance is reduced by services performed at the contract rates, which can be the same or different from the standard billing rates.<br />
    /// In addition, Project and Ticket Costs can be deducted from a Retainer contract.<br />
    /// The contract maintains the balance of dollars.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractRetainer : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ContractRetainer() : base() { } //end ContractRetainer()
        public ContractRetainer(net.autotask.webservices.ContractRetainer entity) : base(entity)
        {

        } //end Account(net.autotask.webservices.Account entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public int? IsPaid { get; set; } //ReadOnly PickList
        public double AmountApproved { get; set; } //ReadOnly
        public double InternalCurrencyAmountApproved { get; set; } //ReadOnly
        public double InternalCurrencyAmount { get; set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int ContractID { get; set; } //ReadOnly Required [Contract]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public int Status { get; set; } //Required PickList
        public DateTime DatePurchased { get; set; } //Required
        public DateTime StartDate { get; set; } //Required
        public DateTime EndDate { get; set; } //Required
        public double Amount { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public string InvoiceNumber { get; set; } //Length:50
        public string PaymentNumber { get; set; } //Length:50
        public int? paymentID { get; set; } //PickList

        #endregion //Optional Fields

        #endregion //Fields

    } //end ContractRetainer

}
