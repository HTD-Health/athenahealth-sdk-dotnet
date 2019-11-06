using System;
using System.ComponentModel.DataAnnotations;
using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo

namespace AthenaHealth.Sdk.Models.Request
{
    public class SetPatientAllergies
    {
        public SetPatientAllergies(int departmentId, int patientId)
        {
            DepartmentId = departmentId;
            PatientId = patientId;
        }
        /// <summary>
        /// The ID of the department for this patient. A patient may have multiple charts, and the department determines which chart to use.
        /// </summary>
        [JsonProperty("departmentid")]
        [Required]
        public int DepartmentId  { get; set; }

        /// <summary>
        /// The ID of the patient
        /// </summary>
        [JsonProperty("patientid")]
        [Required]
        public int PatientId  { get; set; }
        
        /// <summary>
        /// Allergies
        /// </summary>
        [JsonProperty("allergies")]
        public Allergy[] Allergies { get; set; }

        /// <summary>
        /// Whether the patient has no known drug allergies. This is an explicit statement separate from a patient with no documented allergies so far. Note that while a patient can have this checked and have allergies, that is not recommended.
        /// </summary>
        [JsonProperty("nkda")]
        public bool? NoKnownDrugAllergies { get; set; }

        /// <summary>
        /// A section-wide note. Passing an empty string will remove any existing note.
        /// </summary>
        [JsonProperty("sectionnote")]
        public string SectionNote { get; set; }


        public class Allergy
        {
            /// <summary>
            /// Athena ID for this allergen.
            /// </summary>
            [JsonProperty("allergenid")]
            public int Id { get; set; }

            /// <summary>
            /// Date of allergy deactivation. Set to deactivate the allergy
            /// </summary>
            [JsonProperty("deactivatedate")]
            [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
            public DateTime? DeactivateDate { get; set; }

            /// <summary>
            /// The name of the allergen.
            /// </summary>
            [JsonProperty("allergenname")]
            public string AllergenName { get; set; }

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
            /// Date of allergy reactivation. Set to reactivate the allergy
            /// </summary>
            [JsonProperty("reactivatedate")]
            [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
            public DateTime? ReactivateDate { get; set; }

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