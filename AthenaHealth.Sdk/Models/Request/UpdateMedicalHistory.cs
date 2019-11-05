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
        [JsonProperty(PropertyName = "departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// JSON array of:
        /// </summary>
        [JsonProperty(PropertyName = "questions")]
        public Question[] Questions { get; set; }

        /// <summary>
        /// Any additional section notes
        /// </summary>
        [JsonProperty(PropertyName = "sectionnote")]
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
            [JsonProperty(PropertyName = "answer")]
            [JsonConverter(typeof(CustomEnumConverter))]
            public AnswerEnum? Answer { get; set; }

            /// <summary>
            /// Remove the answer to this question
            /// </summary>
            [JsonProperty(PropertyName = "delete")]
            public bool? Delete { get; set; }

            /// <summary>
            /// Any additional notes
            /// </summary>
            [JsonProperty(PropertyName = "note")]
            public string Note { get; set; }

            /// <summary>
            /// The athenaNet question id.
            /// </summary>
            [Required]
            [JsonProperty(PropertyName = "questionid")]
            public int Id { get; set; }

            public Question(int id)
            {
                Id = id;
            }
        }
    }
}
