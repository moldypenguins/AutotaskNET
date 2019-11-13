using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The ContractFactor entity describes an Autotask Block Hour Factor, an option used with Block Hours Contracts.<br />
    /// With a Block Hours Contract, the customer pre-pays for a block of hours at a fixed hourly rate.<br />
    /// A Block Hour Factor can compensate for the fixed rate by applying a multiplier to specific role rates.<br />
    /// For example, if the contract hourly rate is $60, but an Engineer's hourly billing rate is $120, applying a block hour factor of 2 will debit 2 hours of contract time for each hour worked by an Engineer.<br />
    /// In Autotask, you create and manage Block Hour Factors from a Block Hours Contract's Summary page in the Contract module. 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractFactor : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ContractFactor() : base() { } //end ContractFactor()
        public ContractFactor(net.autotask.webservices.ContractFactor entity) : base(entity)
        {

        } //end ContractFactor(net.autotask.webservices.ContractFactor entity)

        public static implicit operator net.autotask.webservices.ContractFactor(ContractFactor contractfactor)
        {
            return new net.autotask.webservices.ContractFactor()
            {
                id = contractfactor.id,

            };

        } //end implicit operator net.autotask.webservices.ContractFactor(ContractFactor contractfactor)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public int ContractID; //ReadOnly Required [Contract]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public int RoleID; //Required [Role]
        public double BlockHourFactor; //Required

        #endregion //Required Fields

        #endregion //Fields

    } //end ContractFactor
}
