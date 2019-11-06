using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class Facility
    {
        /// <summary>
        /// The athena ID of this facility, to be used when adding orders
        /// </summary>
        [JsonProperty("facilityid")]
        public int Id { get; set; }

        /// <summary>
        /// The NCPDP ID of the given facility, if applicable.
        /// </summary>
        [JsonProperty("ncpdpid")]
        public int? NcpdpId { get; set; }

        /// <summary>
        /// The name of the facility
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The city of the facility
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// For pharmacies, whether this is a RETAIL or MAILORDER pharmacy.
        /// </summary>
        [JsonProperty("pharmacytype")]
        public string PharmacyType { get; set; }

        /// <summary>
        /// The fax number of the facility
        /// </summary>
        [JsonProperty("faxnumber")]
        public string FaxNumber { get; set; }

        /// <summary>
        /// The physical address of the facility
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// How far the facility is from the department or patient (if patientid is given), in miles.
        /// </summary>
        [JsonProperty("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// The zip code of the facility
        /// </summary>
        [JsonProperty("zipcode")]
        public string ZipCode { get; set; }

        /// <summary>
        /// The state of the facility
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The phone number of the facility
        /// </summary>
        [JsonProperty("phonenumber")]
        public string PhoneNumber { get; set; }
    }
}
