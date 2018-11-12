using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a ticket category applied to tickets in Autotask to specify features and fields that appear on the ticket detail.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TicketCategory : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public TicketCategory() : base() { } //end TicketCategory()
        public TicketCategory(net.autotask.webservices.TicketCategory entity) : base(entity)
        {

        } //end TicketCategory(net.autotask.webservices.TicketCategory entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public bool? GlobalDefault { get; set; } //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public string Name { get; set; } //Required Length:30
        public bool Active { get; set; } //Required
        public int DisplayColorRGB { get; set; } //Required PickList

        #endregion //Required Fields

        #region Optional Fields

        public string Nickname { get; set; } //Length:3

        #endregion //Optional Fields

        #endregion //Fields

    } //end TicketCategory

}
