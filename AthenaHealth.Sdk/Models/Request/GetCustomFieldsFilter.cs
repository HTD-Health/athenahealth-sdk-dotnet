using AthenaHealth.Sdk.Models.Request.Interfaces;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Request
{
    public class GetCustomFieldsFilter : IPagingFilter
    {
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
