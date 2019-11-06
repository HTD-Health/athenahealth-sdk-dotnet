using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AthenaHealth.Sdk.Models.Request
{
    public class UpdateSocialHistory
    {
        /// <summary>
        /// The department for this patient. A patient may have multiple charts, and the department determines which chart to retrieve.
        /// </summary>
        [Required]
        [JsonProperty("departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// JSON array
        /// </summary>
        [JsonProperty("questions")]
        public Question[] Questions { get; set; }

        /// <summary>
        /// A section-wide note
        /// </summary>
        [JsonProperty("sectionnote")]
        public string SectionNote { get; set; }

        public UpdateSocialHistory(int departmentId)
        {
            DepartmentId = departmentId;
        }

        public class Question
        {
            /// <summary>
            /// The answer to the question. A blank answer will delete the existing answer and the question will not show up in succeeding GETs unless includeunansweredquestions=true.
            /// </summary>
            [JsonProperty("answer")]
            public string Answer { get; set; }

            /// <summary>
            /// Remove the answer to this question. Equivalent to submitting a null answer.
            /// </summary>
            [JsonProperty("delete")]
            public bool? Delete { get; set; }

            /// <summary>
            /// The question key that identifies this question, irregardless of the template
            /// </summary>
            [JsonProperty("key")]
            public string Key { get; set; }

            /// <summary>
            /// The note attached to this answer
            /// </summary>
            [Required]
            [JsonProperty("note")]
            public string Note { get; set; }

            /// <summary>
            /// The reason the question was not performed.
            /// </summary>
            [JsonProperty("notperformedreason")]
            public string NotPerformedReason { get; set; }

            public Question(string key)
            {
                Key = key;
            }
        }
    }
}
