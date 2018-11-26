using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes Autotask Configuration Items (previously known as Installed Products).<br />
    /// Configuration items are products that are associated with an Account entity.<br />
    /// Autotask users manage configuration items through the CRM Module (CRM >Configuration Items, or CRM > Accounts > Configuration Items tab).
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class InstalledProduct : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => true;

        #endregion //Properties

        #region Constructors

        public InstalledProduct() : base() { } //end InstalledProduct()
        public InstalledProduct(net.autotask.webservices.InstalledProduct entity) : base(entity)
        {
            this.AccountID = int.Parse(entity.AccountID.ToString());
            this.Active = bool.Parse(entity.Active.ToString());
            this.InstallDate = DateTime.Parse(entity.InstallDate.ToString());
            this.ProductID = int.Parse(entity.ProductID.ToString());
            this.AccountPhysicalLocationID = entity.AccountPhysicalLocationID == null ? default(int?) : int.Parse(entity.AccountPhysicalLocationID.ToString());
            this.AEMDeviceAuditArchitectureID = entity.AEMDeviceAuditArchitectureID == null ? default(int?) : int.Parse(entity.AEMDeviceAuditArchitectureID.ToString());
            this.AEMDeviceAuditDescription = entity.AEMDeviceAuditDescription == null ? default(string) : entity.AEMDeviceAuditDescription.ToString();
            this.AEMDeviceAuditDeviceTypeID = entity.AEMDeviceAuditDeviceTypeID == null ? default(int?) : int.Parse(entity.AEMDeviceAuditDeviceTypeID.ToString());
            this.AEMDeviceAuditDisplayAdaptorID = entity.AEMDeviceAuditDisplayAdaptorID == null ? default(int?) : int.Parse(entity.AEMDeviceAuditDisplayAdaptorID.ToString());
            this.AEMDeviceAuditDomainID = entity.AEMDeviceAuditDomainID == null ? default(int?) : int.Parse(entity.AEMDeviceAuditDomainID.ToString());
            this.AEMDeviceAuditExternalIPAddress = entity.AEMDeviceAuditExternalIPAddress == null ? default(string) : entity.AEMDeviceAuditExternalIPAddress.ToString();
            this.AEMDeviceAuditHostname = entity.AEMDeviceAuditHostname == null ? default(string) : entity.AEMDeviceAuditHostname.ToString();
            this.AEMDeviceAuditIPAddress = entity.AEMDeviceAuditIPAddress == null ? default(string) : entity.AEMDeviceAuditIPAddress.ToString();
            this.AEMDeviceAuditLastUser = entity.AEMDeviceAuditLastUser == null ? default(string) : entity.AEMDeviceAuditLastUser.ToString();
            this.AEMDeviceAuditMacAddress = entity.AEMDeviceAuditMacAddress == null ? default(string) : entity.AEMDeviceAuditMacAddress.ToString();
            this.AEMDeviceAuditManufacturerID = entity.AEMDeviceAuditManufacturerID == null ? default(int?) : int.Parse(entity.AEMDeviceAuditManufacturerID.ToString());
            this.AEMDeviceAuditMemoryBytes = long.Parse(entity.AEMDeviceAuditMemoryBytes.ToString());
            this.AEMDeviceAuditMissingPatchCount = entity.AEMDeviceAuditMissingPatchCount == null ? default(int?) : int.Parse(entity.AEMDeviceAuditMissingPatchCount.ToString());
            this.AEMDeviceAuditMobileNetworkOperatorID = entity.AEMDeviceAuditMobileNetworkOperatorID == null ? default(int?) : int.Parse(entity.AEMDeviceAuditMobileNetworkOperatorID.ToString());
            this.AEMDeviceAuditMobileNumber = entity.AEMDeviceAuditMobileNumber == null ? default(string) : entity.AEMDeviceAuditMobileNumber.ToString();
            this.AEMDeviceAuditModelID = entity.AEMDeviceAuditModelID  == null ? default(int?) : int.Parse(entity.AEMDeviceAuditModelID.ToString());
            this.AEMDeviceAuditMotherboardID = entity.AEMDeviceAuditMotherboardID == null ? default(int?) : int.Parse(entity.AEMDeviceAuditMotherboardID.ToString());
            this.AEMDeviceAuditOperatingSystem = entity.AEMDeviceAuditOperatingSystem == null ? default(string) : entity.AEMDeviceAuditOperatingSystem.ToString());
            this.AEMDeviceAuditProcessorID = entity.AEMDeviceAuditProcessorID == null ? default(int?) : int.Parse(entity.AEMDeviceAuditProcessorID.ToString());
            this.AEMDeviceAuditServicePackID = entity.AEMDeviceAuditServicePackID == null ? default(int?) : int.Parse(entity.AEMDeviceAuditServicePackID.ToString());
            this.AEMDeviceAuditSNMPContact = entity.AEMDeviceAuditSNMPContact == null ? default(string) : entity.AEMDeviceAuditSNMPContact.ToString();
            this.AEMDeviceAuditSNMPLocation = entity.AEMDeviceAuditSNMPLocation == null ? default(string) : entity.AEMDeviceAuditSNMPLocation.ToString();
            this.AEMDeviceAuditSNMPName = entity.AEMDeviceAuditSNMPName == null ? default(string) : entity.AEMDeviceAuditSNMPName.ToString();
            this.AEMDeviceAuditStorageBytes = long.Parse(entity.AEMDeviceAuditStorageBytes.ToString());
            this.AEMDeviceID = long.Parse(entity.AEMDeviceID.ToString());
            this.AEMDeviceUID = entity.AEMDeviceID == null ? default(string) : entity.AEMDeviceID.ToString();
            this.AEMOpenAlertCount = int.Parse(entity.AEMOpenAlertCount.ToString());
            this.ContactID = int.Parse(entity.ContactID.ToString());
            this.ContractID = entity.ContactID == null ? default(int?) : int.Parse(entity.ContactID.ToString());
            this.ContractServiceBundleID = entity.ContractServiceBundleID == null ? default(int?) : int.Parse(entity.ContractServiceBundleID.ToString());
            this.ContractServiceID = entity.ContractServiceID == null ? default(int?) : int.Parse(entity.ContractServiceID.ToString());
            this.CreateDate = entity.CreateDate == null ? default(DateTime?) : DateTime.Parse(entity.CreateDate.ToString());
            this.DattoAvailableKilobytes = long.Parse(entity.DattoAvailableKilobytes.ToString());
            this.DattoDeviceMemoryMegabytes = entity.DattoDeviceMemoryMegabytes == null ? default(int?) : int.Parse(entity.DattoDeviceMemoryMegabytes.ToString());
            this.DattoDrivesErrors = entity.DattoDrivesErrors == null ? default(bool?) : bool.Parse(entity.DattoDrivesErrors.ToString());
            this.DattoHostname = entity.DattoHostname == null ? default(string) : entity.DattoHostname.ToString();
            this.DattoInternalIP = entity.DattoInternalIP == null ? default(string) : entity.DattoInternalIP.ToString();
            this.DattoKernelVersionID = entity.DattoKernelVersionID == null ? default(int?) : int.Parse(entity.DattoKernelVersionID.ToString());
            this.DattoLastCheckInDateTime = entity.DattoLastCheckInDateTime == null ? default(DateTime?) : DateTime.Parse(entity.DattoLastCheckInDateTime.ToString());
            this.DattoNICSpeedKilobitsPerSecond = entity.DattoNICSpeedKilobitsPerSecond == null ? default(int?) : int.Parse(entity.DattoNICSpeedKilobitsPerSecond.ToString());
            this.DattoNumberOfAgents = entity.DattoNumberOfAgents == null ? default(int?) : int.Parse(entity.DattoNumberOfAgents.ToString());
            this.DattoNumberOfDrives = entity.DattoNumberOfDrives == null ? default(int?) : int.Parse(entity.DattoNumberOfDrives.ToString());
            this.DattoNumberOfVolumes = entity.DattoNumberOfVolumes == null ? default(int?) : int.Parse(entity.DattoNumberOfVolumes.ToString());
            this.DattoOffsiteUsedBytes = long.Parse(entity.DattoOffsiteUsedBytes.ToString());
            this.DattoOSVersionID = entity.DattoOSVersionID == null ? default(int?) : int.Parse(entity.DattoOSVersionID.ToString());
            this.DattoPercentageUsed = double.Parse(entity.DattoPercentageUsed.ToString());
            this.DattoProtectedKilobytes = long.Parse(entity.DattoProtectedKilobytes.ToString());
            this.DattoRemoteIP = entity.DattoInternalIP == null ? default(string) : entity.DattoInternalIP.ToString();
            this.DattoSerialNumber = entity.DattoSerialNumber == null ? default(string) : entity.DattoSerialNumber.ToString();
            this.DattoUptimeSeconds = entity.DattoUptimeSeconds == null ? default(int?) : int.Parse(entity.DattoUptimeSeconds.ToString());
            this.DattoUsedKilobytes = long.Parse(entity.DattoUsedKilobytes.ToString());
            this.DattoZFSVersionID = entity.DattoZFSVersionID == null ? default(int?) : int.Parse(entity.DattoZFSVersionID.ToString());
            this.DailyCost = double.Parse(entity.DailyCost.ToString());
            this.HourlyCost = double.Parse(entity.HourlyCost.ToString());
            this.InstalledByContactID = entity.InstalledByContactID == null ? default(int?) : int.Parse(entity.InstalledByContactID.ToString());
            this.InstalledByID = entity.InstalledByID == null ? default(int?) : int.Parse(entity.InstalledByID.ToString());
            this.LastModifiedTime = entity.LastModifiedTime == null ? default(DateTime?) : DateTime.Parse(entity.LastModifiedTime.ToString());
            this.Location = entity.Location == null ? default(string) : entity.Location.ToString();
            this.MonthlyCost = double.Parse(entity.MonthlyCost.ToString());
            this.Notes = entity.Notes == null ? default(string) : entity.Notes.ToString();
            this.NumberOfUsers = double.Parse(entity.NumberOfUsers.ToString());
            this.ParentInstalledProductID = entity.ParentInstalledProductID == null ? default(int?) : int.Parse(entity.ParentInstalledProductID.ToString());
            this.PerUseCost = double.Parse(entity.PerUseCost.ToString());
            this.ReferenceNumber = entity.ReferenceNumber == null ? default(string) : entity.ReferenceNumber.ToString();
            this.ReferenceTitle = entity.ReferenceTitle == null ? default(string) : entity.ReferenceTitle.ToString();
            this.SerialNumber = entity.SerialNumber == null ? default(string) : entity.SerialNumber.ToString();
            this.ServiceBundleID = entity.ServiceBundleID == null ? default(int?) : int.Parse(entity.ServiceBundleID.ToString());
            this.ServiceID = entity.ServiceID == null ? default(int?) : int.Parse(entity.ServiceID.ToString());
            this.ServiceLevelAgreementID = entity.ServiceLevelAgreementID == null ? default(int?) : int.Parse(entity.ServiceLevelAgreementID.ToString());
            this.SetupFee = double.Parse(entity.SetupFee.ToString());
            this.Type = entity.Type == null ? default(int?) : int.Parse(entity.Type.ToString());
            this.VendorID = entity.VendorID == null ? default(int?) : int.Parse(entity.VendorID.ToString());
            this.WarrantyExpirationDate = entity.WarrantyExpirationDate == null ? default(DateTime?) : DateTime.Parse(entity.WarrantyExpirationDate.ToString());
        } //end InstalledProduct(net.autotask.webservices.InstalledProduct entity)

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

        

        public DateTime? CreateDate; //ReadOnly
        public int AccountID; //ReadOnly Required [Account]
        public bool Active; //Required
        public double DailyCost;
        public double HourlyCost;
        public DateTime InstallDate; //Required
        public double MonthlyCost;
        public string Notes; //Length:5000
        public double NumberOfUsers;
        public double PerUseCost;
        public int ProductID; //Required [Product]
        public string ReferenceNumber; //Length:50
        public string ReferenceTitle; //Length:200
        public string SerialNumber; //Length:100
        public double SetupFee;
        public DateTime? WarrantyExpirationDate;
        public int? ContractID; //[Contract]
        public int? ServiceID; //[Service]
        public int? ServiceBundleID; //[ServiceBundle]
        public int? Type; //PickList
        public string Location; //Length:100
        public int? ContactID; //[Contact]
        public int? VendorID; //[Account]
        public int? InstalledByID; //ReadOnly [Resource]
        public int? InstalledByContactID; //ReadOnly [Contact]
        public int? ParentInstalledProductID; //[InstalledProduct]
        public DateTime? LastModifiedTime; //ReadOnly
        public int? ContractServiceID; //[ContractService]
        public int? ContractServiceBundleID; //[ContractServiceBundle]
        public int? ServiceLevelAgreementID; //PickList
        public int? AccountPhysicalLocationID; //[AccountPhysicalLocation]
        public long AEMDeviceID; //ReadOnly
        public string AEMDeviceUID; //ReadOnly Length:255
        public int? AEMDeviceAuditArchitectureID; //ReadOnly PickList
        public int? AEMDeviceAuditDisplayAdaptorID; //ReadOnly PickList
        public int? AEMDeviceAuditDomainID; //ReadOnly PickList
        public string AEMDeviceAuditExternalIPAddress; //ReadOnly Length:255
        public string AEMDeviceAuditHostname; //ReadOnly Length:255
        public string AEMDeviceAuditIPAddress; //ReadOnly Length:255
        public string AEMDeviceAuditMacAddress; //ReadOnly Length:255
        public int? AEMDeviceAuditManufacturerID; //ReadOnly PickList
        public long AEMDeviceAuditMemoryBytes; //ReadOnly
        public int? AEMDeviceAuditModelID; //ReadOnly PickList
        public int? AEMDeviceAuditMotherboardID; //ReadOnly PickList
        public string AEMDeviceAuditOperatingSystem; //ReadOnly Length:255
        public int? AEMDeviceAuditProcessorID; //ReadOnly PickList
        public int? AEMDeviceAuditServicePackID; //ReadOnly PickList
        public long AEMDeviceAuditStorageBytes; //ReadOnly
        public int? AEMDeviceAuditDeviceTypeID; //ReadOnly PickList
        public string AEMDeviceAuditSNMPLocation; //ReadOnly Length:255
        public string AEMDeviceAuditSNMPName; //ReadOnly Length:255
        public string AEMDeviceAuditSNMPContact; //ReadOnly Length:255
        public int? AEMDeviceAuditMobileNetworkOperatorID; //ReadOnly PickList
        public string AEMDeviceAuditMobileNumber; //ReadOnly Length:255
        public string AEMDeviceAuditDescription; //ReadOnly Length:255
        public int? AEMOpenAlertCount; //ReadOnly
        public string AEMDeviceAuditLastUser; //ReadOnly Length:50
        public int? AEMDeviceAuditMissingPatchCount; //ReadOnly
        public string DattoSerialNumber; //ReadOnly Length:100
        public string DattoInternalIP; //ReadOnly Length:255
        public string DattoRemoteIP; //ReadOnly Length:255
        public string DattoHostname; //ReadOnly Length:255
        public long DattoProtectedKilobytes; //ReadOnly
        public long DattoUsedKilobytes; //ReadOnly
        public long DattoAvailableKilobytes; //ReadOnly
        public double DattoPercentageUsed; //ReadOnly
        public long DattoOffsiteUsedBytes; //ReadOnly
        public int? DattoOSVersionID; //ReadOnly PickList
        public int? DattoZFSVersionID; //ReadOnly PickList
        public int? DattoKernelVersionID; //ReadOnly PickList
        public int? DattoNICSpeedKilobitsPerSecond; //ReadOnly
        public int? DattoDeviceMemoryMegabytes; //ReadOnly
        public int? DattoUptimeSeconds; //ReadOnly
        public int? DattoNumberOfAgents; //ReadOnly
        public int? DattoNumberOfDrives; //ReadOnly
        public bool? DattoDrivesErrors; //ReadOnly
        public int? DattoNumberOfVolumes; //ReadOnly
        public DateTime? DattoLastCheckInDateTime; //ReadOnly

        #endregion //Fields

    } //end InstalledProduct

}
