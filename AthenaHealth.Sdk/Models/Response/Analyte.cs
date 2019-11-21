using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Response
{
    public class AnalyteResponse : IPagingResponse<Analyte>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("analytes")]
        public Analyte[] Items { get; set; }
    }

    public class Analyte
    {
        /// <summary>
        /// Name / description specific to this analyte
        /// </summary>
        [JsonProperty("analytename")]
        public string AnalyteName { get; set; }

        /// <summary>
        /// Athena ID for the given lab result observation/analyte
        /// </summary>
        [JsonProperty("analyteid")]
        public int? AnalyteId { get; set; }

        /// <summary>
        /// Logical Observation Identifiers Names and Codes ID, if available
        /// </summary>
        [JsonProperty("loinc")]
        public string LOINC { get; set; }

        /// <summary>
        /// Value recorded for this observation
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// Units for this analyte entry, if provided by the lab
        /// </summary>
        [JsonProperty("units")]
        public string Units { get; set; }

        /// <summary>
        /// Date when this observation was recorded
        /// </summary>
        [JsonProperty("analytedate")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime? AnalyteDate { get; set; }

        /// <summary>
        /// General description of the lab result test
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Additional note for this analyte, if applicable
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// Status indicator of the measurement relative to normal (low, high, normal, abnormal)
        /// </summary>
        [JsonProperty("abnormalflag")]
        public string AbnormalFlag { get; set; }

        /// <summary>
        /// The HL7 code related to the abnormal flag.
        /// </summary>
        [JsonProperty("abnormalhl7code")]
        public string AbnormalHL7Code { get; set; }

        /// <summary>
        /// The HL7 description related to the abnormal flag.
        /// </summary>
        [JsonProperty("abnormalhl7name")]
        public string AbnormalHL7Name { get; set; }

        /// <summary>
        /// Reference range of values accepted as normal for this observation
        /// </summary>
        [JsonProperty("referencerange")]
        public string ReferenceRange { get; set; }

        /// <summary>
        /// The status of the result (e.g., "final", "preliminary", "corrected", etc.)
        /// </summary>
        [JsonProperty("resultstatus")]
        public AnalyteResultStatusEnum? ResultStatus { get; set; }

        /// <summary>
        /// The status of the underlying lab result
        /// </summary>
        [JsonProperty("labresultstatus")]
        public LabResultStatusEnum? LabResultStatus { get; set; }

        [OnError]
        internal void OnError(StreamingContext context, ErrorContext errorContext)
        {
            if (errorContext.Member is string property)
            {
                if (property == "valuestatus") // Deprecated property
                    errorContext.Handled = true;
            }
        }
    }
}
