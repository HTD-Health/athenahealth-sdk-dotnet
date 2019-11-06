using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class PrescriptionResponse : IPagingResponse<Prescription>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("prescriptions")]
        public Prescription[] Items { get; set; }
    }

    public class Prescription
    {
        /// <summary>
        /// Date the document was created. Please use createddatetime instead.
        /// </summary>
        [JsonProperty("createddate")]
        public string CreatedDate { get; set; }

        /// <summary>
        /// The 'Internal Note' attached to this document
        /// </summary>
        [JsonProperty("internalnote")]
        public string InternalNote { get; set; }

        /// <summary>
        /// Provider ID for this document
        /// </summary>
        [JsonProperty("providerid")]
        public int? ProviderId { get; set; }

        /// <summary>
        /// The external accession ID for this document. Format depends on the system the ID belongs to.
        /// </summary>
        [JsonProperty("externalaccessionid")]
        public string ExternalAccessionId { get; set; }

        /// <summary>
        /// Order type group name
        /// </summary>
        [JsonProperty("ordertype")]
        public string OrderType { get; set; }

        /// <summary>
        /// Status of the document
        /// </summary>
        [JsonProperty("status")]
        public PrescriptionStatusEnum? Status { get; set; }

        /// <summary>
        /// The internal accession ID for this document. Format depends on the system the ID belongs to.
        /// </summary>
        [JsonProperty("internalaccessionid")]
        public string InternalAccessionId { get; set; }

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
        /// NPI (National Provider Identity) of the provider for this prescription.
        /// </summary>
        [JsonProperty("providernpi")]
        public string ProviderNPI { get; set; }

        /// <summary>
        /// Description of the document type
        /// </summary>
        [JsonProperty("documentdescription")]
        public string DocumentDescription { get; set; }

        /// <summary>
        /// Explains method by which the document was entered into the AthenaNet (INTERFACE
        /// (digital), FAX, etc.)
        /// </summary>
        [JsonProperty("documentroute")]
        public string DocumentRoute { get; set; }

        /// <summary>
        /// Explains where this document originated.
        /// </summary>
        [JsonProperty("documentsource")]
        public string DocumentSource { get; set; }

        /// <summary>
        /// Specific type of document
        /// </summary>
        [JsonProperty("documentsubclass")]
        public string DocumentSubclass { get; set; }

        /// <summary>
        /// Encounter ID
        /// </summary>
        [JsonProperty("encounterid")]
        public int? EncounterId { get; set; }

        /// <summary>
        /// Document priority, when available. 1 is high, 2 is normal. Some labs use other numbers or
        /// characters that are lab-specific.
        /// </summary>
        [JsonProperty("priority")]
        public string Priority { get; set; }

        /// <summary>
        /// Date/time (ISO 8601) the observation was taken
        /// </summary>
        [JsonProperty("observationdatetime")]
        public string ObservationDateTime { get; set; }

        /// <summary>
        /// Subject of the document
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// List of codes indicating why the order was not given. If this field is not present, the
        /// order was not declined. If the array is empty, no reason has been chosen.
        /// </summary>
        [JsonProperty("declinedreason")]
        public Reason[] DeclinedReason { get; set; }

        /// <summary>
        /// The appointment ID for this document
        /// </summary>
        [JsonProperty("appointmentid")]
        public int? AppointmentId { get; set; }

        /// <summary>
        /// The patient case id
        /// </summary>
        [JsonProperty("patientcaseid")]
        public int? PatientCaseId { get; set; }

        /// <summary>
        /// Department for the document
        /// </summary>
        [JsonProperty("departmentid")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Person the document is assigned to
        /// </summary>
        [JsonProperty("assignedto")]
        public string AssignedTo { get; set; }

        /// <summary>
        /// Date/time (ISO 8601) the document was deleted
        /// </summary>
        [JsonProperty("deleteddatetime")]
        public string DeletedDateTime { get; set; }

        /// <summary>
        /// A specific document type identifier.
        /// </summary>
        [JsonProperty("documenttypeid")]
        public int? DocumentTypeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("observationdate")]
        public string ObservationDate { get; set; }

        /// <summary>
        /// A number corresponding to the level of restriction the drug is placed under by the DEA.
        /// </summary>
        [JsonProperty("deaschedule")]
        public int? DeaSchedule { get; set; }

        /// <summary>
        /// Class of document
        /// </summary>
        [JsonProperty("documentclass")]
        public string DocumentClass { get; set; }

        /// <summary>
        /// Ordering Mode for a prescription. One of Prescribe, Adminster, Dispense
        /// </summary>
        [JsonProperty("orderingmode")]
        public string OrderingMode { get; set; }

        /// <summary>
        /// ID of a prescription document
        /// </summary>
        [JsonProperty("prescriptionid")]
        public int? Id { get; set; }

        /// <summary>
        /// External note for the patient.
        /// </summary>
        [JsonProperty("externalnote")]
        public string ExternalNote { get; set; }

        /// <summary>
        /// Order ID of the order this document is tied to, if any
        /// </summary>
        [JsonProperty("tietoorderid")]
        public int? TieToOrderId { get; set; }

        /// <summary>
        /// The ID of the clinical provider associated with this clinical document. Clinical
        /// providers are a master list of providers throughout the country. These include providers
        /// as well as radiology centers, labs and pharmacies.
        /// </summary>
        [JsonProperty("facilityid")]
        public int? FacilityId { get; set; }

        /// <summary>
        /// The user-facing description of the reason the order was not given.
        /// </summary>
        [JsonProperty("declinedreasontext")]
        public string DeclinedReasonText { get; set; }

        public class Reason
        {
            /// <summary>
            /// The code indicating why the order was not given.
            /// </summary>
            [JsonProperty("code")]
            public string Code { get; set; }

            /// <summary>
            /// The codeset that the code belongs to.
            /// </summary>
            [JsonProperty("codeset")]
            public string Codeset { get; set; }

            /// <summary>
            /// The plaintext description of the reason the order was not given.
            /// </summary>
            [JsonProperty("description")]
            public string Description { get; set; }
        }
    }
}
