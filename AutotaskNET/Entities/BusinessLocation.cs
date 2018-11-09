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

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public string Name { get; set; } //Required Length:100
        public string DateFormat { get; set; } //Required PickList Length:0
        public string TimeFormat { get; set; } //Required PickList Length:0
        public string NumberFormat { get; set; } //Required PickList Length:0
        public int TimeZoneID { get; set; } //Required PickList

        #endregion //Required Fields

        #region Optional Fields

        public string Address1 { get; set; } //Length:100
        public string Address2 { get; set; } //Length:100
        public string City { get; set; } //Length:50
        public string State { get; set; } //Length:25
        public string PostalCode { get; set; } //Length:20
        public string AdditionalAddressInfo { get; set; } //Length:100
        public int? CountryID { get; set; } //[Country]
        public int? HolidaySetID { get; set; } //[HolidaySet]
        public bool? NoHoursOnHolidays { get; set; }
        public bool? Default { get; set; }
        public int? FirstDayOfWeek { get; set; } //PickList
        public DateTime? SundayBusinessHoursStartTime { get; set; }
        public DateTime? SundayBusinessHoursEndTime { get; set; }
        public DateTime? SundayExtendedHoursStartTime { get; set; }
        public DateTime? SundayExtendedHoursEndTime { get; set; }
        public DateTime? MondayBusinessHoursStartTime { get; set; }
        public DateTime? MondayBusinessHoursEndTime { get; set; }
        public DateTime? MondayExtendedHoursStartTime { get; set; }
        public DateTime? MondayExtendedHoursEndTime { get; set; }
        public DateTime? TuesdayBusinessHoursStartTime { get; set; }
        public DateTime? TuesdayBusinessHoursEndTime { get; set; }
        public DateTime? TuesdayExtendedHoursStartTime { get; set; }
        public DateTime? TuesdayExtendedHoursEndTime { get; set; }
        public DateTime? WednesdayBusinessHoursStartTime { get; set; }
        public DateTime? WednesdayBusinessHoursEndTime { get; set; }
        public DateTime? WednesdayExtendedHoursStartTime { get; set; }
        public DateTime? WednesdayExtendedHoursEndTime { get; set; }
        public DateTime? ThursdayBusinessHoursStartTime { get; set; }
        public DateTime? ThursdayBusinessHoursEndTime { get; set; }
        public DateTime? ThursdayExtendedHoursStartTime { get; set; }
        public DateTime? ThursdayExtendedHoursEndTime { get; set; }
        public DateTime? FridayBusinessHoursStartTime { get; set; }
        public DateTime? FridayBusinessHoursEndTime { get; set; }
        public DateTime? FridayExtendedHoursStartTime { get; set; }
        public DateTime? FridayExtendedHoursEndTime { get; set; }
        public DateTime? SaturdayBusinessHoursStartTime { get; set; }
        public DateTime? SaturdayBusinessHoursEndTime { get; set; }
        public DateTime? SaturdayExtendedHoursStartTime { get; set; }
        public DateTime? SaturdayExtendedHoursEndTime { get; set; }

        #endregion //Optional Fields

        #endregion //Fields

    } //end BusinessLocation

}
