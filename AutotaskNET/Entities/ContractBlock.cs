using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The ContractBlock entity describes an Autotask Contract Block.<br />
    /// The Contract Block represents a block of hours purchased for a Block Hours type Contract.<br />
    /// With a Block Hours Contract, the customer pre-pays for a block of hours and then the prepaid hours are reduced as billable work is performed.<br />
    /// The contract maintains the balance of hours.<br />
    /// You can create a Block Hours type Contract without creating an associated ContractBlock entity, but time cannot be charged against the contract.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractBlock : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields

        public string IsPaid { get; set; } //ReadOnly PickList Length:10
        public double HoursApproved { get; set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public int ContractID { get; set; } //Required [Contract]
        public DateTime DatePurchased { get; set; } //Required
        public DateTime StartDate { get; set; } //Required
        public DateTime EndDate { get; set; } //Required
        public double Hours { get; set; } //Required
        public double HourlyRate { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public int? Status { get; set; } //PickList
        public string InvoiceNumber { get; set; } //Length:50
        public string PaymentNumber { get; set; } //Length:50
        public int? PaymentType { get; set; } //PickList

        #endregion //Optional Fields

    } //end ContractBlock

}
