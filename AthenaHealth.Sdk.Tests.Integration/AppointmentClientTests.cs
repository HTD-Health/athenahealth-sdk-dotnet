using System.Threading.Tasks;
using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.Integration.TestingHelpers;
using Shouldly;
using Xunit;

// ReSharper disable StringLiteralTypo
namespace AthenaHealth.Sdk.Tests.Integration
{
    public class AppointmentClientTests
    {
        [Fact]
        public async Task GetAppointmentTypes_ReturnsRecords()
        {
            var appointmentClient = new Clients.AppointmentClient(ConnectionFactory.CreateFromFile(@"Data\Appointment\GetAppointmentTypes.json"));

            AppointmentTypeResponse response = await appointmentClient.GetAppointmentTypes();

            response.Total.ShouldBe(466);
            response.Items.ShouldContain(a => a.Name == "Office Visit");
        }

        [Fact]
        public async Task GetAppointmentType_ValidId_ReturnsAppointmentType()
        {
            var appointmentClient = new Clients.AppointmentClient(ConnectionFactory.CreateFromFile(@"Data\Appointment\GetAppointmentType.json"));

            AppointmentType appointmentType = await appointmentClient.GetAppointmentType(622);

            appointmentType.ShouldNotBeNull();
            appointmentType.Name.ShouldBe("Sick Visit");
        }

        [Fact]
        public  async Task GetAppointmentType_InvalidId_ThrowException()
        {
            var appointmentClient = new Clients.AppointmentClient(ConnectionFactory.Create("[]"));
            await Should.ThrowAsync<ApiValidationException>(async () => await appointmentClient.GetAppointmentType(5000000));
        }
    }
}
