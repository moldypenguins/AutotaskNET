using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes the associations between Change Request tickets and both Incidents and Problems.<br />
    /// Change request tickets are part of the Autotask change Management feature set.<br />
    /// Change management features are only available in the Autotask UI when the Change Management module is enabled.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ChangeRequestLink : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ChangeRequestLink() : base() { } //end ChangeRequestLink()
        public ChangeRequestLink(net.autotask.webservices.ChangeRequestLink entity) : base(entity)
        {

        } //end ChangeRequestLink(net.autotask.webservices.ChangeRequestLink entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.ChangeRequestLink()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public int ChangeRequestTicketID; //Required [Ticket]
        public int ProblemOrIncidentTicketID; //Required [Ticket]

        #endregion //Required Fields

        #endregion //Fields

    } //end ChangeRequestLink

}
