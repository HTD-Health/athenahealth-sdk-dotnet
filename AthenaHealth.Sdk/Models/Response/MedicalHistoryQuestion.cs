using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class MedicalHistoryQuestionResponse : IPagingResponse<MedicalHistoryQuestion>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("questions")]
        public MedicalHistoryQuestion[] Items { get; set; }
    }

    public class MedicalHistoryQuestion
    {
        /// <summary>
        /// Athena ID for the question
        /// </summary>
        [JsonProperty(PropertyName = "questionid")]
        public int QuestionId { get; set; }

        /// <summary>
        /// Disease being inquired about
        /// </summary>
        [JsonProperty(PropertyName = "question")]
        public string Question { get; set; }

        /// <summary>
        /// Diagnosis code for the disease, if provided
        /// </summary>
        [JsonProperty(PropertyName = "diagnosiscode")]
        public string DiagnosisCode { get; set; }

        /// <summary>
        /// True if this question has been deleted
        /// </summary>
        [JsonProperty(PropertyName = "deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Used for re-ordering questions
        /// </summary>
        [JsonProperty(PropertyName = "ordering")]
        public int? Ordering { get; set; }
    }
}
