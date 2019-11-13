using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ServiceCallTask : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ServiceCallTask() : base() { } //end ServiceCallTask()
        public ServiceCallTask(net.autotask.webservices.ServiceCallTask entity) : base(entity)
        {
            this.ServiceCallID = int.Parse(entity.ServiceCallID.ToString());
            this.TaskID = int.Parse(entity.TaskID.ToString());

        } //end ServiceCallTask(net.autotask.webservices.ServiceCallTask entity)

        public static implicit operator net.autotask.webservices.ServiceCallTask(ServiceCallTask servicecalltask)
        {
            return new net.autotask.webservices.ServiceCallTask()
            {
                id = servicecalltask.id,

            };

        } //end implicit operator net.autotask.webservices.ServiceCallTask(ServiceCallTask servicecalltask)

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public int ServiceCallID; //Required [ServiceCall]
        public int TaskID; //Required [Task]

        #endregion //Required Fields

        #endregion //Fields

    } //end ServiceCallTask

}
