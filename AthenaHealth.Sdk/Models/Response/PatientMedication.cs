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
        [JsonProperty(PropertyName = "medications")]
        public Medication[][] Medications { get; set; }

        /// <summary>
        /// Whether the patient explicitly has no reported medications
        /// </summary>
        [JsonProperty(PropertyName = "nomedicationsreported")]
        public bool NoMedicationsReported { get; set; }

        /// <summary>
        /// A section-wide note
        /// </summary>
        [JsonProperty(PropertyName = "sectionnote")]
        public string SectionNote { get; set; }

        /// <summary>
        /// The last time any of the medications were updated
        /// </summary>
        [JsonProperty(PropertyName = "lastupdated")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Whether or not the patient has consented to have their medication history downloaded.
        /// There are plans to deprecate this field.
        /// </summary>
        [JsonProperty(PropertyName = "patientdownloadconsent")]
        public bool PatientDownloadConsent { get; set; }

        /// <summary>
        /// Whether or not the patient needs to consent to have medication history downloaded. This
        /// will be true if either the patient has not currently consented, or the practice is not
        /// enabled for these downloads. This field is typically used when determining whether to
        /// message to the patient that they have not consented to these downloads. Note that
        /// regardless of this setting, medication history that has already been downloaded will
        /// remain available.
        /// </summary>
        [JsonProperty(PropertyName = "patientneedsdownloadconsent")]
        public bool PatientNeedsDownloadConsent { get; set; }

        /// <summary>
        /// The time of the last attempted medication history download from SureScripts.
        /// </summary>
        [JsonProperty(PropertyName = "lastdownloadeddate")]
        public string LastDownloadedDate { get; set; }

        /// <summary>
        /// BETA FIELD: Whether or not the last medication history download was denied.
        /// </summary>
        [JsonProperty(PropertyName = "lastdownloaddenied")]
        public bool LastDownloadDenied { get; set; }

        /// <summary>
        /// BETA FIELD: The reason the last medication history download was denied.
        /// </summary>
        [JsonProperty(PropertyName = "lastdownloaddenialreason")]
        public string LastDownloadDenialReason { get; set; }

        public class Medication
        {
            [JsonProperty(PropertyName = "clinicalordertypeid")]
            public string ClinicalOrderTypeId { get; set; } 

             [JsonProperty(PropertyName = "lastmodifieddate")]
            [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
            public DateTime? LastModifiedDate { get; set; } 
            
             [JsonProperty(PropertyName = "lastmodifiedby")]
            public string LastModifiedBy { get; set; } 

            [JsonProperty(PropertyName = "fdbmedicationid")]
            public string FdbMedicationId { get; set; } 

             [JsonProperty(PropertyName = "fdbgenericmedicationnameid")]
            public string FdbGenericMedicationNameId { get; set; } 
            
            /// <summary>
            /// The list of events for this medication. Can be START, END, ORDER, ENTER, FILL, or HIDE.
            /// </summary>
            [JsonProperty(PropertyName = "events")]
            public Event[] Events { get; set; }

            /// <summary>
            /// Components of the structured sig.
            /// </summary>
            [JsonProperty(PropertyName = "structuredsig")]
            public StructuredSigModel StructuredSig { get; set; }

            /// <summary>
            /// Primary ID for this medication entry. Those starting with C are clinical
            /// prescriptions, and those starting with H are historical (entered, downloaded, etc).
            /// </summary>
            [JsonProperty(PropertyName = "medicationentryid")]
            public string MedicationEntryId { get; set; }

            /// <summary>
            /// Athena ID for this medication.
            /// </summary>
            [JsonProperty(PropertyName = "medicationid")]
            public int? MedicationId { get; set; }

            /// <summary>
            /// The name of the medication.
            /// </summary>
            [JsonProperty(PropertyName = "medication")]
            public string Name { get; set; }

            /// <summary>
            /// Whether the sig for this entry is structured.
            /// </summary>
            [JsonProperty(PropertyName = "isstructuredsig")]
            public bool IsStructuredSig { get; set; }

            /// <summary>
            /// The unstructured sig for this medication, if any. If there is a structured sig, this
            /// will contain the formatted version of that sig.
            /// </summary>
            [JsonProperty(PropertyName = "unstructuredsig")]
            public string UnstructuredSig { get; set; }

            /// <summary>
            /// How this medication was entered. This can be the ordering provider, a medication
            /// history download (express scripts, medco, etc), ATHENA (which means it was entered
            /// manually), etc.
            /// </summary>
            [JsonProperty(PropertyName = "source")]
            public string Source { get; set; }

            /// <summary>
            /// The status of this medication. Medications in PEND status are associated with
            /// approved future orders and have not yet been submitted.
            /// </summary>
            [JsonProperty(PropertyName = "status")]
            public string Status { get; set; }

            /// <summary>
            /// The organ class for this medication. This is equivalent to a medication class.
            /// </summary>
            [JsonProperty(PropertyName = "organclass")]
            public string OrganClass { get; set; }

            /// <summary>
            /// The therapeutic class for this medication. This is equivalent to a medication subclass.
            /// </summary>
            [JsonProperty(PropertyName = "therapeuticclass")]
            public string TherapeuticClass { get; set; }

            /// <summary>
            /// The date a medication will be submitted. Included if the medication is in PEND status
            /// and attached to a approved future order.
            /// </summary>
            [JsonProperty(PropertyName = "futuresubmitdate")]
            public string FutureSubmitDate { get; set; }

            /// <summary>
            /// If this was a prescription, this contains the ID of the encounter where it was
            /// ordered or administered
            /// </summary>
            [JsonProperty(PropertyName = "encounterid")]
            public int? EncounterId { get; set; }

            /// <summary>
            /// The athenaNet username of the person who entered or ordered the medication.
            /// Downloaded medications have INTERFACE for this field.
            /// </summary>
            [JsonProperty(PropertyName = "createdby")]
            public string CreatedBy { get; set; }

            /// <summary>
            /// For clinical prescriptions, the athenaNet username of the person who approved this prescription.
            /// </summary>
            [JsonProperty(PropertyName = "approvedby")]
            public string ApprovedBy { get; set; }

            /// <summary>
            /// The billing NDC code for this medication.
            /// </summary>
            [JsonProperty(PropertyName = "billingndc")]
            public string BillingNDC { get; set; }

            /// <summary>
            /// The ordering mode for prescriptions. Can be PRESCRIBE, DISPENSE, or ADMINISTER.
            /// </summary>
            [JsonProperty(PropertyName = "orderingmode")]
            public string OrderingMode { get; set; }

            /// <summary>
            /// The total quantity prescribed, dispensed, administered. This is not currently
            /// available for historical (downloaded) medications.
            /// </summary>
            [JsonProperty(PropertyName = "quantity")]
            public int? Quantity { get; set; }

            /// <summary>
            /// The unit of the quantity. Example: tablets, sprays, etc.
            /// </summary>
            [JsonProperty(PropertyName = "quantityunit")]
            public string QuantityUnit { get; set; }

            /// <summary>
            /// The number of refills allowed when this medication was ordered.
            /// </summary>
            [JsonProperty(PropertyName = "refillsallowed")]
            public int? RefillsAllowed { get; set; }

            /// <summary>
            /// </summary>
            [JsonProperty(PropertyName = "issafetorenew")]
            public bool IsSafeToRenew { get; set; }

            /// <summary>
            /// The reason why this medication was stopped.
            /// </summary>
            [JsonProperty(PropertyName = "stopreason")]
            public string StopReason { get; set; }

            /// <summary>
            /// Non-patient facing note for ths prescription. Labeled "internal note" in the UI.
            /// </summary>
            [JsonProperty(PropertyName = "providernote")]
            public string ProviderNote { get; set; }

            /// <summary>
            /// Patient-facing note for this prescription. Labeled "note" in the UI.
            /// </summary>
            [JsonProperty(PropertyName = "patientnote")]
            public string PatientNote { get; set; }

            /// <summary>
            /// The name of the pharmacy where this medication was filled.
            /// </summary>
            [JsonProperty(PropertyName = "pharmacy")]
            public string Pharmacy { get; set; }

            /// <summary>
            /// The NCPDP ID of the pharmacy for this medication.. See http://www.ncpdp.org/ for details.
            /// </summary>
            [JsonProperty(PropertyName = "pharmacyncpdpid")]
            public string PharmacyNcpdpId { get; set; }

            /// <summary>
            /// The user who prescribed this medication.
            /// </summary>
            [JsonProperty(PropertyName = "prescribedby")]
            public string PrescribedBy { get; set; }

            /// <summary>
            /// The list of NDC numbers that correspond to this medication.
            /// </summary>
            [JsonProperty(PropertyName = "ndcoptions")]
            public string[] NdcOptions { get; set; }

            /// <summary>
            /// The list of RxNorm Identifiers that correspond to this medication. This list may
            /// contain both branded and generic identifiers
            /// </summary>
            [JsonProperty(PropertyName = "rxnorm")]
            public string[] RxNorm { get; set; }

            /// <summary>
            /// The route for the prescription.
            /// </summary>
            [JsonProperty(PropertyName = "route")]
            public string Route { get; set; }

            public class Event
            {
                /// <summary>
                /// The event type. Can be START, END, ORDER, ENTER, FILL, or HIDE.
                /// </summary>
                [JsonProperty(PropertyName = "type")]
                public string Type { get; set; }

                /// <summary>
                /// The date this event occurred
                /// </summary>
                [JsonProperty(PropertyName = "eventdate")]
                [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
                public DateTime? EventDate { get; set; }

                /// <summary>
                /// The display name for the user most relevant for this event. May be null.
                /// </summary>
                [JsonProperty(PropertyName = "userdisplayname")]
                public string UserDisplayName { get; set; }
            }

            public class StructuredSigModel
            {
                /// <summary>
                /// How the medication is taken. Examples are Chew, Take, Inhale, etc.
                /// </summary>
                [JsonProperty(PropertyName = "dosageaction")]
                public string DosageAction { get; set; }

                /// <summary>
                /// How many of this med is taken.
                /// </summary>
                [JsonProperty(PropertyName = "dosagequantityvalue")]
                public int? DosageQuantityValue { get; set; }

                /// <summary>
                /// The unit of the quantity. Example: tablets, sprays, etc.
                /// </summary>
                [JsonProperty(PropertyName = "dosagequantityunit")]
                public string DosageQuantityUnit { get; set; }

                /// <summary>
                /// How many times (in the given time unit) this should be taken.
                /// </summary>
                [JsonProperty(PropertyName = "dosagefrequencyvalue")]
                public double? DosageFrequencyBalue { get; set; }

                /// <summary>
                /// The unit of the frequency. Example: per day, per week.
                /// </summary>
                [JsonProperty(PropertyName = "dosagefrequencyunit")]
                public string DosageFrequencyUnit { get; set; }

                /// <summary>
                /// A standardized patient-friendly frequency. Example: 6 per day becomes "every 4 hours".
                /// </summary>
                [JsonProperty(PropertyName = "dosagefrequencydescription")]
                public string DosageFrequencyDescription { get; set; }

                /// <summary>
                /// How this medication is taken. Example: oral, inhalation, intranasal, etc.
                /// </summary>
                [JsonProperty(PropertyName = "dosageroute")]
                public string DosageRoute { get; set; }

                /// <summary>
                /// Additional instructions. Example: with meals
                /// </summary>
                [JsonProperty(PropertyName = "dosageadditionalinstructions")]
                public string DosageAdditionalInstructions { get; set; }

                /// <summary>
                /// How many duration time units this medication should be taken for.
                /// </summary>
                [JsonProperty(PropertyName = "dosagedurationvalue")]
                public int? DosageDurationValue { get; set; }

                /// <summary>
                /// The unit of the duration. Example: days. So take this for days.
                /// </summary>
                [JsonProperty(PropertyName = "dosagedurationunit")]
                public string DosageDurationUnit { get; set; }
            }
        }
    }
}
