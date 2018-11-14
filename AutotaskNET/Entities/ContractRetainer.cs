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

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.ContractRetainer()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public int? IsPaid; //ReadOnly PickList
        public double AmountApproved; //ReadOnly
        public double InternalCurrencyAmountApproved; //ReadOnly
        public double InternalCurrencyAmount; //ReadOnly

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int ContractID; //ReadOnly Required [Contract]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public int Status; //Required PickList
        public DateTime DatePurchased; //Required
        public DateTime StartDate; //Required
        public DateTime EndDate; //Required
        public double Amount; //Required

        #endregion //Required Fields

        #region Optional Fields

        public string InvoiceNumber; //Length:50
        public string PaymentNumber; //Length:50
        public int? paymentID; //PickList

        #endregion //Optional Fields

        #endregion //Fields

    } //end ContractRetainer

}
