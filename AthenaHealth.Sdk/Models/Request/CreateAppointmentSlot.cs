using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo
namespace AthenaHealth.Sdk.Models.Request
{
    public class CreateAppointmentSlot
    {
        /// <summary>
        /// The appointment date for the new open appointment slot (mm/dd/yyyy).
        /// </summary>
        [JsonProperty("appointmentdate")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        [Required]
        public DateTime AppointmentDate { get; set; }

        /// <summary>
        /// The time (hh24:mi) for the new appointment slot.  Multiple times (either as a comma delimited list or multiple POSTed values) are allowed.  24 hour time.
        /// </summary>
        [JsonProperty("appointmenttime")]
        [JsonConverter(typeof(DelimitedStringConverter), ",")]
        [Required]
        public ClockTime[] AppointmentTime { get; set; }

        /// <summary>
        /// The appointment type ID to be created.  Either this or a reason must be provided.
        /// </summary>
        [JsonProperty("appointmenttypeid")]
        public int? AppointmentTypeId { get; set; }

        /// <summary>
        /// The athenaNet department ID.
        /// </summary>
        [JsonProperty("departmentid")]
        [Required]
        public int DepartmentId { get; set; }

        /// <summary>
        /// The athenaNet provider ID.
        /// </summary>
        [JsonProperty("providerid")]
        [Required]
        public int ProviderId { get; set; }

        /// <summary>
        /// The appointment reason (/patientappointmentreasons) to be created. Either this or a raw appointment type ID must be provided.
        /// </summary>
        [JsonProperty("reasonid")]
        public int? ReasonId { get; set; }

        public CreateAppointmentSlot(int departmentId, int providerId, DateTime appointmentDate, ClockTime[] appointmentTime)
        {
            DepartmentId = departmentId;
            ProviderId = providerId;
            AppointmentDate = appointmentDate;
            AppointmentTime = appointmentTime;
        }
    }
}
