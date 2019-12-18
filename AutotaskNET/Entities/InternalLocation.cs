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

        public static implicit operator net.autotask.webservices.InternalLocation(InternalLocation internallocation)
        {
            return new net.autotask.webservices.InternalLocation()
            {
                id = internallocation.id,
                Name = internallocation.Name == null ? default(string) : internallocation.Name.ToString(),
                AdditionalAddressInfo = internallocation.AdditionalAddressInfo == null ? default(string) : internallocation.AdditionalAddressInfo.ToString(),
                Address1 = internallocation.Address1 == null ? default(string) : internallocation.Address1.ToString(),
                Address2 = internallocation.Address2 == null ? default(string) : internallocation.Address2.ToString(),
                City = internallocation.City == null ? default(string) : internallocation.City.ToString(),
                Country = internallocation.Country == null ? default(string) : internallocation.Country.ToString(),
                HolidaySetId = long.Parse(internallocation.HolidaySetId.ToString()),
                IsDefault = internallocation.IsDefault == null ? default(bool?) : bool.Parse(internallocation.IsDefault.ToString()),
                PostalCode = internallocation.PostalCode == null ? default(string) : internallocation.PostalCode.ToString(),
                State = internallocation.State == null ? default(string) : internallocation.State.ToString(),
                TimeZone = internallocation.TimeZone == null ? default(string) : internallocation.TimeZone.ToString()
            };

        } //end implicit operator net.autotask.webservices.InternalLocation(InternalLocation internallocation)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public string Address1 { get; set; } //ReadOnly Length:100
        public string Address2 { get; set; } //ReadOnly Length:100
        public string City { get; set; } //ReadOnly Length:50
        public string State { get; set; } //ReadOnly Length:25
        public string PostalCode { get; set; } //ReadOnly Length:20
        public string Country { get; set; } //ReadOnly Length:100
        public string AdditionalAddressInfo { get; set; } //ReadOnly Length:100
        public string TimeZone { get; set; } //ReadOnly Length:100
        public long HolidaySetId { get; set; } //ReadOnly PickList
        public bool? IsDefault { get; set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public string Name { get; set; } //ReadOnly Required Length:100

        #endregion //ReadOnly Required Fields

        #endregion //Fields

    } //end InternalLocation

}
