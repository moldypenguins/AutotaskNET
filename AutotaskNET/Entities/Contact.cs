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
            this.AccountID = int.Parse(entity.AccountID.ToString());
            this.AccountPhysicalLocationID = entity.AccountPhysicalLocationID == null ? default(int?) : int.Parse(entity.AccountPhysicalLocationID.ToString());
            this.Active = int.Parse(entity.Active.ToString());
            this.AdditionalAddressInformation = entity.ZipCode == null ? default(string) : entity.ZipCode.ToString();
            this.AddressLine = entity.AddressLine == null ? default(string) : entity.AddressLine.ToString();
            this.AddressLine1 = entity.AddressLine1 == null ? default(string) : entity.AddressLine1.ToString();
            this.AlternatePhone = entity.AlternatePhone == null ? default(string) : entity.AlternatePhone.ToString();
            this.BulkEmailOptOut = entity.BulkEmailOptOut == null ? default(bool?) : bool.Parse(entity.BulkEmailOptOut.ToString());
            this.BulkEmailOptOutTime = entity.BulkEmailOptOutTime == null ? default(DateTime?) : DateTime.Parse(entity.BulkEmailOptOutTime.ToString());
            this.City = entity.City == null ? default(string) : entity.City.ToString();
            this.Country = entity.Country == null ? default(string) : entity.Country.ToString();
            this.CountryID = entity.CountryID == null ? default(int?) : int.Parse(entity.CountryID.ToString());
            this.CreateDate = entity.CreateDate == null ? default(DateTime?) : DateTime.Parse(entity.CreateDate.ToString());
            this.EMailAddress = entity.EMailAddress == null ? default(string) : entity.EMailAddress.ToString();
            this.EMailAddress2 = entity.EMailAddress2 == null ? default(string) : entity.EMailAddress2.ToString();
            this.EMailAddress3 = entity.EMailAddress3 == null ? default(string) : entity.EMailAddress3.ToString();
            this.Extension = entity.Extension == null ? default(string) : entity.Extension.ToString();
            this.ExternalID = entity.ExternalID == null ? default(string) : entity.ExternalID.ToString();
            this.FacebookUrl = entity.FacebookUrl == null ? default(string) : entity.FacebookUrl.ToString();
            this.FaxNumber = entity.FaxNumber == null ? default(string) : entity.FaxNumber.ToString();
            this.FirstName = entity.FirstName == null ? default(string) : entity.FirstName.ToString();
            this.LastActivityDate = entity.LastActivityDate == null ? default(DateTime?) : DateTime.Parse(entity.LastActivityDate.ToString());
            this.LastModifiedDate = entity.LastModifiedDate == null ? default(DateTime?) : DateTime.Parse(entity.LastModifiedDate.ToString());
            this.LastName = entity.LastName == null ? default(string) : entity.LastName.ToString();
            this.LinkedInUrl = entity.LinkedInUrl == null ? default(string) : entity.LinkedInUrl.ToString();
            this.MiddleInitial = entity.MiddleInitial == null ? default(string) : entity.MiddleInitial.ToString();
            this.MobilePhone = entity.MobilePhone == null ? default(string) : entity.MobilePhone.ToString();
            this.NamePrefix = entity.NamePrefix == null ? default(int?) : int.Parse(entity.NamePrefix.ToString());
            this.NameSuffix = entity.NameSuffix == null ? default(int?) : int.Parse(entity.NameSuffix.ToString());
            this.Note = entity.Note == null ? default(string) : entity.Note.ToString();
            this.Notification = entity.Notification == null ? default(bool?) : bool.Parse(entity.Notification.ToString());
            this.Phone = entity.Phone == null ? default(string) : entity.Phone.ToString();
            this.PrimaryContact = entity.PrimaryContact == null ? default(bool?) : bool.Parse(entity.PrimaryContact.ToString());
            this.RoomNumber = entity.RoomNumber == null ? default(string) : entity.RoomNumber.ToString();
            this.SolicitationOptOut = entity.SolicitationOptOut == null ? default(bool?) : bool.Parse(entity.SolicitationOptOut.ToString());
            this.SolicitationOptOutTime = entity.SolicitationOptOutTime == null ? default(DateTime?) : DateTime.Parse(entity.SolicitationOptOutTime.ToString());
            this.State = entity.State == null ? default(string) : entity.State.ToString();
            this.SurveyOptOut = entity.SurveyOptOut == null ? default(bool?) : bool.Parse(entity.SurveyOptOut.ToString());
            this.Title = entity.Title == null ? default(string) : entity.Title.ToString();
            this.TwitterUrl = entity.TwitterUrl == null ? default(string) : entity.TwitterUrl.ToString();
            this.ZipCode = entity.ZipCode == null ? default(string) : entity.ZipCode.ToString();

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
