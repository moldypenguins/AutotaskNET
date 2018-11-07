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

        } //end ServiceCall(net.autotask.webservices.ServiceCall entity)

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
