using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes an Autotask Department.<br />
    /// A Department is an association used to manage resources, especially when assigning project tasks.<br />
    /// Every resource must be associated with at least one department and have at least one assigned role in that department.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Department : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public Department() : base() { } //end Department()
        public Department(net.autotask.webservices.Department entity) : base(entity)
        {
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
            this.Number = entity.Number == null ? default(string) : entity.Number.ToString();
            this.PrimaryLocationID = int.Parse(entity.PrimaryLocationID.ToString());

        } //end Department(net.autotask.webservices.Department entity)

        public static implicit operator net.autotask.webservices.Department(Department department)
        {
            return new net.autotask.webservices.Department()
            {
                id = department.id,

            };

        } //end implicit operator net.autotask.webservices.Department(Department department)

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public string Name; //Required Length:100
        public int PrimaryLocationID; //Required [BusinessLocation]

        #endregion //Required Fields

        #region Optional Fields

        public string Number; //Length:50
        public string Description; //Length:1000

        #endregion //Optional Fields

        #endregion //Fields

    } //end Department

}
