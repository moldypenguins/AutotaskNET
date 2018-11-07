using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ServiceCallTicketResource : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ServiceCallTicketResource() : base() { } //end ServiceCallTicketResource()
        public ServiceCallTicketResource(net.autotask.webservices.ServiceCallTicketResource entity) : base(entity)
        {
            this.ResourceID = int.Parse(entity.ResourceID.ToString());
            this.ServiceCallTicketID = int.Parse(entity.ServiceCallTicketID.ToString());

        } //end ServiceCallTicketResource(net.autotask.webservices.ServiceCallTicketResource entity)

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public int ServiceCallTicketID; //Required [ServiceCallTicket]
        public int ResourceID; //Required [Resource]

        #endregion //Required Fields

        #endregion //Fields

    } //end ServiceCallTicketResource

}
