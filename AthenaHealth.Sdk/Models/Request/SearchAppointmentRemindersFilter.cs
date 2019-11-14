using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using System;

namespace AthenaHealth.Sdk.Models.Request
{
    public class SearchAppointmentRemindersFilter
    {
        public int DepartmentId { get; set; }

        /// <summary>
        /// Find reminders for appointments whose approximate date is on or before this date.
        /// </summary>
        [JsonConverter(typeof(CustomDateConverter))]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Find reminders for appointments whose approximate date is on or after this date.
        /// </summary>
        [JsonConverter(typeof(CustomDateConverter))]
        public DateTime StartDate { get; set; }

        public int? AppointmentTypeId { get; set; }

        public int? PatientId { get; set; }

        public int? ProviderId { get; set; }

        /// <summary>
        /// By default, we do not return reminders that have been deleted. Setting this to true will show all reminders regardless of status.
        /// </summary>
        public bool ShowDeleted { get; set; }

        /// <summary>
        /// Number of entries to return (default 100, max 500)
        /// </summary>
        public int Limit { get; set; } = 100;

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        public int Offset { get; set; } = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="departmentId">An athenaNet department ID.</param>
        /// <param name="startDate">Find reminders for appointments whose approximate date is on or after this date.</param>
        /// <param name="endDate">Find reminders for appointments whose approximate date is on or before this date.</param>
        public SearchAppointmentRemindersFilter(int departmentId, DateTime startDate, DateTime endDate)
        {
            DepartmentId = departmentId;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
