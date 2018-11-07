using System;

namespace AutotaskNET
{
    /// <summary>
    /// 
    /// </summary>
    public class PicklistValue
    {
        public PicklistValue() { } //end PicklistValue()
        public PicklistValue(net.autotask.webservices.PickListValue pick_list_value)
        {
            this.Value = int.Parse(pick_list_value.Value.ToString());
            this.IsActive = bool.Parse(pick_list_value.IsActive.ToString());
            this.IsDefaultValue = bool.Parse(pick_list_value.IsDefaultValue.ToString());
            this.IsSystem = bool.Parse(pick_list_value.IsSystem.ToString());
            this.Label = pick_list_value.Label.ToString();
            this.ParentValue = pick_list_value.parentValue.ToString();
            this.SortOrder = int.Parse(pick_list_value.SortOrder.ToString());

        } //end PicklistValue()

        #region Fields

        public int Value;
        public bool IsActive;
        public bool IsDefaultValue;
        public bool IsSystem;
        public string Label; //Length:50
        public string ParentValue; //Length:50
        public int SortOrder;

        #endregion //Fields

    } //end PicklistValue

}
