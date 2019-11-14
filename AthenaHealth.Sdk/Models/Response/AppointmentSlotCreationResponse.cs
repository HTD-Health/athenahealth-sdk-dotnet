using Newtonsoft.Json;
using System.Collections.Generic;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class AppointmentSlotCreationResponse
    {
        /// <summary>
        /// An hash of appointment IDs to the time requested.
        /// Key - contains Id of created slot
        /// Value - contains time of created slot
        /// </summary>
        [JsonProperty("appointmentids")]
        public Dictionary<string, string> AppointmentIds { get; set; }
    }
}
