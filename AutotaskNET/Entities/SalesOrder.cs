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
            this.AccountID = int.Parse(entity.AccountID.ToString());
            this.AdditionalBillToAddressInformation = entity.AdditionalBillToAddressInformation == null ? default(string) : entity.AdditionalBillToAddressInformation.ToString();
            this.AdditionalShipToAddressInformation = entity.AdditionalShipToAddressInformation == null ? default(string) : entity.AdditionalShipToAddressInformation.ToString();
            this.BillToAddress1 = entity.BillToAddress1 == null ? default(string) : entity.BillToAddress1.ToString();
            this.BillToAddress2 = entity.BillToAddress2 == null ? default(string) : entity.BillToAddress2.ToString();
            this.BillToCity = entity.BillToCity == null ? default(string) : entity.BillToCity.ToString();
            this.BillToCountry = entity.BillToCountry == null ? default(string) : entity.BillToCountry.ToString();
            this.BillToCountryID = entity.BillToCountryID == null ? default(int?) : int.Parse(entity.BillToCountryID.ToString());
            this.BillToPostalCode = entity.BillToPostalCode == null ? default(string) : entity.BillToPostalCode.ToString();
            this.BillToState = entity.BillToState == null ? default(string) : entity.BillToState.ToString();
            this.BusinessDivisionSubdivisionID = entity.BusinessDivisionSubdivisionID == null ? default(int?) : int.Parse(entity.BusinessDivisionSubdivisionID.ToString());
            this.Contact = int.Parse(entity.Contact.ToString());
            this.OpportunityID = int.Parse(entity.OpportunityID.ToString());
            this.OwnerResourceID = int.Parse(entity.OwnerResourceID.ToString());
            this.PromisedDueDate = entity.PromisedDueDate == null ? default(DateTime?) : DateTime.Parse(entity.PromisedDueDate.ToString());
            this.SalesOrderDate = DateTime.Parse(entity.SalesOrderDate.ToString());
            this.ShipToAddress1 = entity.ShipToAddress1 == null ? default(string) : entity.ShipToAddress1.ToString();
            this.ShipToAddress2 = entity.ShipToAddress2 == null ? default(string) : entity.ShipToAddress2.ToString();
            this.ShipToCity = entity.ShipToCity == null ? default(string) : entity.ShipToCity.ToString();
            this.ShipToCountry = entity.ShipToCountry.ToString();
            this.ShipToCountryID = entity.ShipToCountryID == null ? default(int?) : int.Parse(entity.ShipToCountryID.ToString());
            this.ShipToPostalCode = entity.ShipToPostalCode == null ? default(string) : entity.ShipToPostalCode.ToString();
            this.ShipToState = entity.ShipToState == null ? default(string) : entity.ShipToState.ToString();
            this.Status = int.Parse(entity.Status.ToString());
            this.Title = entity.Title == null ? default(string) : entity.Title.ToString();
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

        #endregion //Fields

    } //end SalesOrder

}
