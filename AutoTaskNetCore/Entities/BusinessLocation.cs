using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes key business details for the Autotask Account 0, that is, the Autotask user's company account.<br />
    /// The entity provides an efficient way to access the details, via the API, to assist with the customer's Autotask implementation.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class BusinessLocation : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public BusinessLocation() : base() { } //end BusinessLocation()
        public BusinessLocation(net.autotask.webservices.BusinessLocation entity) : base(entity)
        {

        } //end BusinessLocation(net.autotask.webservices.BusinessLocation entity)

        public static implicit operator net.autotask.webservices.BusinessLocation(BusinessLocation businesslocation)
        {
            return new net.autotask.webservices.BusinessLocation()
            {
                id = businesslocation.id,

            };

        } //end implicit operator net.autotask.webservices.BusinessLocation(BusinessLocation businesslocation)

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public string Name; //Required Length:100
        public string DateFormat; //Required PickList Length:0
        public string TimeFormat; //Required PickList Length:0
        public string NumberFormat; //Required PickList Length:0
        public int TimeZoneID; //Required PickList

        #endregion //Required Fields

        #region Optional Fields

        public string Address1; //Length:100
        public string Address2; //Length:100
        public string City; //Length:50
        public string State; //Length:25
        public string PostalCode; //Length:20
        public string AdditionalAddressInfo; //Length:100
        public int? CountryID; //[Country]
        public int? HolidaySetID; //[HolidaySet]
        public bool? NoHoursOnHolidays;
        public bool? Default;
        public int? FirstDayOfWeek; //PickList
        public DateTime? SundayBusinessHoursStartTime;
        public DateTime? SundayBusinessHoursEndTime;
        public DateTime? SundayExtendedHoursStartTime;
        public DateTime? SundayExtendedHoursEndTime;
        public DateTime? MondayBusinessHoursStartTime;
        public DateTime? MondayBusinessHoursEndTime;
        public DateTime? MondayExtendedHoursStartTime;
        public DateTime? MondayExtendedHoursEndTime;
        public DateTime? TuesdayBusinessHoursStartTime;
        public DateTime? TuesdayBusinessHoursEndTime;
        public DateTime? TuesdayExtendedHoursStartTime;
        public DateTime? TuesdayExtendedHoursEndTime;
        public DateTime? WednesdayBusinessHoursStartTime;
        public DateTime? WednesdayBusinessHoursEndTime;
        public DateTime? WednesdayExtendedHoursStartTime;
        public DateTime? WednesdayExtendedHoursEndTime;
        public DateTime? ThursdayBusinessHoursStartTime;
        public DateTime? ThursdayBusinessHoursEndTime;
        public DateTime? ThursdayExtendedHoursStartTime;
        public DateTime? ThursdayExtendedHoursEndTime;
        public DateTime? FridayBusinessHoursStartTime;
        public DateTime? FridayBusinessHoursEndTime;
        public DateTime? FridayExtendedHoursStartTime;
        public DateTime? FridayExtendedHoursEndTime;
        public DateTime? SaturdayBusinessHoursStartTime;
        public DateTime? SaturdayBusinessHoursEndTime;
        public DateTime? SaturdayExtendedHoursStartTime;
        public DateTime? SaturdayExtendedHoursEndTime;

        #endregion //Optional Fields

        #endregion //Fields

    } //end BusinessLocation

}
