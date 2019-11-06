using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class AddProblemResponse
    {
        /// <summary>
        /// If successful, the athena ID of the newly created problem
        /// </summary>
        [JsonProperty("problemid")]
        public int? ProblemId { get; set; }

        /// <summary>
        /// Whether the operation was successful or not.
        /// </summary>
        [JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// If the operation failed, this will contain any error messages.
        /// </summary>
        [JsonProperty("errormessage")]
        public string ErrorMessage { get; set; }
    }
}
