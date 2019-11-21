using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class OfficeOrderType
    {
        /// <summary>
        /// The name of the clinical provider / department handling this point of care order
        /// </summary>
        [JsonProperty("clinicalprovider")]
        public string ClinicalProvider { get; set; }

        /// <summary>
        /// The LOINC code matching this order, if available
        /// </summary>
        [JsonProperty("loinc")]
        public string LOINC { get; set; }

        /// <summary>
        /// The type of order -- LAB, IMAGING, etc.
        /// </summary>
        [JsonProperty("ordertypecategory")]
        public string OrderTypeCategory { get; set; }

        /// <summary>
        /// The name of the order type
        /// </summary>
        [JsonProperty("ordertype")]
        public string OrderType { get; set; }

        /// <summary>
        /// The athena ID of the clinical provider / department handling this point of care order
        /// </summary>
        [JsonProperty("clinicalproviderid")]
        public int? ClinicalProviderId { get; set; }

        /// <summary>
        /// The list of departments that have this point of care order type configured
        /// </summary>
        [JsonProperty("departmentids")]
        [JsonConverter(typeof(CustomDelimitedStringToArrayConverter))]
        public int[] DepartmentIds { get; set; }

        /// <summary>
        /// The athena ID for this order type
        /// </summary>
        [JsonProperty("clinicalordertypeid")]
        public int? ClinicalOrderTypeId { get; set; }
    }
}
