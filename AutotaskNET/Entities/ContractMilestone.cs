using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The ContractMilestone entity describes a billing milestone for an Autotask Fixed Price Contract.<br />
    /// Billing milestones describe tangible work or measured progress that must be completed before billing can take place, for example, "user approval on design specifications", or "ten workstations installed".<br />
    /// A fixed price contract can have multiple billing milestones.<br />
    /// In Autotask, you add and manage contract milestones from the Fixed Price Contract's Summary page.     /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class ContractMilestone : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public ContractMilestone() : base() { } //end ContractMilestone()
        public ContractMilestone(net.autotask.webservices.ContractMilestone entity) : base(entity)
        {
            this.Amount = double.Parse(entity.Amount.ToString());
            this.ContractID = int.Parse(entity.ContractID.ToString());
            this.DateDue = DateTime.Parse(entity.DateDue.ToString());
            this.IsInitialPayment = bool.Parse(entity.IsInitialPayment.ToString());
            this.Status = int.Parse(entity.Status.ToString());
            this.Title = entity.Title == null ? default(string) : entity.Title.ToString();
            this.AllocationCodeID = entity.AllocationCodeID == null ? default(int?) : int.Parse(entity.AllocationCodeID.ToString());
            this.CreateDate = entity.CreateDate == null ? default(DateTime?) : DateTime.Parse(entity.CreateDate.ToString());
            this.CreatorResourceID = entity.CreatorResourceID == null ? default(int?) : int.Parse(entity.CreatorResourceID.ToString());
            this.Description = entity.Description == null ? default(string) : entity.Description.ToString();
            this.InternalCurrencyAmount = double.Parse(entity.InternalCurrencyAmount.ToString());
        } //end Account(net.autotask.webservices.Account entity)

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public DateTime? CreateDate; //ReadOnly
        public int? CreatorResourceID; //ReadOnly [Resource]
        public double InternalCurrencyAmount; //ReadOnly
        public int? BusinessDivisionSubdivisionID; //ReadOnly [BusinessDivisionSubdivision]

        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields

        public int ContractID; //ReadOnly Required [Contract]

        #endregion //ReadOnly Required Fields

        #region Required Fields

        public int Status; //Required PickList
        public DateTime DateDue; //Required
        public double Amount; //Required
        public string Title; //Required Length:50
        public bool IsInitialPayment; //Required

        #endregion //Required Fields

        #region Optional Fields

        public string Description; //Length:250
        public int? AllocationCodeID; //[AllocationCode]

        #endregion //Optional Fields

        #endregion //Fields

    } //end ContractMilestone

}
