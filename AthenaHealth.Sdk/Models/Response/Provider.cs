using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public class ProviderResponse
    {
        [JsonProperty("totalcount")]
        public int Total { get; set; }

        [JsonProperty("providers")]
        public Provider[] Items { get; set; }
    }

    public class Provider
    {
        /// <summary>
        /// The ID to be used for this provider.
        /// Note that in athenaNet, an individual provider (as defined by a unique NPI)
        /// may have multiple provider IDs. For the API, we have collapsed these to a single canonical ID.
        /// </summary>
        [JsonProperty("providerid")]
        public string Id { get; set; }

        /// <summary>
        /// The provider's first name.
        /// </summary>
        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        /// <summary>
        /// The provider's last name.
        /// </summary>
        [JsonProperty("lastname")]
        public string LastName { get; set; }

        /// <summary>
        /// Indicates if this is a billable provider.
        /// </summary>
        [JsonProperty("billable")]
        public bool Billable { get; set; }

        /// <summary>
        /// This is just the ID (a text string) such as "NP" or "NP S" for the provider type.
        /// </summary>
        [JsonProperty("providertypeid")]
        public string ProviderTypeId { get; set; }

        /// <summary>
        /// This is the ANSI code for this provider's specialty.
        /// </summary>
        [JsonProperty("ansispecialtycode	")]
        public string AnsiSpecialtyCode { get; set; }

        /// <summary>
        /// For certain purposes, this can be considered to be the "home" or default department for a provider.
        /// </summary>
        [JsonProperty("homedepartment")]
        public string HomeDepartment { get; set; }

        /// <summary>
        /// The username of the provider.
        /// </summary>
        [JsonProperty("providerusername")]
        public string ProviderUsername { get; set; }

        /// <summary>
        /// The ID of the supervising provider.
        /// </summary>
        [JsonProperty("supervisingproviderid")]
        public int SupervisingProviderId { get; set; }

        /// <summary>
        /// There is a long potential list of provider type in the form "full name (id)",
        /// but "MD", "NP" or "NP S" (Nurse Practitioner (Supervising)), "RES" (resident),
        /// "EQUIP", "DO", "PA" or "PASUP" (Physician's Assistant (Supervising)), "TECH",
        /// "RN", LPT", "CRNA" or "CRNASUP" (Certified Registered Nurse Anesthesiologist (Supervising)),
        /// and MA (Medical Assistant) are among the most common.
        /// </summary>
        [JsonProperty("providertype")]
        public string ProviderType { get; set; }

        /// <summary>
        /// A list of provider IDs for this provider NPI that will create an encounter when the appointment is checked in for encounter supported appointment types.
        /// Only populated if 'showallproviderids' is set.
        /// </summary>
        [JsonProperty("createencounterprovideridlist")]
        public string[] CreateEncounterProviderIdList { get; set; }

        /// <summary>
        /// The scheduling name for this provider (as used in athenaNet).
        /// </summary>
        [JsonProperty("schedulingname")]
        public string SchedulingName { get; set; }

        /// <summary>
        /// If true, appointments scheduled with this provider will create an encounter when the appointment
        /// is checked in for encounter supported appointment types.
        /// Only applies to the primary providerid.
        /// If the provider has other IDs with the same API,
        /// please use '<see cref="GetProviderFilter.ShowAllProviderIds"/>' to see which IDs create encounters.
        /// </summary>
        [JsonProperty("createencounteroncheckin")]
        public bool CreateEncounterOnCheckIn { get; set; }

        /// <summary>
        /// A friendly name for this provider's specialty.
        /// </summary>
        [JsonProperty("specialty")]
        public string Specialty { get; set; }

        /// <summary>
        /// Name of the scheduling resource type tied to the provider.
        /// </summary>
        [JsonProperty("scheduleresourcetype")]
        public string ScheduleResourceType { get; set; }

        /// <summary>
        /// If set, this provider does not appear in athenaCommunicator's web portal.
        /// </summary>
        [JsonProperty("hideinportal")]
        public bool HideInPortal { get; set; }

        /// <summary>
        /// Indicates whether the provider is accepting new patients.
        /// This field is currently only for informational purposes, and does not drive any athenaNet functionality.
        /// </summary>
        [JsonProperty("acceptingnewpatients")]
        public bool AcceptingNewPatients { get; set; }

        /// <summary>
        /// This is the ANSI name with ANSI code for this provider's specialty.
        /// </summary>
        [JsonProperty("ansinamecode")]
        public string AnsiNameCode { get; set; }

        /// <summary>
        /// The NPI for this provider, if available.
        /// </summary>
        [JsonProperty("npi")]
        public int Npi { get; set; }

        /// <summary>
        /// Either "Person" or "Non-Person" (e.g. X-Ray machines)
        /// </summary>
        [JsonProperty("entitytype")]
        public string EntityType { get; set; }

        /// <summary>
        /// When showallproviderids is set to true, a list of all other athenaNet providers IDs that may refer to this same provider.
        /// If not present with showallproviderids, there are no other IDs other than the primary ID.
        /// </summary>
        [JsonProperty("otherprovideridlist")]
        public string[] OtherProviderIdList { get; set; }

        /// <summary>
        /// The preferred name to use when displaying this provider.
        /// </summary>
        [JsonProperty("displayname")]
        public string DisplayName { get; set; }

        /// <summary>
        /// When showallproviderids is set to true, a list of all provider groups that this provider is registered in.
        /// Data is only relevant if a practice is using Provider-Group-Based Data Permissions in their practice.
        /// </summary>
        [JsonProperty("providergrouplist")]
        public string[] ProviderGroupList { get; set; }

        [JsonProperty("supervisingproviderusername")]
        public string SupervisingProviderUsername { get; set; }

        /// <summary>
        /// The "usual" department for this provider, if SHOWUSUALDEPARTMENTGUESSTHRESHOLD is set.
        /// </summary>
        [JsonProperty("usualdepartmentid")]
        public int UsualDepartmentId { get; set; }
    }
}