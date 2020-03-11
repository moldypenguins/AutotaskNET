using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a note associated with an Autotask Contract.<br />
    /// Notes are used to track information, update the status of the associated contract, and communicate with resources and customers.In Autotask, you create and manage Contract Notes from the Options or Notes features found on the Contract Summary page in the Contract module. 
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractNote : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ContractNote() : base() { } //end ContractNote()
        public ContractNote(net.autotask.webservices.ContractNote entity) : base(entity)
        {
            id = entity.id;
            ContractID = entity.ContractID?.ToString();
            Description = entity.Description?.ToString();
            CreatorResourceID = entity.CreatorResourceID == null ? (int?) null : int.Parse(entity.CreatorResourceID.ToString());
            LastActivityDate = entity.LastActivityDate == null ? (DateTime?)null : DateTime.Parse(entity.LastActivityDate.ToString());
            Title = entity.Title?.ToString();
            UserDefinedFields = entity.UserDefinedFields?.Select(udf => new UserDefinedField { Name = udf.Name, Value = udf.Value }).ToList();

        } //end ContractNote(net.autotask.webservices.ContractNote entity)

        public static implicit operator net.autotask.webservices.ContractNote(ContractNote contractnote)
        {
            return new net.autotask.webservices.ContractNote()
            {
                id = contractnote.id,
                ContractID = contractnote.id,
                Description = contractnote.Description,
                CreatorResourceID = contractnote.CreatorResourceID,
                LastActivityDate = contractnote.LastActivityDate,
                Title = contractnote.Title,
                UserDefinedFields = Array.ConvertAll(contractnote.UserDefinedFields.ToArray(), new Converter<UserDefinedField, net.autotask.webservices.UserDefinedField>(UserDefinedField.ToATWS))
            };

        } //end implicit operator net.autotask.webservices.ContractNote(ContractNote contractnote)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public DateTime? LastActivityDate; //ReadOnly
        public int? CreatorResourceID; //ReadOnly [Resource]

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public string ContractID; //ReadOnly Required [Contract] Length:25

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public string Title; //Required Length:250
        public string Description; //Required Length:8000

        #endregion //Required Fields

        #endregion //Fields

    } //end ContractNote

}
