using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo
// ReSharper disable once CommentTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public class OrderType
    {
        /// <summary>
        /// The athena ID of the type of order.
        /// </summary>
        [JsonProperty("ordertypeid")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the order.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}