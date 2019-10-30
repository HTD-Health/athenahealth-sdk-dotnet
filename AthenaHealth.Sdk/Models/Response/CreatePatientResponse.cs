using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class CreatePatientResponse
    {
        /// <summary>
        /// Please remember to never disclose this ID to patients since it may result in inadvertant
        /// disclosure that a patient exists in a practice already.
        /// </summary>
        [JsonProperty("patientid")]
        public int? PatientId { get; set; }

        /// <summary>
        /// Error message will be returned if show error message flag is set to true and patient
        /// match found.
        /// </summary>
        [JsonProperty("errormessage")]
        public string ErrorMessage { get; set; }
    }
}
