using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    internal class GetCheckInRequiredFieldsResponse
    {
        [JsonProperty("fieldlist")]
        public string[] Fields { get; set; }
    }
}
