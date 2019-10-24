using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models.Response
{
    public class LabResultResponse
    {
        [JsonProperty("totalcount")]
        public int Total { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("results")]
        public LabResult[] Items { get; set; }
    }

    public class LabResult
    {
        /// <summary>
        /// The provider ID for this document.
        /// </summary>
        [JsonProperty(PropertyName = "providerid")]
        public int? ProviderId { get; set; }

        /// <summary>
        /// The exactduplicatedocumentid of the document.
        /// </summary>
        [JsonProperty(PropertyName = "exactduplicatedocumentid")]
        public int? ExactDuplicateDocumentId { get; set; }

        /// <summary>
        /// The interpretation template added to the lab result.
        /// </summary>
        [JsonProperty(PropertyName = "interpretationtemplate")]
        public InterpretationTemplateModel InterpretationTemplate { get; set; }

        /// <summary>
        /// The supersededid of the Document.
        /// </summary>
        [JsonProperty(PropertyName = "supersededdocumentid")]
        public string SupersedEdDocumentId { get; set; }

        /// <summary>
        /// This flag depicts if the lab result has a scanned document attachment or not.
        /// </summary>
        [JsonProperty(PropertyName = "attachmentexists")]
        public bool? AttachmentExists { get; set; }

        /// <summary>
        /// The observation date and time associated with this lab result. Returned in mm/dd/yyyy hh24:mi:ss format.
        /// </summary>
        [JsonProperty(PropertyName = "labresultdatetime")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy HH:mm:ss")]
        public DateTime? LabResultDateTime { get; set; }

        /// <summary>
        /// Document priority, when available. 1 is high, 2 is normal. Some labs use other numbers or characters that are lab-specific.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public string Priority { get; set; }

        /// <summary>
        /// The external note for the patient.
        /// </summary>
        [JsonProperty(PropertyName = "patientnote")]
        public string PatientNote { get; set; }

        /// <summary>
        /// The 'Internal Note' attached to this document.
        /// </summary>
        [JsonProperty(PropertyName = "internalnote")]
        public string InternalNote { get; set; }

        /// <summary>
        /// Individual lab result observations/analytes
        /// </summary>
        [JsonProperty(PropertyName = "analytes")]
        public Analyte[] Analytes { get; set; }

        /// <summary>
        /// The ID of the clinical provider associated with this clinical document. Clinical providers are a master list of providers throughout the country. These include providers as well as radiology centers, labs and pharmacies.
        /// </summary>
        [JsonProperty(PropertyName = "facilityid")]
        public int? FacilityId { get; set; }

        /// <summary>
        /// Athena ID for this lab result
        /// </summary>
        [JsonProperty(PropertyName = "labresultid")]
        public int? LabresultId { get; set; }

        /// <summary>
        /// The athena ID of the associated order document
        /// </summary>
        [JsonProperty(PropertyName = "orderid")]
        public int? OrderId { get; set; }

        /// <summary>
        /// Description for this lab result
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The LOINC for the result document or associated order.
        /// </summary>
        [JsonProperty(PropertyName = "labresultloinc")]
        public string LabResultLOINC { get; set; }

        /// <summary>
        /// Observation date associated with this lab result
        /// </summary>
        [JsonProperty(PropertyName = "labresultdate")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        public DateTime? LabResultDate { get; set; }

        /// <summary>
        /// Additional note associated with this lab result, if any
        /// </summary>
        [JsonProperty(PropertyName = "labresultnote")]
        public string LabresultNote { get; set; }

        /// <summary>
        /// The status of the result (e.g., "final", "preliminary", "corrected", etc.)
        /// </summary>
        [JsonProperty(PropertyName = "resultstatus")]
        public LabResultStatusEnum? ResultStatus { get; set; }

        public class InterpretationTemplateModel
        {
            /// <summary>
            /// The paragraphs in the template.
            /// </summary>
            [JsonProperty(PropertyName = "paragraphs")]
            public Paragraph[] Paragraphs { get; set; }

            /// <summary>
            /// The interpretation note.
            /// </summary>
            [JsonProperty(PropertyName = "interpretationtemplatenote")]
            public string InterpretationTemplateNote { get; set; }

            /// <summary>
            /// The name of the interpretation template.
            /// </summary>
            [JsonProperty(PropertyName = "interpretationtemplatename")]
            public string InterpretationTemplateName { get; set; }

            public class Paragraph
            {
                /// <summary>
                /// The sentences in the paragraph.
                /// </summary>
                [JsonProperty(PropertyName = "sentences")]
                public Sentence[] Sentences { get; set; }

                /// <summary>
                /// The name of the interpretation paragraph.
                /// </summary>
                [JsonProperty(PropertyName = "paragraphname")]
                public string Name { get; set; }

                public class Sentence
                {
                    /// <summary>
                    /// The note that goes along with this sentence.
                    /// </summary>
                    [JsonProperty(PropertyName = "sentencenote")]
                    public string SentenceNote { get; set; }

                    /// <summary>
                    /// The findings in the sentence
                    /// </summary>
                    [JsonProperty(PropertyName = "findings")]
                    public Finding[] Findings { get; set; }

                    /// <summary>
                    /// The name of the sentence in the paragraph.
                    /// </summary>
                    [JsonProperty(PropertyName = "sentencename")]
                    public string Name { get; set; }

                    public class Finding
                    {
                        /// <summary>
                        /// The note for the finding selected.
                        /// </summary>
                        [JsonProperty(PropertyName = "findingnote")]
                        public string FindingNote { get; set; }

                        /// <summary>
                        /// The option in the finding that was selected by the user.
                        /// </summary>
                        [JsonProperty(PropertyName = "selectedoptions")]
                        public string SelectedOptions { get; set; }

                        /// <summary>
                        /// Describes the finding - either NORMAL, ABNORMAL, or NEUTRAL.
                        /// </summary>
                        [JsonProperty(PropertyName = "findingtype")]
                        public string Type { get; set; }

                        /// <summary>
                        /// The name of the finding.
                        /// </summary>
                        [JsonProperty(PropertyName = "findingname")]
                        public string Name { get; set; }

                        /// <summary>
                        /// Freetext that could be associated with this finding.
                        /// </summary>
                        [JsonProperty(PropertyName = "freetext")]
                        public string FreeText { get; set; }
                    }
                }
            }
        }

        public class Analyte
        {
            /// <summary>
            /// The date and time when this observation was recorded. Returned in mm/dd/yyyy hh24:mi:ss format.
            /// </summary>
            [JsonProperty(PropertyName = "analytedatetime")]
            [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy HH:mm:ss")]
            public DateTime? AnalyteDateTime { get; set; }

            /// <summary>
            /// Athena ID for the given lab result observation/analyte
            /// </summary>
            [JsonProperty(PropertyName = "analyteid")]
            public int? AnalyteId { get; set; }

            /// <summary>
            /// Name / description specific to this analyte
            /// </summary>
            [JsonProperty(PropertyName = "analytename")]
            public string AnalyteName { get; set; }

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
            /// Reference range of values accepted as normal for this observation
            /// </summary>
            [JsonProperty(PropertyName = "referencerange")]
            public string ReferenceRange { get; set; }

            /// <summary>
            /// The status of the result (e.g., "final", "preliminary", "corrected", etc.)
            /// </summary>
            [JsonProperty(PropertyName = "resultstatus")]
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
