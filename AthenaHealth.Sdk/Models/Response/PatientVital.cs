using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace AthenaHealth.Sdk.Models.Response
{
    public class PatientVitalResponse : IPagingResponse<PatientVital>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("vitals")]
        public PatientVital[] Items { get; set; }
    }

    public class PatientVital
    {
        /// <summary>
        /// List of vital attribute readings. One entry per attribute (so the temperature and where
        /// the temperature was taken are two different readings, tied together by the readingid
        /// </summary>
        [JsonProperty("readings")]
        public Reading[][] Readings { get; set; }

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
        /// Configured order for this vital group
        /// </summary>
        [JsonProperty("ordering")]
        public int? Ordering { get; set; }

        public class Reading
        {
            [JsonProperty("percentilespec")]
            public Specification PercentileSpecification { get; set; }

            /// <summary>
            /// Unique ID for this vital attribute reading. Used to update/delete this reading.
            /// </summary>
            [JsonProperty("vitalid")]
            public int? VitalId { get; set; }

            /// <summary>
            /// Key used to identify this particular vital attribute
            /// </summary>
            [JsonProperty("clinicalelementid")]
            public string ClinicalElementId { get; set; }

            /// <summary>
            /// The source of this reading.
            /// </summary>
            [JsonProperty("source")]
            public string Source { get; set; }

            /// <summary>
            /// External key to source.
            /// </summary>
            [JsonProperty("sourceid")]
            public int? SourceId { get; set; }

            /// <summary>
            /// Numeric key used to tie related and distinguish separate readings. So the diastolic
            /// and systolic blood pressure should have the same readingid.
            /// </summary>
            [JsonProperty("readingid")]
            public int? Id { get; set; }

            /// <summary>
            /// Date that the reading was taken.
            /// </summary>
            [JsonProperty("readingtaken")]
            public string ReadingTaken { get; set; }

            /// <summary>
            /// Unit that describes this vital's value.
            /// </summary>
            [JsonProperty("unit")]
            public string Unit { get; set; }

            /// <summary>
            /// The value of this reading. NOTE: for numeric values, the units are always in the
            /// 'native' units per the configuration.
            /// </summary>
            [JsonProperty("value")]
            public string Value { get; set; }

            /// <summary>
            /// Code indentifier for the reading.
            /// </summary>
            [JsonProperty("code")]
            public string Code { get; set; }

            /// <summary>
            /// Codeset of the code.
            /// </summary>
            [JsonProperty("codeset")]
            public string Codeset { get; set; }

            /// <summary>
            /// Description of the code identifier.
            /// </summary>
            [JsonProperty("codedescription")]
            public string CodeDescription { get; set; }

            /// <summary>
            /// The athenaNet username of the person who entered the vital.
            /// </summary>
            [JsonProperty("createdby")]
            public string CreatedBy { get; set; }

            /// <summary>
            /// The date this vital was entered into the chart. Returned in mm/dd/yyyy hh24:mi:ss format.
            /// </summary>
            [JsonProperty("createddate")]
            [JsonConverter(typeof(DateConverter), "MM/dd/yyyy HH:mm:ss")]
            public DateTime? CreatedDate { get; set; }

            /// <summary>
            /// Flag indicating if this vital is graphable.
            /// </summary>
            [JsonProperty("isgraphable")]
            public bool IsGraphable { get; set; }

            public class Specification
            {
                /// <summary>
                /// The highest value the y value could be.
                /// </summary>
                [JsonProperty("high")]
                public int? High { get; set; }

                /// <summary>
                /// Ordinal of the high value.
                /// </summary>
                [JsonProperty("highordinal")]
                public string HighOrdinal { get; set; }

                /// <summary>
                /// The lowest value that y could be.
                /// </summary>
                [JsonProperty("low")]
                public int? Low { get; set; }

                /// <summary>
                /// Ordinal of the lowest value.
                /// </summary>
                [JsonProperty("lowordinal")]
                public string LowOrdinal { get; set; }

                /// <summary>
                /// Indicator of less than or greater. Possible values: (&gt;,&lt;)
                /// </summary>
                [JsonProperty("prefix")]
                public string Prefix { get; set; }
            }
        }
    }
}
