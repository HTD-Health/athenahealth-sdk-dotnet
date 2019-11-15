using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class AllergyReaction
    {
        /// <summary>
        /// Athena ID for this reaction
        /// </summary>
        [JsonProperty("reactionid")]
        public int Id { get; set; }

        /// <summary>
        /// Name of the reaction
        /// </summary>
        [JsonProperty("reactionname")]
        public string Name { get; set; }

        /// <summary>
        /// SNOMED code for this reaction
        /// </summary>
        [JsonProperty("snomedcode")]
        public string SNOMED { get; set; }
    }
}
