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
        public async Task<Practice> GetById(int practiceId, BaseLimitFilter filter = null)
        {
            PracticeResponse result = await _connection.Get<PracticeResponse>($"{practiceId}/practiceinfo", filter);
            return result.Items.FirstOrThrowException();
        }

        /// <summary>
        /// Returns <see cref="Practice"/> for <see cref="IAthenaHealthClient.PracticeId"/>.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [Endpoint]
        public async Task<Practice> GetCurrentPractice(BaseLimitFilter filter = null)
        {
            return await GetById(_connection.PracticeId, filter);
        }

        [Endpoint]
        public async Task<PracticeResponse> GetAll(BaseLimitFilter filter = null)
        {
            return await _connection.Get<PracticeResponse>($"1/practiceinfo", filter);
        }
    }
}
