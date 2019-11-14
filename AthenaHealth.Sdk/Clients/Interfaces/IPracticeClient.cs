using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IPracticeClient
    {
        [Endpoint("GET /practiceinfo")]
        Task<Practice> GetById(int practiceId, GetPracticeFilter filter = null);

        /// <summary>
        /// Returns <see cref="Practice"/> for <see cref="IAthenaHealthClient.PracticeId"/>.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [Endpoint]
        Task<Practice> GetCurrentPractice(GetPracticeFilter filter = null);

        [Endpoint]
        Task<PracticeResponse> GetAll(GetPracticeFilter filter = null);
    }
}
