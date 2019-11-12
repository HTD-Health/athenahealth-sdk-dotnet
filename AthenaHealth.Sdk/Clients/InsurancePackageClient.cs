using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using System.Threading.Tasks;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Clients
{
    public class InsurancePackageClient : IInsurancePackageClient
    {
        private readonly IConnection _connection;

        public InsurancePackageClient(IConnection connection)
        {
            _connection = connection;
        }

        /// <summary>
        /// The top athenaNet insurance packages (over .5% utilized, up to 100 packages total) used by the practice.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [Endpoint("GET /misc/topinsurancepackages")]
        public async Task<InsurancePackageResponse<TopInsurancePackage>> GetTop(GetTopInsurancePackageFilter filter = null)
        {
            return await _connection.Get<InsurancePackageResponse<TopInsurancePackage>>($"{_connection.PracticeId}/misc/topinsurancepackages", filter);
        }

        /// <summary>
        /// Returns commonly used insurance packages used by a practice.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [Endpoint("GET /misc/commoninsurancepackages")]
        public async Task<InsurancePackageResponse<CommonInsurancePackage>> GetCommon(GetCommonInsurancePackageFilter filter = null)
        {
            return await _connection.Get<InsurancePackageResponse<CommonInsurancePackage>>($"{_connection.PracticeId}/misc/commoninsurancepackages", filter);
        }

        /// <summary>
        /// Search standard insurances based on input criteria.
        /// Max results returned is 15. Please narrow the search criteria if result is not found.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [Endpoint("GET /insurancepackages")]
        public async Task<InsurancePackageResponse> Search(SearchInsuranceFilter filter)
        {
            return await _connection.Get<InsurancePackageResponse>($"{_connection.PracticeId}/insurancepackages", filter);
        }
    }
}
