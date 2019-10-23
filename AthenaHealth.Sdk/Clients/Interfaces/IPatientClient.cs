using System.Collections.Generic;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IPatientClient
    {
        Task<Patient> GetPatientById(int patientId, GetPatientByIdFilter getPatientByIdFilter = null);

        Task<IEnumerable<PatientWithScore>> EnhancedBestmatch(EnhancedBestmatchFilter queryParameters);

        Task<Pharmacy> GetDefaultPharmacy(int patientId, int departmentId);

        Task<PharmacyResponse> GetPreferredPharmacies(int patientId, GetPreferredPharmacyFilter getPreferredPharmacyFilter);

        Task SetDefaultPharmacy(int patientId, SetPharmacyRequest setPharmacyRequest);

        Task AddPreferredPharmacy(int patientId, SetPharmacyRequest setPharmacyRequest);

        Task<PatientResponse> GetPatients(GetPatientsFilter queryParameters);

        Task<ProblemResponse> GetPatientProblems(int patientId, GetPatientProblemsFilter queryParameters);

        Task<LabResultResponse> GetLabResults(int patientId, GetLabResultsFilter queryParameters);
    }
}
