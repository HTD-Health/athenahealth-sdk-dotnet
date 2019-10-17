using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class PatientWithScore : Patient
    {
        /// <summary>
        /// This is the patient's matching score. This indicates how likely this patient is to be the
        /// patient you are searching for given the demographics input. A score of 26 indicates the
        /// patient is automatically assumed to be the same. A score under 16 indicates that this is
        /// almost guaranteed to NOT be the patient you are looking for (we will never return any
        /// patient with a score under 16). A score of around 23 is the maximum you can get if the
        /// only parameters you pass in are the required parameters.
        /// </summary>
        [JsonProperty("score")]
        public double? Score { get; set; }
    }
}
