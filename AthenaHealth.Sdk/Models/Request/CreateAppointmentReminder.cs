using System;
using System.ComponentModel.DataAnnotations;
using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Request
{
    public class CreateAppointmentReminder
    {
        public CreateAppointmentReminder(DateTime approximateDate, int appointmentTypeId, int patientId, int departmentId)
        {
            AppointmentTypeId = appointmentTypeId;
            PatientId = patientId;
            DepartmentId = departmentId;
            ApproximateDate = approximateDate;
        }

        /// <summary>
        /// The athenaNet department ID.
        /// </summary>
        [JsonProperty("departmentid")]
        [Required]
        public int DepartmentId { get; set; }

        /// <summary>
        /// The approximate date on which an appointment for this reminder should be scheduled.
        /// </summary>
        [JsonProperty("approximatedate")]
        [Required]
        [JsonConverter(typeof(CustomDateConverter))]
        public DateTime ApproximateDate { get; set; }

        /// <summary>
        /// The athenaNet patient ID.
        /// </summary>
        [JsonProperty("patientid")]
        [Required]
        public int PatientId { get; set; }

        /// <summary>
        /// The athenaNet provider ID.
        /// </summary>
        [JsonProperty("providerid")]
        public int? ProviderId { get; set; }

        /// <summary>
        /// The athenaNet appointment type ID.
        /// </summary>
        [JsonProperty("appointmenttypeid")]
        public int? AppointmentTypeId { get; set; }

        /// <summary>
        /// Free-text notes entered by the practice about this reminder.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// Status of the reminder.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Free-text instructions for the patient entered by the practice for this reminder.
        /// </summary>
        [JsonProperty("patientinstructions")]
        public string PatientInstructions { get; set; }
    }
}
