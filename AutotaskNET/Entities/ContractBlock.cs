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
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ContractBlock() : base() { } //end ContractBlock()
        public ContractBlock(net.autotask.webservices.ContractBlock entity) : base(entity)
        {
            this.ContractID = int.Parse(entity.ContractID.ToString());
            this.DatePurchased = DateTime.Parse(entity.DatePurchased.ToString());
            this.EndDate = DateTime.Parse(entity.EndDate.ToString());
            this.HourlyRate = double.Parse(entity.HourlyRate.ToString());
            this.Hours = double.Parse(entity.Hours.ToString());
            this.StartDate = DateTime.Parse(entity.StartDate.ToString());
            this.HoursApproved = double.Parse(entity.HoursApproved.ToString());
            this.InvoiceNumber = entity.InvoiceNumber == null ? default(string) : entity.InvoiceNumber.ToString();
            this.IsPaid = entity.IsPaid == null ? default(string) : entity.IsPaid.ToString();
            this.PaymentNumber = entity.PaymentNumber == null ? default(string) : entity.PaymentNumber.ToString();
            this.PaymentType = entity.PaymentType == null ? default(int?) : int.Parse(entity.PaymentType.ToString());
            this.Status = entity.Status == null ? default(int?) : int.Parse(entity.UserDefinedFields.ToString());
        } //end ContractBlock(net.autotask.webservices.ContractBlock entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public string IsPaid; //ReadOnly PickList Length:10
        public double HoursApproved; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public int ContractID; //Required [Contract]
        public DateTime DatePurchased; //Required
        public DateTime StartDate; //Required
        public DateTime EndDate; //Required
        public double Hours; //Required
        public double HourlyRate; //Required

        #endregion //Required Fields

        #region Optional Fields

        public int? Status; //PickList
        public string InvoiceNumber; //Length:50
        public string PaymentNumber; //Length:50
        public int? PaymentType; //PickList

        #endregion //Optional Fields

        #endregion //Fields

    } //end ContractBlock

}
