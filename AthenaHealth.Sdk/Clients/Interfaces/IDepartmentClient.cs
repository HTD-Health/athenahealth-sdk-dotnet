using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IDepartmentClient
    {
        Task<DepartmentResponse> GetAll(GetDepartmentFilter filter = null);
        Task<Department> GetById(int departmentId, GetDepartmentFilter filter = null);

        /// <summary>
        /// A text search for facilities of a particular type.
        /// Examples include pharmacies, labs, imaging centers, and DME suppliers.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<Facility[]> SearchFacilities(SearchFacilitiesFilter filter);
    }
}
