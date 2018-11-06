using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ServiceLevelAgreementResults : Entity
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

        public int? TicketID { get; set; } //ReadOnly [Ticket]
        public string ServiceLevelAgreementName { get; set; } //ReadOnly Length:100
        public decimal FirstResponseElapsedHours { get; set; } //ReadOnly
        public int? FirstResponseInitiatingResourceID { get; set; } //ReadOnly [Resource]
        public int? FirstResponseResourceID { get; set; } //ReadOnly [Resource]
        public bool? FirstResponseMet { get; set; } //ReadOnly
        public decimal ResolutionPlanElapsedHours { get; set; } //ReadOnly
        public int? ResolutionPlanResourceID { get; set; } //ReadOnly [Resource]
        public bool? ResolutionPlanMet { get; set; } //ReadOnly
        public decimal ResolutionElapsedHours { get; set; } //ReadOnly
        public int? ResolutionResourceID { get; set; } //ReadOnly [Resource]
        public bool? ResolutionMet { get; set; } //ReadOnly

    } //end ServiceLevelAgreementResults

}
