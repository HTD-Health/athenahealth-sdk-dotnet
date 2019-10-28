using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Request.Interfaces
{
    public interface IPagingFilter
    {
        [JsonProperty("limit")]
        int? Limit { get; set; }

        [JsonProperty("offset")]
        int? Offset { get; set; }
    }
}
