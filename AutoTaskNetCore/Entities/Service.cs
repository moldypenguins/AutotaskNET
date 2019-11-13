using System;
using System.Linq;

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
            this.Name = entity.Name?.ToString();
            this.Description = entity.Description?.ToString();
            this.InvoiceDescription = entity.InvoiceDescription.ToString();
            this.IsActive = entity.IsActive == null ? default(bool?) : bool.Parse(entity.IsActive.ToString());
            this.UnitCost = entity.UnitCost == null ? default(double) : double.Parse(entity.UnitCost.ToString());
            this.UnitPrice = entity.UnitPrice == null ? default(double) : double.Parse(entity.UnitPrice.ToString());
            this.CreateDate = entity.CreateDate == null
                ? default(DateTime?)
                : DateTime.Parse(entity.CreateDate.ToString());
            this.AllocationCodeID = entity.AllocationCodeID == null ? default(int) : int.Parse(entity.AllocationCodeID.ToString());
            this.LastModifiedDate = entity.LastModifiedDate == null
                ? default(DateTime)
                : DateTime.Parse(entity.LastModifiedDate.ToString());
            this.CreatorResourceID = entity.CreatorResourceID == null
                ? default(int?)
                : int.Parse(entity.CreatorResourceID.ToString());
            this.MarkupRate = entity.MarkupRate == null ? default(double) : double.Parse(entity.MarkupRate.ToString());
            this.PeriodType = entity.PeriodType?.ToString();
            this.ServiceLevelAgreementID = entity.ServiceLevelAgreementID == null
                ? default(long)
                : long.Parse(entity.ServiceLevelAgreementID.ToString());
            this.UpdateResourceID = entity.UpdateResourceID == null
                ? default(int?)
                : int.Parse(entity.UpdateResourceID.ToString());
            this.VendorAccountID = entity.VendorAccountID == null
                ? default(int?)
                : int.Parse(entity.VendorAccountID.ToString());

            this.UserDefinedFields = entity.UserDefinedFields?.Select(udf => new UserDefinedField { Name = udf.Name, Value = udf.Value }).ToList();


        } //end Account(net.autotask.webservices.Account entity)

        public static implicit operator net.autotask.webservices.Service(Service service)
        {
            return new net.autotask.webservices.Service()
            {
                id = service.id,
                IsActive = service.IsActive,
                MarkupRate = service.MarkupRate,
                VendorAccountID = service.VendorAccountID,
                UnitCost = service.UnitCost,
                UpdateResourceID = service.UpdateResourceID,
                UnitPrice = service.UnitPrice,
                CreateDate = service.CreateDate,
                ServiceLevelAgreementID = service.ServiceLevelAgreementID,
                LastModifiedDate = service.LastModifiedDate,
                CreatorResourceID = service.CreatorResourceID,
                Description = service.Description,
                Name = service.Name,
                InvoiceDescription = service.InvoiceDescription,
                PeriodType = service.PeriodType,
                AllocationCodeID = service.AllocationCodeID,
                UserDefinedFields = Array.ConvertAll(service.UserDefinedFields.ToArray(), UserDefinedField.ToATWS)
            };

        } //end implicit operator net.autotask.webservices.Service(Service service)

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
