using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class ReferringProviderResponse : IPagingResponse<ReferringProvider>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("referringproviders")]
        public ReferringProvider[] Items { get; set; }
    }

    public class ReferringProvider
    {
        /// <summary>
        /// The city of the referring provider.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// The email of the referring provider.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The note associated with the referring provider.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// The ANSI speciality code for this referring provider.
        /// </summary>
        [JsonProperty("ansispecialtycode")]
        public string AnsiSpecialtyCode { get; set; }

        /// <summary>
        /// The middle initial of the referring provider.
        /// </summary>
        [JsonProperty("middleinitial")]
        public string MiddleInitial { get; set; }

        /// <summary>
        /// The fax of the referring provider.
        /// </summary>
        [JsonProperty("fax")]
        public string Fax { get; set; }

        /// <summary>
        /// The address (1st line) of the referring provider.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// The NPI number associated with the referring provider.
        /// </summary>
        [JsonProperty("npinumber")]
        public string NpiNumber { get; set; }

        /// <summary>
        /// The provider type of the referring provider.
        /// </summary>
        [JsonProperty("providertype")]
        public string ProviderType { get; set; }

        /// <summary>
        /// The full name of the referring provider.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A friendly name for this provider's specialty.
        /// </summary>
        [JsonProperty("specialty")]
        public string Specialty { get; set; }

        /// <summary>
        /// The ID of the referring provider. Note: this is unrelated to /providers.
        /// </summary>
        [JsonProperty("referringproviderid")]
        public int? ReferringProviderId { get; set; }

        /// <summary>
        /// The zip of the referring provider.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// The last name of the referring provider.
        /// </summary>
        [JsonProperty("lastname")]
        public string LastName { get; set; }

        /// <summary>
        /// The first name of the referring provider.
        /// </summary>
        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        /// <summary>
        /// This is the ANSI name and code for this referring provider's specialty.
        /// </summary>
        [JsonProperty("ansinamecode")]
        public string AnsiNameCode { get; set; }

        /// <summary>
        /// The state of the referring provider.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Either "Person" or "Non-Person" (e.g. X-Ray machines)
        /// </summary>
        [JsonProperty("entitytype")]
        public string EntityType { get; set; }

        /// <summary>
        /// The address (2nd line) of the referring provider.
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// The phone of the referring provider.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// The name suffix of the referring provider.
        /// </summary>
        [JsonProperty("namesuffix")]
        public string NameSuffix { get; set; }
    }
}
