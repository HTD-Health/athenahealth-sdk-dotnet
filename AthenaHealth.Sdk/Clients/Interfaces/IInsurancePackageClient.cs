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
    }
}
