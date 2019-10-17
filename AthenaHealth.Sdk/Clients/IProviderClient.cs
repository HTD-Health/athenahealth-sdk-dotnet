using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients
{
    public interface IProviderClient
    {
        Task<ProviderTypeResponse> GetProviderTypes(BaseLimitFilter filter = null);
        Task<ProviderResponse> GetAll(GetProviderFilter filter = null);
        Task<ProviderExtended> GetById(int providerId, GetByIdProviderFilter filter = null);
    }
}
