using AthenaHealth.Sdk.Models.Request.Interfaces;
using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Request
{
    public class GetOrderSetsFilter : IPagingFilter
    {
        /// <summary>
        /// Username to find all available order sets for. Will return all order sets configured for
        /// this user as well as order sets configured for all users.
        /// </summary>
        [JsonProperty("username")]
        public string UserName { get; set; }

        /// <summary>
        /// Number of entries to return (default 1500, max 5000)
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        [JsonProperty("offset")]
        public int? Offset { get; set; }
    }
}
