namespace AthenaHealth.Sdk.Models.Request
{
    public class GetByIdProviderFilter : GetProviderFilter
    {
        /// <summary>
        /// Possible values: 0 or 1
        /// Include the provider's federal ID number in results.
        /// </summary>
        public int ShowFederalIdNumber { get; set; }
    }
}
