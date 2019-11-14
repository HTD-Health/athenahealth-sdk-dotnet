using Newtonsoft.Json;

// ReSharper disable once StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class StatusResponse : BaseResponse
    {
        /// <summary>
        /// If <see cref="BaseResponse.IsSuccess"/> is false will contain error message.
        /// </summary>
        [JsonProperty("errormessage")]
        public string ErrorMessage { get; set; }
    }
}
