using System.Threading.Tasks;
using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients
{
    public class DictionaryClient : IDictionaryClient
    {
        private readonly IConnection _connection;

        public DictionaryClient(IConnection connection)
        {
            _connection = connection;
        }

        public async Task<ProviderTypeResponse> GetProviderTypes(BaseLimitFilter filter = null)
        {
            return await _connection.Get<ProviderTypeResponse>($"{_connection.PracticeId}/reference/providertypes", filter);
        }

        public async Task<OrderType[]> SearchOrderTypesByName(string name)
        {
            return await _connection.Get<OrderType[]>($"{_connection.PracticeId}/reference/order/lab", new { searchValue = name });
        }

        public async Task<Medication[]> SearchMedicationsByName(string name)
        {
            return await _connection.Get<Medication[]>($"{_connection.PracticeId}/reference/medications", new {searchValue = name});
        }

        public async Task<Allergy[]> SearchAllergiesByName(string name)
        {
            return await _connection.Get<Allergy[]>(
                $"{_connection.PracticeId}/reference/allergies", 
                new { searchValue = name }, 
                false);
        }
    }
}
