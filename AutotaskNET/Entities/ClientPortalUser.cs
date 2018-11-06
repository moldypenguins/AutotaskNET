using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask Account Contact that has been assigned access to the Client Access Portal.<br />
    /// In the Autotask Interface, Account Contacts are enabled as Client Portal Users in Admin > Client Access Portal > Manage Accounts > select Account > "Manage users for this account" or from the Client Portal tab of the Edit Contact window.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ClientPortalUser : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Required Fields

        public int ContactID { get; set; } //ReadOnly Required [Contact]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public int SecurityLevel { get; set; } //Required PickList
        public int DateFormat { get; set; } //Required PickList
        public int TimeFormat { get; set; } //Required PickList
        public int NumberFormat { get; set; } //Required PickList
        public string UserName { get; set; } //Required Length:200
        public bool ClientPortalActive { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public string Password { get; set; } //Length:50

        #endregion //Optional Fields
        
    } //end ClientPortalUser
}
