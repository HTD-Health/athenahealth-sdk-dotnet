using AthenaHealth.Sdk.Models.Request.Interfaces;

// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Request
{
    public class GetCommunicatorBrandsFilter : IPagingFilter
    {
        /// <summary>
        /// Number of entries to return (default 1500, max 5000)
        /// </summary>
        public int? Limit { get; set; } = 1000;

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        public int? Offset { get; set; }
    }
}
