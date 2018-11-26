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
            this.ContractID = long.Parse(entity.ContractID.ToString());
            this.CostID = entity.CostID == null ? default(int?) : int.Parse(entity.CostID.ToString());
            this.EstimatedArrivalDate = entity.EstimatedArrivalDate == null ? default(DateTime?) : DateTime.Parse(entity.EstimatedArrivalDate.ToString());
            this.InventoryLocationID = int.Parse(entity.InventoryLocationID.ToString());
            this.Memo = entity.Memo == null ? default(string) : entity.Memo.ToString();
            this.OrderID = int.Parse(entity.OrderID.ToString());
            this.ProductID = int.Parse(entity.ProductID.ToString());
            this.ProjectID = long.Parse(entity.ProjectID.ToString());
            this.Quantity = int.Parse(entity.Quantity.ToString());
            this.SalesOrderID = long.Parse(entity.SalesOrderID.ToString());
            this.TicketID = long.Parse(entity.TicketID.ToString());
            this.UnitCost = double.Parse(entity.UnitCost.ToString());
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

        public int OrderID; //ReadOnly Required [PurchaseOrder]
        public int ProductID; //Required [Product]
        public int InventoryLocationID; //Required [InventoryLocation]
        public int Quantity; //Required
        public string Memo; //Length:4000
        public double UnitCost; //Required
        public long SalesOrderID; //ReadOnly [SalesOrder]
        public DateTime? EstimatedArrivalDate; //ReadOnly
        public int? CostID; //ReadOnly
        public long ContractID; //ReadOnly [Contract]
        public long ProjectID; //ReadOnly [Project]
        public long TicketID; //ReadOnly [Ticket]

        #endregion //Fields

    } //end PurchaseOrderItem

}
