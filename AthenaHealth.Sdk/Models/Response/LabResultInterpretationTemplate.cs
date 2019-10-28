using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class LabResultInterpretationTemplate
    {
        /// <summary>
        /// The paragraphs in the template.
        /// </summary>
        [JsonProperty(PropertyName = "paragraphs")]
        public Paragraph[] Paragraphs { get; set; }

        /// <summary>
        /// The interpretation note.
        /// </summary>
        [JsonProperty(PropertyName = "interpretationtemplatenote")]
        public string Note { get; set; }

        /// <summary>
        /// The name of the interpretation template.
        /// </summary>
        [JsonProperty(PropertyName = "interpretationtemplatename")]
        public string Name { get; set; }

        public class Paragraph
        {
            /// <summary>
            /// The sentences in the paragraph.
            /// </summary>
            [JsonProperty(PropertyName = "sentences")]
            public Sentence[] Sentences { get; set; }

            /// <summary>
            /// The name of the interpretation paragraph.
            /// </summary>
            [JsonProperty(PropertyName = "paragraphname")]
            public string Name { get; set; }

            public class Sentence
            {
                /// <summary>
                /// The note that goes along with this sentence.
                /// </summary>
                [JsonProperty(PropertyName = "sentencenote")]
                public string Note { get; set; }

                /// <summary>
                /// The findings in the sentence
                /// </summary>
                [JsonProperty(PropertyName = "findings")]
                public Finding[] Findings { get; set; }

                /// <summary>
                /// The name of the sentence in the paragraph.
                /// </summary>
                [JsonProperty(PropertyName = "sentencename")]
                public string Name { get; set; }

                public class Finding
                {
                    /// <summary>
                    /// The note for the finding selected.
                    /// </summary>
                    [JsonProperty(PropertyName = "findingnote")]
                    public string Note { get; set; }

                    /// <summary>
                    /// Describes the finding - either NORMAL, ABNORMAL, or NEUTRAL.
                    /// </summary>
                    [JsonProperty(PropertyName = "findingtype")]
                    public string Type { get; set; }

                    /// <summary>
                    /// The option in the finding that was selected by the user.
                    /// </summary>
                    [JsonProperty(PropertyName = "selectedoptions")]
                    public string SelectedOptions { get; set; }

                    /// <summary>
                    /// The name of the finding.
                    /// </summary>
                    [JsonProperty(PropertyName = "findingname")]
                    public string Name { get; set; }

                    /// <summary>
                    /// Freetext that could be associated with this finding.
                    /// </summary>
                    [JsonProperty(PropertyName = "freetext")]
                    public string Text { get; set; }
                }
            }
        }
    }
}
