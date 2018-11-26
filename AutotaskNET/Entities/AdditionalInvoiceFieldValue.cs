using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes the values for custom Additional Invoice Fields that users can add to Autotask for use with Autotask Invoice Templates.<br />
    /// Autotask invoice templates define the appearance and content of an invoice generated in Autotask.<br />
    /// Users can add Additional Invoice Fields as variables to the template.<br />
    /// The user can then specify a value for the field(s) when one or more invoices are processed and that value will apply to all invoices for that session.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class AdditionalInvoiceFieldValue : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public AdditionalInvoiceFieldValue() : base() { } //end AdditionalInvoiceFieldValue()
        public AdditionalInvoiceFieldValue(net.autotask.webservices.AdditionalInvoiceFieldValue entity) : base(entity)
        {
            this.AdditionalInvoiceFieldID = long.Parse(entity.AdditionalInvoiceFieldID.ToString());
            this.FieldValue = entity.FieldValue == null ? default(string) : entity.FieldValue.ToString();
            this.InvoiceBatchID = long.Parse(entity.InvoiceBatchID.ToString());
        } //end AdditionalInvoiceFieldValue(net.autotask.webservices.AdditionalInvoiceFieldValue entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public long AdditionalInvoiceFieldID; //ReadOnly Required PickList
        public long InvoiceBatchID; //ReadOnly Required
        public string FieldValue; //ReadOnly Required Length:100

        #endregion //ReadOnly Required Fields

        #endregion //Fields

    } //end AdditionalInvoiceFieldValue

}
