using System;
using System.Linq;
using System.Net.Http.Headers;

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
            id = entity.id;
            ContractID = entity.ContractID == null ? default(int?) : int.Parse(entity.ContractID.ToString());
            ContactID = entity.ContactID == null ? default(int?) : int.Parse(entity.ContactID.ToString());
            CreateDate = entity.CreateDate == null ? default(DateTime?) : DateTime.Parse(entity.CreateDate.ToString());
            AccountID = entity.AccountID == null ? default(int) : int.Parse(entity.AccountID.ToString());
            Active = entity.Active != null && bool.Parse(entity.Active.ToString());
            DailyCost = entity.DailyCost == null ? default(double) : double.Parse(entity.DailyCost.ToString());
            HourlyCost = entity.HourlyCost == null ? default(double) : double.Parse(entity.HourlyCost.ToString());
            InstallDate = entity.InstallDate == null ? default(DateTime) : DateTime.Parse(entity.InstallDate.ToString());
            MonthlyCost = entity.MonthlyCost == null ? default(double) : double.Parse(entity.MonthlyCost.ToString());
            Notes = entity.Notes?.ToString();
            NumberOfUsers = entity.NumberOfUsers == null ? default(double) : double.Parse(entity.NumberOfUsers.ToString());
            PerUseCost = entity.PerUseCost == null ? default(double) : double.Parse(entity.PerUseCost.ToString());
            ProductID = entity.ProductID == null ? default(int) : int.Parse(entity.ProductID.ToString());
            ReferenceNumber = entity.ReferenceNumber?.ToString();
            ReferenceTitle = entity.ReferenceTitle?.ToString();
            SerialNumber = entity.SerialNumber?.ToString();
            SetupFee = entity.SetupFee == null ? default(double) : double.Parse(entity.SetupFee.ToString());
            WarrantyExpirationDate = entity.WarrantyExpirationDate == null ? default(DateTime?) : DateTime.Parse(entity.WarrantyExpirationDate.ToString());
            ServiceID = entity.ServiceID == null ? default(int?) : int.Parse(entity.ServiceID.ToString());
            ServiceBundleID = entity.ServiceBundleID == null ? default(int?) : int.Parse(entity.ServiceBundleID.ToString());
            Type = entity.Type == null ? default(int?) : int.Parse(entity.Type.ToString());
            VendorID = entity.VendorID == null ? default(int?) : int.Parse(entity.VendorID.ToString());
            InstalledByID = entity.InstalledByID == null ? default(int?) : int.Parse(entity.InstalledByID.ToString());
            ParentInstalledProductID = entity.ParentInstalledProductID == null ? default(int?) : int.Parse(entity.ParentInstalledProductID.ToString());
            InstalledByContactID = entity.InstalledByContactID == null ? default(int?) : int.Parse(entity.InstalledByContactID.ToString());
            ContractServiceID = entity.ContractServiceID == null ? default(int?) : int.Parse(entity.ContractServiceID.ToString());
            ContractServiceBundleID = entity.ContractServiceBundleID == null ? default(int?) : int.Parse(entity.ContractServiceBundleID.ToString());
            ServiceLevelAgreementID = entity.ServiceLevelAgreementID == null ? default(int?) : int.Parse(entity.ServiceLevelAgreementID.ToString());
            AccountPhysicalLocationID = entity.AccountPhysicalLocationID == null ? default(int?) : int.Parse(entity.AccountPhysicalLocationID.ToString());
            AEMDeviceAuditArchitectureID = entity.AEMDeviceAuditArchitectureID == null ? default(int?) : int.Parse(entity.AEMDeviceAuditArchitectureID.ToString());
            AEMDeviceAuditDisplayAdaptorID = entity.AEMDeviceAuditDisplayAdaptorID == null ? default(int?) : int.Parse(entity.AEMDeviceAuditDisplayAdaptorID.ToString());
            AEMDeviceAuditDomainID = entity.AEMDeviceAuditDomainID == null ? default(int?) : int.Parse(entity.AEMDeviceAuditDomainID.ToString());
            AEMDeviceAuditManufacturerID = entity.AEMDeviceAuditManufacturerID == null ? default(int?) : int.Parse(entity.AEMDeviceAuditManufacturerID.ToString());
            AEMDeviceAuditModelID = entity.AEMDeviceAuditModelID == null ? default(int?) : int.Parse(entity.AEMDeviceAuditModelID.ToString());
            AEMDeviceAuditMotherboardID = entity.AEMDeviceAuditMotherboardID == null ? default(int?) : int.Parse(entity.AEMDeviceAuditMotherboardID.ToString());
            Location = entity.Location?.ToString();
            AEMDeviceUID = entity.AEMDeviceUID?.ToString();
            AEMDeviceAuditExternalIPAddress = entity.AEMDeviceAuditExternalIPAddress?.ToString();
            AEMDeviceAuditHostname = entity.AEMDeviceAuditHostname?.ToString();
            AEMDeviceAuditMacAddress = entity.AEMDeviceAuditMacAddress?.ToString();
            AEMDeviceAuditIPAddress = entity.AEMDeviceAuditIPAddress?.ToString();
            AEMDeviceAuditOperatingSystem = entity.AEMDeviceAuditOperatingSystem?.ToString();
            AEMDeviceAuditSNMPLocation = entity.AEMDeviceAuditSNMPLocation?.ToString();
            AEMDeviceAuditSNMPName = entity.AEMDeviceAuditSNMPName?.ToString();
            AEMDeviceAuditSNMPContact = entity.AEMDeviceAuditSNMPContact?.ToString();
            AEMDeviceAuditMobileNumber = entity.AEMDeviceAuditMobileNumber?.ToString();
            AEMDeviceAuditDescription = entity.AEMDeviceAuditDescription?.ToString();
            AEMDeviceAuditLastUser = entity.AEMDeviceAuditLastUser?.ToString();
            DattoSerialNumber = entity.DattoSerialNumber?.ToString();
            DattoInternalIP = entity.DattoInternalIP?.ToString();
            DattoRemoteIP = entity.DattoRemoteIP?.ToString();
            DattoHostname = entity.DattoHostname?.ToString();
            DattoOSVersionID = entity.DattoOSVersionID == null ? default(int?) : int.Parse(entity.DattoOSVersionID.ToString());
            DattoZFSVersionID = entity.DattoZFSVersionID == null ? default(int?) : int.Parse(entity.DattoZFSVersionID.ToString());
            DattoKernelVersionID = entity.DattoKernelVersionID == null ? default(int?) : int.Parse(entity.DattoKernelVersionID.ToString());
            DattoNICSpeedKilobitsPerSecond = entity.DattoNICSpeedKilobitsPerSecond == null ? default(int?) : int.Parse(entity.DattoNICSpeedKilobitsPerSecond.ToString());
            DattoDeviceMemoryMegabytes = entity.DattoDeviceMemoryMegabytes == null ? default(int?) : int.Parse(entity.DattoDeviceMemoryMegabytes.ToString());
            DattoUptimeSeconds = entity.DattoUptimeSeconds == null ? default(int?) : int.Parse(entity.DattoUptimeSeconds.ToString());
            DattoNumberOfAgents = entity.DattoNumberOfAgents == null ? default(int?) : int.Parse(entity.DattoNumberOfAgents.ToString());
            DattoNumberOfDrives = entity.DattoNumberOfDrives == null ? default(int?) : int.Parse(entity.DattoNumberOfDrives.ToString());
            DattoDrivesErrors = entity.DattoDrivesErrors == null ? default(bool?) : bool.Parse(entity.DattoDrivesErrors.ToString());
            AEMDeviceID = entity.AEMDeviceID == null ? default(long) : long.Parse(entity.AEMDeviceID.ToString());
            AEMDeviceAuditMemoryBytes = entity.AEMDeviceAuditMemoryBytes == null ? default(long) : long.Parse(entity.AEMDeviceAuditMemoryBytes.ToString());
            AEMDeviceAuditStorageBytes = entity.AEMDeviceAuditStorageBytes == null ? default(long) : long.Parse(entity.AEMDeviceAuditStorageBytes.ToString());
            DattoProtectedKilobytes = entity.DattoProtectedKilobytes == null ? default(long) : long.Parse(entity.DattoProtectedKilobytes.ToString());
            DattoUsedKilobytes = entity.DattoUsedKilobytes == null ? default(long) : long.Parse(entity.DattoUsedKilobytes.ToString());
            DattoOffsiteUsedBytes = entity.DattoOffsiteUsedBytes == null ? default(long) : long.Parse(entity.DattoOffsiteUsedBytes.ToString());
            DattoAvailableKilobytes = entity.DattoAvailableKilobytes == null ? default(long) : long.Parse(entity.DattoAvailableKilobytes.ToString());
            AEMDeviceAuditProcessorID = entity.AEMDeviceAuditProcessorID == null ? default(int?) : int.Parse(entity.AEMDeviceAuditProcessorID.ToString());
            AEMDeviceAuditServicePackID = entity.AEMDeviceAuditServicePackID == null ? default(int?) : int.Parse(entity.AEMDeviceAuditServicePackID.ToString());
            AEMDeviceAuditDeviceTypeID = entity.AEMDeviceAuditDeviceTypeID == null ? default(int?) : int.Parse(entity.AEMDeviceAuditDeviceTypeID.ToString());
            AEMDeviceAuditMobileNetworkOperatorID = entity.AEMDeviceAuditMobileNetworkOperatorID == null ? default(int?) : int.Parse(entity.AEMDeviceAuditMobileNetworkOperatorID.ToString());
            AEMOpenAlertCount = entity.AEMOpenAlertCount == null ? default(int?) : int.Parse(entity.AEMOpenAlertCount.ToString());
            AEMDeviceAuditMissingPatchCount = entity.AEMDeviceAuditMissingPatchCount == null ? default(int?) : int.Parse(entity.AEMDeviceAuditMissingPatchCount.ToString());
            DattoNumberOfVolumes = entity.DattoNumberOfVolumes == null ? default(int?) : int.Parse(entity.DattoNumberOfVolumes.ToString());
            DattoLastCheckInDateTime = entity.DattoLastCheckInDateTime == null ? default(DateTime?) : DateTime.Parse(entity.DattoLastCheckInDateTime.ToString());
            DattoPercentageUsed = entity.DattoPercentageUsed == null ? default(double) : double.Parse(entity.DattoPercentageUsed.ToString());
            LastModifiedTime = entity.LastModifiedTime == null ? default(DateTime?) : DateTime.Parse(entity.LastModifiedTime.ToString());
            UserDefinedFields = entity.UserDefinedFields?.Select(udf => new UserDefinedField { Name = udf.Name, Value = udf.Value }).ToList();


        } //end InstalledProduct(net.autotask.webservices.InstalledProduct entity)

        public static implicit operator net.autotask.webservices.InstalledProduct(InstalledProduct installedproduct)
        {
            return new net.autotask.webservices.InstalledProduct()
            {
                id = installedproduct.id,
                ContractID = installedproduct.ContractID,
                MonthlyCost = installedproduct.MonthlyCost,
                Active = installedproduct.Active,
                DailyCost = installedproduct.DailyCost,
                HourlyCost = installedproduct.HourlyCost,
                InstallDate = installedproduct.InstallDate,
                Notes = installedproduct.Notes,
                NumberOfUsers = installedproduct.NumberOfUsers,
                PerUseCost = installedproduct.PerUseCost,
                ProductID = installedproduct.ProductID,
                ReferenceNumber = installedproduct.ReferenceNumber,
                ReferenceTitle = installedproduct.ReferenceTitle,
                SerialNumber = installedproduct.SerialNumber,
                SetupFee = installedproduct.SetupFee,
                WarrantyExpirationDate = installedproduct.WarrantyExpirationDate,
                ServiceID = installedproduct.ServiceID,
                ServiceBundleID = installedproduct.ServiceBundleID,
                Type = installedproduct.Type,
                Location = installedproduct.Location,
                ContactID = installedproduct.ContactID,
                VendorID = installedproduct.VendorID,

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
