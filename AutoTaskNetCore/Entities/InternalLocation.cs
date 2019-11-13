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

        } //end InternalLocation(net.autotask.webservices.InternalLocation entity)

        public static implicit operator net.autotask.webservices.InternalLocation(InternalLocation internallocation)
        {
            return new net.autotask.webservices.InternalLocation()
            {
                id = internallocation.id,

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
