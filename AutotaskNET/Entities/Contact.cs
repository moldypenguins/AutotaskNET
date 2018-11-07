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
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => true;

        #endregion //Properties

        #region Constructors

        public Contact() : base() { } //end Contact()
        public Contact(net.autotask.webservices.Contact entity) : base(entity)
        {


        } //end Contact(net.autotask.webservices.Contact entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public DateTime? LastActivityDate; //ReadOnly
        public DateTime? CreateDate; //ReadOnly
        public DateTime? LastModifiedDate; //ReadOnly
        public DateTime? BulkEmailOptOutTime; //ReadOnly
        public bool? SurveyOptOut; //ReadOnly
        public bool? SolicitationOptOut; //ReadOnly
        public DateTime? SolicitationOptOutTime; //ReadOnly

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int AccountID; //ReadOnly Required [Account]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public string FirstName; //Required Length:50
        public string LastName; //Required Length:50
        public int Active; //Required

        #endregion //Required Fields

        #region Optional Fields

        public string MiddleInitial; //Length:2
        public string Title; //Length:50
        public string AddressLine; //Length:128
        public string AddressLine1; //Length:128
        public string City; //Length:32
        public string State; //Length:40
        public string ZipCode; //Length:16
        public string Country; //Length:100
        public string EMailAddress; //Length:254
        public string EMailAddress2; //Length:254
        public string EMailAddress3; //Length:254
        public bool? Notification;
        public string Phone; //Length:25
        public string Extension; //Length:10
        public string AlternatePhone; //Length:32
        public string MobilePhone; //Length:25
        public string FaxNumber; //Length:25
        public string Note; //Length:50
        public string RoomNumber; //Length:50
        public string AdditionalAddressInformation; //Length:100
        public string ExternalID; //Length:50
        public int? CountryID; //[Country]
        public bool? BulkEmailOptOut;
        public int? NamePrefix; //PickList
        public int? NameSuffix; //PickList
        public string FacebookUrl; //Length:200
        public string TwitterUrl; //Length:200
        public string LinkedInUrl; //Length:200
        public bool? PrimaryContact;
        public int? AccountPhysicalLocationID; //[AccountPhysicalLocation]

        #endregion //Optional Fields

        #endregion //Fields

    } //end Contact

}
