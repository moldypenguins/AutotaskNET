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

        } //end InstalledProduct(net.autotask.webservices.InstalledProduct entity)

        public static implicit operator net.autotask.webservices.InstalledProduct(InstalledProduct installedproduct)
        {
            return new net.autotask.webservices.InstalledProduct()
            {
                id = installedproduct.id,

            };

        } //end implicit operator net.autotask.webservices.InstalledProduct(InstalledProduct installedproduct)

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

    } //end InstalledProduct

}
