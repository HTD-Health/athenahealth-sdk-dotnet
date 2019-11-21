using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Response
{
    public class LabResultResponse : IPagingResponse<LabResult>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("results")]
        public LabResult[] Items { get; set; }
    }

    public class LabResult
    {
        /// <summary>
        /// Athena ID for this lab result
        /// </summary>
        [JsonProperty("labresultid")]
        public int? Id { get; set; }

        /// <summary>
        /// The provider ID for this document.
        /// </summary>
        [JsonProperty("providerid")]
        public int? ProviderId { get; set; }

        /// <summary>
        /// The exactduplicatedocumentid of the document.
        /// </summary>
        [JsonProperty("exactduplicatedocumentid")]
        public int? ExactDuplicateDocumentId { get; set; }

        /// <summary>
        /// The interpretation template added to the lab result.
        /// </summary>
        [JsonProperty("interpretationtemplate")]
        public LabResultInterpretationTemplate InterpretationTemplate { get; set; }

        /// <summary>
        /// The supersededid of the Document.
        /// </summary>
        [JsonProperty("supersededdocumentid")]
        public string SupersedEdDocumentId { get; set; }

        /// <summary>
        /// This flag depicts if the lab result has a scanned document attachment or not.
        /// </summary>
        [JsonProperty("attachmentexists")]
        public bool? AttachmentExists { get; set; }

        /// <summary>
        /// The observation date and time associated with this lab result. Returned in mm/dd/yyyy
        /// hh24:mi:ss format.
        /// </summary>
        [JsonProperty("labresultdatetime")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy HH:mm:ss")]
        public DateTime? LabResultDateTime { get; set; }

        /// <summary>
        /// Document priority, when available. 1 is high, 2 is normal. Some labs use other numbers or
        /// characters that are lab-specific.
        /// </summary>
        [JsonProperty("priority")]
        public string Priority { get; set; }

        /// <summary>
        /// The external note for the patient.
        /// </summary>
        [JsonProperty("patientnote")]
        public string PatientNote { get; set; }

        /// <summary>
        /// The 'Internal Note' attached to this document.
        /// </summary>
        [JsonProperty("internalnote")]
        public string InternalNote { get; set; }

        /// <summary>
        /// Individual lab result observations/analytes
        /// </summary>
        [JsonProperty("analytes")]
        public Analyte[] Analytes { get; set; }

        /// <summary>
        /// The ID of the clinical provider associated with this clinical document. Clinical
        /// providers are a master list of providers throughout the country. These include providers
        /// as well as radiology centers, labs and pharmacies.
        /// </summary>
        [JsonProperty("facilityid")]
        public int? FacilityId { get; set; }

        /// <summary>
        /// The athena ID of the associated order document
        /// </summary>
        [JsonProperty("orderid")]
        public int? OrderId { get; set; }

        /// <summary>
        /// Description for this lab result
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The LOINC for the result document or associated order.
        /// </summary>
        [JsonProperty("labresultloinc")]
        public string LabResultLOINC { get; set; }

        /// <summary>
        /// Observation date associated with this lab result
        /// </summary>
        [JsonProperty("labresultdate")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime? LabResultDate { get; set; }

        /// <summary>
        /// Additional note associated with this lab result, if any
        /// </summary>
        [JsonProperty("labresultnote")]
        public string LabresultNote { get; set; }

        /// <summary>
        /// The status of the result (e.g., "final", "preliminary", "corrected", etc.)
        /// </summary>
        [JsonProperty("resultstatus")]
        public LabResultStatusEnum? ResultStatus { get; set; }

        public class Analyte
        {
            /// <summary>
            /// The date and time when this observation was recorded. Returned in mm/dd/yyyy
            /// hh24:mi:ss format.
            /// </summary>
            [JsonProperty("analytedatetime")]
            [JsonConverter(typeof(DateConverter), "MM/dd/yyyy HH:mm:ss")]
            public DateTime? AnalyteDateTime { get; set; }

            /// <summary>
            /// Athena ID for the given lab result observation/analyte
            /// </summary>
            [JsonProperty("analyteid")]
            public int? AnalyteId { get; set; }

            /// <summary>
            /// Name / description specific to this analyte
            /// </summary>
            [JsonProperty("analytename")]
            public string AnalyteName { get; set; }

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

            [OnError]
            internal void OnError(StreamingContext context, ErrorContext errorContext)
            {
                if (errorContext.Member is string property)
                {
                    if (property == "status") // Deprecated property
                        errorContext.Handled = true;
                }
            }
        }
    }
}
