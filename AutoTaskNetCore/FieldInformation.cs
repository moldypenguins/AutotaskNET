using System;
using System.Collections.Generic;

namespace AutotaskNET
{
    public class FieldInformation
    {
        public FieldInformation() { } //end PicklistValue()
        public FieldInformation(net.autotask.webservices.Field field_information)
        {
            this.Name = field_information.Name;
            this.Label = field_information.Label;
            this.Type = field_information.Type;
            this.Description = field_information.Description;
            this.IsRequired = field_information.IsRequired;
            this.IsReadOnly = field_information.IsReadOnly;
            this.IsQueryable = field_information.IsQueryable;
            this.IsReference = field_information.IsReference;
            this.ReferenceEntityType = string.IsNullOrEmpty(field_information.ReferenceEntityType) ? null : System.Type.GetType(field_information.ReferenceEntityType, false, false);
            this.IsPickList = field_information.IsPickList;
            this.PicklistValues = field_information.PicklistValues == null ? null : new List<PicklistValue>();
            if (field_information.PicklistValues != null && field_information.PicklistValues.Length > 0)
            {
                foreach (net.autotask.webservices.PickListValue plv in field_information.PicklistValues)
                {
                    this.PicklistValues.Add(new PicklistValue(plv));
                }
            }
            this.PicklistParentFieldName = field_information.PicklistParentValueField;
            this.DefaultValue = field_information.DefaultValue;
            this.Length = field_information.Length;

        } //end PicklistValue()

        #region Fields

        public string Name { get; set; }
        public string Label { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public bool IsRequired { get; set; }
        public bool IsReadOnly { get; set; }
        public bool IsQueryable { get; set; }
        public bool IsReference { get; set; }
        public Type ReferenceEntityType { get; set; }
        public bool IsPickList { get; set; }
        public List<PicklistValue> PicklistValues { get; set; }
        public string PicklistParentFieldName { get; set; }
        public string DefaultValue { get; set; }
        public int Length { get; set; }

        #endregion //Fields

    } //end FieldInformation

}
