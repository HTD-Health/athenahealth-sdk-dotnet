using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetPatientProblemsFilter
    {
        [JsonProperty("departmentid")]
        public int DepartmentId { get; set; }

        [JsonProperty("showdiagnosisinfo")]
        public bool ShowDiagnosisInfo { get; set; } = false;

        [JsonProperty("showinactive")]
        public bool ShowInactive { get; set; } = false;
    }
}