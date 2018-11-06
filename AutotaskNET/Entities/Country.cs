using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a Country as defined in the Autotask CRM module.<br />
    /// The Country entity is referenced by the Account, Contact, and Sales Order entities and specifies the preferred display name for the associated country as well as the default address format and invoice template to be used by accounts, contacts, and sales orders that reference the Country ID.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Country : Entity
    {
        public override bool CanCreate => false;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields

        public string CountryCode { get; set; } //ReadOnly Length:2
        public string Name { get; set; } //ReadOnly Length:50

        #endregion //ReadOnly Fields

        #region Required Fields

        public string DisplayName { get; set; } //Required Length:100
        public long AddressFormatID { get; set; } //Required PickList

        #endregion //Required Fields

        #region Optional Fields

        public bool? Active { get; set; }
        public bool? IsDefaultCountry { get; set; }
        public int? QuoteTemplateID { get; set; } //[QuoteTemplate]
        public int? InvoiceTemplateID { get; set; } //[InvoiceTemplate]

        #endregion //Optional Fields

    } //end Country

}
