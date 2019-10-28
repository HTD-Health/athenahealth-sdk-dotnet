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
        [JsonProperty(PropertyName = "notelastmodifieddatetime")]
        public DateTime? NoteLastModifiedDateTime { get; set; }

        /// <summary>
        /// A section-wide note
        /// </summary>
        [JsonProperty(PropertyName = "sectionnote")]
        public string SectionNote { get; set; }

        [OnError]
        internal void OnError(StreamingContext context, ErrorContext errorContext)
        {
            if (errorContext.Member is string property)
            {
                if (property == "lastupdated") // Deprecated property
                    errorContext.Handled = true;
            }
        }

        /// <summary>
        /// Allergies
        /// </summary>
        [JsonProperty(PropertyName = "allergies")]
        public Allergy[] Allergies { get; set; }

        /// <summary>
        /// The username of the user who last modified the note, nkda, or allergies.
        /// </summary>
        [JsonProperty(PropertyName = "lastmodifiedby")]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Whether the patient has no known drug allergies. This is an explicit statement separate from a patient with no documented allergies so far.
        /// </summary>
        [JsonProperty(PropertyName = "nkda")]
        public bool? NoKnownDrugAllergies { get; set; }

        /// <summary>
        /// The date and time the note, nkda, or allergies were last updated.
        /// </summary>
        [JsonProperty(PropertyName = "lastmodifieddatetime")]
        public DateTime? LastModifiedDateTime { get; set; }

        /// <summary>
        /// The username of the user who last modified the note.
        /// </summary>
        [JsonProperty(PropertyName = "notelastmodifiedby")]
        public string NoteLastModifiedBy { get; set; }

        public class Allergy
        {
            /// <summary>
            /// Date of allergy deactivation. Set to deactivate the allergy
            /// </summary>
            [JsonProperty(PropertyName = "deactivatedate")]
            [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
            public DateTime? DeactivateDate { get; set; }
           
            [JsonProperty(PropertyName = "rxnormdescription")]
            public string RxNormDescription { get; set; }

             [JsonProperty(PropertyName = "rxnormcode")]
            public string RxNormCode { get; set; }

            /// <summary>
            /// The name of the allergen.
            /// </summary>
            [JsonProperty(PropertyName = "allergenname")]
            public string AllergenName { get; set; }

            /// <summary>
            /// Athena ID for this allergen.
            /// </summary>
            [JsonProperty(PropertyName = "allergenid")]
            public int? AllergenId { get; set; }

            /// <summary>
            /// The username of the user who last modified this allergy.
            /// </summary>
            [JsonProperty(PropertyName = "lastmodifiedby")]
            public string LastModifiedBy { get; set; }

            /// <summary>
            /// Note about this allergy
            /// </summary>
            [JsonProperty(PropertyName = "note")]
            public string Note { get; set; }

            /// <summary>
            /// List of documented reactions
            /// </summary>
            [JsonProperty(PropertyName = "reactions")]
            public Reaction[] Reactions { get; set; }

            /// <summary>
            /// Date of allergy onset
            /// </summary>
            [JsonProperty(PropertyName = "onsetdate")]
            [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
            public DateTime? OnsetDate { get; set; }

            /// <summary>
            /// The date and time the allergy was last modified.
            /// </summary>
            [JsonProperty(PropertyName = "lastmodifieddatetime")]
            public DateTime? LastModifiedDateTime { get; set; }

            /// <summary>
            /// The name of the user who deactivated the allergy.
            /// </summary>
            [JsonProperty(PropertyName = "deactivateduser")]
            public string DeactivatedUser { get; set; }

            public class Reaction
            {
                /// <summary>
                /// Severity of the reaction
                /// </summary>
                [JsonProperty(PropertyName = "severity")]
                public string Severity { get; set; }

                /// <summary>
                /// SNOMED code for the severity of this reaction
                /// </summary>
                [JsonProperty(PropertyName = "severitysnomedcode")]
                public string SeveritySnomedCode { get; set; }

                /// <summary>
                /// SNOMED code for this reaction
                /// </summary>
                [JsonProperty(PropertyName = "snomedcode")]
                public string SnomedCode { get; set; }

                /// <summary>
                /// Name of the reaction
                /// </summary>
                [JsonProperty(PropertyName = "reactionname")]
                public string ReactionName { get; set; }
            }
        }
    }
}
