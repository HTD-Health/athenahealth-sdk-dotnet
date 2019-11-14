using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo
namespace AthenaHealth.Sdk.Models.Request
{
    public class CreateDiagnoses
    {
        /// <summary>
        /// SNOMED code for this diagnosis.
        /// </summary>
        [Required]
        [JsonProperty("snomedcode")]
        public string SnomedCode { get; set; }

        /// <summary>
        /// ICD-10 code(s) for this diagnosis.
        /// </summary>
        [JsonProperty("icd10codes")]
        public string Icd10Codes { get; set; }

        /// <summary>
        /// ICD-9 code(s) for this diagnosis.
        /// </summary>
        [JsonProperty("icd9codes")]
        public string Icd9Codes { get; set; }

        /// <summary>
        /// The note to be entered for this diagnosis.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// Laterality of the SNOMED code.
        /// </summary>
        [JsonProperty("laterality")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public LateralityEnum? Laterality { get; set; }
    }
}
