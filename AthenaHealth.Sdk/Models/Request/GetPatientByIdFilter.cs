// ReSharper disable IdentifierTypo
// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo

using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetPatientByIdFilter
    {
        /// <summary>
        /// This is the ID for the department of the patient you are retrieving. If you are calling this on an enterprise practice with multiple financial groups (also called "provider groups"), this will ensure you are retrieving the correct patient and not a copy that is in a different department.
        /// </summary>
        [JsonProperty(PropertyName = "departmentid")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Set to true to allow ability to find patients with record restrictions and blocked patients. This should only be used when there is no reflection to the patient at all that a match was found or not found.
        /// </summary>
        [JsonProperty(PropertyName = "ignorerestrictions")]
        public bool? IgnoreRestrictions { get; set; }
        
        /// <summary>
        /// If set, will return local patient id tied to the passed in DepartmentID.
        /// </summary>
        [JsonProperty(PropertyName = "limitlocalpatientid")]
        public bool? LimitLocalPatientId { get; set; }

        /// <summary>
        /// Use 2015 Ed. CEHRT compliant strings for describing gender identity and sexual orientation.
        /// </summary>
        [JsonProperty(PropertyName = "show2015edcehrtvalues")]
        public bool? Show2015EdCehrtValues { get; set; }

        /// <summary>
        /// Include information on claims where there is no outstanding patient balance. (Only to be used when showbalancedetails is selected.)
        /// </summary>
        [JsonProperty(PropertyName = "showallclaims")]
        public bool? ShowAllClaims { get; set; }

        /// <summary>
        /// Include an array of all departments the patient is a part of along with all statuses for those departments.
        /// </summary>
        [JsonProperty(PropertyName = "showallpatientdepartmentstatus")]
        public bool? ShowAllPatientDepartmentStatus { get; set; }

        /// <summary>
        /// Show detailed information on patient balances.
        /// </summary>
        [JsonProperty(PropertyName = "showbalancedetails")]
        public bool? ShowBalanceDetails { get; set; }

        /// <summary>
        /// Include custom fields for the patient.
        /// </summary>
        [JsonProperty(PropertyName = "showcustomfields")]
        public bool? ShowCustomFields { get; set; }

        /// <summary>
        /// If set, will show full SSN instead of a masked number.
        /// </summary>
        [JsonProperty(PropertyName = "showfullssn")]
        public bool? ShowFullSsn { get; set; }

        /// <summary>
        /// Include patient insurance information.
        /// </summary>
        [JsonProperty(PropertyName = "showinsurance")]
        public bool? ShowInsurance { get; set; }

        /// <summary>
        /// If set, will show local patient id.
        /// </summary>
        [JsonProperty(PropertyName = "showlocalpatientid")]
        public bool? ShowLocalPatientId { get; set; }

        /// <summary>
        /// If set, will include portal enrollment status in response.
        /// </summary>
        [JsonProperty(PropertyName = "showportalstatus")]
        public bool? ShowPortalStatus { get; set; }

    }

}
