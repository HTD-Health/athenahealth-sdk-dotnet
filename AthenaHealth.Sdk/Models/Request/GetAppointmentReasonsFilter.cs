using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Request.Interfaces;
using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetAppointmentReasonsFilter : IPagingFilter
    {
        public GetAppointmentReasonsFilter(int departmentId, int providerId)
        {
            DepartmentId = departmentId;
            ProviderId = providerId;
        }

        /// <summary>
        /// The athenaNet department ID.
        /// </summary>
        [JsonProperty("departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// The athenaNet provider ID.
        /// </summary>
        [JsonProperty("providerid")]
        public int ProviderId { get; set; }

        public AppointmentReasonTypeEnum Type { get; set; } = AppointmentReasonTypeEnum.New;

        /// <summary>
        /// Number of entries to return (default 1500, max 5000)
        /// </summary>
        public int? Limit { get; set; } = 1500;

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        public int? Offset { get; set; }
    }
}