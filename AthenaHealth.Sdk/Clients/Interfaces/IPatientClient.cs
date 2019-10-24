using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Clients.Interfaces
{
    public interface IPatientClient
    {
        Task<Patient> GetPatientById(int patientId, GetPatientByIdFilter queryParameters = null);

        Task<PatientWithScore[]> EnhancedBestmatch(EnhancedBestmatchFilter queryParameters);

        Task<Pharmacy> GetDefaultPharmacy(int patientId, int departmentId);

        Task<PharmacyResponse> GetPreferredPharmacies(int patientId, GetPreferredPharmacyFilter queryParameters);

        Task SetDefaultPharmacy(int patientId, SetPharmacyRequest request);

        Task AddPreferredPharmacy(int patientId, SetPharmacyRequest request);

        Task<PatientResponse> GetPatients(GetPatientsFilter queryParameters);

        Task<ProblemResponse> GetPatientProblems(int patientId, GetPatientProblemsFilter queryParameters);

        Task<LabResultResponse> GetLabResults(int patientId, GetLabResultsFilter queryParameters);

        Task<MedicalHistory> GetMedicalHistory(int patientId, int departmentId);

        Task<PrescriptionResponse> GetPrescriptions(int patientId, GetPrescriptionsFilter queryParameters);

        Task<AnalyteResponse> GetAnalytes(int patientId, GetAnalytesFilter queryParameters);

        Task<PatientMedication> GetMedications(int patientId, GetMedicationsFilter queryParameters);
    }
}
