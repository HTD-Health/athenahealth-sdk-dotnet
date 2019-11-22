using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;
using System;

// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class ChartGroupResponse : IPagingResponse<ChartGroup>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("chartlist")]
        public ChartGroup[] Items { get; set; }
    }

    public class ChartGroup 
    {
        [JsonProperty("chartsharinggroupid")]
        public int ChartSharingGroupId { get; set; }

        [JsonProperty("sampledepartmentid")]
        public int SampleDepartmentId { get; set; }
    }
}
