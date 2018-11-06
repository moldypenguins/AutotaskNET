using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a modifier for a given Work Type AllocationCode.<br />
    /// It matches the modifier to a work type allocation code id, and stores a value and the modifier type.<br />
    /// <br />
    /// In Autotask, Work Types are allocation codes for labor charges.<br />
    /// They are managed under Billing Codes, accessed from the Autotask menu > Admin > Features & Settings > Finance, Accouting, & Invoicing > Billing Codes.<br />
    /// Modifiers can be configured when adding or editing the Work Type.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class WorkTypeModifier : Entity
    {
        public override bool CanCreate => false;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region Required Fields

        public int ModifierType { get; set; } //Required PickList

        #endregion //Required Fields

        #region Optional Fields

        public decimal ModifierValue { get; set; }

        #endregion //Optional Fields
        
    } //end WorkTypeModifier

}
