using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ServiceBundle : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

        public string Name { get; set; } //Required Length:100
        public string Description { get; set; } //Length:200
        public double UnitPrice { get; set; }
        public double UnitDiscount { get; set; }
        public double PercentageDiscount { get; set; }
        public string PeriodType { get; set; } //ReadOnly Required PickList Length:1
        public int AllocationCodeID { get; set; } //Required [AllocationCode]
        public bool? IsActive { get; set; }
        public int? CreatorResourceID { get; set; } //ReadOnly [Resource]
        public int? UpdateResourceID { get; set; } //ReadOnly [Resource]
        public DateTime? CreateDate { get; set; } //ReadOnly
        public string InvoiceDescription { get; set; } //Length:1000
        public DateTime? LastModifiedDate { get; set; } //ReadOnly
        public long ServiceLevelAgreementID { get; set; } //PickList
        public double UnitCost { get; set; } //ReadOnly

    } //end ServiceBundle

}
