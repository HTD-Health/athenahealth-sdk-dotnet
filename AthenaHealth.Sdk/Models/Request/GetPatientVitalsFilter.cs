using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Request.Interfaces;
using Newtonsoft.Json;
using System;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetPatientVitalsFilter : IPagingFilter
    {
        /// <summary>
        /// The department for this patient. A patient may have multiple charts, and the department determines which chart to retrieve.
        /// </summary>
        [JsonProperty("departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// Only retrieve vitals that were taking on or before this date
        /// </summary>
        [JsonProperty("enddate")]
        [JsonConverter(typeof(DateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Show configured vitals that have no readings for this patient.
        /// </summary>
        [JsonProperty("showemptyvitals")]
        public bool? ShowEmptyVitals { get; set; }

        /// <summary>
        /// Only retrieve vitals that were taking on or after this date
        /// </summary>
        [JsonProperty("startdate")]
        [JsonConverter(typeof(DateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Number of entries to return (default 1000, max 10000). Please note that this endpoint
        /// has a different default and max than normal.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        public int? Offset { get; set; }

        public GetPatientVitalsFilter(int departmentId)
        {
            DepartmentId = departmentId;
        }
    }
}
