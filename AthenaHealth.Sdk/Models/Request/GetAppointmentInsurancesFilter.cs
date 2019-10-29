using AthenaHealth.Sdk.Models.Request.Interfaces;
using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetAppointmentInsurancesFilter : IPagingFilter
    {
        public GetAppointmentInsurancesFilter(int appointmentId)
        {
            AppointmentId = appointmentId;
        }

        /// <summary>
        /// Appointment id
        /// </summary>
        [JsonProperty("appointmentid")]
        public int AppointmentId { get; set; }
        /// <summary>
        /// If set, will show full SSN instead of a masked number.
        /// </summary>
        [JsonProperty("showfullssn")]
        public bool? ShowFullSsn { get; set; }

        /// <summary>
        /// If set, include cancelled and expired insurances.
        /// </summary>
        [JsonProperty("showcancelled")]
        public bool? ShowCancelled { get; set; }

        /// <summary>
        /// Number of entries to return (default 100, max 5000)Please note that this endpoint has a different default than normal.
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; } = 100;

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        [JsonProperty("offset")]
        public int? Offset { get; set; }
    }
}
