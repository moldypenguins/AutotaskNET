using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a payment amount applied to the purchase of (or pre-payment for ) one or more Service Desk Tickets through a Per Ticket Contract.<br />
    /// With a Per Ticket contract, a customers pre-pays for a set of Service Desk tickets, and each ticket completed under that contract consumes one ticket purchase, no matter how much labor is required to resolve the issue.<br />
    /// The contract maintains the balance of unconsumed ticket purchases. 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractTicketPurchase : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ContractTicketPurchase() : base() { } //end ContractTicketPurchase()
        public ContractTicketPurchase(net.autotask.webservices.ContractTicketPurchase entity) : base(entity)
        {

        } //end ContractTicketPurchase(net.autotask.webservices.ContractTicketPurchase entity)

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public long ContractID { get; set; } //Required [Contract]
        public bool IsPaid { get; set; } //Required PickList
        public DateTime DatePurchased { get; set; } //Required
        public DateTime StartDate { get; set; } //Required
        public DateTime EndDate { get; set; } //Required
        public double TicketsPurchased { get; set; } //Required
        public double PerTicketRate { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public string InvoiceNumber { get; set; } //Length:50
        public string PaymentNumber { get; set; } //Length:50
        public int? PaymentType { get; set; } //PickList
        public double TicketsUsed { get; set; } //ReadOnly
        public int? Status { get; set; } //PickList

        #endregion //Optional Fields

        #endregion //Fields

    } //end ContractTicketPurchase

}
