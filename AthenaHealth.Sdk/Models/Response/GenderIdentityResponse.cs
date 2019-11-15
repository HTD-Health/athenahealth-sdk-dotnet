using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class GenderIdentityResponse : IPagingResponse<string>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        /// <summary>
        /// An array of strings describing a gender identity field that can be used to describe a patient in this practice.
        /// </summary>
        [JsonProperty("genderidentityfields")]
        public string[] Items { get; set; }
    }
}
