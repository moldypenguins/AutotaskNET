using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes skills associated with an Autotask Resource. When assigning tickets via the API, this entity provides information to assist in matching the Problem/Incident to resources with the proper skill level.<br />
    /// <br />
    /// To access or update ResourceSkill data, the user logged into the API must have security level must include Resources/Users(HR) permission.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ResourceSkill : Entity
    {
        public override bool CanCreate => false;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #region ReadOnly Required Fields

        public long ResourceID { get; set; } //ReadOnly Required [Resource]
        public long SkillID { get; set; } //ReadOnly Required [Skill]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public long SkillLevel { get; set; } //Required PickList

        #endregion //Required Fields

        #region Optional Fields

        public string SkillDescription { get; set; } //Length:2000

        #endregion //Optional Fields
        
    } //end ResourceSkill

}
