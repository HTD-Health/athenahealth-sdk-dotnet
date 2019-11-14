using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Request
{
    public class GetAppointmentFilter
    {
        /// <summary>
        /// When showing patient detail for appointments, the patient information for patients with record restrictions and blocked patients will not be shown.  Setting this flag to true will show that information for those patients.
        /// </summary>
        [JsonProperty("ignorerestrictions")]
        public bool IgnoreRestrictions { get; set; } = false;

        /// <summary>
        /// Include claim information, if available, associated with an appointment.
        /// </summary>
        [JsonProperty("showclaimdetail")]
        public bool ShowClaimDetail { get; set; } = false;

        /// <summary>
        /// By default, the expected co-pay is returned. For performance purposes, you can set this to false and copay will not be populated.
        /// </summary>
        [JsonProperty("showcopay")]
        public bool ShowCopay { get; set; } = true;

        /// <summary>
        /// Show the expected procedure codes.
        /// </summary>
        [JsonProperty("showexpectedprocedurecodes")]
        public bool ShowExpectedProcedureCodes { get; set; }

        /// <summary>
        /// Include patient insurance information. Shows insurance packages for the appointment if any are selected, and all patient packages otherwise.
        /// </summary>
        [JsonProperty("showinsurance")]
        public bool ShowInsurance { get; set; } = false;

        /// <summary>
        /// Include patient information for each patient associated with an appointment.
        /// </summary>
        [JsonProperty("showpatientdetail")]
        public bool ShowPatientDetail { get; set; }
    }
}
