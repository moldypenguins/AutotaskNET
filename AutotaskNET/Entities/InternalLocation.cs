using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a Location defined in Company Setup in the Autotask Admin module.<br />
    /// Locations represent the various sites where the Autotask user's company has a physical presence.<br />
    /// Every resource is associated with a location.<br />
    /// The time zone and holiday set of the associated location are applied to the resource's time entries and schedules.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class InternalLocation : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public InternalLocation() : base() { } //end InternalLocation()
        public InternalLocation(net.autotask.webservices.InternalLocation entity) : base(entity)
        {
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
            this.AdditionalAddressInfo = entity.AdditionalAddressInfo == null ? default(string) : entity.AdditionalAddressInfo.ToString();
            this.Address1 = entity.Address1 == null ? default(string) : entity.Address1.ToString();
            this.Address2 = entity.Address2 == null ? default(string) : entity.Address2.ToString();
            this.City = entity.City == null ? default(string) : entity.City.ToString();
            this.Country = entity.Country == null ? default(string) : entity.Country.ToString();
            this.HolidaySetId = long.Parse(entity.HolidaySetId.ToString());
            this.IsDefault = entity.IsDefault == null ? default(bool?) : bool.Parse(entity.IsDefault.ToString());
            this.PostalCode = entity.PostalCode == null ? default(string) : entity.PostalCode.ToString();
            this.State = entity.State == null ? default(string) : entity.State.ToString();
            this.TimeZone = entity.TimeZone == null ? default(string) : entity.TimeZone.ToString();
        } //end InternalLocation(net.autotask.webservices.InternalLocation entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public string Address1; //ReadOnly Length:100
        public string Address2; //ReadOnly Length:100
        public string City; //ReadOnly Length:50
        public string State; //ReadOnly Length:25
        public string PostalCode; //ReadOnly Length:20
        public string Country; //ReadOnly Length:100
        public string AdditionalAddressInfo; //ReadOnly Length:100
        public string TimeZone; //ReadOnly Length:100
        public long HolidaySetId; //ReadOnly PickList
        public bool? IsDefault; //ReadOnly

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public string Name; //ReadOnly Required Length:100

        #endregion //ReadOnly Required Fields

        #endregion //Fields

    } //end InternalLocation

}
