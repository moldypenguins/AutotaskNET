using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes the resources associated with an Account Team.<br />
    /// In Autotask, the account team associates resources with an account.<br />
    /// The resources then have access to the account data when their security level allows account access at the Mine level.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class AccountTeam : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public AccountTeam() : base() { } //end AccountTeam()
        public AccountTeam(net.autotask.webservices.AccountTeam entity) : base(entity)
        {
            this.AccountID = long.Parse(entity.AccountID.ToString());
            this.ResourceID = long.Parse(entity.ResourceID.ToString());
        } //end AccountTeam(net.autotask.webservices.AccountTeam entity)

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public long AccountID { get; set; } //Required [Account]
        public long ResourceID { get; set; } //Required [Resource]

        #endregion //Required Fields

        #endregion //Fields

    } //end AccountTeam

}
