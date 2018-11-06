using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask Payment Term.<br />
    /// A payment term specifies the conditions and requirements for payment due on an Autotask invoice; for example, Net 30 days.<br />
    /// <br />
    /// In Autotask, payment terms are set up in the Admin module and added to a Quote or invoice template.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class PaymentTerm : Entity
    {
        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region Required Fields

        public string Name { get; set; } //Required Length:100

        #endregion //Required Fields

        #region Optional Fields

        public string Description { get; set; } //Length:2000
        public bool? Active { get; set; }
        public int? PaymentDueInDays { get; set; }

        #endregion //Optional Fields
        
    } //end PaymentTerm

}
