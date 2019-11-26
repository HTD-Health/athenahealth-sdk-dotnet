using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class AccidentData
    {
        /// <summary>
        /// A boolean field describing whether this appointment is created because of an accident
        /// related to the patient's employment.
        /// </summary>
        [JsonProperty("relatedtoemployment")]
        public bool? RelatedToEmployment { get; set; }

        /// <summary>
        /// A boolean field describing whether this appointment is created because of an accident
        /// caused by another party.
        /// </summary>
        [JsonProperty("anotherpartyresponsible")]
        public bool? AnotherPartyResponsible { get; set; }

        /// <summary>
        /// The two letter state abbreviation. This field is only valid if the relatedtoautoaccident
        /// field is set (or is being set) to true.
        /// </summary>
        [JsonProperty("autoaccidentstate")]
        public string AutoAccidentState { get; set; }

        /// <summary>
        /// The athenaNet appointment ID.
        /// </summary>
        [JsonProperty("appointmentid")]
        public int? AppointmentId { get; set; }

        /// <summary>
        /// A boolean field describing whether this appointment is created because of an automobile accident.
        /// </summary>
        [JsonProperty("relatedtoautoaccident")]
        public bool? RelatedToAutoAccident { get; set; }

        /// <summary>
        /// A boolean field describing whether this appointment is created because of an accident
        /// other than those listed above. This is mutually exclusive with the automobile accident field.
        /// </summary>
        [JsonProperty("relatedtootheraccident")]
        public bool? RelatedToOtherAccident { get; set; }
    }
}
