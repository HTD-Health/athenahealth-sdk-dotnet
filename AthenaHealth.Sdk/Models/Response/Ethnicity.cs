using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class Ethnicity
    {
        /// <summary>
        /// The 2.16.840.1.113883.5.50 code
        /// </summary>
        [JsonProperty("ethnicityid")]
        public string Id { get; set; }

        /// <summary>
        /// The ethnicity name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
