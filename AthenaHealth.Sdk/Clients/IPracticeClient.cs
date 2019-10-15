using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients
{
    public interface IPracticeClient
    {
        Task<Practice> GetById(int practiceId, BaseLimitFilter filter = null);
        Task<PracticeResponse> GetAll(BaseLimitFilter filter = null);
    }
}