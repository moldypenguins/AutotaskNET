using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ServiceCall : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ServiceCall() : base() { } //end ServiceCall()
        public ServiceCall(net.autotask.webservices.ServiceCall entity) : base(entity)
        {
            this.AccountID = int.Parse(entity.AccountID.ToString());
            this.AccountPhysicalLocationID = entity.AccountPhysicalLocationID == null ? default(int?) : int.Parse(entity.AccountPhysicalLocationID.ToString());
            this.CancelationNoticeHours = double.Parse(entity.AccountID.ToString());
            this.CanceledByResource = entity.CanceledByResource == null ? default(int?) : int.Parse(entity.CanceledByResource.ToString()); ;
            this.CanceledDateTime = entity.CanceledDateTime == null ? default(DateTime?) : DateTime.Parse(entity.CanceledDateTime.ToString());
            this.Complete = short.Parse(entity.Complete.ToString());
            this.CreateDateTime = entity.CreateDateTime == null ? default(DateTime?) : DateTime.Parse(entity.CreateDateTime.ToString());
            this.CreatorResourceID = entity.CreatorResourceID == null ? default(int?) : int.Parse(entity.CreatorResourceID.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.Duration = double.Parse(entity.Duration.ToString());
            this.EndDateTime = DateTime.Parse(entity.EndDateTime.ToString());
            this.LastModifiedDateTime = entity.LastModifiedDateTime == null ? default(DateTime?) : DateTime.Parse(entity.LastModifiedDateTime.ToString());
            this.StartDateTime = DateTime.Parse(entity.StartDateTime.ToString());
            this.Status = entity.Status == null ? default(int?) : int.Parse(entity.Status.ToString());

        } //end ServiceCall(net.autotask.webservices.ServiceCall entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.ServiceCall()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public int? CreatorResourceID; //ReadOnly
        public DateTime? CreateDateTime; //ReadOnly
        public DateTime? LastModifiedDateTime; //ReadOnly
        public double Duration; //ReadOnly
        public double CancelationNoticeHours; //ReadOnly

        #endregion //ReadOnly Fields
        
        #region Required Fields

        public int AccountID; //Required [Account]
        public DateTime StartDateTime; //Required
        public DateTime EndDateTime; //Required

        #endregion //Required Fields

        #region Optional Fields

        public string Description; //Length:2000
        public short Complete;
        public int? Status; //PickList
        public int? CanceledByResource;
        public DateTime? CanceledDateTime;
        public int? AccountPhysicalLocationID; //[AccountPhysicalLocation]

        #endregion //Optional Fields

        #endregion //Fields

    } //end ServiceCall

}
