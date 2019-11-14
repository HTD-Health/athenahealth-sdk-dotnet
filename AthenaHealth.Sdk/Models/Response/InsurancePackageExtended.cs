using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class InsurancePackageResponse : IPagingResponse<InsurancePackageExtended>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("insurances")]
        public InsurancePackageExtended[] Items { get; set; }
    }

    public class InsurancePackageExtended
    {
        /// <summary>
        /// The athena insurance package ID.
        /// </summary>
        [JsonProperty("insurancepackageid")]
        public int Id { get; set; }

        /// <summary>
        /// The affiliations associated with this insurance package.
        /// </summary>
        [JsonProperty("affiliations")]
        public string[] Affiliations { get; set; }

        /// <summary>
        /// The addresses associated with this insurance package. The default address is listed first.
        /// </summary>
        [JsonProperty("addresslist")]
        public string[] AddressList { get; set; }

        /// <summary>
        /// Name of the specific insurance package.
        /// </summary>
        [JsonProperty("insuranceplanname")]
        public string InsurancePlanName { get; set; }
    }
}
