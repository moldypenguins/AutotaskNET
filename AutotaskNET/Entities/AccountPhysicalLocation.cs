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
            this.AccountID = int.Parse(entity.AccountID.ToString());
            this.Active = entity.Active == null ? default(bool?) : bool.Parse(entity.Active.ToString());
            this.Address1 = entity.Address1 == null ? default(string) : entity.Address1.ToString();
            this.Address2 = entity.Address2 == null ? default(string) : entity.Address2.ToString();
            this.AlternatePhone1 = entity.AlternatePhone1 == null ? default(string) : entity.AlternatePhone1.ToString();
            this.AlternatePhone2 = entity.AlternatePhone2 == null ? default(string) : entity.AlternatePhone2.ToString();
            this.City = entity.City == null ? default(string) : entity.City.ToString();
            this.CountryID = entity.CountryID == null ? default(int?) : int.Parse(entity.CountryID.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.Fax = entity.Fax == null ? default(string) : entity.Address2.ToString();
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
            this.Phone = entity.Phone == null ? default(string) : entity.Phone.ToString();
            this.PostalCode = entity.PostalCode == null ? default(string) : entity.PostalCode.ToString();
            this.Primary = entity.Primary == null ? default(bool?) : bool.Parse(entity.Primary.ToString());
            this.RoundtripDistance = decimal.Parse(entity.RoundtripDistance.ToString());
            this.State = entity.State == null ? default(string) : entity.State.ToString();
        } //end AccountPhysicalLocation(net.autotask.webservices.AccountPhysicalLocation entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public int AccountID; //ReadOnly Required [Account]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public string Name; //Required Length:100

        #endregion //Required Fields

        #region Optional Fields

        public string Description; //Length:500
        public string Address1; //Length:128
        public string Address2; //Length:128
        public string City; //Length:50
        public string State; //Length:25
        public string PostalCode; //Length:20
        public int? CountryID; //[Country]
        public string Phone; //Length:25
        public string AlternatePhone1; //Length:25
        public string AlternatePhone2; //Length:25
        public string Fax; //Length:25
        public decimal RoundtripDistance;
        public bool? Active;
        public bool? Primary;

        #endregion //Optional Fields

        #endregion //Fields

    } //end AccountPhysicalLocation
}
