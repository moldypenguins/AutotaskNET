﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes information and results for surveys generated by Autotask.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class SurveyResults : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public SurveyResults() : base() { } //end SurveyResults()
        public SurveyResults(net.autotask.webservices.SurveyResults entity) : base(entity)
        {

        } //end SurveyResults(net.autotask.webservices.SurveyResults entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public int? AccountID { get; set; } //ReadOnly [Account]
        public decimal CompanyRating { get; set; } //ReadOnly
        public int? ContactID { get; set; } //ReadOnly [Contact]
        public decimal ContactRating { get; set; } //ReadOnly
        public DateTime? CompleteDate { get; set; } //ReadOnly
        public decimal ResourceRating { get; set; } //ReadOnly
        public DateTime? SendDate { get; set; } //ReadOnly
        public decimal SurveyRating { get; set; } //ReadOnly
        public int? TicketID { get; set; } //ReadOnly [Ticket]

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int SurveyID { get; set; } //ReadOnly Required [Survey]

        #endregion //ReadOnly Required Fields

        #endregion //Fields

    } //end SurveyResults

}
