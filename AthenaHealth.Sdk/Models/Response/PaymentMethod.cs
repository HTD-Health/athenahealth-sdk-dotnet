using AthenaHealth.Sdk.Clients.Interfaces;
using Newtonsoft.Json;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Response
{
    public class PaymentMethodResponse
    {
        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("totalcount")]
        public int Total { get; set; }

        [JsonProperty("paymentmethods")]
        public PaymentMethod[] Items { get; set; }
    }

    public class PaymentMethod
    {
        /// <summary>
        /// The name of this payment method (used in athenahealth's UI).
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The payment method identifier for use in <see cref="IPatientClient.RecordPayment"/>
        /// </summary>
        [JsonProperty("paymentmethod")]
        public string IdentifierName { get; set; }
    }
}
