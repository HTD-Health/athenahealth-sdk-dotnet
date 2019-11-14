using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Models.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// ReSharper disable StringLiteralTypo
// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
namespace AthenaHealth.Sdk.Models.Request
{
    public class RecordPayment
    {
        /// <summary>
        /// The ID of the department where the payment or contract is being collected.
        /// </summary>
        [JsonProperty("departmentid")]
        [Required]
        public int DepartmentId { get; set; }

        /// <summary>
        /// Valid values include CASH or CHECK or anything as a result of <see cref="IDictionaryClient.GetPaymentMethods"/>
        /// Note that practices using Credit Card Plus (CCP) should typically NOT be using this call and should instead use the collectpayment endpoints to charge the card.
        /// In addition, all payments recorded via this method are subject to the same policies as any other money collected by athenahealth.
        /// </summary>
        [JsonProperty("paymentmethod")]
        [Required]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Apply the other amount value to today's service.
        /// </summary>
        [JsonProperty("todayservice")]
        public bool IsTodayService { get; set; }

        /// <summary>
        /// The date the payment was made. Defaulted to today.
        /// </summary>
        [JsonProperty("postdate")]
        [JsonConverter(typeof(CustomDateConverter), "MM/dd/yyyy")]
        public DateTime? PostDate { get; set; }

        /// <summary>
        /// The amount being collected that is not associated with individual appointment.
        /// This money goes into the "unapplied" bucket.
        /// In the future, these payments will be able to be broken down by individual claim level.
        /// Co-pay amounts should be in "copayamount".
        /// </summary>
        [JsonProperty("otheramount")]
        public string OtherAmount { get; set; }

        /// <summary>
        /// The amount associated with a particular appointment for a copay.
        /// </summary>
        [JsonProperty("copayamount")]
        public string CopayAmount { get; set; }

        /// <summary>
        /// The ID of the appointment where the copay should be applied.
        /// </summary>
        [JsonProperty("appointmentid")]
        public int? AppointmentId { get; set; }

        /// <summary>
        /// The last 4 digits of the credit card number. This is required if the payment method is a credit card.
        /// </summary>
        [JsonProperty("cardnumberlast4")]
        public string CardNumberLast4 { get; set; }

        /// <summary>
        /// The check number.
        /// This is required if the payment is made by check.
        /// </summary>
        [JsonProperty("checknumber")]
        public string CheckNumber { get; set; }

        /// <summary>
        /// A JSON representation of claim ID and payment combinations.
        /// For example, '[ { "1":"1.00"}, { "2":"5.00"} ].'
        /// This indicates a payment of $1 for claim ID #1 and a payment of $5 for claim ID #2.
        /// </summary>
        [JsonProperty("claimpayment")]
        public Dictionary<string, string> ClaimPayment { get; set; }

        public RecordPayment(int departmentId, string paymentMethod)
        {
            DepartmentId = departmentId;
            PaymentMethod = paymentMethod;
        }
    }
}
