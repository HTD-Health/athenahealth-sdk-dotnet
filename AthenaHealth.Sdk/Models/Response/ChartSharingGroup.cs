using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using System;

namespace AthenaHealth.Sdk.Models.Response
{
    public class ChartSharingGroup
    {
        /// <summary>
        /// The ID of this chart sharing group.
        /// </summary>
        [JsonProperty("chartsharinggroupid")]
        public int Id { get; set; }

        /// <summary>
        /// The name of this chart sharing group.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(DateConverter), "MM/dd/yyyy")]
        public DateTime? CreatedDate { get; set; }

        [JsonProperty("patientfacingname")]
        public string PatientFacingName { get; set; }
    }
}
