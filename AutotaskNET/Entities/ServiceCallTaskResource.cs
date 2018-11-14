using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ServiceCallTaskResource : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ServiceCallTaskResource() : base() { } //end ServiceCallTaskResource()
        public ServiceCallTaskResource(net.autotask.webservices.ServiceCallTaskResource entity) : base(entity)
        {
            this.ResourceID = int.Parse(entity.ResourceID.ToString());
            this.ServiceCallTaskID = int.Parse(entity.ServiceCallTaskID.ToString());

        } //end ServiceCallTaskResource(net.autotask.webservices.ServiceCallTaskResource entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.ServiceCallTaskResource()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public int ServiceCallTaskID; //Required [ServiceCallTask]
        public int ResourceID; //Required [Resource]

        #endregion //Required Fields

        #endregion //Fields

    } //end ServiceCallTaskResource

}
