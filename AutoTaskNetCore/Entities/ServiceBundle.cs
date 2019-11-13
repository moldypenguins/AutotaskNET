using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ServiceBundle : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ServiceBundle() : base() { } //end ServiceBundle()
        public ServiceBundle(net.autotask.webservices.ServiceBundle entity) : base(entity)
        {

        } //end ServiceBundle(net.autotask.webservices.ServiceBundle entity)

        public static implicit operator net.autotask.webservices.ServiceBundle(ServiceBundle servicebundle)
        {
            return new net.autotask.webservices.ServiceBundle()
            {
                id = servicebundle.id,

            };

        } //end implicit operator net.autotask.webservices.ServiceBundle(ServiceBundle servicebundle)

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

        public string Name; //Required Length:100
        public string Description; //Length:200
        public double UnitPrice;
        public double UnitDiscount;
        public double PercentageDiscount;
        public string PeriodType; //ReadOnly Required PickList Length:1
        public int AllocationCodeID; //Required [AllocationCode]
        public bool? IsActive;
        public int? CreatorResourceID; //ReadOnly [Resource]
        public int? UpdateResourceID; //ReadOnly [Resource]
        public DateTime? CreateDate; //ReadOnly
        public string InvoiceDescription; //Length:1000
        public DateTime? LastModifiedDate; //ReadOnly
        public long ServiceLevelAgreementID; //PickList
        public double UnitCost; //ReadOnly

    } //end ServiceBundle

}
