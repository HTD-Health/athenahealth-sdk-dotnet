using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;
using System;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class AppointmentRemindersResponse : IPagingResponse<AppointmentReminder>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("reminders")]
        public AppointmentReminder[] Items { get; set; }
    }

    public class AppointmentReminder
    {
        /// <summary>
        /// The athenaNet appointment reminder ID.
        /// </summary>
        [JsonProperty("appointmentreminderid")]
        public int Id { get; set; }

        /// <summary>
        /// The athenaNet department ID.
        /// </summary>
        [JsonProperty("departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// The approximate date on which an appointment for this reminder should be scheduled.
        /// </summary>
        [JsonProperty("approximatedate")]
        public DateTime ApproximateDate { get; set; }

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
        /// If set, the date on which this reminder was deleted.
        /// </summary>
        [JsonProperty("deleted")]
        public DateTime DeletedAt { get; set; }

        /// <summary>
        /// Status of the reminder.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The athenaNet patient ID.
        /// </summary>
        [JsonProperty("patientid")]
        public int? PatientId { get; set; }

        /// <summary>
        /// Free-text instructions for the patient entered by the practice for this reminder.
        /// </summary>
        [JsonProperty("patientinstructions")]
        public string PatientInstructions { get; set; }
    }
}
