﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class QuoteLocation : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public QuoteLocation() : base() { } //end QuoteLocation()
        public QuoteLocation(net.autotask.webservices.QuoteLocation entity) : base(entity)
        {

        } //end QuoteLocation(net.autotask.webservices.QuoteLocation entity)

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

        public string Address1 { get; set; } //Length:50
        public string Address2 { get; set; } //Length:50
        public string City { get; set; } //Length:50
        public string State { get; set; } //Length:50
        public string PostalCode { get; set; } //Length:20

    } //end QuoteLocation

}
