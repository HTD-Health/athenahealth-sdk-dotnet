using AthenaHealth.Sdk.Models.Request.Interfaces;
using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetMedicalHistoryQuestionsFilter : IPagingFilter
    {
        /// <summary>
        /// The appointment slot to schedule into.
        /// </summary>
        [JsonProperty(PropertyName = "showdeleted")]
        public bool? ShowDeleted { get; set; }

        /// <summary>
        /// Number of entries to return (default 1000, max 10000). Please note that this endpoint
        /// has a different default and max than normal.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        public int? Offset { get; set; }
    }
}
