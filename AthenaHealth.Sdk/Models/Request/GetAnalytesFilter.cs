// ReSharper disable IdentifierTypo
// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo

using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using Newtonsoft.Json;
using System;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetAnalytesFilter
    {
        /// <summary>
        /// The athenaNet department id.
        /// </summary>
        [JsonProperty(PropertyName = "departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// ID used to return lab results for a specific encounter.
        /// </summary>
        [JsonProperty(PropertyName = "allresultsbyencounterid")]
        public int? AllResultsByEncounterId { get; set; }

        /// <summary>
        /// Filter the results based on the analyte's result status. Since the result status is a free text field, this list is not exhaustive, but does represent a majority of the used statuses.
        /// </summary>
        [JsonProperty(PropertyName = "analyteresultstatus")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public AnalyteResultStatusEnum? AnalyteResultStatus { get; set; }

        /// <summary>
        /// Filter lab orders not individual results that are on or before this date. Example: enddate=1/21/2018. If no enddate is specified, all lab orders found since startdate will be included if specified.
        /// </summary>
        [JsonProperty(PropertyName = "enddate")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// ID used when the lab results sends the exact same result multiple times.
        /// </summary>
        [JsonProperty(PropertyName = "exactduplicatedocumentid")]
        public int? ExactDuplicateDocumentId { get; set; }

        /// <summary>
        /// Filter the results based on the lab result's result status. Since the result status is a free text field, this list is not exhaustive, but does represent a majority of the used statuses.
        /// </summary>
        [JsonProperty(PropertyName = "labresultstatus")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public LabResultStatusEnum? LabResultStatus { get; set; }

        /// <summary>
        /// Include the translation of the abnormalflag into HL7 code standards.
        /// </summary>
        [JsonProperty(PropertyName = "showabnormaldetails")]
        public bool ShowAbnormalDetails { get; set; }

        /// <summary>
        /// Includes the lab results and analytes marked as hidden. Hidden lab results and analytes are created when they are manually entered, for example on the qm tab or in flowsheets.
        /// </summary>
        [JsonProperty(PropertyName = "showhidden")]
        public bool ShowHidden { get; set; }

        /// <summary>
        /// If true, interpretation template added to the document is also returned.
        /// </summary>
        [JsonProperty(PropertyName = "showtemplate")]
        public bool ShowTemplate { get; set; }

        /// <summary>
        /// Filter lab orders not individual results that are on or after this date. Example: startdate=6/21/2015. If no startdate is specified, all prior lab orders will be included until enddate if specified.
        /// </summary>
        [JsonProperty(PropertyName = "startdate")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// ID used when the lab sends a result and later sends a more complete version of the result with additional information.
        /// </summary>
        [JsonProperty(PropertyName = "supersededdocumentid")]
        public int? SupersedEdDocumentId { get; set; }

        /// <summary>
        /// Number of entries to return (default 1000, max 10000). Please note that this endpoint has a
        /// different default and max than normal.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        [JsonProperty(PropertyName = "offset")]
        public int? Offset { get; set; }
    }
}
