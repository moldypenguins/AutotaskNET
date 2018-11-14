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

        } //end Resource(net.autotask.webservices.Resource entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.Resource()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region Unreadable Fields

        public long DefaultServiceDeskRoleID; //[Role]
        public string Password; //Length:64

        #endregion //Unreadable Fields

        #region ReadOnly Fields

        public string DateFormat; //ReadOnly PickList Length:20
        public string TimeFormat; //ReadOnly PickList Length:20
        public double InternalCost; //ReadOnly
        public double SurveyResourceRating; //ReadOnly

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
