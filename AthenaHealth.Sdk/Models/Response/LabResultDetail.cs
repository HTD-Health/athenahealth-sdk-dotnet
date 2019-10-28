using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using System;

namespace AthenaHealth.Sdk.Models.Response
{
    public class LabResultDetail
    {
        /// <summary>
        /// The primary key for labresult class of documents
        /// </summary>
        [JsonProperty(PropertyName = "labresultid")]
        public int? Id { get; set; }

        /// <summary>
        /// Date the document was created. Please use createddatetime instead.
        /// </summary>
        [JsonProperty(PropertyName = "createddate")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Explains method by which the document was entered into the AthenaNet (INTERFACE
        /// (digital), FAX, etc.)
        /// </summary>
        [JsonProperty(PropertyName = "documentroute")]
        public string DocumentRoute { get; set; }

        /// <summary>
        /// The status of the result.
        /// </summary>
        [JsonProperty(PropertyName = "resultstatus")]
        public string ResultStatus { get; set; }

        /// <summary>
        /// Provider ID for this document
        /// </summary>
        [JsonProperty(PropertyName = "providerid")]
        public int? ProviderId { get; set; }

        /// <summary>
        /// The external accession ID for this document. Format depends on the system the ID belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "externalaccessionid")]
        public string ExternalAccessionId { get; set; }

        /// <summary>
        /// Order type group name
        /// </summary>
        [JsonProperty(PropertyName = "ordertype")]
        public string OrderType { get; set; }

        /// <summary>
        /// Result note on a document.
        /// </summary>
        [JsonProperty(PropertyName = "resultnotes")]
        public string ResultNotes { get; set; }

        /// <summary>
        /// Status of the document
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// The user who last modified this document.
        /// </summary>
        [JsonProperty(PropertyName = "lastmodifieduser")]
        public string LastModifiedUser { get; set; }

        /// <summary>
        /// External note for the patient.
        /// </summary>
        [JsonProperty(PropertyName = "externalnoteonly")]
        public string ExternalNoteOnly { get; set; }

        /// <summary>
        /// The most recent action note for a document
        /// </summary>
        [JsonProperty(PropertyName = "actionnote")]
        public string ActionNote { get; set; }

        /// <summary>
        /// The username of the provider associated with this lab result document.
        /// </summary>
        [JsonProperty(PropertyName = "providerusername")]
        public string ProviderUserName { get; set; }

        /// <summary>
        /// The internal accession ID for this document. Format depends on the system the ID belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "internalaccessionid")]
        public string InternalAccessionId { get; set; }

        /// <summary>
        /// If true, this result document should not be shown to the patient.
        /// </summary>
        [JsonProperty(PropertyName = "isconfidential")]
        public bool IsConfidential { get; set; }

        /// <summary>
        /// Date/Time (ISO 8601) the document was created
        /// </summary>
        [JsonProperty(PropertyName = "createddatetime")]
        public DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// Specific type of document
        /// </summary>
        [JsonProperty(PropertyName = "documentsubclass")]
        public string DocumentSubclass { get; set; }

        /// <summary>
        /// Encounter ID
        /// </summary>
        [JsonProperty(PropertyName = "encounterid")]
        public string EncounterId { get; set; }

        /// <summary>
        /// The practice entered interpretation of this result.
        /// </summary>
        [JsonProperty(PropertyName = "interpretation")]
        public string Interpretation { get; set; }

        /// <summary>
        /// Laboratory code that identifies the overall result.
        /// </summary>
        [JsonProperty(PropertyName = "labresultloinc")]
        public string LabresultLoinc { get; set; }

        /// <summary>
        /// Date/time (ISO 8601) the document was last modified
        /// </summary>
        [JsonProperty(PropertyName = "lastmodifieddatetime")]
        public DateTime? LastModifiedDateTime { get; set; }

        /// <summary>
        /// A note from lab.
        /// </summary>
        [JsonProperty(PropertyName = "notefromlab")]
        public string NoteFromLab { get; set; }

        /// <summary>
        /// Individual observation details
        /// </summary>
        [JsonProperty(PropertyName = "observations")]
        public Observation[] Observations { get; set; }

        /// <summary>
        /// Document priority, when available. 1 is high, 2 is normal. Some labs use other numbers or
        /// characters that are lab-specific.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public string Priority { get; set; }

        /// <summary>
        /// Date/time (ISO 8601) the observation was taken
        /// </summary>
        [JsonProperty(PropertyName = "observationdatetime")]
        public DateTime? ObservationDateTime { get; set; }

        /// <summary>
        /// Description of the document type
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// The number days, weeks, months, or year until a lab result document will go into followup
        /// after being sent to the portal.
        /// </summary>
        [JsonProperty(PropertyName = "alarmdays")]
        public string AlarmDays { get; set; }

        /// <summary>
        /// Explains where this document originated.
        /// </summary>
        [JsonProperty(PropertyName = "documentsource")]
        public string DocumentSource { get; set; }

        /// <summary>
        /// The status of the report.
        /// </summary>
        [JsonProperty(PropertyName = "reportstatus")]
        public string ReportStatus { get; set; }

        /// <summary>
        /// Subject of the document
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        /// <summary>
        /// The ID of the description for this document
        /// </summary>
        [JsonProperty(PropertyName = "documenttypeid")]
        public int? DocumentTypeId { get; set; }

        /// <summary>
        /// The appointment ID for this document
        /// </summary>
        [JsonProperty(PropertyName = "appointmentid")]
        public int? AppointmentId { get; set; }

        /// <summary>
        /// Department for the document
        /// </summary>
        [JsonProperty(PropertyName = "departmentid")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// The interpretation template added to the imaging result.
        /// </summary>
        [JsonProperty(PropertyName = "interpretationtemplate")]
        public LabResultInterpretationTemplate InterpretationTemplate { get; set; }

        /// <summary>
        /// An array of image pages associated with this document.
        /// </summary>
        [JsonProperty(PropertyName = "pages")]
        public Page[] Pages { get; set; }

        /// <summary>
        /// Person the document is assigned to
        /// </summary>
        [JsonProperty(PropertyName = "assignedto")]
        public string AssignedTo { get; set; }

        /// <summary>
        /// The user who created this document.
        /// </summary>
        [JsonProperty(PropertyName = "createduser")]
        public string CreatedUser { get; set; }

        /// <summary>
        /// Date/time (ISO 8601) the document was deleted
        /// </summary>
        [JsonProperty(PropertyName = "deleteddatetime")]
        public DateTime? DeletedDateTime { get; set; }

        /// <summary>
        /// Date/time the observation was taken
        /// </summary>
        [JsonProperty(PropertyName = "observationdate")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        public DateTime? ObservationDate { get; set; }

        /// <summary>
        /// Class of document
        /// </summary>
        [JsonProperty(PropertyName = "documentclass")]
        public string DocumentClass { get; set; }

        /// <summary>
        /// Date/time (ISO 8601) the document was last modified
        /// </summary>
        [JsonProperty(PropertyName = "lastmodifieddate")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Date of the encounter associated with this document
        /// </summary>
        [JsonProperty(PropertyName = "encounterdate")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        public DateTime? EncounterDate { get; set; }

        /// <summary>
        /// The ID of the clinical provider associated with this clinical document. Clinical
        /// providers are a master list of providers throughout the country. These include providers
        /// as well as radiology centers, labs and pharmacies.
        /// </summary>
        [JsonProperty(PropertyName = "facilityid")]
        public int? FacilityId { get; set; }

        /// <summary>
        /// The 'Internal Note' attached to this document
        /// </summary>
        [JsonProperty(PropertyName = "internalnote")]
        public string InternalNote { get; set; }

        /// <summary>
        /// A note about this lab result for the patient. This may or may not have been sent to the patient.
        /// </summary>
        [JsonProperty(PropertyName = "patientnote")]
        public string PatientNote { get; set; }

        /// <summary>
        /// Order ID of the order this document is tied to, if any
        /// </summary>
        [JsonProperty(PropertyName = "tietoorderid")]
        public int? TieToOrderId { get; set; }

        public class Observation
        {
            /// <summary>
            /// The athena ID for this analyte. Used to update the analyte.
            /// </summary>
            [JsonProperty(PropertyName = "analyteid")]
            public int? AnalyteId { get; set; }

            /// <summary>
            /// The name / identifier text for this analyte.
            /// </summary>
            [JsonProperty(PropertyName = "analytename")]
            public string AnalyteName { get; set; }

            /// <summary>
            /// The LOINC code for this analyte
            /// </summary>
            [JsonProperty(PropertyName = "loinc")]
            public string Loinc { get; set; }

            /// <summary>
            /// The observation value for this analyte.
            /// </summary>
            [JsonProperty(PropertyName = "value")]
            public string Value { get; set; }

            /// <summary>
            /// The units the value is in.
            /// </summary>
            [JsonProperty(PropertyName = "units")]
            public string Units { get; set; }

            /// <summary>
            /// The level of normality for this result.
            /// </summary>
            [JsonProperty(PropertyName = "abnormalflag")]
            public string AbnormalFlag { get; set; }

            /// <summary>
            /// The normal range for this lab analyte.
            /// </summary>
            [JsonProperty(PropertyName = "referencerange")]
            public string ReferenceRange { get; set; }

            /// <summary>
            /// Whether this observation is a prelimary, corrected, final, etc result.
            /// </summary>
            [JsonProperty(PropertyName = "resultstatus")]
            public string ResultStatus { get; set; }

            /// <summary>
            /// Any additional notes about this analyte.
            /// </summary>
            [JsonProperty(PropertyName = "note")]
            public string Note { get; set; }
        }

        public class Page
        {
            /// <summary>
            /// The content-type that will be returned by the page image call.
            /// </summary>
            [JsonProperty(PropertyName = "contenttype")]
            public string Type { get; set; }

            /// <summary>
            /// Within this list of pages, the ordering (starting with 1).
            /// </summary>
            [JsonProperty(PropertyName = "pageordering")]
            public string PageOrdering { get; set; }

            /// <summary>
            /// The ID to use in a call to get the page image.
            /// </summary>
            [JsonProperty(PropertyName = "pageid")]
            public int? PageId { get; set; }

            /// <summary>
            /// The URL to get the document image.
            /// </summary>
            [JsonProperty(PropertyName = "href")]
            public string Url { get; set; }
        }
    }
}
