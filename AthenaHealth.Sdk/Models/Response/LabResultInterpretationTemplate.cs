using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class LabResultInterpretationTemplate
    {
        /// <summary>
        /// The paragraphs in the template.
        /// </summary>
        [JsonProperty("paragraphs")]
        public Paragraph[] Paragraphs { get; set; }

        /// <summary>
        /// The interpretation note.
        /// </summary>
        [JsonProperty("interpretationtemplatenote")]
        public string Note { get; set; }

        /// <summary>
        /// The name of the interpretation template.
        /// </summary>
        [JsonProperty("interpretationtemplatename")]
        public string Name { get; set; }

        public class Paragraph
        {
            /// <summary>
            /// The sentences in the paragraph.
            /// </summary>
            [JsonProperty("sentences")]
            public Sentence[] Sentences { get; set; }

            /// <summary>
            /// The name of the interpretation paragraph.
            /// </summary>
            [JsonProperty("paragraphname")]
            public string Name { get; set; }

            public class Sentence
            {
                /// <summary>
                /// The note that goes along with this sentence.
                /// </summary>
                [JsonProperty("sentencenote")]
                public string Note { get; set; }

                /// <summary>
                /// The findings in the sentence
                /// </summary>
                [JsonProperty("findings")]
                public Finding[] Findings { get; set; }

                /// <summary>
                /// The name of the sentence in the paragraph.
                /// </summary>
                [JsonProperty("sentencename")]
                public string Name { get; set; }

                public class Finding
                {
                    /// <summary>
                    /// The note for the finding selected.
                    /// </summary>
                    [JsonProperty("findingnote")]
                    public string Note { get; set; }

                    /// <summary>
                    /// Describes the finding - either NORMAL, ABNORMAL, or NEUTRAL.
                    /// </summary>
                    [JsonProperty("findingtype")]
                    public string Type { get; set; }

                    /// <summary>
                    /// The option in the finding that was selected by the user.
                    /// </summary>
                    [JsonProperty("selectedoptions")]
                    public string SelectedOptions { get; set; }

                    /// <summary>
                    /// The name of the finding.
                    /// </summary>
                    [JsonProperty("findingname")]
                    public string Name { get; set; }

                    /// <summary>
                    /// Freetext that could be associated with this finding.
                    /// </summary>
                    [JsonProperty("freetext")]
                    public string Text { get; set; }
                }
            }
        }
    }
}
