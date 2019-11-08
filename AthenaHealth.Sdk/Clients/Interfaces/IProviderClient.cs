using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IProviderClient
    {
        [Endpoint("GET /providers")]
        Task<ProviderResponse> GetAll(GetProviderFilter filter = null);

        [Endpoint("GET /providers/{providerid}")]
        Task<ProviderExtended> GetById(int providerId, GetByIdProviderFilter filter = null);
    }
}
