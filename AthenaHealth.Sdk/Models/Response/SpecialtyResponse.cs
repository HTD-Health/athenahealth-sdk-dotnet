using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AthenaHealth.Sdk.Models.Response
{
    public class SpecialtyResponse : IPagingResponse<Specialty>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("providerspecialties")]
        public Specialty[] Items { get; set; }
    }

    public class Specialty
    {
        [JsonProperty("specialtyid")]
        public string Id { get; set; }

        [JsonProperty("specialtyname")]
        public string Name { get; set; }
    }
}
