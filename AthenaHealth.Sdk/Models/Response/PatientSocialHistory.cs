using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using System;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class PatientSocialHistory
    {
        /// <summary>
        /// The selected social history templates for this patient.
        /// </summary>
        [JsonProperty("templates")]
        public Template[] Templates { get; set; }

        /// <summary>
        /// The social history questions and answers for this patient.
        /// </summary>
        [JsonProperty("questions")]
        public Question[] Questions { get; set; }

        /// <summary>
        /// A section-wide note.
        /// </summary>
        [JsonProperty("sectionnote")]
        public string SectionNote { get; set; }

        public class Template
        {
            /// <summary>
            /// ID for this social history template
            /// </summary>
            [JsonProperty("templateid")]
            public int? Id { get; set; }

            /// <summary>
            /// Name for this social history template
            /// </summary>
            [JsonProperty("templatename")]
            public string Name { get; set; }
        }

        public class Question
        {
            [JsonProperty("socialhistorystatus")]
            public string SocialHistoryStatus { get; set; }


            /// <summary>
            /// The patient answer to this question
            /// </summary>
            [JsonProperty("answer")]
            public string Answer { get; set; }

            /// <summary>
            /// Unique ID for this question within this template.
            /// </summary>
            [JsonProperty("questionid")]
            public int? Id { get; set; }

            /// <summary>
            /// Unique key for this question, can exist in multiple templates.
            /// </summary>
            [JsonProperty("key")]
            public string Key { get; set; }

            /// <summary>
            /// Human readable question
            /// </summary>
            [JsonProperty("question")]
            public string QuestionText { get; set; }

            /// <summary>
            /// Display ordering for this question within this template
            /// </summary>
            [JsonProperty("ordering")]
            public int? Ordering { get; set; }

            /// <summary>
            /// The template where this question is listed. If it exists on multiple templates, then only one of them.
            /// </summary>
            [JsonProperty("templateid")]
            public int? TemplateId { get; set; }

            /// <summary>
            /// The notes associated with this question.
            /// </summary>
            [JsonProperty("note")]
            public string Note { get; set; }

            /// <summary>
            /// The date this answer was last updated (or first answered if never updated).
            /// </summary>
            [JsonProperty("lastupdated")]
            [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
            public DateTime? LastUpdated { get; set; }

            /// <summary>
            /// The date this note was last updated (or first added if never updated).
            /// </summary>
            [JsonProperty("notelastupdateddate")]
            [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
            public DateTime? NoteLastUpdatedDate { get; set; }

            /// <summary>
            /// The reason this question was not performed.
            /// </summary>
            [JsonProperty("notperformedreason")]
            public Reason NotPerformedReason { get; set; }

            public class Reason
            {
                /// <summary>
                /// SNOMED code for the not performed reason, or 1 if there is no reason
                /// </summary>
                [JsonProperty("code")]
                public int? Code { get; set; }

                /// <summary>
                /// Human-readable text for the not performed reason.
                /// </summary>
                [JsonProperty("text")]
                public string Text { get; set; }
            }
        }
    }
}
