using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class DocumentResponse : IPagingResponse<Document>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("documents")]
        public Document[] Items { get; set; }
    }

    public class Document
    {
        /// <summary>
        /// Provider ID for this document
        /// </summary>
        [JsonProperty("providerid")]
        public int? ProviderId { get; set; }

        /// <summary>
        /// The internal accession ID for this document. Format depends on the system the ID belongs to.
        /// </summary>
        [JsonProperty("internalaccessionid")]
        public string InternalAccessionId { get; set; }

        /// <summary>
        /// Encounter ID
        /// </summary>
        [JsonProperty("encounterid")]
        public int? EncounterId { get; set; }

        /// <summary>
        /// Date/time (ISO 8601) the observation was taken
        /// </summary>
        [JsonProperty("observationdatetime")]
        public string ObservationDateTime { get; set; }

        /// <summary>
        /// The clinical provider ID of the performing provider
        /// </summary>
        [JsonProperty("clinicalproviderid")]
        public int? ClinicalProviderId { get; set; }

        /// <summary>
        /// The description for this document
        /// </summary>
        [JsonProperty("documenttype")]
        public string DocumentType { get; set; }

        /// <summary>
        /// The external accession ID for this document. Format depends on the system the ID belongs to.
        /// </summary>
        [JsonProperty("externalaccessionid")]
        public string ExternalAccessionId { get; set; }

        /// <summary>
        /// The appointment ID for this document,
        /// </summary>
        [JsonProperty("appointmentid")]
        public int? AppointmentId { get; set; }

        /// <summary>
        /// The ID of the description for this document
        /// </summary>
        [JsonProperty("documenttypeid")]
        public int? DocumentTypeId { get; set; }

        /// <summary>
        /// Order ID of the order this document is tied to, if any
        /// </summary>
        [JsonProperty("tietoorderid")]
        public int? TieToOrderId { get; set; }

        /// <summary>
        /// ID for the document. Note that in documents/{documentclass} calls, this will become an ID
        /// named after the document class (e.g. rtoid or letterid).
        /// </summary>
        [JsonProperty("documentid")]
        public string DocumentId { get; set; }

        /// <summary>
        /// The primary key for coordinatortask class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("coordinatortaskid")]
        public int? CoordinatorTaskId { get; set; }

        /// <summary>
        /// The primary key for advertisement class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("advertisementid")]
        public int? AdvertisementId { get; set; }

        /// <summary>
        /// The primary key for electronicreferral class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("electronicreferralid")]
        public int? ElectronicReferralId { get; set; }

        /// <summary>
        /// The primary key for medicalrecord class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("medicalrecordid")]
        public int? MedicalRecordId { get; set; }

        /// <summary>
        /// The primary key for html class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("htmlid")]
        public int? HtmlId { get; set; }

        /// <summary>
        /// The primary key for encounterdocument class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("encounterdocumentid")]
        public int? EncounterDocumentId { get; set; }

        /// <summary>
        /// The primary key for officenote class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("officenoteid")]
        public int? OfficeNoteId { get; set; }

        /// <summary>
        /// The primary key for acog class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("acogid")]
        public int? AcogId { get; set; }

        /// <summary>
        /// The primary key for patientrecord class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("patientrecordid")]
        public int? PatientRecordId { get; set; }

        /// <summary>
        /// The primary key for interpretation class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("interpretationid")]
        public int? InterpretationId { get; set; }

        /// <summary>
        /// The primary key for chartabstraction class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("chartabstractionid")]
        public int? ChartAbstractionId { get; set; }

        /// <summary>
        /// The primary key for phonemessage class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("phonemessageid")]
        public int? PhoneMessageId { get; set; }

        /// <summary>
        /// The primary key for surgicalresult class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("surgicalresultid")]
        public int? SurgicalResultId { get; set; }

        /// <summary>
        /// The primary key for vaccine class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("vaccineid")]
        public int? VaccineId { get; set; }

        /// <summary>
        /// The primary key for prescription class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("prescriptionid")]
        public int? PrescriptionId { get; set; }

        /// <summary>
        /// The primary key for labresult class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("labresultid")]
        public int? LabResultId { get; set; }

        /// <summary>
        /// The primary key for coversheet class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("coversheetid")]
        public int? CoverSheetId { get; set; }

        /// <summary>
        /// The primary key for hospital class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("hospitalid")]
        public int? HospitalId { get; set; }

        /// <summary>
        /// The primary key for appointmentrequest class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("appointmentrequestid")]
        public int? AppointmentRequestId { get; set; }

        /// <summary>
        /// The primary key for imagingresult class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("imagingresultid")]
        public int? ImagingResultId { get; set; }

        /// <summary>
        /// The primary key for requisition class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("requisitionid")]
        public int? RequisitionId { get; set; }

        /// <summary>
        /// The primary key for rto class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("rtoid")]
        public int? RtoId { get; set; }

        /// <summary>
        /// The primary key for correctivelens class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("correctivelensid")]
        public int? CorrectiveLensId { get; set; }

        /// <summary>
        /// The primary key for order class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("orderid")]
        public int? OrderId { get; set; }

        /// <summary>
        /// The primary key for dme class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("dmeid")]
        public int? DmeId { get; set; }

        /// <summary>
        /// The primary key for patientcase class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("patientcaseid")]
        public int? PatientCaseId { get; set; }

        /// <summary>
        /// The primary key for physicianauth class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("physicianauthid")]
        public int? PhysicianAuthId { get; set; }

        /// <summary>
        /// The primary key for shareable class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("shareableid")]
        public int? ShareableId { get; set; }

        /// <summary>
        /// The primary key for mednotification class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("mednotificationid")]
        public int? MedNotificationId { get; set; }

        /// <summary>
        /// The primary key for admin class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("adminid")]
        public int? AdminId { get; set; }

        /// <summary>
        /// The primary key for patientinfo class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("patientinfoid")]
        public int? PatientInfoId { get; set; }

        /// <summary>
        /// The primary key for surgery class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("surgeryid")]
        public int? SurgeryId { get; set; }

        /// <summary>
        /// The primary key for unknown class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("unknownid")]
        public int? UnknownId { get; set; }

        /// <summary>
        /// The primary key for clinicaldocument class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("clinicaldocumentid")]
        public int? ClinicalDocumentId { get; set; }

        /// <summary>
        /// The primary key for letter class of documents. This is in place of a documentid.
        /// </summary>
        [JsonProperty("letterid")]
        public int? LetterId { get; set; }

        /// <summary>
        /// Department for the document
        /// </summary>
        [JsonProperty("departmentid")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// Description of the document type
        /// </summary>
        [JsonProperty("documentdescription")]
        public string DocumentDescription { get; set; }

        /// <summary>
        /// External note for the patient
        /// </summary>
        [JsonProperty("externalnote")]
        public string ExternalNote { get; set; }

        /// <summary>
        /// Subject of the document
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Date the document was created. Please use createddatetime instead.
        /// </summary>
        [JsonProperty("createddate")]
        public string CreatedDate { get; set; }

        /// <summary>
        /// Date/Time (ISO 8601) the document was created
        /// </summary>
        [JsonProperty("createddatetime")]
        public string CreatedDateTime { get; set; }

        /// <summary>
        /// Date/time (ISO 8601) the document was last modified
        /// </summary>
        [JsonProperty("lastmodifieddatetime")]
        public string LastModifiedDateTime { get; set; }

        /// <summary>
        /// Date/time (ISO 8601) the document was deleted
        /// </summary>
        [JsonProperty("deleteddatetime")]
        public string DeletedDateTime { get; set; }

        /// <summary>
        /// Class of document
        /// </summary>
        [JsonProperty("documentclass")]
        public string DocumentClass { get; set; }

        /// <summary>
        /// Specific type of document
        /// </summary>
        [JsonProperty("documentsubclass")]
        public string DocumentSubclass { get; set; }

        /// <summary>
        /// Status of the document
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Person the document is assigned to
        /// </summary>
        [JsonProperty("assignedto")]
        public string AssignedTo { get; set; }

        /// <summary>
        /// Document priority, when available.
        /// </summary>
        [JsonProperty("priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// The 'Internal Note' attached to this document
        /// </summary>
        [JsonProperty("internalnote")]
        public string InternalNote { get; set; }

        /// <summary>
        /// Explains method by which the document was entered into the AthenaNet (INTERFACE
        /// (digital), FAX, etc.)
        /// </summary>
        [JsonProperty("documentroute")]
        public string DocumentRoute { get; set; }

        /// <summary>
        /// Explains where this document originated (e.g. ENCOUNTER, PORTAL, etc.)
        /// </summary>
        [JsonProperty("documentsource")]
        public string DocumentSource { get; set; }

        /// <summary>
        /// External note sent to the receiving facility
        /// </summary>
        [JsonProperty("receivernote")]
        public string ReceiverNote { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("declinedreasontext")]
        public string DeclinedReasonText { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("declinedreason")]
        public DeclinedReason[] DeclinedReasons { get; set; }

        public class DeclinedReason
        {
            /// <summary>
            /// </summary>
            [JsonProperty("code")]
            public string Code { get; set; }

            /// <summary>
            /// </summary>
            [JsonProperty("codeset")]
            public string Codeset { get; set; }

            /// <summary>
            /// </summary>
            [JsonProperty("description")]
            public string Description { get; set; }
        }
    }
}
