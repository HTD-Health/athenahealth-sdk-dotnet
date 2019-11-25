// ReSharper disable IdentifierTypo
// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo

using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Request.Interfaces;
using Newtonsoft.Json;
using System;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetAnalytesFilter : IPagingFilter
    {
        /// <summary>
        /// The athenaNet department id.
        /// </summary>
        [JsonProperty("departmentid")]
        public int DepartmentId { get; set; }

        /// <summary>
        /// ID used to return lab results for a specific encounter.
        /// </summary>
        [JsonProperty("allresultsbyencounterid")]
        public int? AllResultsByEncounterId { get; set; }

        /// <summary>
        /// Filter the results based on the analyte's result status. Since the result status is a
        /// free text field, this list is not exhaustive, but does represent a majority of the used statuses.
        /// </summary>
        [JsonProperty("analyteresultstatus")]
        [JsonConverter(typeof(EnumConverter))]
        public AnalyteResultStatusEnum? AnalyteResultStatus { get; set; }

        /// <summary>
        /// Filter lab orders not individual results that are on or before this date. Example:
        /// enddate=1/21/2018. If no enddate is specified, all lab orders found since startdate will
        /// be included if specified.
        /// </summary>
        [JsonProperty("enddate")]
        [JsonConverter(typeof(DateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// ID used when the lab results sends the exact same result multiple times.
        /// </summary>
        [JsonProperty("exactduplicatedocumentid")]
        public int? ExactDuplicateDocumentId { get; set; }

        /// <summary>
        /// Filter the results based on the lab result's result status. Since the result status is a
        /// free text field, this list is not exhaustive, but does represent a majority of the used statuses.
        /// </summary>
        [JsonProperty("labresultstatus")]
        [JsonConverter(typeof(EnumConverter))]
        public LabResultStatusEnum? LabResultStatus { get; set; }

        /// <summary>
        /// Include the translation of the abnormalflag into HL7 code standards.
        /// </summary>
        [JsonProperty("showabnormaldetails")]
        public bool ShowAbnormalDetails { get; set; }

        /// <summary>
        /// Includes the lab results and analytes marked as hidden. Hidden lab results and analytes
        /// are created when they are manually entered, for example on the qm tab or in flowsheets.
        /// </summary>
        [JsonProperty("showhidden")]
        public bool ShowHidden { get; set; }

        /// <summary>
        /// If true, interpretation template added to the document is also returned.
        /// </summary>
        [JsonProperty("showtemplate")]
        public bool ShowTemplate { get; set; }

        /// <summary>
        /// Filter lab orders not individual results that are on or after this date. Example:
        /// startdate=6/21/2015. If no startdate is specified, all prior lab orders will be included
        /// until enddate if specified.
        /// </summary>
        [JsonProperty("startdate")]
        [JsonConverter(typeof(DateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// ID used when the lab sends a result and later sends a more complete version of the result
        /// with additional information.
        /// </summary>
        [JsonProperty("supersededdocumentid")]
        public int? SupersedEdDocumentId { get; set; }

        /// <summary>
        /// Number of entries to return (default 1000, max 10000). Please note that this endpoint has
        /// a different default and max than normal.
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Starting point of entries; 0-indexed
        /// </summary>
        public int? Offset { get; set; }

        public GetAnalytesFilter(int departmentId)
        {
            DepartmentId = departmentId;
        }
    }
}
