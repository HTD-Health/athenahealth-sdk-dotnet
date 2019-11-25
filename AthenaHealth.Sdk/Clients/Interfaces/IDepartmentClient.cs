using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IDepartmentClient
    {
        [Endpoint("GET /departments")]
        Task<DepartmentResponse> GetAll(GetDepartmentsFilter filter = null);

        [Endpoint("GET /departments/{departmentid}")]
        Task<Department> GetById(int departmentId, GetDepartmentFilter filter = null);

        /// <summary>
        /// A text search for facilities of a particular type.
        /// Examples include pharmacies, labs, imaging centers, and DME suppliers.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [Endpoint("GET /chart/configuration/facilities")]
        Task<Facility[]> SearchFacilities(SearchFacilitiesFilter filter);

        [Endpoint("GET /departments/{departmentid}/checkinrequired")]
        Task<string[]> GetCheckInRequiredFields(int departmentId);
    }
}
