using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The AccountLocation entity takes on the UDFs that hold the site setup information for the account represented by AccountId.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class AccountLocation : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => true;

        #endregion //Properties

        #region Constructors

        public AccountLocation() : base() { } //end AccountLocation()
        public AccountLocation(net.autotask.webservices.AccountLocation entity) : base(entity)
        {
            this.AccountID = int.Parse(entity.AccountID.ToString());
            this.LocationName = entity.LocationName == null ? default(string) : entity.LocationName.ToString();

        } //end AccountLocation(net.autotask.webservices.AccountLocation entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public int AccountID; //ReadOnly Required [Account]

        #endregion //ReadOnly Required Fields

        #region ReadOnly Fields

        public string LocationName; //ReadOnly Length:100

        #endregion //ReadOnly Fields

        #endregion //Fields

    } //end AccountLocation

}
