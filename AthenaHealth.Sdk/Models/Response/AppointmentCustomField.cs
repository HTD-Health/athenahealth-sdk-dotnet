using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class AppointmentCustomFieldResponse : IPagingResponse<AppointmentCustomField>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("appointmentcustomfields")]
        public AppointmentCustomField[] Items { get; set; }
    }

    public class AppointmentCustomField
    {
        /// <summary>
        /// The custom field ID.
        /// </summary>
        [JsonProperty("customfieldid")]
        public int? Id { get; set; }

        /// <summary>
        /// The name of this custom field.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Maximum length of this field.
        /// </summary>
        [JsonProperty("length")]
        public int? Length { get; set; }

        /// <summary>
        /// One of "TEXT", "DATE", "NUMBER", or "REFERRINGPROVIDER".
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Can this field be updated?
        /// </summary>
        [JsonProperty("disallowupdate")]
        public bool? DisallowUpdate { get; set; }

        /// <summary>
        /// If true will allow it to be searchable from the search box in the main page.
        /// </summary>
        [JsonProperty("searchable")]
        public bool? Searchable { get; set; }

        /// <summary>
        /// Is this field case sensitive?
        /// </summary>
        [JsonProperty("casesensitive")]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// An array of options, each one containing selectid and a selectvalue.
        /// </summary>
        [JsonProperty("selectlist")]
        public Option[] Options { get; set; }

        /// <summary>
        /// The ordering in which this field is displayed.
        /// </summary>
        [JsonProperty("ordering")]
        public int? Ordering { get; set; }

        /// <summary>
        /// Is this field a select list (and thus should have a "selectlist" as well).
        /// </summary>
        [JsonProperty("select")]
        public bool? Select { get; set; }

        public class Option
        {
            /// <summary>
            /// The ID that is used to identify this option.
            /// </summary>
            [JsonProperty("optionid")]
            public int? Id { get; set; }

            /// <summary>
            /// The value to be displayed.
            /// </summary>
            [JsonProperty("optionvalue")]
            public string Value { get; set; }
        }
    }
}
