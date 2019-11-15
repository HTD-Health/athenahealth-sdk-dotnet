using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class AllergySeverity
    {
        /// <summary>
        /// SNOMED code for this severity level
        /// </summary>
        [JsonProperty("snomedcode")]
        public string SNOMED { get; set; }

        /// <summary>
        /// Severity level name
        /// </summary>
        [JsonProperty("severity")]
        public string Severity { get; set; }
    }
}
