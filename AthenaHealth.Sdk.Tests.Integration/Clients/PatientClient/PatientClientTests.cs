using System.Linq;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.Integration.Helpers;
using Shouldly;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Integration.Clients.PatientClient
{
    public class PatientClientTests
    {
        [Fact]
        public void GetPatientById_ValidId_ReturnsPatient ()
        {
            var patientClient = new Sdk.Clients.PatientClient(ConnectionFactory.CreateFromFile(@"Clients\PatientClient\ResponseOk1.json"));

            Patient patient = patientClient.GetPatientById(1);

            patient.ShouldNotBeNull();
            patient.Email.ShouldBe("monroe86@hotmail.com");
            patient.DepartmentId.ShouldBe(162);
            patient.Balances.ShouldNotBeEmpty();
            patient.Balances.First().Value.ShouldBe(10);
        }
    }
}
