namespace AthenaHealth.Sdk.Models.Request
{
    public class GetDepartmentFilter : BaseLimitFilter
    {
        /// <summary>
        /// If set to true, return hospital only departments.
        /// </summary>
        public bool HospitalOnly { get; set; } = false;

        /// <summary>
        /// If set to true, list providers who see patients in this department.
        /// Default is false.
        /// </summary>
        public bool ProviderList { get; set; } = false;

        /// <summary>
        /// By default, departments hidden in the portal do not appear.
        /// When this is set to true, that restriction is not applied.
        /// Default is false.
        /// </summary>
        public bool ShowAllDepartments { get; set; } = false;
    }
}