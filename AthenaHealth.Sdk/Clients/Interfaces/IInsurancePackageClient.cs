using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IInsurancePackageClient
    {
        /// <summary>
        /// The top athenaNet insurance packages (over .5% utilized, up to 100 packages total) used by the practice.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<InsurancePackageResponse<TopInsurancePackage>> GetTop(GetTopInsurancePackageFilter filter = null);

        /// <summary>
        /// Returns commonly used insurance packages used by a practice.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<InsurancePackageResponse<CommonInsurancePackage>> GetCommon(GetCommonInsurancePackageFilter filter);

        /// <summary>
        /// Search standard insurances based on input criteria.
        /// Max results returned is 15. Please narrow the search criteria if result is not found.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<InsurancePackageResponse> Search(SearchInsuranceFilter filter = null);
    }
}
