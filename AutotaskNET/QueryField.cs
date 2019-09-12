using System;
using System.Collections.Generic;
using System.Linq;

namespace AutotaskNET
{
    public class QueryField : QueryCondition
    {
        /// <summary>
        /// Available op attribute values:<br />
        /// Equals<br />
        /// NotEqual<br />
        /// GreaterThan<br />
        /// LessThan<br />
        /// GreaterThanorEquals<br />
        /// LessThanOrEquals<br />
        /// BeginsWith<br />
        /// EndsWith<br />
        /// Contains<br />
        /// IsNotNull<br />
        /// IsNull<br />
        /// IsThisDay<br />
        /// Like<br />
        /// NotLike<br />
        /// SoundsLike<br />
        /// <br />
        /// For Account Name, Contact Name, and Phone Number fields only:<br />
        /// normalizedequals<br />
        /// <br />
        /// Normalized Equals is now available as an expression operator attribute for the AccountName, ContactName, and PhoneNumber fields (<expression op="normalizedequals">).<br />
        /// This expression will pull in query results without the exact character matching search criteria required by the standard "equals" op attribute.<br />
        /// Normalized data is stored in a table in the database.<br />
        /// The following information is removed from these fields when we store the normalized data:<br />
        /// Characters:<br />
        /// ` ~ ! @ # $ % ^ & * ( ) _ - + = { [ } ] | \ : " ' < > . ? / ’ « € » Ð × Þ ð ÷ þ ° ² — ¡ ¿<br />
        /// Words:<br />
        /// An, And, Co, Company, Corp, Corporation, Inc, Incorporated, Llc, Llp, Ltd, Of, The
        /// </summary>
        internal new string Operation { get; private set; }

        /// <summary>
        /// Gets or sets the name of the field to filter.
        /// </summary>
        internal string FieldName { get; private set; }
        /// <summary>
        /// Gets or sets the field value to filter on.
        /// </summary>
        internal object Value { get; private set; }
        /// <summary>
        /// Gets or sets whether this field is a UDF
        /// </summary>
        internal bool IsUDF { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryField"/> class.
        /// </summary>
        public QueryField(string fieldname, QueryFieldOperation operation, bool udf = false)
        {
            this.FieldName = fieldname;
            this.Operation = operation;
            this.Value = null;
            this.IsUDF = udf;

            if (!new List<string> { QueryFieldOperation.IsNull, QueryFieldOperation.IsNotNull, QueryFieldOperation.IsThisDay }.Contains(operation))
            {
                throw new ArgumentException("QueryField(string fieldname, QueryFieldOperation operation) can only be used with IsNull, IsNotNull, and IsThisDay");
            }

        } //end QueryField(string fieldname, QueryFieldOperation operation, bool udf = false)

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryField"/> class.
        /// </summary>
        public QueryField(string fieldname, QueryFieldOperation operation, object value, bool udf = false)
        {
            this.FieldName = fieldname;
            this.Operation = operation;
            this.Value = value;
            this.IsUDF = udf;

        } //end QueryField(string fieldname, QueryFieldOperation operation, object value, bool udf = false)



    } //end QueryField


    public class QueryFieldOperation
    {
        private QueryFieldOperation(string value) { _value = value; }

        internal static string _value { get; set; }

        public static implicit operator string(QueryFieldOperation category) { return _value; }

        public static new QueryFieldOperation Equals { get { return new QueryFieldOperation("equals"); } }
        public static QueryFieldOperation NotEqual { get { return new QueryFieldOperation("notequal"); } }
        public static QueryFieldOperation GreaterThan { get { return new QueryFieldOperation("greaterthan"); } }
        public static QueryFieldOperation LessThan { get { return new QueryFieldOperation("lessthan"); } }
        public static QueryFieldOperation GreaterThanorEquals { get { return new QueryFieldOperation("greaterthanorequals"); } }
        public static QueryFieldOperation LessThanOrEquals { get { return new QueryFieldOperation("lessthanorequals"); } }
        public static QueryFieldOperation BeginsWith { get { return new QueryFieldOperation("beginswith"); } }
        public static QueryFieldOperation EndsWith { get { return new QueryFieldOperation("endswith"); } }
        public static QueryFieldOperation Contains { get { return new QueryFieldOperation("contains"); } }
        public static QueryFieldOperation IsNotNull { get { return new QueryFieldOperation("isnotnull"); } }
        public static QueryFieldOperation IsNull { get { return new QueryFieldOperation("isnull"); } }
        public static QueryFieldOperation IsThisDay { get { return new QueryFieldOperation("isthisday"); } }
        public static QueryFieldOperation Like { get { return new QueryFieldOperation("like"); } }
        public static QueryFieldOperation NotLike { get { return new QueryFieldOperation("notlike"); } }
        public static QueryFieldOperation SoundsLike { get { return new QueryFieldOperation("soundslike"); } }
        public static QueryFieldOperation NormalizedEquals { get { return new QueryFieldOperation("normalizedequals"); } }

    } //end QueryFieldOperation

}
