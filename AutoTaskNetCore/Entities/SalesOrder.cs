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

        public static implicit operator net.autotask.webservices.SalesOrder(SalesOrder salesorder)
        {
            return new net.autotask.webservices.SalesOrder()
            {
                id = salesorder.id,

            };

        } //end implicit operator net.autotask.webservices.SalesOrder(SalesOrder salesorder)

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

        public int AccountID; //ReadOnly Required [Account]
        public string Title; //ReadOnly Required Length:128
        public int Status; //Required PickList
        public int Contact; //Required [Contact]
        public int OwnerResourceID; //Required [Resource]
        public DateTime SalesOrderDate; //Required
        public DateTime? PromisedDueDate;
        public string BillToAddress1; //Length:150
        public string BillToAddress2; //Length:150
        public string BillToCity; //Length:50
        public string BillToState; //Length:50
        public string BillToPostalCode; //Length:50
        public string BillToCountry; //Length:100
        public string ShipToAddress1; //Length:150
        public string ShipToAddress2; //Length:150
        public string ShipToCity; //Length:50
        public string ShipToState; //Length:50
        public string ShipToPostalCode; //Length:50
        public string ShipToCountry; //Length:100
        public int OpportunityID; //ReadOnly Required [Opportunity]
        public string AdditionalBillToAddressInformation; //Length:100
        public string AdditionalShipToAddressInformation; //Length:100
        public int? BillToCountryID; //[Country]
        public int? ShipToCountryID; //[Country]
        public int? BusinessDivisionSubdivisionID; //[BusinessDivisionSubdivision]

    } //end SalesOrder

}
