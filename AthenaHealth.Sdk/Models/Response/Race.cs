using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class Race
    {
        /// <summary>
        /// The 2.16.840.1.113883.5.104 code
        /// </summary>
        [JsonProperty("raceid")]
        public string Id { get; set; }

        /// <summary>
        /// The race name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
