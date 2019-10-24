using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class MedicalHistory
    {
        /// <summary>
        /// List of questions corresponding to patient medical history
        /// </summary>
        [JsonProperty(PropertyName = "questions")]
        public Question[] Questions { get; set; }

        /// <summary>
        /// Additional notes for the entire medical history section, if any
        /// </summary>
        [JsonProperty(PropertyName = "sectionnote")]
        public string SectionNote { get; set; }

        public class Question
        {
            /// <summary>
            /// Athena ID for the question
            /// </summary>
            [JsonProperty(PropertyName = "questionid")]
            public int Id { get; set; }

            /// <summary>
            /// Disease being inquired about
            /// </summary>
            [JsonProperty(PropertyName = "question")]
            public string Value { get; set; }

            /// <summary>
            /// The answer given by the patient to the question
            /// </summary>
            [JsonProperty(PropertyName = "answer")]
            public string Answer { get; set; }

            /// <summary>
            /// Any special notes
            /// </summary>
            [JsonProperty(PropertyName = "note")]
            public string Note { get; set; }

            /// <summary>
            /// Diagnosis code
            /// </summary>
            [JsonProperty(PropertyName = "diagnosiscode")]
            public string DiagnosisCode { get; set; }

            /// <summary>
            /// Codeset the diagnosis code belongs to
            /// </summary>
            [JsonProperty(PropertyName = "codeset")]
            public string Codeset { get; set; }

            /// <summary>
            /// Description of the code
            /// </summary>
            [JsonProperty(PropertyName = "description")]
            public string Description { get; set; }
        }
    }
}
