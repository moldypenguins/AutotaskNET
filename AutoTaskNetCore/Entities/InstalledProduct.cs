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
            var thisType = GetType();
            var fields = GetType().GetFields();
            var entityReflection = entity.GetType();

            foreach (var i in fields)
            {
                //Console.WriteLine($"Converting: {i.Name} -- {i.FieldType} -- {i.MemberType}");
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

        } //end InstalledProduct(net.autotask.webservices.InstalledProduct entity)

        public static implicit operator net.autotask.webservices.InstalledProduct(InstalledProduct entity)
        {
            var newEntity = new net.autotask.webservices.InstalledProduct();
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
