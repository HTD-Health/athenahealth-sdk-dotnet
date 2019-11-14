using AthenaHealth.Sdk.Models.Request.Interfaces;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetCommonInsurancePackageFilter : IPagingFilter
    {
        /// <summary>
        /// Only look at patients who are associated with this department's provider group in determining which insurance packages to list.
        /// Note that insurance packages do not "belong" to a department and thus department ID is not returned in the output.
        /// The same insurance packages will (and often do) appear across multiple departments.
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// If true only show the case policies.
        /// </summary>
        public bool ShowOnlyCasePolicies { get; set; } = false;

        /// <summary>
        /// Number of entries to return (default 1500, max 5000)
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        public int? Offset { get; set; }

        public GetCommonInsurancePackageFilter(int departmentId, bool showOnlyCasePolicies = false)
        {
            DepartmentId = departmentId;
            ShowOnlyCasePolicies = showOnlyCasePolicies;
        }
    }
}
