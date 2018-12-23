using System;
using System.Collections;
using System.Collections.Generic;

namespace AutotaskNET
{
    public class ConditionGroup : IEnumerable<ConditionGroup>
    {
        private readonly List<ConditionGroup> _conditions;

        /// <summary>
        /// Available op attribute values:<br />
        /// And<br />
        /// Or<br />
        /// </summary>
        internal string Operation { get; private set; }

        public ConditionGroup()
        {
            this._conditions = new List<ConditionGroup>();

        } //end ConditionGroup()

        public ConditionGroup(ConditionGroupOperation operation) : this()
        {
            this.Operation = operation;

        } //end ConditionGroup(string operation)

        internal ConditionGroup(QueryFilter query_filter) : this()
        {
            foreach (ConditionGroup group in query_filter)
            {
                this._conditions.Add(group);
            }

        } //end ConditionGroup(string operation)

        public ConditionGroup Add(ConditionGroup condition)
        {
            this._conditions.Add(condition);
            return this;
        }


        public IEnumerator<ConditionGroup> GetEnumerator()
        {
            return _conditions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    } //end ConditionGroup


    public class ConditionGroupOperation
    {
        private ConditionGroupOperation(string value) { _value = value; }

        internal static string _value { get; set; }

        public static implicit operator string(ConditionGroupOperation category) { return _value; }

        public static ConditionGroupOperation AND { get { return new ConditionGroupOperation("AND"); } }
        public static ConditionGroupOperation OR { get { return new ConditionGroupOperation("OR"); } }
    }

}
