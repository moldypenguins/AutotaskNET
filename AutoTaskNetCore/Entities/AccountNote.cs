using System;
using System.Linq;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The AccountNote entity describes any sort of note created by an Autotask user and associated with an Account entity or an Opportunity entity.<br />
    /// Autotask users manage Account Notes through the CRM module (CRM > Accounts).
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class AccountNote : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public AccountNote() : base() { } //end AccountNote()
        public AccountNote(net.autotask.webservices.AccountNote entity) : base(entity)
        {
            var thisType = GetType();
            var fields = GetType().GetFields();
            var entityReflection = entity.GetType();

            foreach (var i in fields)
            {
                try
                {
                    if (i.Name == "UserDefinedFields")
                    {
                        // treat differently:
                        UserDefinedFields = entity.UserDefinedFields?.Select(udf => new UserDefinedField { Name = udf.Name, Value = udf.Value }).ToList();
                        continue;
                    }

                    var value = entityReflection.GetProperty(i.Name)?.GetValue(entity);
                    thisType.GetField(i.Name).SetValue(this, value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }


        } //end AccountNote(net.autotask.webservices.AccountNote entity)

        public static implicit operator net.autotask.webservices.AccountNote(AccountNote entity)
        {
            var newEntity = new net.autotask.webservices.AccountNote();
            var entityReflection = newEntity.GetType();
            var thisType = entity.GetType();
            var fields = entity.GetType().GetFields();

            foreach (var i in entityReflection.GetProperties())
            {
                try
                {
                    if (i.Name == "UserDefinedFields")
                    {
                        newEntity.UserDefinedFields = entity.UserDefinedFields == null
                            ? default
                            : Array.ConvertAll(entity.UserDefinedFields?.ToArray(), UserDefinedField.ToATWS);
                        continue;
                    }

                    if (i.Name == "Fields")
                        continue;

                    var value = thisType.GetField(i.Name).GetValue(entity);
                    entityReflection.GetProperty(i.Name)?.SetValue(newEntity, value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(i.Name);
                    Console.WriteLine(e);
                    throw;
                }
            }

            return newEntity;
        } //end implicit operator net.autotask.webservices.AccountNote(AccountNote accountnote)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public DateTime? CompletedDateTime; //ReadOnly
        public DateTime? LastModifiedDate; //ReadOnly

        #endregion //ReadOnly Fields

        #region Required Fields

        public int AccountID; //Required [Account]
        public int ActionType; //Required PickList
        public int AssignedResourceID; //Required [Resource]
        public DateTime EndDateTime; //Required
        public DateTime StartDateTime; //Required

        #endregion //Required Fields

        #region Optional Fields

        public int? ContactID; //[Contact]
        public string Name; //Length:128
        public string Note; //Length:32000
        public int? OpportunityID; //[Opportunity]

        #endregion //Optional Fields

        #endregion //Fields

    } //end AccountNote

}
