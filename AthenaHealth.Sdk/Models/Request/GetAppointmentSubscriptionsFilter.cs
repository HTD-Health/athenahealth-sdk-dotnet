using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetAppointmentSubscriptionsFilter
    {
        /// <summary>
        /// If this is set, we will include the UpdateRemiderCall event as if it is one of the
        /// default events. Otherwise we will ignore that it exists.
        /// </summary>
        [JsonProperty("includeremindercall")]
        public bool? IncludeReminderCall { get; set; }

        /// <summary>
        /// If this is set, we will include the UpdateSuggestedOverbooking event as if it is one of
        /// the default events. Otherwise we will ignore that it exists.
        /// </summary>
        [JsonProperty("includesuggestedoverbooking")]
        public bool? IncludeSuggestedOverbooking { get; set; }
    }
}
