using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Models.Response
{
    public class Receipt
    {
        /// <summary>
        /// If this e-payment was associated with a payment contract, this is the max amount allowed
        /// for the contract.
        /// </summary>
        [JsonProperty("epaymentcontractmaxamount")]
        public string EpaymentContractMaxAmount { get; set; }

        /// <summary>
        /// The short version of the type of card.
        /// </summary>
        [JsonProperty("cardtypeabbreviation")]
        public string CardTypeAbbreviation { get; set; }

        /// <summary>
        /// The amount of the payment.
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// Type of transaction associated with the payment.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// If this e-payment was associated with a payment contract, this is the ID of that contract.
        /// </summary>
        [JsonProperty("contractid")]
        public int? ContractId { get; set; }

        /// <summary>
        /// The last 4 digits of the card number.
        /// </summary>
        [JsonProperty("cardnumberlast4digits")]
        public string CardNumberLast4Digits { get; set; }

        /// <summary>
        /// If this e-payment was associated with a payment contract, this is the balance for the contract.
        /// </summary>
        [JsonProperty("epaymentcontractbalance")]
        public string EpaymentContractBalance { get; set; }

        /// <summary>
        /// An ID that can be used to get a receipt.
        /// </summary>
        [JsonProperty("epaymentid")]
        public int? EpaymentId { get; set; }

        /// <summary>
        /// The timestamp (Eastern) when the payment was initiated.
        /// </summary>
        [JsonProperty("requestdate")]
        public string RequestDate { get; set; }

        /// <summary>
        /// The long version of the type of card.
        /// </summary>
        [JsonProperty("cardtypename")]
        public string CardTypeName { get; set; }
    }
}
