using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Request
{
    public class UpdateSocialHistoryTemplates
    {
        /// <summary>
        /// The athenaNet department id.
        /// </summary>
        [JsonProperty("departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// A comma separated list of template IDs to subscribe to.
        /// </summary>
        [JsonProperty("templateids")]
        [JsonConverter(typeof(CustomArrayToStringConverter), ",", true)]
        public int[] TemplateIds { get; set; }

        public UpdateSocialHistoryTemplates(int departmentId, int[] templateIds)
        {
            DepartmentId = departmentId;
            TemplateIds = templateIds;
        }
    }
}
