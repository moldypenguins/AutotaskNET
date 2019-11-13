using System;

namespace AutotaskNET
{
    public class EntityInformation
    {
        public EntityInformation() { } //end PicklistValue()
        public EntityInformation(net.autotask.webservices.EntityInfo entity_information)
        {
            this.name = entity_information.Name;
            this.canQuery = entity_information.CanQuery;
            this.canCreate = entity_information.CanCreate;
            this.canUpdate = entity_information.CanUpdate;
            this.canDelete = entity_information.CanDelete;
            this.hasUserDefinedFields = entity_information.HasUserDefinedFields;

        } //end PicklistValue()

        #region Fields

        public string name;
        public bool canUpdate;
        public bool canDelete;
        public bool canCreate;
        public bool canQuery;
        public bool hasUserDefinedFields;

        #endregion //Fields

    } //end EntityInformation

}
