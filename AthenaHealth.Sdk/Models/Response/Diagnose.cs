using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public class Diagnose : DiagnoseForEncounter
    {
        [JsonProperty(PropertyName = "supportslaterality")]
        public bool SupportsLaterality { get; set; }

        [JsonProperty(PropertyName = "ranking")]
        public int Ranking { get; set; }

        [JsonProperty("laterality")]
        public string Laterality { get; set; }
    }
}