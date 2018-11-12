using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask project Phase.<br />
    /// Phases allow users to break projects into sub-groups of project tasks.<br />
    /// They can be a sub-phase to a Parent phase.Users manage phases through the Project's Schedule view in the Projects module.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Phase : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public Phase() : base() { } //end Phase()
        public Phase(net.autotask.webservices.Phase entity) : base(entity)
        {

        } //end Phase(net.autotask.webservices.Phase entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

        #endregion //Fields

        public DateTime? CreateDate { get; set; } //ReadOnly
        public int? CreatorResourceID { get; set; } //ReadOnly [Resource]
        public string Description { get; set; } //Length:8000
        public DateTime? DueDate { get; set; }
        public float EstimatedHours { get; set; } //ReadOnly
        public string ExternalID { get; set; } //Length:50
        public DateTime? LastActivityDateTime { get; set; } //ReadOnly
        public int? ParentPhaseID { get; set; } //[Phase]
        public string PhaseNumber { get; set; } //ReadOnly Length:50
        public int ProjectID { get; set; } //ReadOnly Required [Project]
        public bool? Scheduled { get; set; } //ReadOnly
        public DateTime? StartDate { get; set; }
        public string Title { get; set; } //Required Length:255

    } //end Phase

}
