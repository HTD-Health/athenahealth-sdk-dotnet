using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;
using System;

// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class PatientCaseResponse : IPagingResponse<PatientCase>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("patientcases")]
        public PatientCase[] Items { get; set; }
    }

    public class PatientCase
    {
        /// <summary>
        /// ID for the document
        /// </summary>
        [JsonProperty("patientcaseid")]
        public int? Id { get; set; }

        /// <summary>
        /// Description of the patient case
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Subject of the patient case
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Date the patient case was created
        /// </summary>
        [JsonProperty("createddate")]
        [JsonConverter(typeof(DateConverter))]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Type of patient case
        /// </summary>
        [JsonProperty("patientcasetype")]
        public string PatientCaseType { get; set; }

        /// <summary>
        /// Status of the patient case
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
