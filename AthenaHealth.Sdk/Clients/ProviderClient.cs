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

        public async Task<ProviderTypeResponse> GetProviderTypes(BaseLimitFilter filter = null)
        {
            return await _connection.Get<ProviderTypeResponse>($"{_connection.Credentials.PracticeId}/reference/providertypes", filter);
        }

        public async Task<ProviderResponse> GetAll(GetProviderFilter filter = null)
        {
            return await _connection.Get<ProviderResponse>($"{_connection.Credentials.PracticeId}/providers", filter);
        }

        public async Task<ProviderExtended> GetById(int providerId, GetByIdProviderFilter filter = null)
        {
            var result = await _connection.Get<ProviderExtended[]>($"{_connection.Credentials.PracticeId}/providers/{providerId}", filter);
            if (result.Length == 1)
            {
                return result.First();
            }

            throw new Exception("Number of Items not equals 1.");
        }
    }
}
