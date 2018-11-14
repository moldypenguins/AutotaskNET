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

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.PurchaseOrderItem()
            {
                id = this.id,

            };

        } //end ToATWS()

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

    } //end PurchaseOrderItem

}
