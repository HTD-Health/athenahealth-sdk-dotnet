using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Models.Enums;
using AthenaHealth.Sdk.Models.Request;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.EndToEnd.Data.Encounter;
using AthenaHealth.Sdk.Tests.EndToEnd.Fixtures;
using Shouldly;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace AthenaHealth.Sdk.Tests.EndToEnd
{
    public class EncounterClientTests : IClassFixture<AthenaHealthClientFixture>
    {
        private readonly IAthenaHealthClient _client;

        public EncounterClientTests(AthenaHealthClientFixture athenaHealthClientFixture)
        {
            _client = athenaHealthClientFixture.Client;
        }

        [Fact]
        public async Task GetById_ExistingId_ReturnsRecord()
        {
            int encounterId = 1;

            Encounter response = await _client.Encounters.GetById(encounterId);

            response.Id.ShouldBe(encounterId);
            response.ShouldNotBeNull();
        }

        [Fact]
        public async Task GetById_NotExistingId_ThrowsApiException()
        {
            await Assert.ThrowsAsync<ApiValidationException>(() =>
                _client.Encounters.GetById(999)
                );
        }

        [Fact]
        public async Task GetSummary_ExistingId_ReturnsRecord()
        {
            int encounterId = 1;

            EncounterSummary response = await _client.Encounters.GetSummary(encounterId);

            response.ShouldNotBeNull();
            response.Html.ShouldNotBeNull();
        }

        [Fact]
        public async Task GetSummary_NotExistingId_ThrowsApiException()
        {
            await Assert.ThrowsAsync<ApiException>(() =>
                _client.Encounters.GetSummary(999)
            );
        }

        [Fact]
        public async Task GetDiagnoses_ExistingId_ReturnsRecords()
        {
            int encounterId = 1;

            Diagnose[] response = await _client.Encounters.GetDiagnoses(encounterId);

            response.Length.ShouldBeGreaterThan(0);
            response.All(x => !string.IsNullOrWhiteSpace(x.Description)).ShouldBeTrue();
            response.All(x => x.IcdCodes.All(y => !string.IsNullOrWhiteSpace(y.Codeset))).ShouldBeTrue();
            response.All(x => x.IcdCodes.All(y => !string.IsNullOrWhiteSpace(y.Code))).ShouldBeTrue();
        }

        [Fact]
        public async Task GetDiagnoses_NotExistingId_ThrowsApiException()
        {
            await Assert.ThrowsAsync<ApiValidationException>(() =>
                _client.Encounters.GetDiagnoses(999)
            );
        }

        [Fact]
        public async Task CreateDiagnoses_ValidModel_CreatesDiagnoses()
        {
            // Arrange. Make sure there is no diagnosis with the same SnomedCode.
            int encounterId = 183;
            string snomedCode = "52967002";

            Diagnose[] response = await _client.Encounters.GetDiagnoses(encounterId);
            Diagnose diagnosisToDelete = response.FirstOrDefault(x => x.SnomedCode == snomedCode);
            if (diagnosisToDelete != null)
            {
                await _client.Encounters.DeleteDiagnoses(encounterId, diagnosisToDelete.Id);
            }


            // Act.
            Diagnose createdDiagnose = await _client.Encounters.CreateDiagnoses(encounterId, new CreateDiagnoses()
            {
                SnomedCode = snomedCode,
                Laterality = LateralityEnum.Left,
                Note = "testing"
            });

            // Assert.
            createdDiagnose.Note.ShouldBe("testing");
            createdDiagnose.Laterality.ToLower().ShouldBe("left");
            createdDiagnose.Id.ShouldBeGreaterThan(0);
            createdDiagnose.SnomedCode.ShouldBe(snomedCode);
        }

        [Fact]
        public async Task CreateDiagnoses_ExistingSnomedCode_ThrowsBadRequest()
        {
            var model = new CreateDiagnoses()
            {
                SnomedCode = "52967002",
                Laterality = LateralityEnum.Left,
                Note = "testing"
            };

            ApiValidationException exception = await Assert.ThrowsAsync<ApiValidationException>(() =>
                _client.Encounters.CreateDiagnoses(1, model)
            );

            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
            exception.Message.ShouldNotContain(@"""missingfields"":[""snomedcode""]");
            exception.Message.ShouldContain("Diagnosis with same snomed code already present in encounter.");
        }

        [Fact]
        public async Task CreateDiagnoses_NoExistingEncounter_ThrowsBadRequest()
        {
            var model = new CreateDiagnoses()
            {
                SnomedCode = "52967002",
                Laterality = LateralityEnum.Left,
                Note = "testing"
            };

            ApiValidationException exception = await Assert.ThrowsAsync<ApiValidationException>(() =>
                _client.Encounters.CreateDiagnoses(999, model)
            );

            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
            exception.Message.ShouldNotContain("Diagnosis with same snomed code already present in encounter.");
            exception.Message.ShouldContain("Encounter not found");
        }

        [Fact]
        public async Task DeleteDiagnoses_ExistingId_DeletesDiagnoses()
        {
            // Arrange. Make sure there is no diagnosis with the same SnomedCode.
            int encounterId = 183;
            string snomedCode = "52967002";

            Diagnose[] response = await _client.Encounters.GetDiagnoses(encounterId);
            Diagnose diagnosisToDelete = response.FirstOrDefault(x => x.SnomedCode == snomedCode);
            if (diagnosisToDelete == null)
            {
                Diagnose createDiagnose = await _client.Encounters.CreateDiagnoses(encounterId, new CreateDiagnoses()
                {
                    SnomedCode = snomedCode,
                    Laterality = LateralityEnum.Left,
                    Note = "testing"
                });
                diagnosisToDelete = createDiagnose;
            }


            // Act.
            await _client.Encounters.DeleteDiagnoses(encounterId, diagnosisToDelete.Id);
        }

        [Fact]
        public async Task DeleteDiagnoses_NoExistingEncounter_ThrowsBadRequest()
        {
            // Arrange. Make sure such diagnosis not exists.
            int encounterId = 183;
            int diagnosisId = 15448;
            try
            {
                await _client.Encounters.DeleteDiagnoses(encounterId, diagnosisId);
            }
            catch (Exception)
            {
                // ignored
            }

            ApiValidationException exception = await Assert.ThrowsAsync<ApiValidationException>(() =>
                   _client.Encounters.DeleteDiagnoses(encounterId, diagnosisId)
            );

            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
            exception.Message.ShouldContain("Diagnosis not found");
        }

        [Fact]
        public async Task CreateOrderLab_ValidModel_ReturnsDocumentId()
        {
            var model = new CreateOrderLab(353034, "52967002");

            OrderLab response = await _client.Encounters.CreateOrderLab(1, model);

            response.DocumentId.ShouldBeGreaterThan(0);
        }

        [Fact]
        public async Task CreateOrderLab_InvalidOrderTypeId_ThrowsApiValidationException()
        {
            var model = new CreateOrderLab(0, "52967002");

            ApiValidationException exception = await Assert.ThrowsAsync<ApiValidationException>(() =>
                _client.Encounters.CreateOrderLab(1, model)
            );

            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
            exception.Message.ShouldContain("You must specify which lab to order, either via the ordertypeid or a LOINC");
        }

        [Theory]
        [ClassData(typeof(GetEncounterOrdersData))]
        public async Task GetOrders_ExistingId_ReturnsRecords(int encounterId)
        {
            var response = await _client.Encounters.GetOrders(encounterId, new EncounterGetOrdersFilter()
            {
                AllowDischargeType = true,
                ShowClinicalProvider = true,
                ShowDeclinedOrders = true,
                ShowExternalCodes = true
            });

            response.Any().ShouldBeTrue();
            response.First().Orders.Length.ShouldBeGreaterThan(0);
            response.All(x => x.Orders.All(o => o.Id > 0)).ShouldBeTrue();
            response.All(x => x.Orders.Length > 0).ShouldBeTrue();
            response.All(x => !string.IsNullOrEmpty(x.DiagnosisSnomed)).ShouldBeTrue();
        }

        [Fact]
        public async Task GetOrders_NoExistingEncounter_ThrowsApiValidationException()
        {
            int encounterId = 999;

            ApiValidationException exception = await Assert.ThrowsAsync<ApiValidationException>(() =>
                _client.Encounters.GetOrders(encounterId)
            );

            exception.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
            exception.Message.ShouldContain("Encounter not found");
        }

        [Theory]
        [ClassData(typeof(GetEncounterOrderData))]
        public async Task GetOrderById_ExistingOrderId_ReturnsRecord(int encounterId, int orderId)
        {
            EncounterOrder response = await _client.Encounters.GetOrderById(encounterId, orderId, new EncounterGetOrderByIdFilter()
            {
                ShowQuestions = true,
                ShowExternalCodes = true
            });

            response.ShouldNotBeNull();
            response.Id.ShouldBeGreaterThan(0);
            response.Status.ShouldNotBeNull();
        }
    }
}
