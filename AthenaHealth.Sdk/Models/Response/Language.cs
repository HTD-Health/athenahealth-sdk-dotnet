using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class Language
    {
        /// <summary>
        /// The language name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The ISO 6392 code
        /// </summary>
        [JsonProperty("iso6392code")]
        public string Iso6392Code { get; set; }
    }
}
