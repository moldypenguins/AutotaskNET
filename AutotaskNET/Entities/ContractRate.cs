using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a billing rate for an Autotask Contract.<br />
    /// A Contract Rate is associated with a Role and is specific to a contract, allowing you to override your company's standard role rates for labor tracked against the contract.<br />
    /// Rates are used with Time and Materials, Fixed Price, and Retainer type contracts.<br />
    /// In Autotask, you add and manage Contract Rates from the Contract Summary page. 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractRate : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ContractRate() : base() { } //end ContractRate()
        public ContractRate(net.autotask.webservices.ContractRate entity) : base(entity)
        {

        } //end ContractRate(net.autotask.webservices.ContractRate entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public double InternalCurrencyContractHourlyRate { get; set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int ContractID { get; set; } //ReadOnly Required [Contract]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public int RoleID { get; set; } //Required [Role]

        public double ContractHourlyRate { get; set; } //Required

        #endregion //Required Fields

        #endregion //Fields

    } //end ContractRate

}
