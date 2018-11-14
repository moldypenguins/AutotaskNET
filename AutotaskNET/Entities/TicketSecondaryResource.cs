using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a secondary resource assigned to a Ticket. 
    /// Secondary resources are different from the primary resource.
    /// A Ticket can have more than one Secondary Resource assigned, and can have secondary resources without a primary resource assigned.

    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TicketSecondaryResource : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public TicketSecondaryResource() : base() { } //end TicketSecondaryResource()
        public TicketSecondaryResource(net.autotask.webservices.TicketSecondaryResource entity) : base(entity)
        {
            this.ResourceID = long.Parse(entity.ResourceID.ToString());
            this.RoleID = long.Parse(entity.RoleID.ToString());
            this.TicketID = long.Parse(entity.TicketID.ToString());

        } //end TicketSecondaryResource(net.autotask.webservices.TicketSecondaryResource entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.TicketSecondaryResource()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public long TicketID; //Required [Ticket]
        public long ResourceID; //Required [Resource]
        public long RoleID; //Required [Role]

        #endregion //Required Fields

        #endregion //Fields

    } //end TicketSecondaryResource

}
