using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetPatientProblemsFilter
    {
        /// <summary>
        /// The athenaNet department id.
        /// </summary>
        [JsonProperty("departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// If true, will include every encounter and associated diagnosis with each problem. Also
        /// fills the bestmatchicd10code field with the best conversion from the problem SNOMED code
        /// to ICD10 code if there is no user-selected ICD10 code in an encounter diagnosis event.
        /// Please note that the bestmatchicd10code may not always be accurate.
        /// </summary>
        [JsonProperty("showdiagnosisinfo")]
        public bool? ShowDiagnosisInfo { get; set; }

        /// <summary>
        /// Also show inactive (but not soft deleted) problems.
        /// </summary>
        [JsonProperty("showinactive")]
        public bool? ShowInactive { get; set; }

        public GetPatientProblemsFilter(int departmentId)
        {
            DepartmentId = departmentId;
        }
    }
}
