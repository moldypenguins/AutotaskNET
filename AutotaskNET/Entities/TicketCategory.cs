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
            this.Active = bool.Parse(entity.Active.ToString());
            this.DisplayColorRGB = int.Parse(entity.DisplayColorRGB.ToString());
            this.GlobalDefault = entity.GlobalDefault == null ? default(bool?) : bool.Parse(entity.GlobalDefault.ToString());
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
            this.Nickname = entity.Nickname == null ? default(string) : entity.Nickname.ToString();
        } //end TicketCategory(net.autotask.webservices.TicketCategory entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public bool? GlobalDefault; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public string Name; //Required Length:30
        public bool Active; //Required
        public int DisplayColorRGB; //Required PickList

        #endregion //Required Fields

        #region Optional Fields

        public string Nickname; //Length:3

        #endregion //Optional Fields

        #endregion //Fields

    } //end TicketCategory

}
