using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class EncounterSummary
    {
        [JsonProperty("summaryhtml")]
        public string Html { get; set; }
    }
}
