using System;
using System.Net.Http.Headers;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a cost associated with an Autotask Ticket.<br />
    /// A cost is a billing item for products or materials.<br />
    /// Cost items can be billable or non-billable.<br />
    /// Billable cost items appear in Approve and Post.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TicketCost : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => this.Billed == false;
        public override bool CanQuery => true;
        public override bool CanDelete => this.Billed == false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public TicketCost() : base() { } //end TicketCost()
        public TicketCost(net.autotask.webservices.TicketCost entity) : base(entity)
        {
            //entity.AccountName == null ? default(string) : entity.AccountName.ToString();
            ProductID = entity.ProductID == null ? default : long.Parse(entity.ProductID.ToString());
            Billed = entity.Billed == null ? default : bool.Parse(entity.Billed.ToString());
            InternalPurchaseOrderNumber = entity.InternalPurchaseOrderNumber?.ToString();
            id = entity.id;
        } //end TicketCost(net.autotask.webservices.TicketCost entity)

        public static implicit operator net.autotask.webservices.TicketCost(TicketCost ticketcost)
        {
            return new net.autotask.webservices.TicketCost()
            {
                id = ticketcost.id,
                Billed = ticketcost.Billed,
                ProductID = ticketcost.ProductID,
                InternalPurchaseOrderNumber = ticketcost.InternalPurchaseOrderNumber

            };

        } //end implicit operator net.autotask.webservices.TicketCost(TicketCost ticketcost)

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

        public long TicketID { get; set; } //Required [Ticket]
        public long ProductID { get; set; } //[Product]
        public long AllocationCodeID { get; set; } //[AllocationCode]
        public string Name { get; set; } //Required Length:100
        public string Description { get; set; } //Length:2000
        public DateTime DatePurchased { get; set; } //Required
        public int CostType { get; set; } //Required PickList
        public string PurchaseOrderNumber { get; set; } //Length:50
        public string InternalPurchaseOrderNumber { get; set; } //Length:50
        public double UnitQuantity { get; set; } //Required
        public double UnitCost { get; set; }
        public double UnitPrice { get; set; }
        public double ExtendedCost { get; set; } //ReadOnly
        public double BillableAmount { get; set; } //ReadOnly
        public bool? BillableToAccount { get; set; }
        public bool? Billed { get; set; } //ReadOnly
        public long Status { get; set; } //ReadOnly PickList
        public long StatusLastModifiedBy { get; set; } //ReadOnly
        public DateTime? StatusLastModifiedDate { get; set; } //ReadOnly
        public DateTime? CreateDate { get; set; } //ReadOnly
        public long CreatorResourceID { get; set; } //ReadOnly [Resource]
        public long ContractServiceID { get; set; } //[ContractService]
        public long ContractServiceBundleID { get; set; } //[ContractServiceBundle]
        public double InternalCurrencyBillableAmount { get; set; } //ReadOnly
        public double InternalCurrencyUnitPrice { get; set; } //ReadOnly
        public int? BusinessDivisionSubdivisionID { get; set; } //ReadOnly [BusinessDivisionSubdivision]

    } //end TicketCost

}
