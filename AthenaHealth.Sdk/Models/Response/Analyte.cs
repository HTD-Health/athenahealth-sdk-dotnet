using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using Newtonsoft.Json;
using System;

namespace AthenaHealth.Sdk.Models.Response
{
    public class AnalyteResponse
    {
        [JsonProperty("totalcount")]
        public int Total { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("analytes")]
        public Analyte[] Items { get; set; }
    }

    public class Analyte
    {
        /// <summary>
        /// Name / description specific to this analyte
        /// </summary>
        [JsonProperty(PropertyName = "analytename")]
        public string AnalyteName { get; set; }

        /// <summary>
        /// Athena ID for the given lab result observation/analyte
        /// </summary>
        [JsonProperty(PropertyName = "analyteid")]
        public int? AnalyteId { get; set; }

        /// <summary>
        /// Logical Observation Identifiers Names and Codes ID, if available
        /// </summary>
        [JsonProperty(PropertyName = "loinc")]
        public string LOINC { get; set; }

        /// <summary>
        /// Value recorded for this observation
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Units for this analyte entry, if provided by the lab
        /// </summary>
        [JsonProperty(PropertyName = "units")]
        public string Units { get; set; }

        /// <summary>
        /// Date when this observation was recorded
        /// </summary>
        [JsonProperty(PropertyName = "analytedate")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        public DateTime? AnalyteDate { get; set; }

        /// <summary>
        /// General description of the lab result test
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Additional note for this analyte, if applicable
        /// </summary>
        [JsonProperty(PropertyName = "note")]
        public string Note { get; set; }

        /// <summary>
        /// Status indicator of the measurement relative to normal (low, high, normal, abnormal)
        /// </summary>
        [JsonProperty(PropertyName = "abnormalflag")]
        public string AbnormalFlag { get; set; }

        /// <summary>
        /// The HL7 code related to the abnormal flag.
        /// </summary>
        [JsonProperty(PropertyName = "abnormalhl7code")]
        public string AbnormalHL7Code { get; set; }

        /// <summary>
        /// The HL7 description related to the abnormal flag.
        /// </summary>
        [JsonProperty(PropertyName = "abnormalhl7name")]
        public string AbnormalHL7Name { get; set; }

        /// <summary>
        /// DEPRECATED -- use "abnormalflag" instead. Status indicator of the measurement relative to normal (low, high, normal, abnormal)
        /// </summary>
        [Obsolete]
        [JsonProperty(PropertyName = "valuestatus")]
        public string ValueStatus { get; set; }

        /// <summary>
        /// Reference range of values accepted as normal for this observation
        /// </summary>
        [JsonProperty(PropertyName = "referencerange")]
        public string ReferenceRange { get; set; }

        /// <summary>
        /// The status of the result (e.g., "final", "preliminary", "corrected", etc.)
        /// </summary>
        [JsonProperty(PropertyName = "resultstatus")]
        public AnalyteResultStatusEnum? ResultStatus { get; set; }

        /// <summary>
        /// The status of the underlying lab result
        /// </summary>
        [JsonProperty(PropertyName = "labresultstatus")]
        public LabResultStatusEnum? LabResultStatus { get; set; }
    }
}
