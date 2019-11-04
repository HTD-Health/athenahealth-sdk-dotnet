using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class AddProblemResponse
    {
        /// <summary>
        /// If successful, the athena ID of the newly created problem
        /// </summary>
        [JsonProperty(PropertyName = "problemid")]
        public int? ProblemId { get; set; }

        /// <summary>
        /// Whether the operation was successful or not.
        /// </summary>
        [JsonProperty(PropertyName = "success")]
        public bool? Success { get; set; }

        /// <summary>
        /// If the operation failed, this will contain any error messages.
        /// </summary>
        [JsonProperty(PropertyName = "errormessage")]
        public string ErrorMessage { get; set; }
    }
}
