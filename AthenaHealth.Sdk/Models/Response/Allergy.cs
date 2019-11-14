using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
// ReSharper disable once CommentTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class Allergy
    {
        /// <summary>
        /// The athena ID of the allergen.
        /// </summary>
        [JsonProperty("allergenid")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the allergen.
        /// </summary>
        [JsonProperty("allergenname")]
        public string Name { get; set; }
    }
}
