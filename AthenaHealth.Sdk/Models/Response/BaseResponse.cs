using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class BaseResponse
    {
        [JsonProperty("success")]
        public bool IsSuccess { get; set; }
    }
}
