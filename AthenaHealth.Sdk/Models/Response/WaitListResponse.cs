using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class WaitListResponse : IPagingResponse<WaitListItem>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("waitlistentries")]
        public WaitListItem[] Items { get; set; }
    }

    public class WaitListItem
    {
        /// <summary>
        /// The wait list ID, used in other calls.
        /// </summary>
        [JsonProperty("waitlistid")]
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// The patient ID of the patient who is on the wait list.
        /// </summary>
        [JsonProperty("patientid")]
        [Required]
        public int PatientId { get; set; }

        /// <summary>
        /// The date and time that this wait list entry was created.
        /// </summary>
        [JsonProperty("created")]
        [Required]
        public string Created { get; set; }

        /// <summary>
        /// The department ID of the desired department.  This can be blank if any department is acceptable.
        /// </summary>
        [JsonProperty("departmentid")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// The hour (24 hour clock) after which an appointment is desired by a patient.  Inclusive.
        /// </summary>
        [JsonProperty("hourfrom")]
        public int? HourFrom { get; set; }

        /// <summary>
        /// The hour (24 hour clock) before which an appointment is desired by a patient.  Inclusive.
        /// </summary>
        [JsonProperty("hourto")]
        public int? HourTo { get; set; }

        /// <summary>
        /// The booked appointment ID of the appointment that this wait list entry would replace.
        /// </summary>
        [JsonProperty("appointmentid")]
        public int? AppointmentId { get; set; }

        /// <summary>
        /// The appointment type ID of the desired appointment.
        /// </summary>
        [JsonProperty("appointmenttypeid")]
        public int? AppointmentTypeId { get; set; }

        /// <summary>
        /// Indicating the priority of this wait list entry.
        /// </summary>
        [JsonProperty("priority")]
        [JsonConverter(typeof(EnumConverter))]
        public PriorityEnum? Priority { get; set; }

        /// <summary>
        /// A list of day of week IDs that are desired by the patient, with 1 being Sunday, and 7 being Saturday.
        /// </summary>
        [JsonProperty("dayofweekids")]
        public int[] DayOfWeekIds { get; set; }

        /// <summary>
        /// Practice-facing note about why the wait list entry exists.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// The provider ID of the desired provider.  This can be blank if any provider is acceptable.
        /// </summary>
        [JsonProperty("providerid")]
        public int? ProviderId { get; set; }
    }
}
