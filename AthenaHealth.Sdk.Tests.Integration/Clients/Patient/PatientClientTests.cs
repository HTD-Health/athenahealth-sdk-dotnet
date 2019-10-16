using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Tests.Integration.TestingHelpers;
using Shouldly;
using Xunit;
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Tests.Integration.Clients.Patient
{
    public class PatientClientTests
    {
        [Fact]
        public async Task GetPatientById_ValidId_ReturnsPatient ()
        {
            var patientClient = new Sdk.Clients.PatientClient(ConnectionFactory.CreateFromFile(@"Clients\Patient\Patient.json"));

            Models.Response.Patient patient = await patientClient.GetPatientById(1);

            patient.ShouldNotBeNull();
            patient.Email.ShouldBe("monroe86@hotmail.com");
            patient.DepartmentId.ShouldBe(162);
            patient.Balances.ShouldNotBeEmpty();
            patient.Balances.First().Value.ShouldBe(10);
        }

        [Fact]
        public void GetPatientById_InvalidId_ThrowsApiException ()
        {
            var patientClient = new Sdk.Clients.PatientClient(ConnectionFactory.CreateFromFile(@"Clients\Patient\GetPatient_InvalidId.json", HttpStatusCode.OK)); //In this case athena respond with HTTP 200 OK and status code 400 in response body
            ApiException exc = Should.Throw<ApiException>(async () => await patientClient.GetPatientById(0));
            exc.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task GetDefaultPharmacy_ValidId_ReturnsDefaultPharmacy ()
        {
            var patientClient = new Sdk.Clients.PatientClient(ConnectionFactory.CreateFromFile(@"Clients\Patient\GetDefaultPharmacy.json", HttpStatusCode.OK));
            
            Models.Response.Pharmacy pharmacy = await patientClient.GetDefaultPharmacy(195900, 300, 1);

            pharmacy.ShouldNotBeNull();
            pharmacy.State.ShouldBe("NY");
            pharmacy.ClinicalProviderName.ShouldBe("Himani Shishodia");
        }
    }
}
