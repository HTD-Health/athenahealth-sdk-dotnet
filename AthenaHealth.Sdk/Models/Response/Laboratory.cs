using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class Laboratory
    {
        /// <summary>
        /// The athenaNet clinical provider ID.
        /// </summary>
        [JsonProperty("clinicalproviderid")]
        public int? ClinicalProviderId { get; set; }

        /// <summary>
        /// The lab name
        /// </summary>
        [JsonProperty("clinicalprovidername")]
        public string ClinicalProviderName { get; set; }

        /// <summary>
        /// Address line 1 of the lab
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Address line 2 of the lab
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// City of the lab
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// State of the lab
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Zip code of the lab
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Phone number of the lab
        /// </summary>
        [JsonProperty("phonenumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Fax number of the lab
        /// </summary>
        [JsonProperty("faxnumber")]
        public string FaxNumber { get; set; }

        /// <summary>
        /// Flag representing if the lab accepts fax
        /// </summary>
        [JsonProperty("acceptfax")]
        public bool? AcceptFax { get; set; }
    }
}
