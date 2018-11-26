using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ServiceLevelAgreementResults : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ServiceLevelAgreementResults() : base() { } //end ServiceLevelAgreementResults()
        public ServiceLevelAgreementResults(net.autotask.webservices.ServiceLevelAgreementResults entity) : base(entity)
        {

        } //end ServiceLevelAgreementResults(net.autotask.webservices.ServiceLevelAgreementResults entity)

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

        public int? TicketID; //ReadOnly [Ticket]
        public string ServiceLevelAgreementName; //ReadOnly Length:100
        public decimal FirstResponseElapsedHours; //ReadOnly
        public int? FirstResponseInitiatingResourceID; //ReadOnly [Resource]
        public int? FirstResponseResourceID; //ReadOnly [Resource]
        public bool? FirstResponseMet; //ReadOnly
        public decimal ResolutionPlanElapsedHours; //ReadOnly
        public int? ResolutionPlanResourceID; //ReadOnly [Resource]
        public bool? ResolutionPlanMet; //ReadOnly
        public decimal ResolutionElapsedHours; //ReadOnly
        public int? ResolutionResourceID; //ReadOnly [Resource]
        public bool? ResolutionMet; //ReadOnly

        #endregion //Fields

    } //end ServiceLevelAgreementResults

}
