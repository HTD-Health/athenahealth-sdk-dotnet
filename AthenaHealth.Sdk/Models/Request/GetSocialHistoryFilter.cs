using AthenaHealth.Sdk.Models.Enums;
using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetSocialHistoryFilter
    {
        /// <summary>
        /// The athenaNet department id.
        /// </summary>
        [JsonProperty(PropertyName = "departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// The intended audience for the data. If given, questions marked as confidential for this
        /// audience will be withheld.
        /// </summary>
        [JsonProperty(PropertyName = "recipientcategory")]
        public RecipientCategoryEnum? RecipientCategory { get; set; }

        /// <summary>
        /// Include questions that the provider did not perform.
        /// </summary>
        [JsonProperty(PropertyName = "shownotperformedquestions")]
        public bool? ShowNotPerformedQuestions { get; set; }

        /// <summary>
        /// Include questions where there is no current answer.
        /// </summary>
        [JsonProperty(PropertyName = "showunansweredquestions")]
        public bool? ShowUnansweredQuestions { get; set; }

        public GetSocialHistoryFilter(int departmentId)
        {
            DepartmentId = departmentId;
        }
    }
}
