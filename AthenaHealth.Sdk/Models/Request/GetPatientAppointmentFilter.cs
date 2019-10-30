using AthenaHealth.Sdk.Models.Request.Interfaces;
using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetPatientAppointmentFilter : IPagingFilter
    {
        /// <summary>
        /// Show cancelled appointments
        /// </summary>
        [JsonProperty("showcancelled")]
        public bool? ShowCancelled { get; set; }
        
        /// <summary>
        /// Show expected procedure codes.	
        /// </summary>
        [JsonProperty("showexpectedprocedurecodes")]
        public bool? ShowExpectedProcedureCodes { get; set; }

        /// <summary>
        /// Show appointments that were before today
        /// </summary>
        [JsonProperty("showpast")]
        public bool? ShowPast { get; set; }

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
