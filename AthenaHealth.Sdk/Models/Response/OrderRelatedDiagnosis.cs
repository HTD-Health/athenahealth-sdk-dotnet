using Newtonsoft.Json;

// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo
// ReSharper disable IdentifierTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class OrderRelatedDiagnosis
    {
        [JsonProperty("diagnosiscode")]
        public IcdCode DiagnosisCode { get; set; }

        /// <summary>
        /// ICD equivalent Codes for the SNOMED Code.
        /// </summary>
        [JsonProperty("snomedicdcodes")]
        public SnomedIcdCode[] SnomedIcdCodes { get; set; }
    }

    /// <summary>
    /// ICD equivalent Codes for the SNOMED Code.
    /// </summary>
    public class SnomedIcdCode
    {
        /// <summary>
        /// Unstripped Diagnosis Code.
        /// </summary>
        [JsonProperty("unstrippeddiagnosiscode")]
        public string Ndc { get; set; }

        /// <summary>
        /// Code set the ICD10 code belongs to.
        /// </summary>
        [JsonProperty("codeset")]
        public string CodeSet { get; set; }

        /// <summary>
        /// ICD 10 Code.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Brief description for this code.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
