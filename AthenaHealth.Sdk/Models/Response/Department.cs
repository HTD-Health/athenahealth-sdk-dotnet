using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class DepartmentResponse
    {
        [JsonProperty("totalcount")]
        public int Total { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("departments")]
        public Department[] Departments { get; set; }
    }

    public class Department
    {
        [JsonProperty("clinicalproviderfax")]
        public string ClinicalProviderFax { get; set; }

        [JsonProperty("placeofservicetypeid")]
        public string PlaceOfServiceTypeId { get; set; }

        [JsonProperty("departmentid")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("creditcardtypes")]
        public string[] CreditCardTypes { get; set; }

        [JsonProperty("timezoneoffset")]
        public int TimezoneOffset { get; set; }

        [JsonProperty("singleappointmentcontractmax")]
        public string SingleAppointmentContractMax { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("placeofservicefacility")]
        public bool PlaceOfServiceFacility { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("clinicals")]
        public string Clinicals { get; set; }

        [JsonProperty("timezone")]
        public int Timezone { get; set; }

        [JsonProperty("patientdepartmentname")]
        public string PatientDepartmentName { get; set; }

        [JsonProperty("chartsharinggroupid")]
        public string ChartSharingGroupId { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("placeofservicetypename")]
        public string PlaceOfServiceTypeName { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("timezonename")]
        public string TimezoneName { get; set; }

        [JsonProperty("communicatorbrandid")]
        public string CommunicatorBrandId { get; set; }

        [JsonProperty("medicationhistoryconsent")]
        public bool MedicationHistoryConsent { get; set; }

        [JsonProperty("ishospitaldepartment")]
        public bool IsHospitalDepartment { get; set; }

        [JsonProperty("providergroupid")]
        public string ProviderGroupId { get; set; }

        [JsonProperty("portalurl")]
        public string PortalUrl { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("servicedepartment")]
        public bool ServiceDepartment { get; set; }

        [JsonProperty("oneyearcontractmax")]
        public string OneYearContractMax { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("providergroupname")]
        public string ProviderGroupName { get; set; }

        [JsonProperty("doesnotobservedst")]
        public string DoesNotObserveDst { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("ecommercecreditcardtypes")]
        public string[] ECommerceCreditCardTypes { get; set; }

        /// <summary>
        /// Providers who see patients in this department.
        /// </summary>
        [JsonProperty("providerlist")]
        public string[] ProviderList { get; set; }
    }
}
