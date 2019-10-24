using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IOrderTypeClient
    {
        /// <summary>
        /// The list of matching orders alias autocomplete.
        /// </summary>
        /// <param name="name">A term to search for. Must be at least 2 characters.</param>
        /// <returns></returns>
        Task<OrderType[]> SearchByName(string name);
    }
}