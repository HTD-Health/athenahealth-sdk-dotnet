using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AthenaHealth.Sdk.Models.Response
{
    public class PatientInsuranceResponse
    {
        [JsonProperty("insurances")]
        public Insurance[] Items { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("totalcount")]
        public int Total { get; set; }
    }
}
