using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public class AddToWaitListResponse
    {
        /// <summary>
        /// The ID of the wait list entry that was created.
        /// </summary>
        [JsonProperty("waitlistid")]
        public int WaitListId { get; set; }
    }
}