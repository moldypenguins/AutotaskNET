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
            Name = entity.Name.ToString();
            AccountID = entity.AccountID == null ? default : int.Parse(entity.AccountID.ToString());
            Address1 = entity.Address1.ToString();
            Address2 = entity.Address2.ToString();
            City = entity.City.ToString();
            Active = entity.Active == null ? default : bool.Parse(entity.Active.ToString());
            AlternatePhone2 = entity.AlternatePhone2.ToString();
            AlternatePhone1 = entity.AlternatePhone1.ToString();
            State = entity.State.ToString();
            PostalCode = entity.PostalCode.ToString();
            RoundtripDistance = entity.RoundtripDistance == null
                ? default
                : decimal.Parse(entity.RoundtripDistance.ToString());
            Primary = entity.Primary == null ? default : bool.Parse(entity.Primary.ToString());
            Fax = entity.Fax.ToString();
            CountryID = entity.CountryID == null ? default : int.Parse(entity.CountryID.ToString());
            Description = entity.Description.ToString();
            Phone = entity.Phone.ToString();
            id = entity.id;

        } //end AccountPhysicalLocation(net.autotask.webservices.AccountPhysicalLocation entity)

        public static implicit operator net.autotask.webservices.AccountPhysicalLocation(AccountPhysicalLocation accountphysicallocation)
        {
            return new net.autotask.webservices.AccountPhysicalLocation()
            {
                id = accountphysicallocation.id,
                Name = accountphysicallocation.Name,
                AccountID = accountphysicallocation.AccountID,
                Active = accountphysicallocation.Active,
                Address1 = accountphysicallocation.Address1,
                Address2 = accountphysicallocation.Address2,
                AlternatePhone1 = accountphysicallocation.AlternatePhone1,
                AlternatePhone2 = accountphysicallocation.AlternatePhone2,
                City = accountphysicallocation.City,
                CountryID = accountphysicallocation.CountryID,
                Description = accountphysicallocation.Description,
                Fax = accountphysicallocation.Fax,
                Phone = accountphysicallocation.Phone,
                PostalCode = accountphysicallocation.PostalCode,
                RoundtripDistance = accountphysicallocation.RoundtripDistance,
                Primary = accountphysicallocation.Primary,
                State = accountphysicallocation.State,
                UserDefinedFields = accountphysicallocation.UserDefinedFields == null ? default : Array.ConvertAll(accountphysicallocation.UserDefinedFields.ToArray(), UserDefinedField.ToATWS)
            };

        } //end implicit operator net.autotask.webservices.AccountPhysicalLocation(AccountPhysicalLocation accountphysicallocation)

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
