using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes the default settings for fields associated with the specified ticket category.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TicketCategoryFieldDefaults : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public TicketCategoryFieldDefaults() : base() { } //end TicketCategoryFieldDefaults()
        public TicketCategoryFieldDefaults(net.autotask.webservices.TicketCategoryFieldDefaults entity) : base(entity)
        {
            this.BusinessDivisionSubdivisionID = entity.BusinessDivisionSubdivisionID == null ? default(int?) : int.Parse(entity.BusinessDivisionSubdivisionID.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.EstimatedHours = decimal.Parse(entity.EstimatedHours.ToString());
            this.IssueTypeID = entity.IssueTypeID == null ? default(int?) : int.Parse(entity.IssueTypeID.ToString());
            this.Priority = entity.Priority == null ? default(int?) : int.Parse(entity.Priority.ToString());
            this.PurchaseOrderNumber = entity.PurchaseOrderNumber == null ? default(string) : entity.PurchaseOrderNumber.ToString();
            this.QueueID = entity.QueueID == null ? default(int?) : int.Parse(entity.QueueID.ToString());
            this.Resolution = entity.Resolution == null ? default(string) : entity.Resolution.ToString();
            this.ServiceLevelAgreementID = entity.ServiceLevelAgreementID == null ? default(int?) : int.Parse(entity.ServiceLevelAgreementID.ToString());
            this.SourceID = entity.SourceID == null ? default(int?) : int.Parse(entity.SourceID.ToString());
            this.Status = entity.Status == null ? default(int?) : int.Parse(entity.Status.ToString());
            this.SubIssueTypeID = entity.SubIssueTypeID == null ? default(int?) : int.Parse(entity.SubIssueTypeID.ToString());
            this.TicketCategoryID = int.Parse(entity.TicketCategoryID.ToString());
            this.TicketTypeID = entity.TicketTypeID == null ? default(int?) : int.Parse(entity.TicketTypeID.ToString());
            this.Title = entity.Title == null ? default(string) : entity.Title.ToString();
            this.WorkTypeID = entity.WorkTypeID == null ? default(int?) : int.Parse(entity.WorkTypeID.ToString());
        } //end TicketCategoryFieldDefaults(net.autotask.webservices.TicketCategoryFieldDefaults entity)

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

        public int? BusinessDivisionSubdivisionID; //ReadOnly [BusinessDivisionSubdivision]
        public string Description; //ReadOnly Length:8000
        public decimal EstimatedHours; //ReadOnly
        public int? IssueTypeID; //ReadOnly PickList
        public string PurchaseOrderNumber; //ReadOnly Length:50
        public int? QueueID; //ReadOnly PickList
        public string Resolution; //ReadOnly Length:8000
        public int? ServiceLevelAgreementID; //ReadOnly PickList
        public int? SourceID; //ReadOnly PickList
        public int? SubIssueTypeID; //ReadOnly PickList
        public int TicketCategoryID; //ReadOnly Required [TicketCategory]
        public int? TicketTypeID; //ReadOnly PickList
        public string Title; //ReadOnly Length:255
        public int? WorkTypeID; //ReadOnly [AllocationCode]
        public int? Status; //ReadOnly PickList
        public int? Priority; //ReadOnly PickList

    } //end TicketCategoryFieldDefaults

}
