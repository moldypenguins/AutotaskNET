using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The AccountPhysicalLocation entity describes an individual business unit that is associated with a company in Autotask. <br />
    /// The business unit can be a separate physical location, like an affiliate or franchise, or a division or agency operating in the same physical location as the company, like a hospital Emergency department where the hospital is the Autotask company.<br />
    /// The company handles all billing for the business unit.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class AccountPhysicalLocation : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public AccountPhysicalLocation() : base() { } //end AccountPhysicalLocation()
        public AccountPhysicalLocation(net.autotask.webservices.AccountPhysicalLocation entity) : base(entity)
        {

        } //end AccountPhysicalLocation(net.autotask.webservices.AccountPhysicalLocation entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public int AccountID; //ReadOnly Required [Account]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public string Name { get; set; } //Required Length:100

        #endregion //Required Fields

        #region Optional Fields

        public string Description { get; set; } //Length:500
        public string Address1 { get; set; } //Length:128
        public string Address2 { get; set; } //Length:128
        public string City { get; set; } //Length:50
        public string State { get; set; } //Length:25
        public string PostalCode { get; set; } //Length:20
        public int? CountryID { get; set; } //[Country]
        public string Phone { get; set; } //Length:25
        public string AlternatePhone1 { get; set; } //Length:25
        public string AlternatePhone2 { get; set; } //Length:25
        public string Fax { get; set; } //Length:25
        public decimal RoundtripDistance { get; set; }
        public bool? Active { get; set; }
        public bool? Primary { get; set; }

        #endregion //Optional Fields

        #endregion //Fields

    } //end AccountPhysicalLocation
}
