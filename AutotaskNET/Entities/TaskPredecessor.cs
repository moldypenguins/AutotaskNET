using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TaskPredecessor : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Required Fields

        public int PredecessorTaskID { get; set; } //ReadOnly Required [Task]
        public int SuccessorTaskID { get; set; } //ReadOnly Required [Task]

        #endregion //ReadOnly Required Fields

        #region Optional Fields

        public int? LagDays { get; set; }

        #endregion //Optional Fields
        
    } //end TaskPredecessor

}
