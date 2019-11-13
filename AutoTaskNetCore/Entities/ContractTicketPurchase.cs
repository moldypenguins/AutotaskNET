﻿using System;

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

        public static implicit operator net.autotask.webservices.ContractTicketPurchase(ContractTicketPurchase contractticketpurchase)
        {
            return new net.autotask.webservices.ContractTicketPurchase()
            {
                id = contractticketpurchase.id,

            };

        } //end implicit operator net.autotask.webservices.ContractTicketPurchase(ContractTicketPurchase contractticketpurchase)

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public long ContractID; //Required [Contract]
        public bool IsPaid; //Required PickList
        public DateTime DatePurchased; //Required
        public DateTime StartDate; //Required
        public DateTime EndDate; //Required
        public double TicketsPurchased; //Required
        public double PerTicketRate; //Required

        #endregion //Required Fields

        #region Optional Fields

        public string InvoiceNumber; //Length:50
        public string PaymentNumber; //Length:50
        public int? PaymentType; //PickList
        public double TicketsUsed; //ReadOnly
        public int? Status; //PickList

        #endregion //Optional Fields

        #endregion //Fields

    } //end ContractTicketPurchase

}
