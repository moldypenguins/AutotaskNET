﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ResourceRoleDepartment : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ResourceRoleDepartment() : base() { } //end ResourceRoleDepartment()
        public ResourceRoleDepartment(net.autotask.webservices.ResourceRoleDepartment entity) : base(entity)
        {

        } //end ResourceRoleDepartment(net.autotask.webservices.ResourceRoleDepartment entity)

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

        public int DepartmentID { get; set; } //Required [Department]
        public int ResourceID { get; set; } //ReadOnly Required [Resource]
        public int RoleID { get; set; } //Required [Role]
        public bool Active { get; set; } //Required
        public bool Default { get; set; } //Required
        public bool DepartmentLead { get; set; } //Required

    } //end ResourceRoleDepartment

}
