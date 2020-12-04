using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Quote : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public Quote() : base() { } //end Quote()
        public Quote(net.autotask.webservices.Quote entity) : base(entity)
        {
            var thisType = typeof(Quote);
            var fields = typeof(Quote).GetFields();
            var entityReflection = typeof(net.autotask.webservices.Quote);

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
        } //end Quote(net.autotask.webservices.Quote entity)

        public static implicit operator net.autotask.webservices.Quote(Quote quote)
        {
            var newQuote = new net.autotask.webservices.Quote();
            var entityReflection = typeof(net.autotask.webservices.Quote);
            var thisType = quote.GetType();
            var fields = quote.GetType().GetFields();

            foreach (var i in entityReflection.GetProperties())
            {
                try
                {
                    if (i.Name == "UserDefinedFields")
                    {
                        newQuote.UserDefinedFields = quote.UserDefinedFields == null
                            ? default
                            : Array.ConvertAll(quote.UserDefinedFields?.ToArray(), UserDefinedField.ToATWS);
                        continue;
                    }

                    if (i.Name == "Fields")
                        continue;

                    var value = thisType.GetField(i.Name).GetValue(quote);
                    entityReflection.GetProperty(i.Name)?.SetValue(newQuote, value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            return newQuote;

        } //end implicit operator net.autotask.webservices.Quote(Quote quote)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

        #endregion //Fields

        public int OpportunityID; //ReadOnly Required [Opportunity]
        public string Name; //Required Length:100
        public bool? eQuoteActive;
        public DateTime EffectiveDate; //Required
        public DateTime ExpirationDate; //Required
        public DateTime? CreateDate; //ReadOnly
        public int? CreatorResourceID; //ReadOnly [Resource]
        public int? ContactID; //[Contact]
        public int? TaxGroup; //PickList
        public int? ProposalProjectID; //[Project]
        public int BillToLocationID; //Required [QuoteLocation]
        public int ShipToLocationID; //Required [QuoteLocation]
        public int SoldToLocationID; //Required [QuoteLocation]
        public int? ShippingType; //PickList
        public int? PaymentType; //PickList
        public int? PaymentTerm; //PickList
        public string ExternalQuoteNumber; //Length:50
        public string PurchaseOrderNumber; //Length:50
        public string Comment; //Length:1000
        public string Description; //Length:2000
        public int? AccountID; //[Account]
        public bool? CalculateTaxSeparately;
        public bool? GroupByProductCategory;
        public bool? ShowEachTaxInGroup;
        public bool? ShowTaxCategory;
        public bool? PrimaryQuote;
        public DateTime? LastActivityDate; //ReadOnly
        public int? LastModifiedBy; //ReadOnly [Resource]
        public int? QuoteTemplateID; //[QuoteTemplate]
        public Int16 GroupByID; //PickList
        public int? QuoteNumber; //ReadOnly

    } //end Quote

}
