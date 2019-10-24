using System.Threading.Tasks;
using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Http;
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

        /// <summary>
        /// The list of matching orders alias autocomplete.
        /// </summary>
        /// <param name="name">A term to search for. Must be at least 2 characters.</param>
        /// <returns></returns>
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
