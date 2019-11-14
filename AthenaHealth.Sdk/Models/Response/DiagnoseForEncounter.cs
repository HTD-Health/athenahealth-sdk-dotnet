using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class DiagnoseForEncounter
    {
        /// <summary>
        /// Athena ID for this diagnosis
        /// </summary>
        [JsonProperty("diagnosisid")]
        public int Id { get; set; }

        /// <summary>
        /// The note entered for this diagnosis.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// List of relevant ICD codes for this diagnosis
        /// </summary>
        [JsonProperty("icdcodes")]
        public IcdCode[] IcdCodes { get; set; }

        /// <summary>
        /// SNOMED Code for this diagnosis
        /// </summary>
        [JsonProperty("snomedcode")]
        public string SnomedCode { get; set; }

        /// <summary>
        /// Brief description for this SNOMED Code
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
