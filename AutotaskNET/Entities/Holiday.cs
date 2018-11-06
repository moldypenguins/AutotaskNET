using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a day specified as a Holiday (usually counted as paid time off) and included in an Autotask Internal Location Holiday Set.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Holiday : Entity
    {
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => true;
        public override bool CanHaveUDFs => false;

        #region Required Fields

        public string HolidayName { get; set; } //Required Length:100
        public DateTime HolidayDate { get; set; } //Required
        public int HolidaySetID { get; set; } //Required [HolidaySet]

        #endregion //Required Fields
        
    } //end Holiday

}
