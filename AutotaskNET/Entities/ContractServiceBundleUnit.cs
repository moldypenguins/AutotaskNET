using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes the number of units of a specific service bundle that are associated with a Recurring Service contract for a specific date range.They provide information used in billing for the service bundle.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractServiceBundleUnit : Entity
    {
        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields

        public double Price { get; set; } //ReadOnly
        public DateTime? ApproveAndPostDate { get; set; } //ReadOnly
        public double Cost { get; set; } //ReadOnly
        public int? ContractServiceBundleID { get; set; } //ReadOnly [ContractServiceBundle]
        public double InternalCurrencyPrice { get; set; } //ReadOnly
        public int? BusinessDivisionSubdivisionID { get; set; } //ReadOnly [BusinessDivisionSubdivision]

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int ContractID { get; set; } //ReadOnly Required [Contract]
        public int ServiceBundleID { get; set; } //ReadOnly Required [ServiceBundle]
        public DateTime StartDate { get; set; } //ReadOnly Required
        public DateTime EndDate { get; set; } //ReadOnly Required
        public int Units { get; set; } //ReadOnly Required

        #endregion //ReadOnly Required Fields
        
    } //end ContractServiceBundleUnit

}
