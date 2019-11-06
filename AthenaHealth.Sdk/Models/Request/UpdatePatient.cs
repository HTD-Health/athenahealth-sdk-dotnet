using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Request
{
    public class UpdatePatient : CreateOrUpdatePatient
    {
        /// <summary>
        /// Use this in practices that register copies of patients in different departments in order
        /// to make sure you are updating the correct version of the patient.
        /// </summary>
        [JsonProperty("lookupdepartmentid")]
        public int? LookupDepartmentId { get; set; }

        /// <summary>
        /// If you use LOOKUPDEPARTMENTID to get the local copy of a patient to update, and if the
        /// patient is not currently registered in that department, setting this flag will register a
        /// new copy of this patient in that department.
        /// </summary>
        [JsonProperty("registerpatientindepartment")]
        public bool? RegisterPatientInDepartment { get; set; }
    }
}
