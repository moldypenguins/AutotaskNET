using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a skill that can be associated with a Resource through the ResourceSkill entity.<br />
    /// When assigning tickets via the API, the ResourceSkill entity provides information to assist in matching a Problem/Incident to resources with the proper skill level.<br />
    /// <br />
    /// To access or update ResourceSkill data, the user logged into the API must have security level must include Resources/Users (HR) permission.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Skill : Entity
    {
        public override bool CanCreate => false;
        public override bool CanUpdate => false;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Fields

        public string Description { get; set; } //ReadOnly Length:2000

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public string Name { get; set; } //ReadOnly Required Length:100
        public long CategoryID { get; set; } //ReadOnly Required PickList
        public bool Active { get; set; } //ReadOnly Required

        #endregion //ReadOnly Required Fields
        
    } //end Skill

}
