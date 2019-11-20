using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AthenaHealth.Sdk.Models.Response
{
    public class VitalResponse : IPagingResponse<Vital>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("vitals")]
        public Vital[] Items { get; set; }
    }

    public class Vital
    {
        /// <summary>
        /// List of vital attributes in this vital group. Contains all possible attributes even if
        /// there are no readings.
        /// </summary>
        [JsonProperty("attributes")]
        public VitalAttribute[] Attributes { get; set; }

        /// <summary>
        /// Key for this vital group. E.g., HEIGHT.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Short human-readable string for this vital group. E.g., Ht.
        /// </summary>
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// If true, this vital is tied to some measurement.
        /// </summary>
        [JsonProperty("istiedtomeasurement")]
        public bool? IsTiedToMeasurement { get; set; }

        /// <summary>
        /// Configured order for this vital group
        /// </summary>
        [JsonProperty("ordering")]
        public int? Ordering { get; set; }

        public class VitalAttribute
        {
            /// <summary>
            /// Key used to identify this particular vital attribute
            /// </summary>
            [JsonProperty("clinicalelementid")]
            public string ClinicalElementId { get; set; }

            /// <summary>
            /// Human readable name for this attribute
            /// </summary>
            [JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// Short human readable name for this attribute
            /// </summary>
            [JsonProperty("abbreviation")]
            public string Abbreviation { get; set; }

            /// <summary>
            /// Data type for this attribute. Can be CHECKBOX, FREETEXT, NUMERIC, or SET.
            /// </summary>
            [JsonProperty("datatype")]
            [JsonConverter(typeof(CustomEnumConverter))]
            public VitalAttributeDataTypeEnum? DataType { get; set; }

            /// <summary>
            /// For NUMERIC attributes, the units the value is in.
            /// </summary>
            [JsonProperty("unit")]
            public string Unit { get; set; }

            /// <summary>
            /// For SET attributes, the list of valid values.
            /// </summary>
            [JsonProperty("dataset")]
            public string[] DataSet { get; set; }
        }
    }
}
