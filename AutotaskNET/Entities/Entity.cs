using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// Each Autotask Entity object inherits from the Autotask base class Entity.
    /// </summary>
    public abstract class Entity
    {
        #region Properties

        public abstract bool CanCreate { get; }
        public abstract bool CanUpdate { get; }
        public abstract bool CanQuery { get; }
        public abstract bool CanDelete { get; }
        public abstract bool CanHaveUDFs { get; }

        #endregion //Properties

        #region Constructors

        public Entity() { } //end Entity()
        public Entity(net.autotask.webservices.Entity entity)
        {
            this.id = long.Parse(entity.id.ToString());

        } //end Entity(net.autotask.webservices.Entity entity)

        #endregion //Constructors

        #region Fields

        #region Required ReadOnly Fields

        public long id; //Required ReadOnly

        #endregion //Required ReadOnly Fields

        #endregion //Fields

        #region Methods

        /*
        public List<PropertyInfo> GetFields()
        {
            List<PropertyInfo> pInfo = new List<PropertyInfo>();
            foreach (PropertyInfo prop in this.GetType().GetProperties())
            {
                pInfo.Add(prop);
                //Console.WriteLine("{0}={1}", prop.Name, prop.GetValue(this, null));
            }
            return pInfo;
        } //end GetFields()
        */

        #endregion //Methods

    } //end Entity

}
