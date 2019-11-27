using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AthenaHealth.Sdk.Models.Response
{
    public class ReferralSourceResponse : IPagingResponse<ReferralSource>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("referralsources")]
        public ReferralSource[] Items { get; set; }
    }

    public class ReferralSource
    {
        /// <summary>
        /// The name of this referral source.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The ordering in which this source is displayed.
        /// </summary>
        [JsonProperty("ordering")]
        public string Ordering { get; set; }

        /// <summary>
        /// The referral source ID.
        /// </summary>
        [JsonProperty("referralsourceid")]
        public int? Id { get; set; }
    }
}
