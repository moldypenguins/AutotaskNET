﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes general information for a survey generated by Autotask.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Survey : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public Survey() : base() { } //end Survey()
        public Survey(net.autotask.webservices.Survey entity) : base(entity)
        {

        } //end Survey(net.autotask.webservices.Survey entity)

        public static implicit operator net.autotask.webservices.Survey(Survey survey)
        {
            return new net.autotask.webservices.Survey()
            {
                id = survey.id,

            };

        } //end implicit operator net.autotask.webservices.Survey(Survey survey)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public string DisplayName { get; set; } //ReadOnly Length:100
        public string Description { get; set; } //ReadOnly Length:1000

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public string Name { get; set; } //ReadOnly Required Length:100

        #endregion //ReadOnly Required Fields

        #endregion //Fields

    } //end Survey

}
