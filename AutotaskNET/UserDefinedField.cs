using System;

namespace AutotaskNET
{
    public class UserDefinedField
    {
        public UserDefinedField() { } //end UserDefinedField()
        public UserDefinedField(net.autotask.webservices.UserDefinedField user_defined_field)
        {
            this.Name = user_defined_field.Name == null ? default(string) : user_defined_field.Name.ToString();
            this.Value = user_defined_field.Value == null ? default(string) : user_defined_field.Value.ToString();

        } //end UserDefinedField()

        public static implicit operator net.autotask.webservices.UserDefinedField(UserDefinedField udf)
        {
            return new net.autotask.webservices.UserDefinedField()
            {
                Name = udf.Name,
                Value = udf.Value
            };

        } //end implicit operator net.autotask.webservices.UserDefinedField(UserDefinedField udf)


        //required for array casting
        internal static net.autotask.webservices.UserDefinedField ToATWS(UserDefinedField udf)
        {
            return udf;

        } //end net.autotask.webservices.UserDefinedField ToATWS(UserDefinedField udf)


        #region Fields

        public string Name;
        public string Value;

        #endregion //Fields

    } //end UserDefinedField
}
