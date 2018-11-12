using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class PurchaseOrderItem : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public PurchaseOrderItem() : base() { } //end PurchaseOrderItem()
        public PurchaseOrderItem(net.autotask.webservices.PurchaseOrderItem entity) : base(entity)
        {

        } //end PurchaseOrderItem(net.autotask.webservices.PurchaseOrderItem entity)

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

        public int OrderID { get; set; } //ReadOnly Required [PurchaseOrder]
        public int ProductID { get; set; } //Required [Product]
        public int InventoryLocationID { get; set; } //Required [InventoryLocation]
        public int Quantity { get; set; } //Required
        public string Memo { get; set; } //Length:4000
        public double UnitCost { get; set; } //Required
        public long SalesOrderID { get; set; } //ReadOnly [SalesOrder]
        public DateTime? EstimatedArrivalDate { get; set; } //ReadOnly
        public int? CostID { get; set; } //ReadOnly
        public long ContractID { get; set; } //ReadOnly [Contract]
        public long ProjectID { get; set; } //ReadOnly [Project]
        public long TicketID { get; set; } //ReadOnly [Ticket]

    } //end PurchaseOrderItem

}
