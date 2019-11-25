using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using System;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Request
{
    public class GetChangedAppointmentSlotsFilter
    {
        /// <summary>
        /// Department ID. Multiple departments are allowed, either comma separated or with multiple values.
        /// </summary>
        [JsonProperty("departmentid")]
        [JsonConverter(typeof(DelimitedStringConverter), ",")]
        public int[] DepartmentIds { get; set; }

        /// <summary>
        /// When showing patient detail for appointments, the patient information for patients with record restrictions and blocked patients will not be shown.  Setting this flag to true will show that information for those patients.
        /// </summary>
        [JsonProperty("ignorerestrictions")]
        public bool? IgnoreRestrictions { get; set; }

        /// <summary>
        /// For testing purposes, do not mark records as processed.
        /// </summary>
        [JsonProperty("leaveunprocessed")]
        public bool? LeaveUnprocessed { get; set; }

        /// <summary>
        /// Patient ID. Multiple Patient IDs are allowed, either comma separated or with multiple values.
        /// </summary>
        [JsonProperty("patientid")]
        [JsonConverter(typeof(DelimitedStringConverter), ",")]
        public int[] PatientId { get; set; }

        /// <summary>
        /// Provider ID.  Multiple providers are allowed using comma separated values.
        /// </summary>
        [JsonProperty("providerid")]
        [JsonConverter(typeof(DelimitedStringConverter), ",")]
        public int[] ProviderId { get; set; }

        /// <summary>
        /// Include claim information, if available, associated with an appointment.
        /// </summary>
        [JsonProperty("showclaimdetail")]
        public bool? ShowClaimDetail { get; set; }

        /// <summary>
        /// Return copay information with the appointment data.
        /// </summary>
        [JsonProperty("showcopay")]
        public bool? ShowCopay { get; set; }

        /// <summary>
        /// Include patient insurance information. Shows insurance packages for the appointment if any are selected, and all patient packages otherwise.
        /// </summary>
        [JsonProperty("showinsurance")]
        public bool? ShowInsurance { get; set; }

        /// <summary>
        /// Include patient information for each patient associated with an appointment.
        /// </summary>
        [JsonProperty("showpatientdetail")]
        public bool? ShowPatientDetail { get; set; }

        /// <summary>
        /// See <see cref="ShowProcessedStartDateTime"/>.
        /// </summary>
        [JsonProperty("showprocessedenddatetime")]
        [JsonConverter(typeof(DateConverter))]
        public DateTime? ShowProcessedEndDateTime { get; set; }

        /// <summary>
        /// Show already processed changes.  This will show changes that you previously retrieved at some point after this datetime mm/dd/yyyy hh24:mi:ss (Eastern). Can be used to refetch data if there was an error, such as a timeout, and records are marked as already retrieved. This is intended to be used with showprocessedenddatetime and for a short period of time only. Also note that all messages will eventually be deleted.
        /// </summary>
        [JsonProperty("showprocessedstartdatetime")]
        [JsonConverter(typeof(DateConverter))]
        public DateTime? ShowProcessedStartDateTime { get; set; }

        /// <summary>
        /// Include all reminder call related results, if available, associated with an appointment.
        /// </summary>
        [JsonProperty("showremindercalldetail")]
        public bool? ShowReminderCallDetail { get; set; }
    }
}
