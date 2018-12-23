using System;

namespace AutotaskNET
{
    public class Condition : ConditionGroup
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
        /// Initializes a new instance of the <see cref="Condition"/> class.
        /// </summary>
        public Condition(string fieldname, ConditionOperation operation, object value)
        {
            this.FieldName = fieldname;
            this.Operation = operation;
            this.Value = value;

        } //end Condition(string fieldname, string operation, object value)



    } //end Condition


    public class ConditionOperation
    {
        private ConditionOperation(string value) { _value = value; }

        internal static string _value { get; set; }

        public static implicit operator string(ConditionOperation category) { return _value; }

        public static new ConditionOperation Equals { get { return new ConditionOperation("equals"); } }
        public static ConditionOperation NotEqual { get { return new ConditionOperation("notequal"); } }
        public static ConditionOperation GreaterThan { get { return new ConditionOperation("greaterthan"); } }
        public static ConditionOperation LessThan { get { return new ConditionOperation("lessthan"); } }
        public static ConditionOperation GreaterThanorEquals { get { return new ConditionOperation("greaterthanorequals"); } }
        public static ConditionOperation LessThanOrEquals { get { return new ConditionOperation("lessthanorequals"); } }
        public static ConditionOperation BeginsWith { get { return new ConditionOperation("beginswith"); } }
        public static ConditionOperation EndsWith { get { return new ConditionOperation("endswith"); } }
        public static ConditionOperation Contains { get { return new ConditionOperation("contains"); } }
        public static ConditionOperation IsNotNull { get { return new ConditionOperation("isnotnull"); } }
        public static ConditionOperation IsNull { get { return new ConditionOperation("isnull"); } }
        public static ConditionOperation IsThisDay { get { return new ConditionOperation("isthisday"); } }
        public static ConditionOperation Like { get { return new ConditionOperation("like"); } }
        public static ConditionOperation NotLike { get { return new ConditionOperation("notlike"); } }
        public static ConditionOperation SoundsLike { get { return new ConditionOperation("soundslike"); } }
        public static ConditionOperation NormalizedEquals { get { return new ConditionOperation("normalizedequals"); } }

    } //end ConditionOperation

}
