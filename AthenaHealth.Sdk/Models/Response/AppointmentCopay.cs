using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public class AppointmentCopay
    {
        /// <summary>
        /// The expected copay based on the patient's primary insurance and appointment type.
        /// </summary>
        [JsonProperty("insurancecopay")]
        public string InsuranceCopay { get; set; }

        /// <summary>
        /// Copay payments that have already been collected for this specific appointment.
        /// </summary>
        [JsonProperty("collectedforappointment")]
        public string CollectedForAppointment { get; set; }

        /// <summary>
        /// Copay payments that have already been collected for this patient, but that have not yet been applied to any specific appointment.
        /// </summary>
        [JsonProperty("collectedforother")]
        public string CollectedForOther { get; set; }
    }
}
