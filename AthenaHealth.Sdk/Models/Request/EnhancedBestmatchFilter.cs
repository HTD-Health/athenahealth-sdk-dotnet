using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using System;

namespace AthenaHealth.Sdk.Models.Request
{
    public class EnhancedBestmatchFilter
    {
        /// <summary>
        /// Patient's DOB (mm/dd/yyyy).
        /// </summary>
        [JsonProperty("dob")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Patient's first name.
        /// </summary>
        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        /// <summary>
        /// Patient's last name.
        /// </summary>
        [JsonProperty("lastname")]
        public string LastName { get; set; }

        /// <summary>
        /// This is the ID for the department of the patient you are retrieving. If you are calling
        /// this on an enterprise practice with multiple financial groups (also called "provider
        /// groups"), this will ensure you are retrieving the correct patient and not a copy that is
        /// in a different department.
        /// </summary>
        [JsonProperty("departmentid")]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Patient's email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Guarantor's email address.
        /// </summary>
        [JsonProperty("guarantoremail")]
        public string GuarantorEmail { get; set; }

        /// <summary>
        /// Guarantor's phone number.
        /// </summary>
        [JsonProperty("guarantorphone")]
        public string GuarantorPhone { get; set; }

        /// <summary>
        /// The patient's home phone number.
        /// </summary>
        [JsonProperty("homephone")]
        public string HomePhone { get; set; }

        /// <summary>
        /// Set to true to allow ability to find patients with record restrictions and blocked
        /// patients. This should only be used when there is no reflection to the patient at all that
        /// a match was found or not found.
        /// </summary>
        [JsonProperty("ignorerestrictions")]
        public bool? IgnoreRestrictions { get; set; }

        /// <summary>
        /// If set, will return local patient id tied to the passed in DepartmentID.
        /// </summary>
        [JsonProperty("limitlocalpatientid")]
        public bool? LimitLocalPatientId { get; set; }

        /// <summary>
        /// If you are only interested in matching a patient if they are above a specific confidence
        /// level, you can use this to require any patient matched to have a score greater than or
        /// equal to this value.
        /// </summary>
        [JsonProperty("minscore")]
        public int? MinScore { get; set; }

        /// <summary>
        /// The patient's mobile phone number.
        /// </summary>
        [JsonProperty("mobilephone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Patient's preferred name (or nickname).
        /// </summary>
        [JsonProperty("preferredname")]
        public string PreferredName { get; set; }

        /// <summary>
        /// If this field is set to true, the top five patients with a score of 16 or above will be returned.
        /// </summary>
        [JsonProperty("returnbestmatches")]
        public bool? ReturnBestMatches { get; set; }

        /// <summary>
        /// Use 2015 Ed. CEHRT compliant strings for describing gender identity and sexual orientation.
        /// </summary>
        [JsonProperty("show2015edcehrtvalues")]
        public bool? Show2015EdCehrtValues { get; set; }

        /// <summary>
        /// Include information on claims where there is no outstanding patient balance. (Only to be
        /// used when showbalancedetails is selected.)
        /// </summary>
        [JsonProperty("showallclaims")]
        public bool? ShowAllClaims { get; set; }

        /// <summary>
        /// Include an array of all departments the patient is a part of along with all statuses for
        /// those departments.
        /// </summary>
        [JsonProperty("showallpatientdepartmentstatus")]
        public bool? ShowAllPatientDepartmentStatus { get; set; }

        /// <summary>
        /// Show detailed information on patient balances.
        /// </summary>
        [JsonProperty("showbalancedetails")]
        public bool? ShowBalanceDetails { get; set; }

        /// <summary>
        /// Include custom fields for the patient.
        /// </summary>
        [JsonProperty("showcustomfields")]
        public bool? ShowCustomFields { get; set; }

        /// <summary>
        /// If set, will show full SSN instead of a masked number.
        /// </summary>
        [JsonProperty("showfullssn")]
        public bool? ShowFullSsn { get; set; }

        /// <summary>
        /// Include patient insurance information.
        /// </summary>
        [JsonProperty("showinsurance")]
        public bool? ShowInsurance { get; set; }

        /// <summary>
        /// If set, will show local patient id.
        /// </summary>
        [JsonProperty("showlocalpatientid")]
        public bool? ShowLocalPatientId { get; set; }

        /// <summary>
        /// If set, will include portal enrollment status in response.
        /// </summary>
        [JsonProperty("showportalstatus")]
        public bool? ShowPortalStatus { get; set; }

        /// <summary>
        /// Patient's social security number.
        /// </summary>
        [JsonProperty("ssn")]
        public string Ssn { get; set; }

        /// <summary>
        /// Patient's name suffix.
        /// </summary>
        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        /// <summary>
        /// If this field is set to true, search patients based on a soundex search. Soundex
        /// searching is disabled by default.
        /// </summary>
        [JsonProperty("usesoundexsearch")]
        public bool? UseSoundexSearch { get; set; }

        /// <summary>
        /// The patient's work phone number. Generally not used to contact a patient.
        /// </summary>
        [JsonProperty("workphone")]
        public string WorkPhone { get; set; }

        /// <summary>
        /// Patient's zip.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        public EnhancedBestmatchFilter(DateTime dateOfBirth, string firstName, string lastName)
        {
            DateOfBirth = dateOfBirth;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
