using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes the default settings for fields associated with the specified ticket category.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TicketCategoryFieldDefaults : Entity
    {
        public override bool CanCreate => false;
        public override bool CanUpdate => false;
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

        public int? BusinessDivisionSubdivisionID { get; set; } //ReadOnly [BusinessDivisionSubdivision]
        public string Description { get; set; } //ReadOnly Length:8000
        public decimal EstimatedHours { get; set; } //ReadOnly
        public int? IssueTypeID { get; set; } //ReadOnly PickList
        public string PurchaseOrderNumber { get; set; } //ReadOnly Length:50
        public int? QueueID { get; set; } //ReadOnly PickList
        public string Resolution { get; set; } //ReadOnly Length:8000
        public int? ServiceLevelAgreementID { get; set; } //ReadOnly PickList
        public int? SourceID { get; set; } //ReadOnly PickList
        public int? SubIssueTypeID { get; set; } //ReadOnly PickList
        public int TicketCategoryID { get; set; } //ReadOnly Required [TicketCategory]
        public int? TicketTypeID { get; set; } //ReadOnly PickList
        public string Title { get; set; } //ReadOnly Length:255
        public int? WorkTypeID { get; set; } //ReadOnly [AllocationCode]
        public int? Status { get; set; } //ReadOnly PickList
        public int? Priority { get; set; } //ReadOnly PickList

    } //end TicketCategoryFieldDefaults

}
