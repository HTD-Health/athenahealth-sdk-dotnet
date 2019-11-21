using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using Newtonsoft.Json;
using System;

namespace AthenaHealth.Sdk.Models.Response
{
    public class ProblemResponse
    {
        /// <summary>
        /// List of problems, grouped by problem code
        /// </summary>
        [JsonProperty("problems")]
        public Problem[] Problems { get; set; }

        /// <summary>
        /// The date and time the section note was last updated.
        /// </summary>
        [JsonProperty("notelastmodifieddatetime")]
        public DateTime? NoteLastModifiedDateTime { get; set; }

        /// <summary>
        /// The problem section note
        /// </summary>
        [JsonProperty("sectionnote")]
        public string SectionNote { get; set; }

        /// <summary>
        /// Whether the no known problems checkbox is checked. This is an explicit statement separate from a patient who has no documented problems so far.
        /// </summary>
        [JsonProperty("noknownproblems")]
        public bool? NoKnownProblems { get; set; }

        /// <summary>
        /// Deprecated, used LASTMODIFIEDDATETIME instead. The last date any of the problems in the returned list were updated. Does not include no known problems or the section note, and is date precision.
        /// </summary>
        [JsonProperty("lastupdated")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// The username of the user who last modified the note, no known problems checkbox, or problems.
        /// </summary>
        [JsonProperty("lastmodifiedby")]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// The date and time the note, no known problems checkbox, or problems were last updated.
        /// </summary>
        [JsonProperty("lastmodifieddatetime")]
        public DateTime? LastModifiedDateTime { get; set; }

        /// <summary>
        /// Total number of problems
        /// </summary>
        [JsonProperty("totalcount")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The username of the user who last modified the note.
        /// </summary>
        [JsonProperty("notelastmodifiedby")]
        public string NoteLastModifiedBy { get; set; }

        public class Problem
        {
            /// <summary>
            /// List of start and stop events for this problem, which can occur multiple times.
            /// </summary>
            [JsonProperty("events")]
            public Event[] Events { get; set; }

            /// <summary>
            /// Date of problem deactivation.
            /// </summary>
            [JsonProperty("deactivateddate")]
            [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
            public DateTime? DeactivatedDate { get; set; }

            /// <summary>
            /// The name of the user who deactivated the problem.
            /// </summary>
            [JsonProperty("deactivateduser")]
            public string DeactivatedUser { get; set; }

            /// <summary>
            /// Athena ID for this problem
            /// </summary>
            [JsonProperty("problemid")]
            public int? Id { get; set; }

            /// <summary>
            /// Problem name
            /// </summary>
            [JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// Problem code
            /// </summary>
            [JsonProperty("code")]
            public string Code { get; set; }

            /// <summary>
            /// Problem codeset (SNOMED, ICD9, ICD10, etc)
            /// </summary>
            [JsonProperty("codeset")]
            public string Codeset { get; set; }

            /// <summary>
            /// If this was added from the chart or from an encounter without a selected ICD10 code, and if the primary codeset is SNOMED, then this contains the best matching ICD10 code mapped. Because SNOMED to ICD10 is a many to many map, this will tend to give the most generic diagnosis.
            /// </summary>
            [JsonProperty("bestmatchicd10code")]
            public string BestmatchICD10Code { get; set; }

            /// <summary>
            /// The data will be displayed when the showdiagnosisinfo flag is set to true
            /// </summary>
            [JsonProperty("mostrecentdiagnosisnote")]
            public string MostRecentDiagnosisNote { get; set; }

            /// <summary>
            /// The date the problem was last modified. Currently only date precision.
            /// </summary>
            [JsonProperty("lastmodifieddatetime")]
            public DateTime? LastModifiedDateTime { get; set; }

            /// <summary>
            /// The username of the user who last modified this problem.
            /// </summary>
            [JsonProperty("lastmodifiedby")]
            public string LastModifiedBy { get; set; }

            public class Event
            {
                ///<summary>
                /// List of encounter diagnoses that triggered this problem.
                /// </summary>
                [JsonProperty("diagnoses")]
                public Diagnose[] Diagnoses { get; set; }

                /// <summary>
                /// The type of this event: START, END, HIDDEN, REACTIVATED, or ENCOUNTER
                /// </summary>
                [JsonProperty("eventtype")]
                public string EventType { get; set; }

                /// <summary>
                /// The source of this event: ENCOUNTER or HISTORY
                /// </summary>
                [JsonProperty("source")]
                public string Source { get; set; }

                /// <summary>
                /// The status of this problem event: CHRONIC or ACUTE
                /// </summary>
                [JsonProperty("status")]
                public ProblemStatusEnum? Status { get; set; }

                /// <summary>
                /// The specified onset date for this problem, as entered by the practice. If available this is more accurate than the start date.
                /// </summary>
                [JsonProperty("onsetdate")]
                [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
                public DateTime? OnsetDate { get; set; }

                /// <summary>
                /// The date this problem event started or was restarted. Uses the onsetdate if available, otherwise uses the date the problem was entered into the system.
                /// </summary>
                [JsonProperty("startdate")]
                [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
                public DateTime? StartDate { get; set; }

                /// <summary>
                /// The date this problem event ended or was hidden
                /// </summary>
                [JsonProperty("enddate")]
                [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
                public DateTime? EndDate { get; set; }

                /// <summary>
                /// The date of the encounter where a diagnosis matching this problem was used.
                /// </summary>
                [JsonProperty("encounterdate")]
                [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
                public DateTime? EncounterDate { get; set; }

                /// <summary>
                /// The laterality of this problem. Can be null, LEFT, RIGHT, or BILATERAL.
                /// </summary>
                [JsonProperty("laterality")]
                public LateralityEnum? Laterality { get; set; }

                /// <summary>
                /// The note attached to this event.
                /// </summary>
                [JsonProperty("note")]
                public string Note { get; set; }

                /// <summary>
                /// The date that the user entered this problem.
                /// </summary>
                [JsonProperty("createddate")]
                [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
                public DateTime? CreatedDate { get; set; }

                /// <summary>
                /// The name of the user who entered this problem.
                /// </summary>
                [JsonProperty("createdby")]
                public string CreatedBy { get; set; }

                public class Diagnose
                {
                    /// <summary>
                    /// Diagnosis code
                    /// </summary>
                    [JsonProperty("code")]
                    public string Code { get; set; }

                    /// <summary>
                    /// Diagnosis codeset (SNOMED, ICD9, ICD10, etc)
                    /// </summary>
                    [JsonProperty("codeset")]
                    public string Codeset { get; set; }

                    /// <summary>
                    /// Diagnosis name. Might be different than problem name.
                    /// </summary>
                    [JsonProperty("name")]
                    public string Name { get; set; }
                }
            }
        }
    }
}
