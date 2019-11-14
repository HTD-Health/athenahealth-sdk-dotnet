using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class UpdateMedicalHistoryResponse
    {
        /// <summary>
        /// Whether the operation was successful or not.
        /// </summary>
        [JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// If the operation failed, this will contain any error messages.
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }
    }
}
