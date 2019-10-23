using Newtonsoft.Json;

// ReSharper disable once StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public class DeleteResponse
    {
        [JsonProperty("success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// If <see cref="IsSuccess"/> is false will contain error message.
        /// </summary>
        [JsonProperty("errormessage")]
        public string ErrorMessage { get; set; }
    }
}
