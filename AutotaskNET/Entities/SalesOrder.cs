using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class SalesOrder : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => true;

        #endregion //Properties

        #region Constructors

        public SalesOrder() : base() { } //end SalesOrder()
        public SalesOrder(net.autotask.webservices.SalesOrder entity) : base(entity)
        {

        } //end SalesOrder(net.autotask.webservices.SalesOrder entity)

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

        public int AccountID { get; set; } //ReadOnly Required [Account]
        public string Title { get; set; } //ReadOnly Required Length:128
        public int Status { get; set; } //Required PickList
        public int Contact { get; set; } //Required [Contact]
        public int OwnerResourceID { get; set; } //Required [Resource]
        public DateTime SalesOrderDate { get; set; } //Required
        public DateTime? PromisedDueDate { get; set; }
        public string BillToAddress1 { get; set; } //Length:150
        public string BillToAddress2 { get; set; } //Length:150
        public string BillToCity { get; set; } //Length:50
        public string BillToState { get; set; } //Length:50
        public string BillToPostalCode { get; set; } //Length:50
        public string BillToCountry { get; set; } //Length:100
        public string ShipToAddress1 { get; set; } //Length:150
        public string ShipToAddress2 { get; set; } //Length:150
        public string ShipToCity { get; set; } //Length:50
        public string ShipToState { get; set; } //Length:50
        public string ShipToPostalCode { get; set; } //Length:50
        public string ShipToCountry { get; set; } //Length:100
        public int OpportunityID { get; set; } //ReadOnly Required [Opportunity]
        public string AdditionalBillToAddressInformation { get; set; } //Length:100
        public string AdditionalShipToAddressInformation { get; set; } //Length:100
        public int? BillToCountryID { get; set; } //[Country]
        public int? ShipToCountryID { get; set; } //[Country]
        public int? BusinessDivisionSubdivisionID { get; set; } //[BusinessDivisionSubdivision]

    } //end SalesOrder

}
