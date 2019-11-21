using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using System;

// ReSharper disable StringLiteralTypo
// ReSharper disable once CommentTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class PatientMedication
    {
        /// <summary>
        /// The list of medications
        /// </summary>
        [JsonProperty("medications")]
        public Medication[][] Medications { get; set; }

        /// <summary>
        /// Whether the patient explicitly has no reported medications
        /// </summary>
        [JsonProperty("nomedicationsreported")]
        public bool NoMedicationsReported { get; set; }

        /// <summary>
        /// A section-wide note
        /// </summary>
        [JsonProperty("sectionnote")]
        public string SectionNote { get; set; }

        /// <summary>
        /// The last time any of the medications were updated
        /// </summary>
        [JsonProperty("lastupdated")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Whether or not the patient has consented to have their medication history downloaded.
        /// There are plans to deprecate this field.
        /// </summary>
        [JsonProperty("patientdownloadconsent")]
        public bool PatientDownloadConsent { get; set; }

        /// <summary>
        /// Whether or not the patient needs to consent to have medication history downloaded. This
        /// will be true if either the patient has not currently consented, or the practice is not
        /// enabled for these downloads. This field is typically used when determining whether to
        /// message to the patient that they have not consented to these downloads. Note that
        /// regardless of this setting, medication history that has already been downloaded will
        /// remain available.
        /// </summary>
        [JsonProperty("patientneedsdownloadconsent")]
        public bool PatientNeedsDownloadConsent { get; set; }

        /// <summary>
        /// The time of the last attempted medication history download from SureScripts.
        /// </summary>
        [JsonProperty("lastdownloadeddate")]
        public string LastDownloadedDate { get; set; }

        /// <summary>
        /// BETA FIELD: Whether or not the last medication history download was denied.
        /// </summary>
        [JsonProperty("lastdownloaddenied")]
        public bool LastDownloadDenied { get; set; }

        /// <summary>
        /// BETA FIELD: The reason the last medication history download was denied.
        /// </summary>
        [JsonProperty("lastdownloaddenialreason")]
        public string LastDownloadDenialReason { get; set; }

        public class Medication
        {
            [JsonProperty("clinicalordertypeid")]
            public string ClinicalOrderTypeId { get; set; }

            [JsonProperty("lastmodifieddate")]
            [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
            public DateTime? LastModifiedDate { get; set; }

            [JsonProperty("lastmodifiedby")]
            public string LastModifiedBy { get; set; }

            [JsonProperty("fdbmedicationid")]
            public string FdbMedicationId { get; set; }

            [JsonProperty("fdbgenericmedicationnameid")]
            public string FdbGenericMedicationNameId { get; set; }

            /// <summary>
            /// The list of events for this medication. Can be START, END, ORDER, ENTER, FILL, or HIDE.
            /// </summary>
            [JsonProperty("events")]
            public Event[] Events { get; set; }

            /// <summary>
            /// Components of the structured sig.
            /// </summary>
            [JsonProperty("structuredsig")]
            public StructuredSigModel StructuredSig { get; set; }

            /// <summary>
            /// Primary ID for this medication entry. Those starting with C are clinical
            /// prescriptions, and those starting with H are historical (entered, downloaded, etc).
            /// </summary>
            [JsonProperty("medicationentryid")]
            public string MedicationEntryId { get; set; }

            /// <summary>
            /// Athena ID for this medication.
            /// </summary>
            [JsonProperty("medicationid")]
            public int? MedicationId { get; set; }

            /// <summary>
            /// The name of the medication.
            /// </summary>
            [JsonProperty("medication")]
            public string Name { get; set; }

            /// <summary>
            /// Whether the sig for this entry is structured.
            /// </summary>
            [JsonProperty("isstructuredsig")]
            public bool IsStructuredSig { get; set; }

            /// <summary>
            /// The unstructured sig for this medication, if any. If there is a structured sig, this
            /// will contain the formatted version of that sig.
            /// </summary>
            [JsonProperty("unstructuredsig")]
            public string UnstructuredSig { get; set; }

            /// <summary>
            /// How this medication was entered. This can be the ordering provider, a medication
            /// history download (express scripts, medco, etc), ATHENA (which means it was entered
            /// manually), etc.
            /// </summary>
            [JsonProperty("source")]
            public string Source { get; set; }

            /// <summary>
            /// The status of this medication. Medications in PEND status are associated with
            /// approved future orders and have not yet been submitted.
            /// </summary>
            [JsonProperty("status")]
            public string Status { get; set; }

            /// <summary>
            /// The organ class for this medication. This is equivalent to a medication class.
            /// </summary>
            [JsonProperty("organclass")]
            public string OrganClass { get; set; }

            /// <summary>
            /// The therapeutic class for this medication. This is equivalent to a medication subclass.
            /// </summary>
            [JsonProperty("therapeuticclass")]
            public string TherapeuticClass { get; set; }

            /// <summary>
            /// The date a medication will be submitted. Included if the medication is in PEND status
            /// and attached to a approved future order.
            /// </summary>
            [JsonProperty("futuresubmitdate")]
            public string FutureSubmitDate { get; set; }

            /// <summary>
            /// If this was a prescription, this contains the ID of the encounter where it was
            /// ordered or administered
            /// </summary>
            [JsonProperty("encounterid")]
            public int? EncounterId { get; set; }

            /// <summary>
            /// The athenaNet username of the person who entered or ordered the medication.
            /// Downloaded medications have INTERFACE for this field.
            /// </summary>
            [JsonProperty("createdby")]
            public string CreatedBy { get; set; }

            /// <summary>
            /// For clinical prescriptions, the athenaNet username of the person who approved this prescription.
            /// </summary>
            [JsonProperty("approvedby")]
            public string ApprovedBy { get; set; }

            /// <summary>
            /// The billing NDC code for this medication.
            /// </summary>
            [JsonProperty("billingndc")]
            public string BillingNDC { get; set; }

            /// <summary>
            /// The ordering mode for prescriptions. Can be PRESCRIBE, DISPENSE, or ADMINISTER.
            /// </summary>
            [JsonProperty("orderingmode")]
            public string OrderingMode { get; set; }

            /// <summary>
            /// The total quantity prescribed, dispensed, administered. This is not currently
            /// available for historical (downloaded) medications.
            /// </summary>
            [JsonProperty("quantity")]
            public int? Quantity { get; set; }

            /// <summary>
            /// The unit of the quantity. Example: tablets, sprays, etc.
            /// </summary>
            [JsonProperty("quantityunit")]
            public string QuantityUnit { get; set; }

            /// <summary>
            /// The number of refills allowed when this medication was ordered.
            /// </summary>
            [JsonProperty("refillsallowed")]
            public int? RefillsAllowed { get; set; }

            /// <summary>
            /// </summary>
            [JsonProperty("issafetorenew")]
            public bool IsSafeToRenew { get; set; }

            /// <summary>
            /// The reason why this medication was stopped.
            /// </summary>
            [JsonProperty("stopreason")]
            public string StopReason { get; set; }

            /// <summary>
            /// Non-patient facing note for ths prescription. Labeled "internal note" in the UI.
            /// </summary>
            [JsonProperty("providernote")]
            public string ProviderNote { get; set; }

            /// <summary>
            /// Patient-facing note for this prescription. Labeled "note" in the UI.
            /// </summary>
            [JsonProperty("patientnote")]
            public string PatientNote { get; set; }

            /// <summary>
            /// The name of the pharmacy where this medication was filled.
            /// </summary>
            [JsonProperty("pharmacy")]
            public string Pharmacy { get; set; }

            /// <summary>
            /// The NCPDP ID of the pharmacy for this medication.. See http://www.ncpdp.org/ for details.
            /// </summary>
            [JsonProperty("pharmacyncpdpid")]
            public string PharmacyNcpdpId { get; set; }

            /// <summary>
            /// The user who prescribed this medication.
            /// </summary>
            [JsonProperty("prescribedby")]
            public string PrescribedBy { get; set; }

            /// <summary>
            /// The list of NDC numbers that correspond to this medication.
            /// </summary>
            [JsonProperty("ndcoptions")]
            public string[] NdcOptions { get; set; }

            /// <summary>
            /// The list of RxNorm Identifiers that correspond to this medication. This list may
            /// contain both branded and generic identifiers
            /// </summary>
            [JsonProperty("rxnorm")]
            public string[] RxNorm { get; set; }

            /// <summary>
            /// The route for the prescription.
            /// </summary>
            [JsonProperty("route")]
            public string Route { get; set; }

            public class Event
            {
                /// <summary>
                /// The event type. Can be START, END, ORDER, ENTER, FILL, or HIDE.
                /// </summary>
                [JsonProperty("type")]
                public string Type { get; set; }

                /// <summary>
                /// The date this event occurred
                /// </summary>
                [JsonProperty("eventdate")]
                [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
                public DateTime? EventDate { get; set; }

                /// <summary>
                /// The display name for the user most relevant for this event. May be null.
                /// </summary>
                [JsonProperty("userdisplayname")]
                public string UserDisplayName { get; set; }
            }

            public class StructuredSigModel
            {
                /// <summary>
                /// How the medication is taken. Examples are Chew, Take, Inhale, etc.
                /// </summary>
                [JsonProperty("dosageaction")]
                public string DosageAction { get; set; }

                /// <summary>
                /// How many of this med is taken.
                /// </summary>
                [JsonProperty("dosagequantityvalue")]
                public int? DosageQuantityValue { get; set; }

                /// <summary>
                /// The unit of the quantity. Example: tablets, sprays, etc.
                /// </summary>
                [JsonProperty("dosagequantityunit")]
                public string DosageQuantityUnit { get; set; }

                /// <summary>
                /// How many times (in the given time unit) this should be taken.
                /// </summary>
                [JsonProperty("dosagefrequencyvalue")]
                public double? DosageFrequencyBalue { get; set; }

                /// <summary>
                /// The unit of the frequency. Example: per day, per week.
                /// </summary>
                [JsonProperty("dosagefrequencyunit")]
                public string DosageFrequencyUnit { get; set; }

                /// <summary>
                /// A standardized patient-friendly frequency. Example: 6 per day becomes "every 4 hours".
                /// </summary>
                [JsonProperty("dosagefrequencydescription")]
                public string DosageFrequencyDescription { get; set; }

                /// <summary>
                /// How this medication is taken. Example: oral, inhalation, intranasal, etc.
                /// </summary>
                [JsonProperty("dosageroute")]
                public string DosageRoute { get; set; }

                /// <summary>
                /// Additional instructions. Example: with meals
                /// </summary>
                [JsonProperty("dosageadditionalinstructions")]
                public string DosageAdditionalInstructions { get; set; }

                /// <summary>
                /// How many duration time units this medication should be taken for.
                /// </summary>
                [JsonProperty("dosagedurationvalue")]
                public int? DosageDurationValue { get; set; }

                /// <summary>
                /// The unit of the duration. Example: days. So take this for days.
                /// </summary>
                [JsonProperty("dosagedurationunit")]
                public string DosageDurationUnit { get; set; }
            }
        }
    }
}
