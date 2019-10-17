using AthenaHealth.Sdk.Clients;

namespace AthenaHealth.Sdk.Models.Request
{
    public class GetProviderFilter : BaseLimitFilter
    {
        public string Name { get; set; }

        /// <summary>
        /// The provider type to filter the results on valid provider type
        /// values can be found by using <see cref="IProviderClient.GetProviderTypes"/> GET /reference/providertypes.
        /// </summary>
        public string ProviderType { get; set; }

        /// <summary>
        /// In athenaNet's internal data structures,
        /// a single provider can be represented by multiple IDs.
        /// These IDs are used in certain external messages (e.g. HL7)
        /// and thus these IDs may need to be known by the API user as well.
        /// When set to true, a list of all of these ancillary IDs will be provided.
        /// </summary>
        public bool ShowAllProviderIds { get; set; }

        /// <summary>
        /// Min: 0.0, Max: 1.0
        /// There are situations where determining where a provider "normally" practices is desired.
        /// Unfortunately, there is no such concept in athenaNet since providers often practice in multiple locations.
        /// However, we can use some intelligence to determine this by looking back over the previous few months (90 days) to see actual practice.
        /// To enable this, set this value between 0 and 1; it is highly recommended to be at least .5.
        /// This is the ratio of appointments in a given department to the total number of appointments for that provider.
        /// A value of .5 means "the provider's appointments are 50% in the department guessed."
        /// Setting this to 1 would only return a department if ALL of the provider's appointments were in one department.
        /// </summary>
        public decimal ShowUsualDepartmentGuessThreshold { get; set; }
    }
}
