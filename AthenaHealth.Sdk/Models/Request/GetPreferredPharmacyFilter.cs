using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetPreferredPharmacyFilter : BaseLimitFilter
    {
        /// <summary>
        /// The athenaNet department id.
        /// </summary>
        [JsonProperty(PropertyName = "departmentid")]
        public int DepartmentId { get; set; }
    }
}