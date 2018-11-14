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

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.Service()
            {
                id = this.id,

            };

        } //end ToATWS()

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
        public string Description; //Length:400
        public double UnitPrice; //Required
        public string PeriodType; //Required PickList Length:1
        public int AllocationCodeID; //Required [AllocationCode]
        public bool? IsActive;
        public int? CreatorResourceID; //ReadOnly [Resource]
        public int? UpdateResourceID; //ReadOnly [Resource]
        public DateTime? CreateDate; //ReadOnly
        public DateTime? LastModifiedDate; //ReadOnly
        public int? VendorAccountID; //[Account]
        public double UnitCost;
        public string InvoiceDescription; //Length:1000
        public long ServiceLevelAgreementID; //PickList
        public double MarkupRate; //ReadOnly

    } //end Service

}
