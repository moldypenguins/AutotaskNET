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
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public Appointment() : base() { } //end Appointment()
        public Appointment(net.autotask.webservices.Appointment entity) : base(entity)
        {

        } //end Appointment(net.autotask.webservices.Appointment entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.Appointment()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public int? CreatorResourceID; //ReadOnly [Resource]
        public DateTime? CreateDateTime; //ReadOnly
        public DateTime? UpdateDateTime; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public int ResourceID; //Required [Resource]
        public string Title; //Required Length:256
        public DateTime StartDateTime; //Required
        public DateTime EndDateTime; //Required

        #endregion //Required Fields

        #region Optional Fields

        public string Description; //Length:8000

        #endregion //Optional Fields

        #endregion //Fields

    } //end Appointment

}
