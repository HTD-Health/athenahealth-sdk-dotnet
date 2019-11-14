using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
// ReSharper disable once CommentTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class Medication
    {
        /// <summary>
        /// The athena ID of the medication.
        /// </summary>
        [JsonProperty("medicationid")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the medication.
        /// </summary>
        [JsonProperty("medication")]
        public string Name { get; set; }
    }
}
