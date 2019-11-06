using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace AthenaHealth.Sdk.Models.Request
{
    public class UpdateMedicalHistory
    {
        /// <summary>
        /// The athenaNet department ID.
        /// </summary>
        [Required]
        [JsonProperty("departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// JSON array of:
        /// </summary>
        [JsonProperty("questions")]
        public Question[] Questions { get; set; }

        /// <summary>
        /// Any additional section notes
        /// </summary>
        [JsonProperty("sectionnote")]
        public string SectionNote { get; set; }

        public UpdateMedicalHistory(int departmentId)
        {
            DepartmentId = departmentId;
        }

        public class Question
        {
            /// <summary>
            /// Answer to this question
            /// </summary>
            [JsonProperty("answer")]
            [JsonConverter(typeof(CustomEnumConverter))]
            public AnswerEnum? Answer { get; set; }

            /// <summary>
            /// Remove the answer to this question
            /// </summary>
            [JsonProperty("delete")]
            public bool? Delete { get; set; }

            /// <summary>
            /// Any additional notes
            /// </summary>
            [JsonProperty("note")]
            public string Note { get; set; }

            /// <summary>
            /// The athenaNet question id.
            /// </summary>
            [Required]
            [JsonProperty("questionid")]
            public int Id { get; set; }

            public Question(int id)
            {
                Id = id;
            }
        }
    }
}
