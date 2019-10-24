using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class Facility
    {
        /// <summary>
        /// The athena ID of this facility, to be used when adding orders
        /// </summary>
        [JsonProperty(PropertyName = "facilityid")]
        public int Id { get; set; }

        /// <summary>
        /// The NCPDP ID of the given facility, if applicable.
        /// </summary>
        [JsonProperty(PropertyName = "ncpdpid")]
        public int? NcpdpId { get; set; }

        /// <summary>
        /// The name of the facility
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The city of the facility
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// For pharmacies, whether this is a RETAIL or MAILORDER pharmacy.
        /// </summary>
        [JsonProperty(PropertyName = "pharmacytype")]
        public string PharmacyType { get; set; }

        /// <summary>
        /// The fax number of the facility
        /// </summary>
        [JsonProperty(PropertyName = "faxnumber")]
        public string FaxNumber { get; set; }

        /// <summary>
        /// The physical address of the facility
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// How far the facility is from the department or patient (if patientid is given), in miles.
        /// </summary>
        [JsonProperty(PropertyName = "distance")]
        public string Distance { get; set; }

        /// <summary>
        /// The zip code of the facility
        /// </summary>
        [JsonProperty(PropertyName = "zipcode")]
        public string ZipCode { get; set; }

        /// <summary>
        /// The state of the facility
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// The phone number of the facility
        /// </summary>
        [JsonProperty(PropertyName = "phonenumber")]
        public string PhoneNumber { get; set; }
    }
}
