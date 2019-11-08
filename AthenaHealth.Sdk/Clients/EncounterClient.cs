using System.Threading.Tasks;
using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Extensions;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients
{
    public class EncounterClient : IEncounterClient
    {
        private readonly IConnection _connection;

        public EncounterClient(IConnection connection)
        {
            _connection = connection;
        }

        [Endpoint("GET /chart/encounter/{encounterid}")]
        public async Task<Encounter> GetById(int encounterId)
        {
            Encounter[] result = await _connection.Get<Encounter[]>($"{_connection.PracticeId}/chart/encounter/{encounterId}");
            return result.FirstOrThrowException();
        }

        /// <summary>
        /// The HTML Summary for an encounter.
        /// </summary>
        /// <param name="encounterId"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        [Endpoint("GET /chart/encounters/{encounterid}/summary")]
        public async Task<EncounterSummary> GetSummary(int encounterId, GetEncounterSummaryFilter filter = null)
        {
            return await _connection.Get<EncounterSummary>($"{_connection.PracticeId}/chart/encounters/{encounterId}/summary", filter);
        }

        /// <summary>
        /// The list of diagnoses for this encounter.
        /// </summary>
        /// <param name="encounterId"></param>
        /// <returns></returns>
        [Endpoint("GET /chart/encounter/{encounterid}/diagnoses")]
        public async Task<Diagnose[]> GetDiagnoses(int encounterId)
        {
            return await _connection.Get<Diagnose[]>($"{_connection.PracticeId}/chart/encounter/{encounterId}/diagnoses");
        }

        [Endpoint("POST /chart/encounter/{encounterid}/diagnoses")]
        public async Task<Diagnose> CreateDiagnoses(int encounterId, CreateDiagnoses model)
        {
            return await _connection.Post<Diagnose>($"{_connection.PracticeId}/chart/encounter/{encounterId}/diagnoses", null, model);
        }

        [Endpoint("DELETE /chart/encounter/{encounterid}/diagnoses/{diagnosisid}")]
        public Task DeleteDiagnoses(int encounterId, int diagnosisId)
        {
            return _connection.Delete<StatusResponse>(
                $"{_connection.PracticeId}/chart/encounter/{encounterId}/diagnoses/{diagnosisId}"
            );
        }

        [Endpoint("POST /chart/encounter/{encounterid}/orders/lab")]
        public async Task<OrderLab> CreateOrderLab(int encounterId, CreateOrderLab model)
        {
            return await _connection.Post<OrderLab>($"{_connection.PracticeId}/chart/encounter/{encounterId}/orders/lab", null, model);
        }

        [Endpoint("GET /chart/encounter/{encounterid}/orders")]
        public async Task<EncounterOrdersResponse[]> GetOrders(int encounterId, EncounterGetOrdersFilter filter = null)
        {
            return await _connection.Get<EncounterOrdersResponse[]>($"{_connection.PracticeId}/chart/encounter/{encounterId}/orders", filter);
        }

        [Endpoint("GET /chart/encounter/{encounterid}/orders/{orderid}")]
        public async Task<EncounterOrder> GetOrderById(int encounterId, int orderId, EncounterGetOrderByIdFilter filter = null)
        {
            return await _connection.Get<EncounterOrder>($"{_connection.PracticeId}/chart/encounter/{encounterId}/orders/{orderId}", filter);
        }
    }
}
