using AthenaHealth.Sdk.Models.Request.Interfaces;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetDepartmentsFilter : GetDepartmentFilter, IPagingFilter
    {
        /// <summary>
        /// If set to true, return hospital only departments.
        /// </summary>
        public bool HospitalOnly { get; set; }

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
