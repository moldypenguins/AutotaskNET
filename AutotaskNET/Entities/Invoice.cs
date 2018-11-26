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
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public Invoice() : base() { } //end Invoice()
        public Invoice(net.autotask.webservices.Invoice entity) : base(entity)
        {
            this.InvoiceDateTime = DateTime.Parse(entity.InvoiceDateTime.ToString());
            this.AccountID = entity.AccountID == null ? default(int?) : int.Parse(entity.AccountID.ToString());
            this.BatchID = entity.BatchID == null ? default(int?) : int.Parse(entity.BatchID.ToString());
            this.Comments = entity.Comments == null ? default(string) : entity.Comments.ToString();
            this.CreateDateTime = entity.CreateDateTime == null ? default(DateTime?) : DateTime.Parse(entity.CreateDateTime.ToString());
            this.CreatorResourceID = entity.CreatorResourceID == null ? default(int?) : int.Parse(entity.CreatorResourceID.ToString());
            this.DueDate = entity.DueDate == null ? default(DateTime?) : DateTime.Parse(entity.DueDate.ToString());
            this.FromDate = entity.FromDate == null ? default(DateTime?) : DateTime.Parse(entity.FromDate.ToString();
            this.InvoiceEditorTemplateID = entity.InvoiceEditorTemplateID == null ? default(int?) : int.Parse(entity.InvoiceEditorTemplateID.ToString());
            this.InvoiceNumber = entity.InvoiceNumber == null ? default(string) : entity.InvoiceNumber.ToString();
            this.InvoiceTotal = double.Parse(entity.InvoiceTotal.ToString());
            this.IsVoided = entity.IsVoided == null ? default(bool?) : bool.Parse(entity.IsVoided.ToString());
            this.OrderNumber = entity.OrderNumber == null ? default(string) : entity.OrderNumber.ToString();
            this.PaidDate = entity.PaidDate == null ? default(DateTime?) : DateTime.Parse(entity .PaidDate.ToString());
            this.PaymentTerm = entity.PaymentTerm == null ? default(int?) : int.Parse(entity.PaymentTerm.ToString());
            this.TaxGroup = entity.TaxGroup == null ? default(int?) : int.Parse(entity.TaxGroup.ToString());
            this.TaxRegionName = entity.TaxRegionName.ToString();
            this.ToDate = entity.ToDate == null ? default(DateTime?) : DateTime.Parse(entity.ToDate.ToString());
            this.TotalTaxValue = double.Parse(entity.TotalTaxValue.ToString());
            this.VoidedByResourceID = entity.VoidedByResourceID == null ? default(int?) : int.Parse(entity.VoidedByResourceID.ToString());
            this.VoidedDate = entity.VoidedDate == null ? default(DateTime?) : DateTime.Parse(entity .VoidedDate.ToString());
            this.WebServiceDate = entity.WebServiceDate == null ? default(DateTime?) : DateTime.Parse(entity .WebServiceDate.ToString());
        } //end Invoice(net.autotask.webservices.Invoice entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

        #endregion //Fields

        public int? AccountID; //ReadOnly [Account]
        public int? CreatorResourceID; //ReadOnly [Resource]
        public DateTime InvoiceDateTime; //ReadOnly Required
        public DateTime? CreateDateTime; //ReadOnly
        public string InvoiceNumber; //Length:100
        public string Comments; //ReadOnly Length:4000
        public double InvoiceTotal; //ReadOnly
        public double TotalTaxValue; //ReadOnly
        public int? TaxGroup; //ReadOnly PickList
        public DateTime? FromDate; //ReadOnly
        public DateTime? ToDate; //ReadOnly
        public string OrderNumber; //ReadOnly Length:20
        public int? PaymentTerm; //ReadOnly PickList
        public DateTime? WebServiceDate;
        public bool? IsVoided; //ReadOnly
        public DateTime? VoidedDate; //ReadOnly
        public int? VoidedByResourceID; //ReadOnly [Resource]
        public DateTime? PaidDate;
        public string TaxRegionName; //ReadOnly Length:200
        public DateTime? DueDate; //ReadOnly
        public int? BatchID; //ReadOnly
        public int? InvoiceEditorTemplateID; //ReadOnly [InvoiceTemplate]

    } //end Invoice

}
