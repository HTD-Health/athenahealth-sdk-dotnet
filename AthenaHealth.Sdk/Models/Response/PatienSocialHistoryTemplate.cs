using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
// ReSharper disable once CommentTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class PatienSocialHistoryTemplate
    {
        /// <summary>
        /// ID for this social history template
        /// </summary>
        [JsonProperty("templateid")]
        public int Id { get; set; }

        /// <summary>
        /// Name for this social history template
        /// </summary>
        [JsonProperty("templatename")]
        public string Name { get; set; }
    }
}
