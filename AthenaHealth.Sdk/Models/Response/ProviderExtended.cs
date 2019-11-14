using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class ProviderExtended : Provider
    {
        /// <summary>
        /// The federal ID number for provider, if SHOWFEDERALIDNUMBER is set.
        /// </summary>
        [JsonProperty("federalidnumber")]
        public int FederalIdNumber { get; set; }
    }
}
