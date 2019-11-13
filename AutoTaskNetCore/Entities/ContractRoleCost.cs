using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a per hour cost for labor that is set at the contract level.<br />
    /// This cost overrides a resource's Admin level internal cost rate for time entries posted against the contract.<br />
    /// Time entry dates must fall within the active dates of the contract.<br />
    /// The cost rate is associated with a resource and a role.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractRoleCost : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ContractRoleCost() : base() { } //end ContractRoleCost()
        public ContractRoleCost(net.autotask.webservices.ContractRoleCost entity) : base(entity)
        {

        } //end ContractRoleCost(net.autotask.webservices.ContractRoleCost entity)

        public static implicit operator net.autotask.webservices.ContractRoleCost(ContractRoleCost contractrolecost)
        {
            return new net.autotask.webservices.ContractRoleCost()
            {
                id = contractrolecost.id,

            };

        } //end implicit operator net.autotask.webservices.ContractRoleCost(ContractRoleCost contractrolecost)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public int ContractID; //ReadOnly Required [Contract]
        public int ResourceID; //ReadOnly Required [Resource]
        public int RoleID; //ReadOnly Required [Role]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public double Rate; //Required

        #endregion //Required Fields

        #endregion //Fields

    } //end ContractRoleCost

}
