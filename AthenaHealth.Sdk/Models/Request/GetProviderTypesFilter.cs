using AthenaHealth.Sdk.Models.Request.Interfaces;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetProviderTypesFilter : IPagingFilter
    {
        /// <summary>
        /// Number of entries to return (default 1500, max 5000)
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        public int? Offset { get; set; }
    }
}
