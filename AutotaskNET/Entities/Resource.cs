using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Resource : Entity
    {
        public override bool CanCreate => false;
        public override bool CanUpdate => true; //System Administrators Only
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region Unreadable Fields

        public long DefaultServiceDeskRoleID { get; set; } //[Role]
        public string Password { get; set; } //Length:64

        #endregion //Unreadable Fields

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

        public bool Active { get; set; } //Required
        public string Email { get; set; } //Required Length:254
        public string Email2 { get; set; } //Length:254
        public string Email3 { get; set; } //Length:254
        public string EmailTypeCode { get; set; } //Required PickList Length:20
        public string EmailTypeCode2 { get; set; } //PickList Length:20
        public string EmailTypeCode3 { get; set; } //PickList Length:20
        public string FirstName { get; set; } //Required Length:50
        public string Gender { get; set; } //PickList Length:1
        public int? Greeting { get; set; } //PickList
        public string HomePhone { get; set; } //Length:25
        public string Initials { get; set; } //Length:32
        public string LastName { get; set; } //Required Length:50
        public int LocationID { get; set; } //ReadOnly Required PickList
        public string MiddleName { get; set; } //Length:50
        public string MobilePhone { get; set; } //Length:25
        public string OfficeExtension { get; set; } //Length:10
        public string OfficePhone { get; set; } //Length:25
        public string ResourceType { get; set; } //Required PickList Length:15
        public string Suffix { get; set; } //PickList Length:10
        public string Title { get; set; } //Length:50
        public string TravelAvailabilityPct { get; set; } //PickList Length:15
        public string UserName { get; set; } //Required Length:32
        public int UserType { get; set; } //ReadOnly Required PickList
        public string DateFormat { get; set; } //ReadOnly PickList Length:20
        public string TimeFormat { get; set; } //ReadOnly PickList Length:20
        public int PayrollType { get; set; } //Required PickList
        public string NumberFormat { get; set; } //Required PickList Length:20
        public string AccountingReferenceID { get; set; } //Length:100
        public double InternalCost { get; set; } //ReadOnly
        public DateTime HireDate { get; set; } //ReadOnly Required
        public double SurveyResourceRating { get; set; } //ReadOnly

    } //end Resource

}
