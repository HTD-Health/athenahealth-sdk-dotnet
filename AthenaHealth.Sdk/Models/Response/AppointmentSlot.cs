using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public class AppointmentSlotResponse
    {
        [JsonProperty("totalcount")]
        public int Total { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("appointments")]
        public AppointmentSlot[] Items { get; set; }
    }

    public class AppointmentSlot : AppointmentBase
    {
        /// <summary>
        /// A list of Appointment Type IDs that are valid to be booked in this slot. This will only be included if "New Schedule Admin" is enabled for the practice.
        /// </summary>
        [JsonProperty(PropertyName = "validappointmenttypeids")]
        public int[] ValidAppointmentTypeIds { get; set; }

        /// <summary>
        /// The local athenaNet ID for the provider of the appointment.
        /// </summary>
        [JsonProperty(PropertyName = "localproviderid")]
        public int? LocalProviderId { get; set; }
    }
}