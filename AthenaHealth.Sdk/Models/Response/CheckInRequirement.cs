using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class CheckInRequirement
    {
        /// <summary>
        /// Detailed information about the requirements for each section and their status.
        /// </summary>
        [JsonProperty("fields")]
        [JsonConverter(typeof(SingleElementToArrayConverter), typeof(CheckInField))]
        public CheckInField[] Fields { get; set; }

        /// <summary>
        /// Name of the group of requirements.
        /// Can be Demographics, Insurance, Privacy Forms, Check In, and Health History Forms.
        /// The Check In section just gives you the current status.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Whether this section is required to be completed before check in will be allowed.
        /// </summary>
        [JsonProperty("required")]
        public bool IsRequired { get; set; }

        /// <summary>
        /// Whether the requirements for this section have been successfully completed.
        /// </summary>
        [JsonProperty("complete")]
        public bool IsCompleted { get; set; }
    }

    public class CheckInField
    {
        /// <summary>
        /// If the demographic field failed validate, this contains the error why (empty or failed validation).
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }

        /// <summary>
        /// Name of the required or validated demographic field
        /// </summary>
        [JsonProperty("field")]
        public string Field { get; set; }

        /// <summary>
        /// Name of the health history or privacy form.
        /// </summary>
        [JsonProperty("formname")]
        public string FormName { get; set; }

        /// <summary>
        /// Name of the required or validated demographic field.
        /// </summary>
        [JsonProperty("valid")]
        public bool IsValid { get; set; }

        /// <summary>
        /// Check in status (Before or During Check In), the Privacy Form status (Complete or Incomplete), or the percent complete of the health history form.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}