using AthenaHealth.Sdk.Models.Response.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AthenaHealth.Sdk.Models.Response
{
    public class SlidingFeePlanResponse : IPagingResponse<SlidingFeePlan>
    {
        public int Total { get; set; }

        public string Next { get; set; }

        public string Previous { get; set; }

        [JsonProperty("slidingfeeplans")]
        public SlidingFeePlan[] Items { get; set; }
    }

    public class SlidingFeePlan
    {
        /// <summary>
        /// Notes about the program that this plan belongs to.  May not be patient-facing!
        /// </summary>
        [JsonProperty("programnote")]
        public string ProgramNote { get; set; }

        /// <summary>
        /// The name of this sliding fee plan.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The percent of poverty upper bound that this plan applies to.
        /// </summary>
        [JsonProperty("povertylevelupperbound")]
        public string PovertyLevelUpperBound { get; set; }

        /// <summary>
        /// An ID representation the type of sliding fee plan; name and shortname also provided.
        /// </summary>
        [JsonProperty("calculationtypeid")]
        public int? CalculationTypeId { get; set; }

        /// <summary>
        /// The name of the program that this plan belongs to.
        /// </summary>
        [JsonProperty("programname")]
        public string ProgramName { get; set; }

        /// <summary>
        /// The percent of poverty lower bound that this plan applies to.
        /// </summary>
        [JsonProperty("povertylevellowerbound")]
        public string PovertyLevelLowerBound { get; set; }

        /// <summary>
        /// A note about this plan.  This may not be patient-facing!
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// The percentage amount of the charge that the patient pays under this plan.
        /// </summary>
        [JsonProperty("percentageresponsibility")]
        public string PercentageResponsibility { get; set; }

        /// <summary>
        /// The (short) name of the type of sliding fee plan.
        /// </summary>
        [JsonProperty("calculationtypeshortname")]
        public string CalculationTypeShortName { get; set; }

        /// <summary>
        /// The flat fee amount required under this plan.
        /// </summary>
        [JsonProperty("flatfeeresponsibility")]
        public string FlatFeeResponsibility { get; set; }

        /// <summary>
        /// The ordering in which this sliding fee plan is displayed.
        /// </summary>
        [JsonProperty("ordering")]
        public string Ordering { get; set; }

        /// <summary>
        /// The (long) name of the type of sliding fee plan
        /// </summary>
        [JsonProperty("calculationtypename")]
        public string CalculationTypeName { get; set; }

        /// <summary>
        /// The sliding fee plan ID.
        /// </summary>
        [JsonProperty("slidingfeeplanid")]
        public int? Id { get; set; }
    }
}
