// ReSharper disable IdentifierTypo
// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo

using AthenaHealth.Sdk.Models.Request.Interfaces;
using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetGenderIdentitiesFilter : IPagingFilter
    {
        /// <summary>
        /// If passed, will return the 2015 Ed. CEHRT values for describing gender identity for a
        /// patient that should be used with the genderidentity argument to POST /patients and PUT
        /// /patients/{patientid}. Otherwise, will return a list of strings that can be used with
        /// the genderidentity argument to POST /patients and PUT /patients/{patientid} for those
        /// clients that are using the 'Gender Identity/Sexual Orientation Workflows (Transgender
        /// Patient)' or 'Population Demographics - Social Determinant Fields (Sexual
        /// orientation/Gender identity)' setting in athenaNet.
        /// </summary>
        [JsonProperty("show2015edcehrtvalues")]
        public bool? Show2015EdCehrtValues { get; set; }

        /// <summary>
        /// Number of entries to return (default 1500, max 5000)
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        public int? Offset { get; set; }
    }
}
