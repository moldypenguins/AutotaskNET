using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The Invoice entity describes an Autotask Invoice.<br />
    /// In Autotask, Invoices include billing items that have been approved and posted and are being billed to a customer or presented for information purposes only.<br />
    /// They are processed through the Autotask Contracts module(Contracts > Invoices).
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Invoice : Entity
    {
        public override bool CanCreate => false;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

        public int? AccountID { get; set; } //ReadOnly [Account]
        public int? CreatorResourceID { get; set; } //ReadOnly [Resource]
        public DateTime InvoiceDateTime { get; set; } //ReadOnly Required
        public DateTime? CreateDateTime { get; set; } //ReadOnly
        public string InvoiceNumber { get; set; } //Length:100
        public string Comments { get; set; } //ReadOnly Length:4000
        public double InvoiceTotal { get; set; } //ReadOnly
        public double TotalTaxValue { get; set; } //ReadOnly
        public int? TaxGroup { get; set; } //ReadOnly PickList
        public DateTime? FromDate { get; set; } //ReadOnly
        public DateTime? ToDate { get; set; } //ReadOnly
        public string OrderNumber { get; set; } //ReadOnly Length:20
        public int? PaymentTerm { get; set; } //ReadOnly PickList
        public DateTime? WebServiceDate { get; set; }
        public bool? IsVoided { get; set; } //ReadOnly
        public DateTime? VoidedDate { get; set; } //ReadOnly
        public int? VoidedByResourceID { get; set; } //ReadOnly [Resource]
        public DateTime? PaidDate { get; set; }
        public string TaxRegionName { get; set; } //ReadOnly Length:200
        public DateTime? DueDate { get; set; } //ReadOnly
        public int? BatchID { get; set; } //ReadOnly
        public int? InvoiceEditorTemplateID { get; set; } //ReadOnly [InvoiceTemplate]

    } //end Invoice

}
