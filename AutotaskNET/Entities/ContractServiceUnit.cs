using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes the number of units of a specific service that are associated with a Recurring Service contract for a specific date range.They provide information used in billing for the service bundle.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractServiceUnit : Entity
    {
        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields

        public float Price { get; set; } //ReadOnly
        public DateTime? ApproveAndPostDate { get; set; } //ReadOnly
        public float Cost { get; set; } //ReadOnly
        public int? VendorAccountID { get; set; } //ReadOnly [Account]
        public float InternalCurrencyPrice { get; set; } //ReadOnly
        public int? BusinessDivisionSubdivisionID { get; set; } //ReadOnly [BusinessDivisionSubdivision]

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int ContractID { get; set; } //ReadOnly Required [Contract]
        public int ServiceID { get; set; } //ReadOnly Required [Service]
        public DateTime StartDate { get; set; } //ReadOnly Required
        public DateTime EndDate { get; set; } //ReadOnly Required
        public int Units { get; set; } //ReadOnly Required

        #endregion //ReadOnly Required Fields

        #region Optional Fields

        public int? ContractServiceID { get; set; } //[ContractService]

        #endregion //Optional Fields

    } //end ContractServiceUnit

}
