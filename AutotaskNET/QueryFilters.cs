using System;
using System.Collections;
using System.Collections.Generic;

namespace AutotaskNET
{
    public class QueryFilter : IEnumerable<ConditionGroup>
    {
        private readonly List<ConditionGroup> _conditions;

        public QueryFilter()
        {
            this._conditions = new List<ConditionGroup>();

        } //end QueryFilters()

        
        public QueryFilter Add(ConditionGroup condition)
        {
            this._conditions.Add(condition);
            return this;
        }

        internal static List<Condition> GetCondition(ConditionGroup group, string fieldname)
        {
            List<Condition> filters = new List<Condition>();
            foreach (ConditionGroup grp in group)
            {
                if (grp.GetType() == typeof(ConditionGroup))
                {
                    filters.AddRange(QueryFilter.GetCondition(grp, fieldname));
                }
                else if (grp.GetType() == typeof(Condition))
                {
                    Condition cnd = (Condition)grp;
                    if (cnd.FieldName == fieldname)
                    {
                        filters.Add(cnd);
                    }
                }
            }
            return filters;

        } //end GetCondition(ConditionGroup group, string fieldname)

        internal static bool ContainsCondition(ConditionGroup group, string fieldname)
        {
            bool exists = false;
            foreach (ConditionGroup grp in group)
            {
                if(grp.GetType() == typeof(ConditionGroup))
                {
                    if (QueryFilter.ContainsCondition(grp, fieldname))
                    {
                        exists = true;
                        break;
                    }
                }
                else if (grp.GetType() == typeof(Condition))
                {
                    Condition cnd = (Condition)grp;
                    if (cnd.FieldName == "id")
                    {
                        exists = true;
                        break;
                    }
                }
            }
            return exists;

        } //end ContainsCondition(ConditionGroup group, string fieldname)

        public IEnumerator<ConditionGroup> GetEnumerator()
        {
            return _conditions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

    } //end Query

}
