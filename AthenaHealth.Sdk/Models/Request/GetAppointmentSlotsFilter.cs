using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Request.Interfaces;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Request
{
    public class GetAppointmentSlotsFilter : IPagingFilter
    {
        /// <summary>
        /// Normally, an appointment reason ID should be used which will map to the correct underlying appointment type in athenaNet. This field will ignore the practice's existing setup for what should be scheduled. Please consult with athenahealth before using. Either an appointmenttypeid or a reasonid must be specified or no results will be returned.
        /// </summary>
        [JsonProperty("appointmenttypeid")]
        public int? AppointmentTypeId { get; set; }

        /// <summary>
        /// Bypass checks that usually require returned appointments to be some amount of hours in the future (as configured by the practice, defaulting to 24 hours), and also ignores the setting that only shows appointments for a certain number of days in the future (also configurable by the practice, defaulting to 90 days).
        /// </summary>
        [JsonProperty("bypassscheduletimechecks")]
        public bool? BypassScheduleTimeChecks { get; set; }

        /// <summary>
        /// The athenaNet department ID.
        /// </summary>
        [JsonProperty("departmentid")]
        [Required]
        [JsonConverter(typeof(DelimitedStringConverter), ",")]
        public int[] DepartmentId { get; set; }

        /// <summary>
        /// End of the appointment search date range (mm/dd/yyyy).  Inclusive. Defaults to seven days from startdate.
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("enddate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// By default, we show only appointments that are are available to scheduled via the API.   This flag allows you to bypass that restriction for viewing available appointments (but you still may not be able to schedule based on this permission!).  This flag does not, however, show the full schedule (that is, appointments that are already booked).
        /// </summary>
        [JsonProperty("ignoreschedulablepermission")]
        // ReSharper disable once IdentifierTypo
        public bool? IgnoreSchedulablePermission { get; set; }

        /// <summary>
        /// The athenaNet provider ID. Required if a reasonid other than -1 is specified.
        /// </summary>
        [JsonProperty("providerid")]
        [JsonConverter(typeof(DelimitedStringConverter), ",")]
        public int[] ProviderId { get; set; }

        /// <summary>
        /// The athenaNet patient appointment reason ID, from GET /patientappointmentreasons. While this is not technically required due to some unusual use cases, it is highly recommended for most calls. We do allow a special value of -1 for the reasonid. This reasonid will return open, web-schedulable slots regardless of reason.  However, slots returned using a search of -1 may return slots that are not bookable by any reason ID (they may be bookable by specific appointment type IDs instead).  This argument allows multiple valid reason IDs to be specified (e.g. reasonid=1,2,3), so if you are looking for slots that match "any" reason, it is recommended that you enumerate the set of reasons you are looking for.  Either a reasonid or an appointmenttypeid must be specified or no results will be returned. If a reasonid other than -1 is specified then a providerid must also be specified.
        /// </summary>
        [JsonProperty("reasonid")]
        [JsonConverter(typeof(DelimitedStringConverter), ",")]
        public int[] ReasonId { get; set; }

        /// <summary>
        /// By default, we hide appointments that are frozen from being returned via the API.   This flag allows you to show frozen slots in the set of results returned.
        /// </summary>
        [JsonProperty("showfrozenslots")]
        public bool? ShowFrozenSlots { get; set; }

        /// <summary>
        /// Start of the appointment search date range (mm/dd/yyyy).  Inclusive.  Defaults to today.
        /// </summary>
        [JsonConverter(typeof(DateConverter))]
        [JsonProperty("startdate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Number of entries to return (default 1000, max 10000)Please note that this endpoint has a different default and max than normal.
        /// </summary>
        public int? Limit { get; set; } = 1000;

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        public int? Offset { get; set; }

        public GetAppointmentSlotsFilter(int[] departmentId)
        {
            DepartmentId = departmentId;
        }
    }
}
