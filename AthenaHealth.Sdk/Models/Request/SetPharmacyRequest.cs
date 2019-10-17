using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo

namespace AthenaHealth.Sdk.Models.Request
{
    public class SetPharmacyRequest
    {
        /// <summary>
        /// The clinical provider ID that you wish to set as the default pharmacy or add as a preferred pharmacy. This or the NCPDPID must be provided.
        /// </summary>
        [JsonProperty(PropertyName = "clinicalproviderid")]
        public int? ClinicalProviderId { get; set; }

        /// <summary>
        /// The athenaNet department id.
        /// </summary>
        [Required]
        [JsonProperty(PropertyName = "departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// The NCPDP ID of the clinical provider. Can be used instead of clinicalproviderid. Only one can be used.
        /// </summary>
        [JsonProperty(PropertyName = "ncpdpid")]
        // ReSharper disable once IdentifierTypo
        public int? NcpdpId { get; set; }
    }
}