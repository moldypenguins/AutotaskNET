using System;
using System.Collections;
using System.Collections.Generic;

namespace AutotaskNET
{
    public class QueryFilter : IEnumerable<QueryCondition>
    {
        private readonly List<QueryCondition> _conditions;

        public QueryFilter()
        {
            this._conditions = new List<QueryCondition>();

        } //end QueryFilters()

        
        public QueryFilter Add(QueryCondition condition)
        {
            this._conditions.Add(condition);
            return this;
        }

        internal static List<QueryField> GetCondition(QueryCondition group, string fieldname)
        {
            List<QueryField> filters = new List<QueryField>();
            foreach (QueryCondition grp in group)
            {
                if (grp.GetType() == typeof(QueryCondition))
                {
                    filters.AddRange(QueryFilter.GetCondition(grp, fieldname));
                }
                else if (grp.GetType() == typeof(QueryField))
                {
                    QueryField cnd = (QueryField)grp;
                    if (cnd.FieldName == fieldname)
                    {
                        filters.Add(cnd);
                    }
                }
            }
            return filters;

        } //end GetCondition(QueryCondition group, string fieldname)

        internal static bool ContainsCondition(QueryCondition group, string fieldname)
        {
            bool exists = false;
            foreach (QueryCondition grp in group)
            {
                if(grp.GetType() == typeof(QueryCondition))
                {
                    if (QueryFilter.ContainsCondition(grp, fieldname))
                    {
                        exists = true;
                        break;
                    }
                }
                else if (grp.GetType() == typeof(QueryField))
                {
                    QueryField cnd = (QueryField)grp;
                    if (cnd.FieldName == "id")
                    {
                        exists = true;
                        break;
                    }
                }
            }
            return exists;

        } //end ContainsCondition(QueryCondition group, string fieldname)

        public IEnumerator<QueryCondition> GetEnumerator()
        {
            return _conditions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

    } //end Query

}
