﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes Price List information associated with a Role.<br />
    /// Roles are assigned to Resources and required when a resource is assigned to a ticket or enters time on a ticket or task.<br />
    /// <br />
    /// Price List information for Products, Services, Materials, and Labor (Work Types and Roles) is set up and managed in Autotask on the Price List page: from the Autotask menu select Admin > Features & Settings > Finance, Accounting, & Invoicing > Price List.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class PriceListRole : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public PriceListRole() : base() { } //end PriceListRole()
        public PriceListRole(net.autotask.webservices.PriceListRole entity) : base(entity)
        {

        } //end PriceListRole(net.autotask.webservices.PriceListRole entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public int RoleID { get; set; } //ReadOnly Required [Role]
        public int CurrencyID { get; set; } //ReadOnly Required [Currency]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public bool UsesInternalCurrencyPrice { get; set; } //Required

        #endregion //Required Fields

        #region Optional Fields

        public decimal HourlyRate { get; set; }

        #endregion //Optional Fields

        #endregion //Fields

    } //end PriceListRole

}
