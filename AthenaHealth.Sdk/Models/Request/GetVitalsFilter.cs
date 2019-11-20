using AthenaHealth.Sdk.Models.Request.Interfaces;
using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetVitalsFilter : GetDepartmentFilter, IPagingFilter
    {
        /// <summary>
        /// Show all global vitals, even if they are not configured at this practice.
        /// </summary>
        [JsonProperty("showunconfigured")]
        public bool? ShowUnconfigured { get; set; }

        /// <summary>
        /// Show only the vitals configured for this specialty
        /// </summary>
        [JsonProperty("specialtyid")]
        public string SpecialtyId { get; set; }

        /// <summary>
        /// Number of entries to return (default 1000, max 1000). Please note that this endpoint has
        /// a different default and max than normal.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        public int? Offset { get; set; }
    }
}
