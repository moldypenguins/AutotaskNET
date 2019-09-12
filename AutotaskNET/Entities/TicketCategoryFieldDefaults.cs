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

        } //end TicketCategoryFieldDefaults(net.autotask.webservices.TicketCategoryFieldDefaults entity)

        public static implicit operator net.autotask.webservices.TicketCategoryFieldDefaults(TicketCategoryFieldDefaults ticketcategoryfielddefaults)
        {
            return new net.autotask.webservices.TicketCategoryFieldDefaults()
            {
                id = ticketcategoryfielddefaults.id,

            };

        } //end implicit operator net.autotask.webservices.TicketCategoryFieldDefaults(TicketCategoryFieldDefaults ticketcategoryfielddefaults)

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
