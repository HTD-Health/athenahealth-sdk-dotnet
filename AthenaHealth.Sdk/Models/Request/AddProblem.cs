using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using Newtonsoft.Json;
using System;

namespace AthenaHealth.Sdk.Models.Request
{
    public class AddProblem
    {
        /// <summary>
        /// The athenaNet department id.
        /// </summary>
        [JsonProperty("departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// Update the laterality of this problem. Can be null, LEFT, RIGHT, or BILATERAL.
        /// </summary>
        [JsonProperty("laterality")]
        [JsonConverter(typeof(EnumConverter))]
        public LateralityEnum? Laterality { get; set; }

        /// <summary>
        /// The note to be attached to this problem.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// The SNOMED code of the problem you are adding.
        /// </summary>
        [JsonProperty("snomedcode")]
        public string SnomedCode { get; set; }

        /// <summary>
        /// The onset date to be updated for this problem in MM/DD/YYYY format.
        /// </summary>
        [JsonProperty("startdate")]
        [JsonConverter(typeof(DateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Whether the problem is chronic or acute.
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(EnumConverter))]
        public ProblemStatusEnum? Status { get; set; }

        public AddProblem(int departmentId, string snomedCode)
        {
            DepartmentId = departmentId;
            SnomedCode = snomedCode;
        }
    }
}
