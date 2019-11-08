using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IPracticeClient
    {
        [Endpoint("GET /practiceinfo")]
        Task<Practice> GetById(int practiceId, BaseLimitFilter filter = null);

        /// <summary>
        /// Returns <see cref="Practice"/> for <see cref="IAthenaHealthClient.PracticeId"/>.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<Practice> GetCurrentPractice(BaseLimitFilter filter = null);

        Task<PracticeResponse> GetAll(BaseLimitFilter filter = null);
    }
}
