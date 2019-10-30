using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public class MedicationAddedResponse : StatusResponse
    {
        /// <summary>
        /// If successful, the athena ID of the newly created historical medication.
        /// </summary>
        [JsonProperty(PropertyName = "medicationentryid")]
        public string MedicationEntryId { get; set; }
    }
}