using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Runtime.Serialization;

// ReSharper disable StringLiteralTypo
// ReSharper disable once CommentTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class PatientAllergy
    {
        /// <summary>
        /// The date and time the note was last updated.
        /// </summary>
        [JsonProperty("notelastmodifieddatetime")]
        public DateTime? NoteLastModifiedDateTime { get; set; }

        /// <summary>
        /// A section-wide note
        /// </summary>
        [JsonProperty("sectionnote")]
        public string SectionNote { get; set; }

        /// <summary>
        /// Allergies
        /// </summary>
        [JsonProperty("allergies")]
        public Allergy[] Allergies { get; set; }

        /// <summary>
        /// The username of the user who last modified the note, nkda, or allergies.
        /// </summary>
        [JsonProperty("lastmodifiedby")]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Whether the patient has no known drug allergies. This is an explicit statement separate
        /// from a patient with no documented allergies so far.
        /// </summary>
        [JsonProperty("nkda")]
        public bool? NoKnownDrugAllergies { get; set; }

        /// <summary>
        /// The date and time the note, nkda, or allergies were last updated.
        /// </summary>
        [JsonProperty("lastmodifieddatetime")]
        public DateTime? LastModifiedDateTime { get; set; }

        /// <summary>
        /// The username of the user who last modified the note.
        /// </summary>
        [JsonProperty("notelastmodifiedby")]
        public string NoteLastModifiedBy { get; set; }

        [OnError]
        internal void OnError(StreamingContext context, ErrorContext errorContext)
        {
            if (errorContext.Member is string property)
            {
                if (property == "lastupdated") // Deprecated property
                    errorContext.Handled = true;
            }
        }

        public class Allergy
        {
            /// <summary>
            /// Date of allergy deactivation. Set to deactivate the allergy
            /// </summary>
            [JsonProperty("deactivatedate")]
            [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
            public DateTime? DeactivateDate { get; set; }

            [JsonProperty("rxnormdescription")]
            public string RxNormDescription { get; set; }

            [JsonProperty("rxnormcode")]
            public string RxNormCode { get; set; }

            /// <summary>
            /// The name of the allergen.
            /// </summary>
            [JsonProperty("allergenname")]
            public string AllergenName { get; set; }

            /// <summary>
            /// Athena ID for this allergen.
            /// </summary>
            [JsonProperty("allergenid")]
            public int? AllergenId { get; set; }

            /// <summary>
            /// The username of the user who last modified this allergy.
            /// </summary>
            [JsonProperty("lastmodifiedby")]
            public string LastModifiedBy { get; set; }

            /// <summary>
            /// Note about this allergy
            /// </summary>
            [JsonProperty("note")]
            public string Note { get; set; }

            /// <summary>
            /// List of documented reactions
            /// </summary>
            [JsonProperty("reactions")]
            public Reaction[] Reactions { get; set; }

            /// <summary>
            /// Date of allergy onset
            /// </summary>
            [JsonProperty("onsetdate")]
            [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
            public DateTime? OnsetDate { get; set; }

            /// <summary>
            /// The date and time the allergy was last modified.
            /// </summary>
            [JsonProperty("lastmodifieddatetime")]
            public DateTime? LastModifiedDateTime { get; set; }

            /// <summary>
            /// The name of the user who deactivated the allergy.
            /// </summary>
            [JsonProperty("deactivateduser")]
            public string DeactivatedUser { get; set; }

            public class Reaction
            {
                /// <summary>
                /// Severity of the reaction
                /// </summary>
                [JsonProperty("severity")]
                public string Severity { get; set; }

                /// <summary>
                /// SNOMED code for the severity of this reaction
                /// </summary>
                [JsonProperty("severitysnomedcode")]
                public string SeveritySnomedCode { get; set; }

                /// <summary>
                /// SNOMED code for this reaction
                /// </summary>
                [JsonProperty("snomedcode")]
                public string SnomedCode { get; set; }

                /// <summary>
                /// Name of the reaction
                /// </summary>
                [JsonProperty("reactionname")]
                public string ReactionName { get; set; }
            }
        }
    }
}
