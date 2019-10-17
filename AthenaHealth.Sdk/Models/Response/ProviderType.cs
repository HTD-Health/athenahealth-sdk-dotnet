using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public class ProviderTypeResponse
    {
        [JsonProperty("totalcount")]
        public int Total { get; set; }

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
