using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class ProviderTypeResponse : IPagingResponse<ProviderType>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("providertypes")]
        public ProviderType[] Items { get; set; }
    }

    public class ProviderType
    {
        /// <summary>
        /// Id of <see cref="ProviderType"/>.
        /// For example: "ACNP".
        /// </summary>
        [JsonProperty("providertypeid")]
        public string Id { get; set; }

        /// <summary>
        /// Name of <see cref="ProviderType"/>.
        /// For example: ""ACUTE CARE - NURSE PRACTITIONER".
        /// </summary>
        [JsonProperty("providertype")]
        public string Name { get; set; }
    }
}
