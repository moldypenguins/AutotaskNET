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
            this.AdditionalAddressInfo = entity.AdditionalAddressInfo == null ? default(string) : entity.AdditionalAddressInfo.ToString();
            this.Address1 = entity.Address1 == null ? default(string) : entity.Address1.ToString();
            this.Address2 = entity.Address2 == null ? default(string) : entity.Address2.ToString();
            this.City = entity.City == null ? default(string) : entity.City.ToString();
            this.CountryID = entity.CountryID == null ? default(int?) : int.Parse(entity.CountryID.ToString());
            this.DateFormat = entity.DateFormat == null ? default(string) : entity.DateFormat.ToString();
            this.Default = entity.Default == null ? default(bool?) : bool.Parse(entity.Default.ToString());
            this.FirstDayOfWeek = entity.FirstDayOfWeek == null ? default(int?) : int.Parse(entity.FirstDayOfWeek.ToString());
            this.FridayBusinessHoursEndTime = entity.FridayBusinessHoursEndTime == null ? default(DateTime?) : DateTime.Parse(entity.FridayBusinessHoursEndTime.ToString());
            this.FridayBusinessHoursStartTime = entity.FridayBusinessHoursStartTime == null ? default(DateTime?) : DateTime.Parse(entity.FridayBusinessHoursStartTime.ToString());
            this.FridayExtendedHoursEndTime = entity.FridayExtendedHoursEndTime == null ? default(DateTime?) : DateTime.Parse(entity.FridayExtendedHoursEndTime.ToString());
            this.FridayExtendedHoursStartTime = entity.FridayExtendedHoursStartTime == null ? default(DateTime?) : DateTime.Parse(entity.FridayExtendedHoursStartTime.ToString());
            this.HolidaySetID = entity.HolidaySetID == null ? default(int?) : int.Parse(entity.HolidaySetID.ToString());
            this.MondayBusinessHoursEndTime = entity.MondayBusinessHoursEndTime == null ? default(DateTime?) : DateTime.Parse(entity.MondayBusinessHoursEndTime.ToString());
            this.MondayBusinessHoursStartTime = entity.MondayBusinessHoursStartTime == null ? default(DateTime?) : DateTime.Parse(entity.MondayBusinessHoursStartTime.ToString());
            this.MondayExtendedHoursEndTime = entity.MondayExtendedHoursEndTime == null ? default(DateTime?) : DateTime.Parse(entity.MondayExtendedHoursEndTime.ToString());
            this.MondayExtendedHoursStartTime = entity.MondayExtendedHoursStartTime == null ? default(DateTime?) : DateTime.Parse(entity.MondayExtendedHoursStartTime.ToString());
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
            this.NoHoursOnHolidays = entity.NoHoursOnHolidays == null ? default(bool?) : bool.Parse(entity.NoHoursOnHolidays.ToString());
            this.NumberFormat = entity.NumberFormat == null ? default(string) : entity.NumberFormat.ToString();
            this.PostalCode = entity.PostalCode == null ? default(string) : entity.PostalCode.ToString();
            this.SaturdayBusinessHoursEndTime = entity.SaturdayBusinessHoursEndTime == null ? default(DateTime?) : DateTime.Parse(entity.SaturdayBusinessHoursEndTime.ToString());
            this.SaturdayBusinessHoursStartTime = entity.SaturdayBusinessHoursStartTime == null ? default(DateTime?) : DateTime.Parse(entity.SaturdayBusinessHoursStartTime.ToString());
            this.SaturdayExtendedHoursEndTime = entity.SaturdayExtendedHoursEndTime == null ? default(DateTime?) : DateTime.Parse(entity.SaturdayExtendedHoursEndTime.ToString());
            this.SaturdayExtendedHoursStartTime = entity.SaturdayExtendedHoursStartTime == null ? default(DateTime?) : DateTime.Parse(entity.SaturdayExtendedHoursStartTime.ToString());
            this.State = entity.State == null ? default(string) : entity.State.ToString();
            this.SundayBusinessHoursEndTime = entity.SundayBusinessHoursEndTime == null ? default(DateTime?) : DateTime.Parse(entity.SundayBusinessHoursEndTime.ToString());
            this.SundayBusinessHoursStartTime = entity.SundayBusinessHoursStartTime == null ? default(DateTime?) : DateTime.Parse(entity.SundayBusinessHoursStartTime.ToString());
            this.SundayExtendedHoursEndTime = entity.SundayExtendedHoursEndTime == null ? default(DateTime?) : DateTime.Parse(entity.SundayExtendedHoursEndTime.ToString());
            this.SundayExtendedHoursStartTime = entity.SundayExtendedHoursStartTime == null ? default(DateTime?) : DateTime.Parse(entity.SundayExtendedHoursStartTime.ToString());
            this.ThursdayBusinessHoursEndTime = entity.ThursdayBusinessHoursEndTime == null ? default(DateTime?) : DateTime.Parse(entity.ThursdayBusinessHoursEndTime.ToString());
            this.ThursdayBusinessHoursStartTime = entity.ThursdayBusinessHoursStartTime == null ? default(DateTime?) : DateTime.Parse(entity.ThursdayBusinessHoursStartTime.ToString());
            this.ThursdayExtendedHoursEndTime = entity.ThursdayExtendedHoursEndTime == null ? default(DateTime?) : DateTime.Parse(entity.ThursdayExtendedHoursEndTime.ToString());
            this.ThursdayExtendedHoursStartTime = entity.ThursdayExtendedHoursStartTime == null ? default(DateTime?) : DateTime.Parse(entity.ThursdayExtendedHoursStartTime.ToString());
            this.TimeFormat = entity.TimeFormat == null ? default(string) : entity.TimeFormat.ToString();
            this.TimeZoneID = int.Parse(entity.TimeZoneID.ToString());
            this.TuesdayBusinessHoursEndTime = entity.TuesdayBusinessHoursEndTime == null ? default(DateTime?) : DateTime.Parse(entity.TuesdayBusinessHoursEndTime.ToString());
            this.TuesdayBusinessHoursStartTime = entity.TuesdayBusinessHoursStartTime == null ? default(DateTime?) : DateTime.Parse(entity.TuesdayBusinessHoursStartTime.ToString());
            this.TuesdayExtendedHoursEndTime = entity.TuesdayExtendedHoursEndTime == null ? default(DateTime?) : DateTime.Parse(entity.TuesdayExtendedHoursEndTime.ToString());
            this.TuesdayExtendedHoursStartTime = entity.TuesdayExtendedHoursStartTime == null ? default(DateTime?) : DateTime.Parse(entity.TuesdayExtendedHoursStartTime.ToString());
            this.WednesdayBusinessHoursEndTime = entity.WednesdayBusinessHoursEndTime == null ? default(DateTime?) : DateTime.Parse(entity.WednesdayBusinessHoursEndTime.ToString());
            this.WednesdayBusinessHoursStartTime = entity.WednesdayBusinessHoursStartTime == null ? default(DateTime?) : DateTime.Parse(entity.WednesdayBusinessHoursStartTime.ToString());
            this.WednesdayExtendedHoursEndTime = entity.WednesdayExtendedHoursEndTime == null ? default(DateTime?) : DateTime.Parse(entity.WednesdayExtendedHoursEndTime.ToString());
            this.WednesdayExtendedHoursStartTime = entity.WednesdayExtendedHoursStartTime == null ? default(DateTime?) : DateTime.Parse(entity.WednesdayExtendedHoursStartTime.ToString());
        } //end BusinessLocation(net.autotask.webservices.BusinessLocation entity)

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
