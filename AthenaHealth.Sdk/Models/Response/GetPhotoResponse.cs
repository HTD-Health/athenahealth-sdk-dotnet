using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class GetPhotoResponse
    {
        [JsonProperty("image")]
        public string Image { get; set; }
    }
}
