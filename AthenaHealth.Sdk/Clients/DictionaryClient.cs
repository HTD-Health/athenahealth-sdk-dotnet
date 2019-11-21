using AthenaHealth.Sdk.Clients.Interfaces;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using System.Threading.Tasks;

namespace AthenaHealth.Sdk.Clients
{
    public class DictionaryClient : IDictionaryClient
    {
        private readonly IConnection _connection;

        public DictionaryClient(IConnection connection)
        {
            _connection = connection;
        }

        [Endpoint("GET /reference/providertypes")]
        public async Task<ProviderTypeResponse> GetProviderTypes(GetProviderTypesFilter filter = null)
        {
            return await _connection.Get<ProviderTypeResponse>($"{_connection.PracticeId}/reference/providertypes", filter);
        }

        [Endpoint("GET /configuration/validnonccpcreditcardmethods")]
        public async Task<PaymentMethodResponse> GetPaymentMethods(GetPaymentMethodsFilter filter = null)
        {
            return await _connection.Get<PaymentMethodResponse>($"{_connection.PracticeId}/configuration/validnonccpcreditcardmethods", filter);
        }

        [Endpoint("GET /reference/order/lab")]
        public async Task<OrderType[]> SearchOrderTypesByName(string name)
        {
            return await _connection.Get<OrderType[]>($"{_connection.PracticeId}/reference/order/lab", new { searchValue = name });
        }

        [Endpoint("GET /reference/medications")]
        public async Task<Medication[]> SearchMedicationsByName(string name)
        {
            return await _connection.Get<Medication[]>($"{_connection.PracticeId}/reference/medications", new { searchValue = name });
        }

        [Endpoint("GET /reference/allergies")]
        public async Task<Allergy[]> SearchAllergiesByName(string name)
        {
            return await _connection.Get<Allergy[]>($"{_connection.PracticeId}/reference/allergies", new { searchValue = name }, false);
        }

        [Endpoint("GET /chart/configuration/medicalhistory")]
        public async Task<MedicalHistoryQuestionResponse> GetMedicalHistoryQuestions(GetMedicalHistoryQuestionsFilter filter = null)
        {
            return await _connection.Get<MedicalHistoryQuestionResponse>($"{_connection.PracticeId}/chart/configuration/medicalhistory", filter);
        }

        [Endpoint("GET /chart/configuration/socialhistory")]
        public async Task<SocialHistoryTemplate[]> GetSocialHistoryTemplates()
        {
            return await _connection.Get<SocialHistoryTemplate[]>($"{_connection.PracticeId}/chart/configuration/socialhistory");
        }

        [Endpoint("GET /ethnicities")]
        public async Task<Ethnicity[]> GetEthnicities()
        {
            return await _connection.Get<Ethnicity[]>($"{_connection.PracticeId}/ethnicities");
        }

        [Endpoint("GET /languages")]
        public async Task<Language[]> GetLanguages()
        {
            return await _connection.Get<Language[]>($"{_connection.PracticeId}/languages");
        }

        [Endpoint("GET /races")]
        public async Task<Race[]> GetRaces()
        {
            return await _connection.Get<Race[]>($"{_connection.PracticeId}/races");
        }

        [Endpoint("GET /states")]
        public async Task<State[]> GetStates()
        {
            return await _connection.Get<State[]>($"{_connection.PracticeId}/states");
        }

        [Endpoint("GET /misc/patientlocations")]
        public async Task<PatientLocation[]> GetPatientLocations()
        {
            return await _connection.Get<PatientLocation[]>($"{_connection.PracticeId}/misc/patientlocations");
        }

        [Endpoint("GET /configuration/patients/genderidentity")]
        public async Task<GenderIdentityResponse> GetGenderIdentities(GetGenderIdentitiesFilter queryParameters = null)
        {
            return await _connection.Get<GenderIdentityResponse>($"{_connection.PracticeId}/configuration/patients/genderidentity", queryParameters);
        }

        [Endpoint("GET /customfields")]
        public async Task<CustomField[]> GetCustomFields()
        {
            return await _connection.Get<CustomField[]>($"{_connection.PracticeId}/customfields");
        }

        [Endpoint("GET /mobilecarriers")]
        public async Task<MobileCarrier[]> GetMobileCarriers()
        {
            return await _connection.Get<MobileCarrier[]>($"{_connection.PracticeId}/mobilecarriers");
        }

        [Endpoint("GET /reference/allergies/reactions")]
        public async Task<AllergyReaction[]> GetAllergyReactions()
        {
            return await _connection.Get<AllergyReaction[]>($"{_connection.PracticeId}/reference/allergies/reactions");
        }

        [Endpoint("GET /reference/allergies/severities")]
        public async Task<AllergySeverity[]> GetAllergySeverities()
        {
            return await _connection.Get<AllergySeverity[]>($"{_connection.PracticeId}/reference/allergies/severities");
        }

        [Endpoint("GET /slidingfeeplans")]
        public async Task<SlidingFeePlanResponse> GetSlidingFeePlans(GetSlidingFeePlansFilter queryParameters = null)
        {
            return await _connection.Get<SlidingFeePlanResponse>($"{_connection.PracticeId}/slidingfeeplans", queryParameters);
        }

        [Endpoint("GET /chart/configuration/vitals")]
        public async Task<VitalResponse> GetVitals(GetVitalsFilter queryParameters = null)
        {
            return await _connection.Get<VitalResponse>($"{_connection.PracticeId}/chart/configuration/vitals", queryParameters);
        }

        [Endpoint("GET /reference/providerspecialties")]
        public async Task<SpecialtyResponse> GetSpecialties(GetSpecialtiesFilter queryParameters = null)
        {
            return await _connection.Get<SpecialtyResponse>($"{_connection.PracticeId}/reference/providerspecialties", queryParameters);
        }

        [Endpoint("GET /configuration/chartsharinggroups")]
        public async Task<ChartSharingGroup[]> GetChartSharingGroups()
        {
            return await _connection.Get<ChartSharingGroup[]>($"{_connection.PracticeId}/configuration/chartsharinggroups");
        }

        [Endpoint("GET /communicatorbrands")]
        public async Task<CommunicatorBrandResponse> GetCommunicatorBrands(GetCommunicatorBrandsFilter queryParameters = null)
        {
            return await _connection.Get<CommunicatorBrandResponse>($"{_connection.PracticeId}/communicatorbrands", queryParameters);
        }

        [Endpoint("GET /chart/configuration/officeordertypes")]
        public async Task<OfficeOrderType[]> GetOfficeOrderTypes()
        {
            return await _connection.Get<OfficeOrderType[]>($"{_connection.PracticeId}/chart/configuration/officeordertypes");
        }
    }
}
