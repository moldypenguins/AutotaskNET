using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a Resource - Service Desk Role association.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ResourceServiceDeskRole : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ResourceServiceDeskRole() : base() { } //end ResourceServiceDeskRole()
        public ResourceServiceDeskRole(net.autotask.webservices.ResourceServiceDeskRole entity) : base(entity)
        {

        } //end ResourceServiceDeskRole(net.autotask.webservices.ResourceServiceDeskRole entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.ResourceServiceDeskRole()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region ReadOnly Required Fields

        public int ResourceID; //ReadOnly Required [Resource]

        #endregion //ReadOnly Required Fields

        #region Obsolete Fields

        public bool? Active; //(Obsolete)
        public bool? Default; //(Obsolete)
        public int RoleID; //Required [Role] (Obsolete)

        #endregion //Obsolete Fields

        #endregion //Fields

    } //end ResourceServiceDeskRole

}
