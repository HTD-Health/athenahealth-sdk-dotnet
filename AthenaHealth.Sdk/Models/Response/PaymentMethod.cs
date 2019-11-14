using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Models.Response
{
    public class PaymentMethodResponse : IPagingResponse<PaymentMethod>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

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
