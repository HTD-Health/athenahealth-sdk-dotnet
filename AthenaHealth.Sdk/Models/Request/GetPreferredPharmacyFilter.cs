using AthenaHealth.Sdk.Models.Request.Interfaces;
using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Request
{
    public class GetPreferredPharmacyFilter : IPagingFilter
    {
        /// <summary>
        /// The athenaNet department id.
        /// </summary>
        [JsonProperty("departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// Number of entries to return (default 100, max 1000). Please note that this endpoint has
        /// a different default and max than normal.
        /// </summary>
        public int? Limit { get; set; } = 100;

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        public int? Offset { get; set; }

        public GetPreferredPharmacyFilter(int departmentId)
        {
            DepartmentId = departmentId;
        }
    }
}
