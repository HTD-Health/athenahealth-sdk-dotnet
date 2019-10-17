using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IPracticeClient
    {
        /// <summary>
        /// Returns <see cref="Practice"/> for <see cref="IAthenaHealthClient.PracticeId"/>.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<Practice> GetCurrentPractice(BaseLimitFilter filter = null);
        Task<Practice> GetById(int practiceId, BaseLimitFilter filter = null);
        Task<PracticeResponse> GetAll(BaseLimitFilter filter = null);
    }
}