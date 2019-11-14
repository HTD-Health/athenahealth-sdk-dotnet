using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Request
{
    public class AddToWaitListRequest
    {
        /// <summary>
        /// The patient ID of the patient who is on the wait list.
        /// </summary>
        [JsonProperty("patientid")]
        [Required]
        public int PatientId { get; set; }

        /// <summary>
        /// The department ID of the desired department.
        /// This can be blank if any department is acceptable.
        /// </summary>
        [JsonProperty("departmentid")]
        [Required]
        public int DepartmentId { get; set; }

        /// <summary>
        /// While a department is required when creating a wait list entry, this flag indicates that any department is acceptable for an appointment.
        /// </summary>
        [JsonProperty("allowanydepartment")]
        public bool AllowAnyDepartment { get; set; }

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
        [JsonConverter(typeof(CustomEnumConverter))]
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

        public AddToWaitListRequest(int patientId, int departmentId)
        {
            PatientId = patientId;
            DepartmentId = departmentId;
        }

        /// <summary>
        /// <see cref="DepartmentId"/> not required. Automatically sets <see cref="AllowAnyDepartment"/> to true.
        /// </summary>
        /// <param name="patientId"></param>
        public AddToWaitListRequest(int patientId)
        {
            PatientId = patientId;
            AllowAnyDepartment = true;
        }
    }
}
