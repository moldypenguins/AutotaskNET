using System;
using System.Collections;
using System.Collections.Generic;

namespace AutotaskNET
{
    public class QueryCondition : IEnumerable<QueryCondition>
    {
        private readonly List<QueryCondition> _conditions;

        /// <summary>
        /// Available op attribute values:<br />
        /// And<br />
        /// Or<br />
        /// </summary>
        internal string Operation { get; private set; }

        public QueryCondition()
        {
            this._conditions = new List<QueryCondition>();

        } //end QueryCondition()

        public QueryCondition(QueryConditionOperation operation) : this()
        {
            this.Operation = operation;

        } //end QueryCondition(string operation)

        internal QueryCondition(QueryFilter query_filter) : this()
        {
            foreach (QueryCondition group in query_filter)
            {
                this._conditions.Add(group);
            }

        } //end QueryCondition(string operation)

        public QueryCondition Add(QueryCondition condition)
        {
            this._conditions.Add(condition);
            return this;
        }


        public IEnumerator<QueryCondition> GetEnumerator()
        {
            return _conditions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    } //end QueryCondition


    public class QueryConditionOperation
    {
        private QueryConditionOperation(string value) { _value = value; }

        internal static string _value { get; set; }

        public static implicit operator string(QueryConditionOperation category) { return _value; }

        public static QueryConditionOperation AND { get { return new QueryConditionOperation("AND"); } }
        public static QueryConditionOperation OR { get { return new QueryConditionOperation("OR"); } }
    }

}
