using System.ComponentModel.DataAnnotations;
using AthenaHealth.Sdk.Models.Converters;
using AthenaHealth.Sdk.Models.Enums;
using Newtonsoft.Json;

// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Models.Request
{
    public class SearchInsuranceFilter
    {
        public SearchInsuranceFilter(string insurancePlanName, string memberId)
        {
            InsurancePlanName = insurancePlanName;
            MemberId = memberId;
        }

        /// <summary>
        /// The name of the insurer.
        /// </summary>
        [JsonProperty("insuranceplanname")]
        [Required]
        public string InsurancePlanName { get; set; }

        /// <summary>
        /// The patient's insurance member ID.
        /// </summary>
        [JsonProperty("memberid")]
        [Required]
        public string MemberId { get; set; }

        /// <summary>
        /// The insurance product type ID.
        /// </summary>
        [JsonProperty("producttypeid")]
        [JsonConverter(typeof(CustomEnumConverter))]
        public ProductTypeEnum? ProductType { get; set; }

        /// <summary>
        /// The address of the insurer.
        /// </summary>
        [JsonProperty("insuranceaddress")]
        public string InsuranceAddress { get; set; }

        /// <summary>
        /// The city of the insurer.
        /// </summary>
        [JsonProperty("insurancecity")]
        public string InsuranceCity { get; set; }

        /// <summary>
        /// The phone number of the insurer.
        /// </summary>
        [JsonProperty("insurancephone")]
        public string InsurancePhone { get; set; }

        /// <summary>
        /// 	The two letter state abbreviation of the insurer's location.
        /// </summary>
        [JsonProperty("insurancestate")]
        public string InsuranceState { get; set; }

        /// <summary>
        /// The zipcode of the insurer. Nine digit zip codes are accepted in the format of 12345-6789.
        /// </summary>
        [JsonProperty("insurancezip")]
        public string InsuranceZip { get; set; }

        /// <summary>
        /// Two letter state abbreviation that filters for insurances that cover this state.
        /// </summary>
        [JsonProperty("stateofcoverage")]
        public string StateOfCoverage { get; set; }
    }
}