using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class State
    {
        [JsonProperty("state")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
