using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class UpdatePatientResponse
    {
        /// <summary>
        /// Please remember to never disclose this ID to patients since it may result in inadvertant
        /// disclosure that a patient exists in a practice already.
        /// </summary>
        [JsonProperty("patientid")]
        public int? PatientId { get; set; }
    }
}
