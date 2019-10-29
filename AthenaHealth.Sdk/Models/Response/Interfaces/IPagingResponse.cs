using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Response.Interfaces
{
    public interface IPagingResponse<T>
    {
        [JsonProperty("totalcount")]
        int Total { get; set; }

        [JsonProperty("next")]
        string Next { get; set; }

        [JsonProperty("previous")]
        string Previous { get; set; }

        T[] Items { get; set; }
    }
}
