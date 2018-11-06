using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The Contact entity describes an Autotask Contact. A contact is an individual associated with an Account.<br />
    /// Autotask users manage contacts through the CRM module(CRM > Contacts) or the Directory Module(Directory > Contacts).
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Contact : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => true;

        #region ReadOnly Fields

        public DateTime? LastActivityDate { get; set; } //ReadOnly
        public DateTime? CreateDate { get; set; } //ReadOnly
        public DateTime? LastModifiedDate { get; set; } //ReadOnly
        public DateTime? BulkEmailOptOutTime { get; set; } //ReadOnly
        public bool? SurveyOptOut { get; set; } //ReadOnly
        public bool? SolicitationOptOut { get; set; } //ReadOnly
        public DateTime? SolicitationOptOutTime { get; set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int AccountID { get; set; } //ReadOnly Required [Account]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public string FirstName { get; set; } //Required Length:50
        public string LastName { get; set; } //Required Length:50
        public int Active { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public string MiddleInitial { get; set; } //Length:2
        public string Title { get; set; } //Length:50
        public string AddressLine { get; set; } //Length:128
        public string AddressLine1 { get; set; } //Length:128
        public string City { get; set; } //Length:32
        public string State { get; set; } //Length:40
        public string ZipCode { get; set; } //Length:16
        public string Country { get; set; } //Length:100
        public string EMailAddress { get; set; } //Length:254
        public string EMailAddress2 { get; set; } //Length:254
        public string EMailAddress3 { get; set; } //Length:254
        public bool? Notification { get; set; }
        public string Phone { get; set; } //Length:25
        public string Extension { get; set; } //Length:10
        public string AlternatePhone { get; set; } //Length:32
        public string MobilePhone { get; set; } //Length:25
        public string FaxNumber { get; set; } //Length:25
        public string Note { get; set; } //Length:50
        public string RoomNumber { get; set; } //Length:50
        public string AdditionalAddressInformation { get; set; } //Length:100
        public string ExternalID { get; set; } //Length:50
        public int? CountryID { get; set; } //[Country]
        public bool? BulkEmailOptOut { get; set; }
        public int? NamePrefix { get; set; } //PickList
        public int? NameSuffix { get; set; } //PickList
        public string FacebookUrl { get; set; } //Length:200
        public string TwitterUrl { get; set; } //Length:200
        public string LinkedInUrl { get; set; } //Length:200
        public bool? PrimaryContact { get; set; }
        public int? AccountPhysicalLocationID { get; set; } //[AccountPhysicalLocation]

        #endregion //Optional Fields
        
    } //end Contact

}
