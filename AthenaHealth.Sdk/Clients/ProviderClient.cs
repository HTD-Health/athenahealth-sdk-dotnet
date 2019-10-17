using System;
using System.Linq;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients
{
    public class ProviderClient : IProviderClient
    {
        private readonly IConnection _connection;

        public ProviderClient(IConnection connection)
        {
            _connection = connection;
        }

        public async Task<ProviderTypeResponse> GetProviderTypes(int practiceId, BaseLimitFilter filter = null)
        {
            return await _connection.Get<ProviderTypeResponse>($"{practiceId}/reference/providertypes", filter);
        }

        public async Task<ProviderResponse> GetAll(int practiceId, GetProviderFilter filter = null)
        {
            return await _connection.Get<ProviderResponse>($"{practiceId}/providers", filter);
        }

        public async Task<ProviderExtended> GetById(int practiceId, int providerId, GetByIdProviderFilter filter = null)
        {
            var result = await _connection.Get<ProviderExtended[]>($"{practiceId}/providers/{providerId}", filter);
            if (result.Length == 1)
            {
                return result.First();
            }

            throw new Exception("Number of Items not equals 1.");
        }
    }
}
