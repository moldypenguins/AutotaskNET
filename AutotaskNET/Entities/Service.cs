using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Service : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public Service() : base() { } //end Service()
        public Service(net.autotask.webservices.Service entity) : base(entity)
        {

        } //end Account(net.autotask.webservices.Account entity)

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

        public string Name { get; set; } //Required Length:100
        public string Description { get; set; } //Length:400
        public double UnitPrice { get; set; } //Required
        public string PeriodType { get; set; } //Required PickList Length:1
        public int AllocationCodeID { get; set; } //Required [AllocationCode]
        public bool? IsActive { get; set; }
        public int? CreatorResourceID { get; set; } //ReadOnly [Resource]
        public int? UpdateResourceID { get; set; } //ReadOnly [Resource]
        public DateTime? CreateDate { get; set; } //ReadOnly
        public DateTime? LastModifiedDate { get; set; } //ReadOnly
        public int? VendorAccountID { get; set; } //[Account]
        public double UnitCost { get; set; }
        public string InvoiceDescription { get; set; } //Length:1000
        public long ServiceLevelAgreementID { get; set; } //PickList
        public double MarkupRate { get; set; } //ReadOnly

    } //end Service

}
