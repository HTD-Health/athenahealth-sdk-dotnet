using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    internal class HasAccessResponse
    {
        [JsonProperty("pong")]
        public bool IsTrue { get; set; }
    }
}
