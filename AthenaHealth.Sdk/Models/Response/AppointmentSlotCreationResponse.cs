using System.Collections.Generic;
using Newtonsoft.Json;
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
        [JsonProperty(PropertyName = "appointmentids")]
        public Dictionary<string, string> AppointmentIds { get; set; }
    }
}
