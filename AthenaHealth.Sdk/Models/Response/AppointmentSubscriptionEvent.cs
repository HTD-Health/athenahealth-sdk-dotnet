using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class AppointmentSubscriptionEvent
    {
        /// <summary>
        /// List of events you are subscribed to.
        /// </summary>
        [JsonProperty("subscriptions")]
        public Subscription[] Subscriptions { get; set; }

        /// <summary>
        /// Will return one of following statuses: ACTIVE, INACTIVE, or PARTIAL. The PARTIAL status
        /// means that not all events are subscribed to. In the event of a problem, UNKNOWN may be returned.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        public class Subscription
        {
            /// <summary>
            /// Name of event
            /// </summary>
            [JsonProperty("eventname")]
            public string EventName { get; set; }
        }
    }
}
