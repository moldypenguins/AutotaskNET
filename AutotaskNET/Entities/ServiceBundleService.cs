﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ServiceBundleService : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ServiceBundleService() : base() { } //end ServiceBundleService()
        public ServiceBundleService(net.autotask.webservices.ServiceBundleService entity) : base(entity)
        {

        } //end ServiceBundleService(net.autotask.webservices.ServiceBundleService entity)

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

        public long ServiceBundleID { get; set; } //ReadOnly Required [ServiceBundle]
        public long ServiceID { get; set; } //ReadOnly Required [Service]

    } //end ServiceBundleService

}
