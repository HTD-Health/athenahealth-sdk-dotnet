using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo
namespace AthenaHealth.Sdk.Models.Request
{
    public class SetPharmacyRequest
    {
        /// <summary>
        /// The clinical provider ID that you wish to set as the default pharmacy or add as a preferred pharmacy. This or the NCPDPID must be provided.
        /// </summary>
        [JsonProperty("clinicalproviderid")]
        public int? ClinicalProviderId { get; set; }

        /// <summary>
        /// The athenaNet department id.
        /// </summary>
        [Required]
        [JsonProperty("departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// The NCPDP ID of the clinical provider. Can be used instead of clinicalproviderid. Only one can be used.
        /// </summary>
        [JsonProperty("ncpdpid")]
        // ReSharper disable once IdentifierTypo
        public int? NcpdpId { get; set; }

        public SetPharmacyRequest(int departmentId)
        {
            DepartmentId = departmentId;
        }
    }
}
