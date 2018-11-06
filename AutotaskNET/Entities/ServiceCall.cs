using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ServiceCall : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
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

        public int AccountID { get; set; } //Required [Account]
        public DateTime StartDateTime { get; set; } //Required
        public DateTime EndDateTime { get; set; } //Required
        public string Description { get; set; } //Length:2000
        public short Complete { get; set; }
        public int? CreatorResourceID { get; set; } //ReadOnly
        public DateTime? CreateDateTime { get; set; } //ReadOnly
        public DateTime? LastModifiedDateTime { get; set; } //ReadOnly
        public double Duration { get; set; } //ReadOnly
        public int? Status { get; set; } //PickList
        public int? CanceledByResource { get; set; }
        public DateTime? CanceledDateTime { get; set; }
        public double CancelationNoticeHours { get; set; } //ReadOnly
        public int? AccountPhysicalLocationID { get; set; } //[AccountPhysicalLocation]

    } //end ServiceCall

}
