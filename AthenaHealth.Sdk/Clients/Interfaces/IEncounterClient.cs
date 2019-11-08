using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IEncounterClient
    {
        [Endpoint("GET /chart/encounter/{encounterid}")]
        Task<Encounter> GetById(int encounterId);

        /// <summary>
        /// The HTML Summary for an encounter.
        /// </summary>
        /// <param name="encounterId"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        [Endpoint("GET /chart/encounters/{encounterid}/summary")]
        Task<EncounterSummary> GetSummary(int encounterId, GetEncounterSummaryFilter filter = null);

        /// <summary>
        /// The list of diagnoses for this encounter.
        /// </summary>
        /// <param name="encounterId"></param>
        /// <returns></returns>
        [Endpoint("GET /chart/encounter/{encounterid}/diagnoses")]
        Task<Diagnose[]> GetDiagnoses(int encounterId);

        [Endpoint("POST /chart/encounter/{encounterid}/diagnoses")]
        Task<Diagnose> CreateDiagnoses(int encounterId, CreateDiagnoses model);

        [Endpoint("DELETE /chart/encounter/{encounterid}/diagnoses/{diagnosisid}")]
        Task DeleteDiagnoses(int encounterId, int diagnosisId);

        /// <summary>
        /// Add a lab order.
        /// </summary>
        /// <param name="encounterId">The encounter ID to add this order to.</param>
        /// <param name="model"></param>
        /// <returns></returns>
        [Endpoint("POST /chart/encounter/{encounterid}/orders/lab")]
        Task<OrderLab> CreateOrderLab(int encounterId, CreateOrderLab model);

        /// <summary>
        /// Given an encounter returns the list of orders broken down by diagnosis.
        /// </summary>
        /// <param name="encounterId"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        [Endpoint("GET /chart/encounter/{encounterid}/orders")]
        Task<EncounterOrdersResponse[]> GetOrders(int encounterId, EncounterGetOrdersFilter filter = null);

        /// <summary>
        /// Retrieve some data regarding an order, including the list of documents attached to the
        /// order. Useful for finding attached letters, prescription renewal chains, and lab/imaging results.
        /// </summary>
        /// <param name="encounterId"></param>
        /// <param name="orderId"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        [Endpoint("GET /chart/encounter/{encounterid}/orders/{orderid}")]
        Task<EncounterOrder> GetOrderById(int encounterId, int orderId, EncounterGetOrderByIdFilter filter = null);
    }
}
