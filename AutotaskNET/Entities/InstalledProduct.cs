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
        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => true;

        #region ReadOnly Fields



        #endregion //ReadOnly Fields

        #region ReadOnly Required Fields



        #endregion //ReadOnly Required Fields

        #region Required Fields



        #endregion //Required Fields

        #region Optional Fields



        #endregion //Optional Fields

        public DateTime? CreateDate { get; set; } //ReadOnly
        public int AccountID { get; set; } //ReadOnly Required [Account]
        public bool Active { get; set; } //Required
        public double DailyCost { get; set; }
        public double HourlyCost { get; set; }
        public DateTime InstallDate { get; set; } //Required
        public double MonthlyCost { get; set; }
        public string Notes { get; set; } //Length:5000
        public double NumberOfUsers { get; set; }
        public double PerUseCost { get; set; }
        public int ProductID { get; set; } //Required [Product]
        public string ReferenceNumber { get; set; } //Length:50
        public string ReferenceTitle { get; set; } //Length:200
        public string SerialNumber { get; set; } //Length:100
        public double SetupFee { get; set; }
        public DateTime? WarrantyExpirationDate { get; set; }
        public int? ContractID { get; set; } //[Contract]
        public int? ServiceID { get; set; } //[Service]
        public int? ServiceBundleID { get; set; } //[ServiceBundle]
        public int? Type { get; set; } //PickList
        public string Location { get; set; } //Length:100
        public int? ContactID { get; set; } //[Contact]
        public int? VendorID { get; set; } //[Account]
        public int? InstalledByID { get; set; } //ReadOnly [Resource]
        public int? InstalledByContactID { get; set; } //ReadOnly [Contact]
        public int? ParentInstalledProductID { get; set; } //[InstalledProduct]
        public DateTime? LastModifiedTime { get; set; } //ReadOnly
        public int? ContractServiceID { get; set; } //[ContractService]
        public int? ContractServiceBundleID { get; set; } //[ContractServiceBundle]
        public int? ServiceLevelAgreementID { get; set; } //PickList
        public int? AccountPhysicalLocationID { get; set; } //[AccountPhysicalLocation]
        public long AEMDeviceID { get; set; } //ReadOnly
        public string AEMDeviceUID { get; set; } //ReadOnly Length:255
        public int? AEMDeviceAuditArchitectureID { get; set; } //ReadOnly PickList
        public int? AEMDeviceAuditDisplayAdaptorID { get; set; } //ReadOnly PickList
        public int? AEMDeviceAuditDomainID { get; set; } //ReadOnly PickList
        public string AEMDeviceAuditExternalIPAddress { get; set; } //ReadOnly Length:255
        public string AEMDeviceAuditHostname { get; set; } //ReadOnly Length:255
        public string AEMDeviceAuditIPAddress { get; set; } //ReadOnly Length:255
        public string AEMDeviceAuditMacAddress { get; set; } //ReadOnly Length:255
        public int? AEMDeviceAuditManufacturerID { get; set; } //ReadOnly PickList
        public long AEMDeviceAuditMemoryBytes { get; set; } //ReadOnly
        public int? AEMDeviceAuditModelID { get; set; } //ReadOnly PickList
        public int? AEMDeviceAuditMotherboardID { get; set; } //ReadOnly PickList
        public string AEMDeviceAuditOperatingSystem { get; set; } //ReadOnly Length:255
        public int? AEMDeviceAuditProcessorID { get; set; } //ReadOnly PickList
        public int? AEMDeviceAuditServicePackID { get; set; } //ReadOnly PickList
        public long AEMDeviceAuditStorageBytes { get; set; } //ReadOnly
        public int? AEMDeviceAuditDeviceTypeID { get; set; } //ReadOnly PickList
        public string AEMDeviceAuditSNMPLocation { get; set; } //ReadOnly Length:255
        public string AEMDeviceAuditSNMPName { get; set; } //ReadOnly Length:255
        public string AEMDeviceAuditSNMPContact { get; set; } //ReadOnly Length:255
        public int? AEMDeviceAuditMobileNetworkOperatorID { get; set; } //ReadOnly PickList
        public string AEMDeviceAuditMobileNumber { get; set; } //ReadOnly Length:255
        public string AEMDeviceAuditDescription { get; set; } //ReadOnly Length:255
        public int? AEMOpenAlertCount { get; set; } //ReadOnly
        public string AEMDeviceAuditLastUser { get; set; } //ReadOnly Length:50
        public int? AEMDeviceAuditMissingPatchCount { get; set; } //ReadOnly
        public string DattoSerialNumber { get; set; } //ReadOnly Length:100
        public string DattoInternalIP { get; set; } //ReadOnly Length:255
        public string DattoRemoteIP { get; set; } //ReadOnly Length:255
        public string DattoHostname { get; set; } //ReadOnly Length:255
        public long DattoProtectedKilobytes { get; set; } //ReadOnly
        public long DattoUsedKilobytes { get; set; } //ReadOnly
        public long DattoAvailableKilobytes { get; set; } //ReadOnly
        public double DattoPercentageUsed { get; set; } //ReadOnly
        public long DattoOffsiteUsedBytes { get; set; } //ReadOnly
        public int? DattoOSVersionID { get; set; } //ReadOnly PickList
        public int? DattoZFSVersionID { get; set; } //ReadOnly PickList
        public int? DattoKernelVersionID { get; set; } //ReadOnly PickList
        public int? DattoNICSpeedKilobitsPerSecond { get; set; } //ReadOnly
        public int? DattoDeviceMemoryMegabytes { get; set; } //ReadOnly
        public int? DattoUptimeSeconds { get; set; } //ReadOnly
        public int? DattoNumberOfAgents { get; set; } //ReadOnly
        public int? DattoNumberOfDrives { get; set; } //ReadOnly
        public bool? DattoDrivesErrors { get; set; } //ReadOnly
        public int? DattoNumberOfVolumes { get; set; } //ReadOnly
        public DateTime? DattoLastCheckInDateTime { get; set; } //ReadOnly

    } //end InstalledProduct

}
