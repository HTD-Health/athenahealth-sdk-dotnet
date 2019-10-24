using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IDictionaryClient
    {
        /// <summary>
        /// Get the list of valid provider types.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<ProviderTypeResponse> GetProviderTypes(BaseLimitFilter filter = null);

        /// <summary>
        /// The list of matching orders alias autocomplete.
        /// </summary>
        /// <param name="name">A term to search for. Must be at least 2 characters.</param>
        /// <returns></returns>
        Task<OrderType[]> SearchOrderTypesByName(string name);

        /// <summary>
        /// Return a list of matching medications alias autocomplete.
        /// </summary>
        /// <param name="name">A term to search for. Must be at least 2 characters.</param>
        /// <returns></returns>
        Task<Medication[]> SearchMedicationsByName(string name);

        /// <summary>
        /// Return a short list of matching allergies alias autocomplete.
        /// </summary>
        /// <param name="name">A term to search for. Must be at least 2 characters.</param>
        /// <returns></returns>
        Task<Allergy[]> SearchAllergiesByName(string name);
    }
}