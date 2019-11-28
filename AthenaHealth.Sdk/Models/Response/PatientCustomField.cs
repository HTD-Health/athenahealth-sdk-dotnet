using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class PatientCustomField
    {
        /// <summary>
        /// Corresponds to the /customfields customfieldid.
        /// </summary>
        [JsonProperty("customfieldid")]
        public int? Id { get; set; }

        /// <summary>
        /// For a non-select custom field, the value.
        /// </summary>
        [JsonProperty("customfieldvalue")]
        public string CustomFieldValue { get; set; }

        /// <summary>
        /// For a select custom field, the selectid value (from /customfield's selectlist).
        /// </summary>
        [JsonProperty("optionid")]
        public int? OptionId { get; set; }
    }
}
