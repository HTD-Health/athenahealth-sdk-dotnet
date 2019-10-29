using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Request.Interfaces;
using Newtonsoft.Json;
using System;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetPatientEncountersFilter : IPagingFilter
    {
        /// <summary>
        /// Find the encounter for this appointment.
        /// </summary>
        [JsonProperty(PropertyName = "appointmentid")]
        public int? AppointmentId { get; set; }

        /// <summary>
        /// The athenaNet department id.
        /// </summary>
        [JsonProperty(PropertyName = "departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// Omit any encounters later than this date
        /// </summary>
        [JsonProperty(PropertyName = "enddate")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The ID of the provider for this encounter
        /// </summary>
        [JsonProperty(PropertyName = "providerid")]
        public int? ProviderId { get; set; }

        /// <summary>
        /// By default only encounters in OPEN, CLOSED, or REVIEW status are retrieved, with this
        /// flag, encounters aren't filtered by status.
        /// </summary>
        [JsonProperty(PropertyName = "showallstatuses")]
        public bool? ShowAllStatuses { get; set; }

        /// <summary>
        /// Retrieve all encounter types, by default only VISIT and ORDERSONLY are retrieved.
        /// </summary>
        [JsonProperty(PropertyName = "showalltypes")]
        public bool? ShowAllTypes { get; set; }

        /// <summary>
        /// Query diagnosis information for every encounter
        /// </summary>
        [JsonProperty(PropertyName = "showdiagnoses")]
        public bool? ShowDiagnoses { get; set; }

        /// <summary>
        /// Omit any encounters earlier than this date
        /// </summary>
        [JsonProperty(PropertyName = "startdate")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Number of entries to return (default 1000, max 10000). Please note that this endpoint has
        /// a different default and max than normal.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        public int? Offset { get; set; }

        public GetPatientEncountersFilter(int departmentId)
        {
            DepartmentId = departmentId;
        }
    }
}
