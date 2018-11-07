using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a configurable alert message, associated with an account, that appears on different account related pages.<br /> 
    /// It can convey important details about the account, for example, special contract requirements, billing arrangements, or support needs.<br />
    /// There are three types of account alerts. The type determine where the alert appears; for example, the Account Detail Alert type appears on the Account Detail page.<br />
    /// Account Alerts are configured on the Alerts tab of Edit Account page.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class AccountAlert : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Required Fields

        public int AccountID; //ReadOnly Required [Account]
        public int AlertTypeID; //ReadOnly Required PickList

        #endregion //ReadOnly Required Fields

        #region Optional Fields

        public string AlertText; //Length:8000

        #endregion //Optional Fields

    } //end AccountAlert

}
