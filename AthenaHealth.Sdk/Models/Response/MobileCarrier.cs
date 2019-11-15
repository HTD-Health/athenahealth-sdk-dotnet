using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class MobileCarrier
    {
        /// <summary>
        /// The athenaNet ID
        /// </summary>
        [JsonProperty("mobilecarrierid")]
        public int Id { get; set; }

        /// <summary>
        /// The name used in athenaNet
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
