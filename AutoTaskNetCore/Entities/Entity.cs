using System;
using System.Collections.Generic;

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

        /*
        public static implicit operator net.autotask.webservices.Entity(Entity entity)
        {
            return entity;

        } //end implicit operator net.autotask.webservices.Entity(Entity entity)
        */

        #region Fields

        #region Required ReadOnly Fields

        public long id; //Required ReadOnly

        #endregion //Required ReadOnly Fields


        #region Optional Fields

        public List<UserDefinedField> UserDefinedFields;

        #endregion //Optional Fields

        #endregion //Fields



    } //end Entity

}
