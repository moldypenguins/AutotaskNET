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
        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #region Required Fields

        public long TicketID { get; set; } //Required [Ticket]
        public long ResourceID { get; set; } //Required [Resource]
        public long RoleID { get; set; } //Required [Role]

        #endregion //Required Fields
        
    } //end TicketSecondaryResource

}
