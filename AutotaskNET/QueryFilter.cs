using System;

namespace AutotaskNET
{
    public class QueryFilter
    {
        /// <summary>
        /// Gets or sets the name of the field to filter.
        /// </summary>
        public string FieldName { get; set; }
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
        public string Operation { get; set; }
        /// <summary>
        /// Gets or sets the field value to filter on.
        /// </summary>
        public object Value { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryFilter"/> class.
        /// </summary>
        public QueryFilter() { } //end QueryFilter()
        
        public QueryFilter(string fieldname, string operation, object value)
        {
            this.FieldName = fieldname;
            this.Operation = operation;
            this.Value = value;
        } //end QueryFilter(string fieldname, string operation, object value)



    } //end QueryFilter

}
