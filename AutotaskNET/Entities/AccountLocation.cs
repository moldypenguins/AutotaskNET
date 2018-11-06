using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The AccountLocation entity takes on the UDFs that hold the site setup information for the account represented by AccountId.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class AccountLocation : Entity
    {
        public override bool CanCreate => false;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => true;

        #region ReadOnly Required Fields

        public int AccountID { get; internal set; } //ReadOnly Required [Account]

        #endregion //ReadOnly Required Fields

        #region ReadOnly Fields

        public string LocationName { get; internal set; } //ReadOnly Length:100

        #endregion //ReadOnly Fields

    } //end AccountLocation

}
