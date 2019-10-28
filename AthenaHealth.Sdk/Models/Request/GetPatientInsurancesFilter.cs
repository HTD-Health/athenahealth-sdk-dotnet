using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetPatientInsurancesFilter
    {
        /// <summary>
        /// If set, we will use the department id in an attempt to find the local patient.
        /// </summary>
        [JsonProperty(PropertyName = "departmentid")]
        public int? DepartmentId { get; set; }


        /// <summary>
        /// If set, include cancelled and expired insurances.
        /// </summary>
        [JsonProperty(PropertyName = "showcancelled")]
        public bool? ShowCancelled { get; set; }

        /// <summary>
        /// If set, will show full SSN instead of a masked number.
        /// </summary>
        [JsonProperty(PropertyName = "showfullssn")]
        public bool? ShowFullSSN { get; set; }

        /// <summary>
        /// Number of entries to return (default 100, max 5000)Please note that this endpoint has a
        /// different default than normal.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        [JsonProperty(PropertyName = "offset")]
        public int? Offset { get; set; }
    }
}
