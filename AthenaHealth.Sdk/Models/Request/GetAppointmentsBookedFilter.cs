using System;
using System.ComponentModel.DataAnnotations;
using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Request.Interfaces;
using Newtonsoft.Json;
// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetAppointmentsBookedFilter :  GetAppointmentFilter, IPagingFilter
    {
        public GetAppointmentsBookedFilter(int[] departmentIds, DateTime startDate, DateTime endDate)
        {
            DepartmentIds = departmentIds;
            StartDate = startDate;
            EndDate = endDate;
        }

        /// <summary>
        /// Filter appointments by status.
        /// </summary>
        [JsonProperty(PropertyName = "appointmentstatus")]
        public AppointmentStatusEnum? AppointmentStatus { get; set; }

        /// <summary>
        /// Filter by appointment type ID.
        /// </summary>
        [JsonProperty(PropertyName = "appointmenttypeid")]
        public int? AppointmentTypeId { get; set; }

        /// <summary>
        /// The athenaNet department ID. Multiple IDs (either as a comma delimited list or multiple POSTed values) are allowed.
        /// </summary>
        [Required]
        [JsonProperty(PropertyName = "departmentid")]
        [JsonConverter(typeof(CustomArrayToStringConverter), ",")]
        public int[] DepartmentIds { get; set; }

        /// <summary>
        /// Start of the appointment search date range (mm/dd/yyyy).  Inclusive.
        /// </summary>
        [Required]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        [JsonProperty(PropertyName = "startdate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// End of the appointment search date range (mm/dd/yyyy).  Inclusive.
        /// </summary>
        [Required]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        [JsonProperty(PropertyName = "enddate")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Identify appointments modified after this date/time (mm/dd/yyyy hh:mi:ss).  Inclusive.
        /// </summary>
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy HH:mm:ss")]
        [JsonProperty(PropertyName = "startlastmodified")]
        public DateTime? StartLastModified { get; set; }

        /// <summary>
        /// Identify appointments modified prior to this date/time (mm/dd/yyyy hh:mi:ss).  Inclusive. Note: This can only be used if a startlastmodified value is supplied as well.
        /// </summary>
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy HH:mm:ss")]
        [JsonProperty(PropertyName = "endlastmodified")]
        public DateTime? EndLastModified { get; set; }

        /// <summary>
        /// The athenaNet patient ID.  If operating in a Provider Group Enterprise practice, this should be the enterprise patient ID.
        /// </summary>
        [JsonProperty(PropertyName = "patientid")]
        public int? PatientId { get; set; }

        /// <summary>
        /// The athenaNet provider ID.  Multiple IDs (either as a comma delimited list or multiple POSTed values) are allowed.
        /// </summary>
        [JsonProperty(PropertyName = "providerid")]
        [JsonConverter(typeof(CustomArrayToStringConverter), ",")]
        public int[] ProviderId { get; set; }

        /// <summary>
        /// Start of the appointment scheduled search date range (mm/dd/yyyy).  Inclusive.
        /// </summary>
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        [JsonProperty(PropertyName = "scheduledstartdate")]
        public DateTime? ScheduledStartDate { get; set; }

        /// <summary>
        /// End of the appointment scheduled search date range (mm/dd/yyyy).  Inclusive.
        /// </summary>
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        [JsonProperty(PropertyName = "scheduledenddate")]
        public DateTime? ScheduledEndDate { get; set; }

        /// <summary>
        /// Include appointments that have been cancelled.
        /// </summary>
        [JsonProperty(PropertyName = "showcancelled")]
        public bool ShowCancelled { get; set; } = false;

        /// <summary>
        /// Include all reminder call related results, if available, associated with an appointment.
        /// </summary>
        [JsonProperty(PropertyName = "showremindercalldetail")]
        public bool ShowReminderCallDetail { get; set; }

        /// <summary>
        /// Number of entries to return (default 1000, max 10000)Please note that this endpoint has a different default and max than normal.
        /// </summary>
        public int? Limit { get; set; } = 1000;

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        public int? Offset { get; set; }
    }
}