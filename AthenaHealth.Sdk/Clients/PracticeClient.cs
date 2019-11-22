using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Extensions;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Clients
{
    public class PracticeClient : IPracticeClient
    {
        private readonly IConnection _connection;

        public PracticeClient(IConnection connection)
        {
            _connection = connection;
        }

        [Endpoint("GET /practiceinfo")]
        public async Task<Practice> GetById(int practiceId, GetPracticeFilter filter = null)
        {
            PracticeResponse result = await _connection.Get<PracticeResponse>($"{practiceId}/practiceinfo", filter);
            return result.Items.FirstOrThrowException();
        }

        [Endpoint("GET /ping")]
        public async Task<bool> HasAccess(int practiceId)
        {
            HasAccessResponse result = await _connection.Get<HasAccessResponse>($"{practiceId}/ping");
            return result.IsTrue;
        }

        /// <summary>
        /// Returns <see cref="Practice"/> for <see cref="IAthenaHealthClient.PracticeId"/>.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [Endpoint]
        public async Task<Practice> GetCurrentPractice(GetPracticeFilter filter = null)
        {
            return await GetById(_connection.PracticeId, filter);
        }

        [Endpoint]
        public async Task<PracticeResponse> GetAll(GetPracticeFilter filter = null)
        {
            return await _connection.Get<PracticeResponse>($"1/practiceinfo", filter);
        }

        [Endpoint("GET /employers")]
        public async Task<EmployerResponse> GetEmployers(GetEmployersFilter filter = null)
        {
            return await _connection.Get<EmployerResponse>($"{_connection.PracticeId}/employers", filter);
        }
    }
}
