using Newtonsoft.Json;
using System;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public abstract class AppointmentBase
    {
        /// <summary>
        /// Appointment ID of the booked appointment
        /// </summary>
        [JsonProperty("appointmentid")]
        public int Id { get; set; }

        /// <summary>
        /// A list of reason IDs that could be used for this slot.  Only present if multiple reason IDs are requested.
        /// </summary>
        [JsonProperty("reasonid")]
        public int[] ReasonId { get; set; }

        /// <summary>
        /// In minutes
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// If true, this appointment slot is frozen
        /// </summary>
        [JsonProperty("frozen")]
        public bool Frozen { get; set; }

        /// <summary>
        /// The practice-friendly (not patient friendly) name for this appointment type.  Note that this may not be the same as the booked appointment because of "generic" slots.
        /// </summary>
        [JsonProperty("appointmenttype")]
        public string AppointmentType { get; set; }

        /// <summary>
        /// This is the ID for the appointment type.   Note that this may not be the same as the booked appointment because of "generic" slots.
        /// </summary>
        [JsonProperty("appointmenttypeid")]
        public int? AppointmentTypeId { get; set; }

        /// <summary>
        /// The appointment date.
        /// </summary>
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The patient-friendly name for this appointment type.  Note that this may not be the same as the booked appointment because of "generic" slots.
        /// </summary>
        [JsonProperty("patientappointmenttypename")]
        public string PatientAppointmentTypeName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("providerid")]
        public int? ProviderId { get; set; }

        /// <summary>
        /// As HH:MM (where HH is the 0-23 hour and MM is the minute).  This time is local to the department.
        /// </summary>
        [JsonProperty("starttime")]
        public ClockTime? StartTime { get; set; }

        /// <summary>
        /// The rendering provider ID.
        /// </summary>
        [JsonProperty("renderingproviderid")]
        public int? RenderingProviderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("departmentid")]
        public int? DepartmentId { get; set; }
    }
}
