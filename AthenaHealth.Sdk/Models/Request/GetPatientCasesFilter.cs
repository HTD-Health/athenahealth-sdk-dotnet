using AthenaHealth.Sdk.Models.Request.Interfaces;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Request
{
    public class GetPatientCasesFilter : IPagingFilter
    {
        /// <summary>
        /// The athenaNet department id.
        /// </summary>
        [Required]
        [JsonProperty("departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// Number of entries to return (default 1000, max 10000). Please note that this endpoint
        /// has a different default and max than normal.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        public int? Offset { get; set; }

        public GetPatientCasesFilter(int departmentId)
        {
            DepartmentId = departmentId;
        }
    }
}
