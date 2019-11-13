using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Resource : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => true; //System Administrators Only
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public Resource() : base() { } //end Resource()
        public Resource(net.autotask.webservices.Resource entity) : base(entity)
        {
            this.Active = bool.Parse(entity.Active.ToString());
            this.Email = entity.Email == null ? default(string) : entity.Email.ToString();
            this.EmailTypeCode = entity.EmailTypeCode == null ? default(string) : entity.EmailTypeCode.ToString();
            this.FirstName = entity.FirstName == null ? default(string) : entity.FirstName.ToString();
            this.HireDate = DateTime.Parse(entity.HireDate.ToString());
            this.LastName = entity.LastName == null ? default(string) : entity.LastName.ToString();
            this.LocationID = int.Parse(entity.LocationID.ToString());
            this.NumberFormat = entity.NumberFormat == null ? default(string) : entity.NumberFormat.ToString();
            this.PayrollType = int.Parse(entity.PayrollType.ToString());
            this.ResourceType = entity.ResourceType == null ? default(string) : entity.ResourceType.ToString();
            this.UserName = entity.UserName == null ? default(string) : entity.UserName.ToString();
            this.UserType = int.Parse(entity.UserType.ToString());
            this.AccountingReferenceID = entity.AccountingReferenceID == null ? default(string) : entity.AccountingReferenceID.ToString();
            this.DateFormat = entity.DateFormat == null ? default(string) : entity.DateFormat.ToString();
            //this.DefaultServiceDeskRoleID = long.Parse(entity.DefaultServiceDeskRoleID.ToString());
            this.Email2 = entity.Email2 == null ? default(string) : entity.Email2.ToString();
            this.Email3 = entity.Email3 == null ? default(string) : entity.Email3.ToString();
            this.EmailTypeCode2 = entity.EmailTypeCode2 == null ? default(string) : entity.EmailTypeCode.ToString();
            this.EmailTypeCode3 = entity.EmailTypeCode3 == null ? default(string) : entity.EmailTypeCode3.ToString();
            this.Gender = entity.Gender == null ? default(string) : entity.Gender.ToString();
            this.Greeting = entity.Greeting == null ? default(int?) : int.Parse(entity.Greeting.ToString());
            this.HomePhone = entity.HomePhone == null ? default(string) : entity.HomePhone.ToString();
            this.Initials = entity.Initials == null ? default(string) : entity.Initials.ToString();
            this.InternalCost = entity.InternalCost == null ? default(double?) : double.Parse(entity.InternalCost.ToString());
            this.MiddleName = entity.MiddleName == null ? default(string) : entity.MiddleName.ToString();
            this.MobilePhone = entity.MobilePhone == null ? default(string) : entity.MobilePhone.ToString();
            this.OfficeExtension = entity.OfficeExtension == null ? default(string) : entity.OfficeExtension.ToString();
            this.OfficePhone = entity.OfficePhone == null ? default(string) : entity.OfficePhone.ToString();
            //this.Password = entity.Password == null ? default(string) : entity.Password.ToString();
            this.Suffix = entity.Suffix == null ? default(string) : entity.Suffix.ToString();
            this.SurveyResourceRating = entity.SurveyResourceRating == null ? default(double?) : double.Parse(entity.SurveyResourceRating.ToString());
            this.TimeFormat = entity.TimeFormat == null ? default(string) : entity.TimeFormat.ToString();
            this.Title = entity.Title == null ? default(string) : entity.Title.ToString();
            this.TravelAvailabilityPct = entity.TravelAvailabilityPct == null ? default(string) : entity.TravelAvailabilityPct.ToString();

        } //end Resource(net.autotask.webservices.Resource entity)

        public static implicit operator net.autotask.webservices.Resource(Resource resource)
        {
            return new net.autotask.webservices.Resource()
            {
                id = resource.id,

            };

        } //end implicit operator net.autotask.webservices.Resource(Resource resource)

        #endregion //Constructors

        #region Fields

        #region Unreadable Fields

        //public long DefaultServiceDeskRoleID; //[Role]
        //public string Password; //Length:64

        #endregion //Unreadable Fields

        #region ReadOnly Fields

        public string DateFormat; //ReadOnly PickList Length:20
        public string TimeFormat; //ReadOnly PickList Length:20
        public double? InternalCost; //ReadOnly
        public double? SurveyResourceRating; //ReadOnly

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int LocationID; //ReadOnly Required PickList
        public int UserType; //ReadOnly Required PickList
        public DateTime HireDate; //ReadOnly Required

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public bool Active; //Required
        public string Email; //Required Length:254
        public string EmailTypeCode; //Required PickList Length:20
        public string FirstName; //Required Length:50
        public string LastName; //Required Length:50
        public string ResourceType; //Required PickList Length:15
        public string UserName; //Required Length:32
        public int PayrollType; //Required PickList
        public string NumberFormat; //Required PickList Length:20

        #endregion //Required Fields

        #region Optional Fields

        public string Email2; //Length:254
        public string Email3; //Length:254
        public string EmailTypeCode2; //PickList Length:20
        public string EmailTypeCode3; //PickList Length:20
        public string Gender; //PickList Length:1
        public int? Greeting; //PickList
        public string HomePhone; //Length:25
        public string Initials; //Length:32
        public string MiddleName; //Length:50
        public string MobilePhone; //Length:25
        public string OfficeExtension; //Length:10
        public string OfficePhone; //Length:25
        public string Suffix; //PickList Length:10
        public string Title; //Length:50
        public string TravelAvailabilityPct; //PickList Length:15
        public string AccountingReferenceID; //Length:100

        #endregion //Optional Fields
        
        #endregion //Fields

    } //end Resource

}
