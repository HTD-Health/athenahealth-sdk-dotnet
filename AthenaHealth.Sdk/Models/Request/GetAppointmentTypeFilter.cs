// ReSharper disable IdentifierTypo
// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo

using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetAppointmentTypeFilter
    {
        /// <summary>
        /// A list of departmentids which when passed will filter the appointmenttypes having said departments. This is used along with providerids to fetch department/provider specific appointmenttypes.
        /// </summary>
        [JsonProperty(PropertyName = "departmentids")]
        public int[] DepartmentIds { get; set; }

        /// <summary>
        /// By default, we show both generic and non-generic types. Setting this to true will hide the generic types (and show only non-generic types).
        /// </summary>
        [JsonProperty(PropertyName = "hidegeneric")]
        public bool HideGeneric { get; set; } = false;

        /// <summary>
        /// By default, we show both generic and non-generic types. Setting this to true will hide non-generic types (and show only generic types).
        /// </summary>
        [JsonProperty(PropertyName = "hidenongeneric")]
        public bool HideNonGeneric { get; set; } = false;

        /// <summary>
        /// This defaults to true if not specified, and thus will hide non-patient facing types.  Setting this to false would thus show non-patient facing types.
        /// </summary>
        [JsonProperty(PropertyName = "hidenonpatient")]
        public bool HideNonPatient { get; set; } = true;

        /// <summary>
        /// By default, we show both "template only" and not-template only types. Setting this to true, the results will omit template only types. ("Template only" is a setting that makes the type appear in schedules, but forces users to select a non-template type upon booking.)
        /// </summary>
        [JsonProperty(PropertyName = "hidetemplatetypeonly")]
        public bool HideTemplateTypeOnly { get; set; } = false;

        /// <summary>
        /// A list of providerids which when passed will filter the appointmenttypes having said providers. This is used along with departmentids to fetch department/provider specific appointmenttypes.
        /// </summary>
        [JsonProperty(PropertyName = "providerids")]
        public int[] ProviderIds { get; set; }



    }

}
