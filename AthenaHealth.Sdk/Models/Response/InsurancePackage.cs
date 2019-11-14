using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class InsurancePackageResponse<T> : IPagingResponse<T>
        where T : InsurancePackage
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("insurancepackages")]
        public T[] Items { get; set; }
    }

    public class TopInsurancePackage : InsurancePackage
    {
        /// <summary>
        /// The athenaNet-wide insurance package (also know in the industry as an "insurance product") id.
        /// </summary>
        [JsonProperty("insurancepackageid")]
        public string Id { get; set; }

        [JsonProperty("ranking")]
        public string Ranking { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }

        /// <summary>
        /// The type of product (e.g. PPO, HMO, etc.)
        /// </summary>
        [JsonProperty("insuranceproducttypename")]
        public string InsuranceProductTypeName { get; set; }
    }

    public class CommonInsurancePackage : InsurancePackage
    {
        /// <summary>
        /// The athenaNet-wide insurance package (also know in the industry as an "insurance product") id.
        /// </summary>
        [JsonProperty("insurancepackageid")]
        public int Id { get; set; }
    }

    public class InsurancePackage
    {
        /// <summary>
        /// The name of the insurance package.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The phone number associated with this insurance package.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The city associated with this insurance package.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// The zip code associated with this insurance package.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// The state associated with this insurance package.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The first address line associated with this insurance package, often on the insurance card itself as a place to send claims.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// The second address line associated with this insurance package.
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 { get; set; }
    }
}
