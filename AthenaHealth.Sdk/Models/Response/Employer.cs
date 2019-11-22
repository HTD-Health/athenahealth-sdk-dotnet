using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class EmployerResponse : IPagingResponse<Employer>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("employers")]
        public Employer[] Items { get; set; }
    }

    public class Employer
    {
        /// <summary>
        /// The practice specific ID for this employer.
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the employer.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The city of the employer.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// The fax number of the employer.
        /// </summary>
        [JsonProperty("fax")]
        public string Fax { get; set; }

        /// <summary>
        /// The address of the employer.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// The zip code of the employer.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// If present, an ordering for this employer for search results.
        /// </summary>
        [JsonProperty("ordering")]
        public string Ordering { get; set; }

        /// <summary>
        /// The state of the employer.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Notes about the employer; likely not patient-facing.
        /// </summary>
        [JsonProperty("notes")]
        public string Notes { get; set; }

        /// <summary>
        /// The phone number of the employer.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
