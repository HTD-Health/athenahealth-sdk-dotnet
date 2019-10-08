using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Http;
using NSubstitute;
using Shouldly;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Http
{
    public class ConnectionTests
    {
        private readonly IHttpClientExtended _httpClientExtended;

        private readonly IConnection _connection;

        private readonly Credentials _credentials;

        private readonly ApiVersion _apiVersion;

        public ConnectionTests()
        {
            _httpClientExtended = Substitute.For<IHttpClientExtended>();
            _credentials = new Credentials("login", "password");
            _apiVersion = ApiVersion.Preview;

            _connection = new Connection(_httpClientExtended, _credentials, _apiVersion);

            HttpResponseMessage positiveAuthorizationResponse = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("{\"access_token\":\"53nde65ep9dx5f2n4up39hj3\",\"token_type\":\"bearer\",\"expires_in\":3600,\"refresh_token\":\"np4crgmae29cnuvw6p3tgus2\"}")
            };
            _httpClientExtended.SendAsync(Arg.Is<HttpRequestMessage>(x => x.RequestUri.AbsoluteUri.EndsWith("/token"))).Returns(Task.FromResult(positiveAuthorizationResponse));
            _httpClientExtended.DefaultRequestHeaders.Returns(new HttpRequestMessage().Headers); // This is only way to create headers
        }

        //[Fact]
        //[SuppressMessage("ReSharper", "StringLiteralTypo")]
        //public void HttpRequest_ValidationErrorCode_ExceptionContainsErrorInfo()
        //{
        //    var error = @"{""missingfields"": [""patientid""], ""error"": ""Additional fields are required.""}";
        //    Connection connection = ConnectionFactory.Create(error, HttpStatusCode.BadRequest);

        //    ApiException exc = Should.Throw<ApiException>(async () => await connection.GetAsync(""));
        //    exc.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        //    exc.ResponseError.ShouldBe(error);
        //}

        //[Fact]
        //public void HttpRequest_NullContent_NotThrowException()
        //{
        //    var connection = ConnectionFactory.Create(null, HttpStatusCode.OK);
        //    Should.NotThrow(async () => await connection.GetAsync<Patient>(""));
        //}

        [Theory]
        [InlineData(HttpStatusCode.BadRequest)]
        [InlineData(HttpStatusCode.Unauthorized)]
        [InlineData(HttpStatusCode.PaymentRequired)]
        [InlineData(HttpStatusCode.Forbidden)]
        [InlineData(HttpStatusCode.NotFound)]
        [InlineData(HttpStatusCode.MethodNotAllowed)]
        [InlineData(HttpStatusCode.NotAcceptable)]
        [InlineData(HttpStatusCode.ProxyAuthenticationRequired)]
        [InlineData(HttpStatusCode.RequestTimeout)]
        [InlineData(HttpStatusCode.Conflict)]
        public void GetAsync_ValidationStatusCode_ThrowsApiValidationException(HttpStatusCode statusCode)
        {
            // Arrange
            HttpResponseMessage responseMessage = new HttpResponseMessage(statusCode);
            _httpClientExtended.GetAsync(Arg.Any<string>()).Returns(Task.FromResult(responseMessage));

            // Act
            Should.Throw<ApiValidationException>(async () => await _connection.GetAsync(""));

            // Assert
            _httpClientExtended.Received(1).GetAsync(Arg.Any<string>());
        }

        [Theory]
        [InlineData(HttpStatusCode.BadRequest)]
        [InlineData(HttpStatusCode.Unauthorized)]
        [InlineData(HttpStatusCode.PaymentRequired)]
        [InlineData(HttpStatusCode.Forbidden)]
        [InlineData(HttpStatusCode.NotFound)]
        [InlineData(HttpStatusCode.MethodNotAllowed)]
        [InlineData(HttpStatusCode.NotAcceptable)]
        [InlineData(HttpStatusCode.ProxyAuthenticationRequired)]
        [InlineData(HttpStatusCode.RequestTimeout)]
        [InlineData(HttpStatusCode.Conflict)]
        public void DeleteAsync_ValidationStatusCode_ThrowsApiValidationException(HttpStatusCode statusCode)
        {
            // Arrange
            HttpResponseMessage responseMessage = new HttpResponseMessage(statusCode);
            _httpClientExtended.DeleteAsync(Arg.Any<string>()).Returns(Task.FromResult(responseMessage));

            // Act
            Should.Throw<ApiValidationException>(async () => await _connection.DeleteAsync(""));

            // Assert
            _httpClientExtended.Received(1).DeleteAsync(Arg.Any<string>());
        }

        [Theory]
        [InlineData(HttpStatusCode.BadRequest)]
        [InlineData(HttpStatusCode.Unauthorized)]
        [InlineData(HttpStatusCode.PaymentRequired)]
        [InlineData(HttpStatusCode.Forbidden)]
        [InlineData(HttpStatusCode.NotFound)]
        [InlineData(HttpStatusCode.MethodNotAllowed)]
        [InlineData(HttpStatusCode.NotAcceptable)]
        [InlineData(HttpStatusCode.ProxyAuthenticationRequired)]
        [InlineData(HttpStatusCode.RequestTimeout)]
        [InlineData(HttpStatusCode.Conflict)]
        public void PostAsync_ValidationStatusCode_ThrowsApiValidationException(HttpStatusCode statusCode)
        {
            // Arrange
            HttpResponseMessage responseMessage = new HttpResponseMessage(statusCode);
            _httpClientExtended.PostAsync(Arg.Any<string>(), Arg.Any<HttpContent>()).Returns(Task.FromResult(responseMessage));

            // Act
            Should.Throw<ApiValidationException>(async () => await _connection.PostAsync("", null));

            // Assert
            _httpClientExtended.Received(1).PostAsync(Arg.Any<string>(), Arg.Any<HttpContent>());
        }

        [Theory]
        [InlineData(HttpStatusCode.BadRequest)]
        [InlineData(HttpStatusCode.Unauthorized)]
        [InlineData(HttpStatusCode.PaymentRequired)]
        [InlineData(HttpStatusCode.Forbidden)]
        [InlineData(HttpStatusCode.NotFound)]
        [InlineData(HttpStatusCode.MethodNotAllowed)]
        [InlineData(HttpStatusCode.NotAcceptable)]
        [InlineData(HttpStatusCode.ProxyAuthenticationRequired)]
        [InlineData(HttpStatusCode.RequestTimeout)]
        [InlineData(HttpStatusCode.Conflict)]
        public void PutAsync_ValidationStatusCode_ThrowsApiValidationException(HttpStatusCode statusCode)
        {
            // Arrange
            HttpResponseMessage responseMessage = new HttpResponseMessage(statusCode);
            _httpClientExtended.PutAsync(Arg.Any<string>(), Arg.Any<HttpContent>()).Returns(Task.FromResult(responseMessage));

            // Act
            Should.Throw<ApiValidationException>(async () => await _connection.PutAsync("", null));

            // Assert
            _httpClientExtended.Received(1).PutAsync(Arg.Any<string>(), Arg.Any<HttpContent>());
        }

        [Theory]
        [InlineData(HttpStatusCode.BadRequest)]
        [InlineData(HttpStatusCode.Unauthorized)]
        [InlineData(HttpStatusCode.PaymentRequired)]
        [InlineData(HttpStatusCode.Forbidden)]
        [InlineData(HttpStatusCode.NotFound)]
        [InlineData(HttpStatusCode.MethodNotAllowed)]
        [InlineData(HttpStatusCode.NotAcceptable)]
        [InlineData(HttpStatusCode.ProxyAuthenticationRequired)]
        [InlineData(HttpStatusCode.RequestTimeout)]
        [InlineData(HttpStatusCode.Conflict)]
        public void PatchAsync_ValidationStatusCode_ThrowsApiValidationException(HttpStatusCode statusCode)
        {
            // Arrange
            HttpResponseMessage responseMessage = new HttpResponseMessage(statusCode);
            _httpClientExtended.PatchAsync(Arg.Any<string>(), Arg.Any<HttpContent>()).Returns(Task.FromResult(responseMessage));

            // Act
            Should.Throw<ApiException>(async () => await _connection.PatchAsync("", null));

            // Assert
            _httpClientExtended.Received(1).PatchAsync(Arg.Any<string>(), Arg.Any<HttpContent>());
        }

        [Theory]
        [InlineData(HttpStatusCode.InternalServerError)]
        [InlineData(HttpStatusCode.NotImplemented)]
        [InlineData(HttpStatusCode.BadGateway)]
        [InlineData(HttpStatusCode.ServiceUnavailable)]
        [InlineData(HttpStatusCode.GatewayTimeout)]
        [InlineData(HttpStatusCode.HttpVersionNotSupported)]
        [InlineData(HttpStatusCode.VariantAlsoNegotiates)]
        [InlineData(HttpStatusCode.InsufficientStorage)]
        [InlineData(HttpStatusCode.LoopDetected)]
        [InlineData(HttpStatusCode.NotExtended)]
        [InlineData(HttpStatusCode.NetworkAuthenticationRequired)]
        public void GetAsync_ErrorStatusCode_ThrowsApiException(HttpStatusCode statusCode)
        {
            // Arrange
            HttpResponseMessage responseMessage = new HttpResponseMessage(statusCode);
            _httpClientExtended.GetAsync(Arg.Any<string>()).Returns(Task.FromResult(responseMessage));

            // Act
            Should.Throw<ApiException>(async () => await _connection.GetAsync(""));

            // Assert
            _httpClientExtended.Received(1).GetAsync(Arg.Any<string>());
        }

        [Theory]
        [InlineData(HttpStatusCode.InternalServerError)]
        [InlineData(HttpStatusCode.NotImplemented)]
        [InlineData(HttpStatusCode.BadGateway)]
        [InlineData(HttpStatusCode.ServiceUnavailable)]
        [InlineData(HttpStatusCode.GatewayTimeout)]
        [InlineData(HttpStatusCode.HttpVersionNotSupported)]
        [InlineData(HttpStatusCode.VariantAlsoNegotiates)]
        [InlineData(HttpStatusCode.InsufficientStorage)]
        [InlineData(HttpStatusCode.LoopDetected)]
        [InlineData(HttpStatusCode.NotExtended)]
        [InlineData(HttpStatusCode.NetworkAuthenticationRequired)]
        public void DeleteAsync_ErrorStatusCode_ThrowsApiException(HttpStatusCode statusCode)
        {
            // Arrange
            HttpResponseMessage responseMessage = new HttpResponseMessage(statusCode);
            _httpClientExtended.DeleteAsync(Arg.Any<string>()).Returns(Task.FromResult(responseMessage));

            // Act
            Should.Throw<ApiException>(async () => await _connection.DeleteAsync(""));

            // Assert
            _httpClientExtended.Received(1).DeleteAsync(Arg.Any<string>());
        }

        [Theory]
        [InlineData(HttpStatusCode.InternalServerError)]
        [InlineData(HttpStatusCode.NotImplemented)]
        [InlineData(HttpStatusCode.BadGateway)]
        [InlineData(HttpStatusCode.ServiceUnavailable)]
        [InlineData(HttpStatusCode.GatewayTimeout)]
        [InlineData(HttpStatusCode.HttpVersionNotSupported)]
        [InlineData(HttpStatusCode.VariantAlsoNegotiates)]
        [InlineData(HttpStatusCode.InsufficientStorage)]
        [InlineData(HttpStatusCode.LoopDetected)]
        [InlineData(HttpStatusCode.NotExtended)]
        [InlineData(HttpStatusCode.NetworkAuthenticationRequired)]
        public void PostAsync_ErrorStatusCode_ThrowsApiException(HttpStatusCode statusCode)
        {
            // Arrange
            HttpResponseMessage responseMessage = new HttpResponseMessage(statusCode);
            _httpClientExtended.PostAsync(Arg.Any<string>(), Arg.Any<HttpContent>()).Returns(Task.FromResult(responseMessage));

            // Act
            Should.Throw<ApiException>(async () => await _connection.PostAsync("", null));

            // Assert
            _httpClientExtended.Received(1).PostAsync(Arg.Any<string>(), Arg.Any<HttpContent>());
        }

        [Theory]
        [InlineData(HttpStatusCode.InternalServerError)]
        [InlineData(HttpStatusCode.NotImplemented)]
        [InlineData(HttpStatusCode.BadGateway)]
        [InlineData(HttpStatusCode.ServiceUnavailable)]
        [InlineData(HttpStatusCode.GatewayTimeout)]
        [InlineData(HttpStatusCode.HttpVersionNotSupported)]
        [InlineData(HttpStatusCode.VariantAlsoNegotiates)]
        [InlineData(HttpStatusCode.InsufficientStorage)]
        [InlineData(HttpStatusCode.LoopDetected)]
        [InlineData(HttpStatusCode.NotExtended)]
        [InlineData(HttpStatusCode.NetworkAuthenticationRequired)]
        public void PutAsync_ErrorStatusCode_ThrowsApiException(HttpStatusCode statusCode)
        {
            // Arrange
            HttpResponseMessage responseMessage = new HttpResponseMessage(statusCode);
            _httpClientExtended.PutAsync(Arg.Any<string>(), Arg.Any<HttpContent>()).Returns(Task.FromResult(responseMessage));

            // Act
            Should.Throw<ApiException>(async () => await _connection.PutAsync("", null));

            // Assert
            _httpClientExtended.Received(1).PutAsync(Arg.Any<string>(), Arg.Any<HttpContent>());
        }

        [Theory]
        [InlineData(HttpStatusCode.InternalServerError)]
        [InlineData(HttpStatusCode.NotImplemented)]
        [InlineData(HttpStatusCode.BadGateway)]
        [InlineData(HttpStatusCode.ServiceUnavailable)]
        [InlineData(HttpStatusCode.GatewayTimeout)]
        [InlineData(HttpStatusCode.HttpVersionNotSupported)]
        [InlineData(HttpStatusCode.VariantAlsoNegotiates)]
        [InlineData(HttpStatusCode.InsufficientStorage)]
        [InlineData(HttpStatusCode.LoopDetected)]
        [InlineData(HttpStatusCode.NotExtended)]
        [InlineData(HttpStatusCode.NetworkAuthenticationRequired)]
        public void PatchAsync_ErrorStatusCode_ThrowsApiException(HttpStatusCode statusCode)
        {
            // Arrange
            HttpResponseMessage responseMessage = new HttpResponseMessage(statusCode);
            _httpClientExtended.PatchAsync(Arg.Any<string>(), Arg.Any<HttpContent>()).Returns(Task.FromResult(responseMessage));

            // Act
            Should.Throw<ApiException>(async () => await _connection.PatchAsync("", null));

            // Assert
            _httpClientExtended.Received(1).PatchAsync(Arg.Any<string>(), Arg.Any<HttpContent>());
        }
    }
}
