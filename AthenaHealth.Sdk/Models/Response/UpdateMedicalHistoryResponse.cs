using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AthenaHealth.Sdk.Models.Response
{
    public class UpdateMedicalHistoryResponse
    {
        /// <summary>
        /// Whether the operation was successful or not.
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public bool? Success { get; set; }

        /// <summary>
        /// If the operation failed, this will contain any error messages.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }
    }
}
