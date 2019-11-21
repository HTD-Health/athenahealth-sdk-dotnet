using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class AppointmentReasonResponse : IPagingResponse<AppointmentReason>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("patientappointmentreasons")]
        public AppointmentReason[] Items { get; set; }
    }

    public class AppointmentReason
    {
        /// <summary>
        /// The ID for this reason.  Used to request open appointment slots.
        /// </summary>
        [JsonProperty("reasonid")]
        public int Id { get; set; }

        /// <summary>
        /// The patient-friendly name to accompany the reason.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The maximum number of days before an appointment that a patient can schedule for a specific practice.
        /// </summary>
        [JsonProperty("schedulingmaxdays")]
        public int? SchedulingMaxDays { get; set; }

        /// <summary>
        /// The patient-friendly reason used to select an appointment type. This is meant to assist the patient in narrowing down what type of appointment should be selected and, in athenaNet, maps to the appropriate appointment type for a particular department/provider combination.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Appointment reasons can be for new patients, existing patients, or all. Values are "new", "existing", or "all".
        /// </summary>
        [JsonProperty("reasontype")]
        [JsonConverter(typeof(EnumConverter))]
        public AppointmentReasonTypeEnum ReasonType { get; set; }

        /// <summary>
        /// The minimum number of hours before an appointment that a patient can schedule or cancel for a specific practice.
        /// </summary>
        [JsonProperty("schedulingminhours")]
        public int? SchedulingMinHours { get; set; }
    }
}
