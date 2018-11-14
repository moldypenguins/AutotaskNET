using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TaskPredecessor : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public TaskPredecessor() : base() { } //end TaskPredecessor()
        public TaskPredecessor(net.autotask.webservices.TaskPredecessor entity) : base(entity)
        {

        } //end TaskPredecessor(net.autotask.webservices.TaskPredecessor entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.TaskPredecessor()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public int PredecessorTaskID; //ReadOnly Required [Task]
        public int SuccessorTaskID; //ReadOnly Required [Task]

        #endregion //ReadOnly Required Fields

        #region Optional Fields

        public int? LagDays;

        #endregion //Optional Fields

        #endregion //Fields

    } //end TaskPredecessor

}
