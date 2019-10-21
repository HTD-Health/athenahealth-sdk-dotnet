namespace AthenaHealth.Sdk.Models.Request
{
    public class GetTopInsurancePackageFilter : BaseLimitFilter
    {
        /// <summary>
        /// Only look at patients who are associated with this department's provider group in determining which insurance packages to list.
        /// Note that insurance packages do not "belong" to a department and thus department ID is not returned in the output.
        /// The same insurance packages will (and often do) appear across multiple departments.
        /// </summary>
        public int? DepartmentId { get; set; }
    }
}