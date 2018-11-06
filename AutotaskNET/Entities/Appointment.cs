using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The Appointment entity describes an Autotask Appointment, that is, scheduled time that is not a service call.<br />
    /// Autotask users manage appointments through their calendar.<br />
    /// In addition, Dispatchers can view and schedule appointments through the Dispatcher's Workshop.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Appointment : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields

        public int? CreatorResourceID { get; internal set; } //ReadOnly [Resource]
        public DateTime? CreateDateTime { get; internal set; } //ReadOnly
        public DateTime? UpdateDateTime { get; internal set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public int ResourceID { get; set; } //Required [Resource]
        public string Title { get; set; } //Required Length:256
        public DateTime StartDateTime { get; set; } //Required
        public DateTime EndDateTime { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public string Description { get; set; } //Length:8000

        #endregion //Optional Fields
        
    } //end Appointment

}
