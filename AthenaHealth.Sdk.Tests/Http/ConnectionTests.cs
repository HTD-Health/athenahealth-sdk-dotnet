using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Http;
using NSubstitute;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using AthenaHealth.Sdk.Http.Adapter;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Http
{
    public class ConnectionTests
    {
        private readonly IAthenaHttpAdapter _athenaHttpAdapter;

        private readonly IConnection _connection;

        private readonly Credentials _credentials;

        private readonly ApiVersion _apiVersion;

        public ConnectionTests()
        {
            _athenaHttpAdapter = Substitute.For<IAthenaHttpAdapter>();
            _credentials = new Credentials("login", "password");
            _apiVersion = ApiVersion.Preview;

            _connection = new Connection(_athenaHttpAdapter, _credentials, _apiVersion);

            Response positiveAuthorizationResponse = new Response(
                HttpStatusCode.OK,
                "{\"access_token\":\"53nde65ep9dx5f2n4up39hj3\",\"token_type\":\"bearer\",\"expires_in\":3600,\"refresh_token\":\"np4crgmae29cnuvw6p3tgus2\"}",
                new Dictionary<string, string>(),
                "",
                true);

            _athenaHttpAdapter.Send(Arg.Is<Request>(x => x.RequestUri.AbsoluteUri.EndsWith("/token"))).Returns(Task.FromResult(positiveAuthorizationResponse));
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
        public void GetAsync_ValidationStatusCode_ThrowsApiValidationException(HttpStatusCode statusCode)
        {
            // Arrange
            Response response = new Response(statusCode, new object(), new Dictionary<string, string>(), "", false);
            _athenaHttpAdapter.Send(Arg.Is<Request>(x => x.RequestUri.AbsoluteUri.EndsWith("/test"))).Returns(Task.FromResult(response));

            // Act
            Should.Throw<ApiValidationException>(async () => await _connection.Get<object>("test"), TimeSpan.FromHours(1));

            // Assert
            _athenaHttpAdapter.Received(2).Send(Arg.Any<Request>());
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
            Response response = new Response(statusCode, new object(), new Dictionary<string, string>(), "", false);
            _athenaHttpAdapter.Send(Arg.Is<Request>(x => x.RequestUri.AbsoluteUri.EndsWith("/test"))).Returns(Task.FromResult(response));

            // Act
            Should.Throw<ApiValidationException>(async () => await _connection.Delete<object>("test"));

            // Assert
            _athenaHttpAdapter.Received(2).Send(Arg.Any<Request>());
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
            Response response = new Response(statusCode, new object(), new Dictionary<string, string>(), "", false);
            _athenaHttpAdapter.Send(Arg.Is<Request>(x => x.RequestUri.AbsoluteUri.EndsWith("/test"))).Returns(Task.FromResult(response));

            // Act
            Should.Throw<ApiValidationException>(async () => await _connection.Post<object>("test", null));

            // Assert
            _athenaHttpAdapter.Received(2).Send(Arg.Any<Request>());
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
            Response response = new Response(statusCode, new object(), new Dictionary<string, string>(), "", false);
            _athenaHttpAdapter.Send(Arg.Is<Request>(x => x.RequestUri.AbsoluteUri.EndsWith("/test"))).Returns(Task.FromResult(response));

            // Act
            Should.Throw<ApiValidationException>(async () => await _connection.Put<object>("test", null));

            // Assert
            _athenaHttpAdapter.Received(2).Send(Arg.Any<Request>());
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
            Response response = new Response(statusCode, new object(), new Dictionary<string, string>(), "", false);
            _athenaHttpAdapter.Send(Arg.Is<Request>(x => x.RequestUri.AbsoluteUri.EndsWith("/test"))).Returns(Task.FromResult(response));

            // Act
            Should.Throw<ApiException>(async () => await _connection.Get<object>("test"));

            // Assert
            _athenaHttpAdapter.Received(2).Send(Arg.Any<Request>());
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
            Response response = new Response(statusCode, new object(), new Dictionary<string, string>(), "", false);
            _athenaHttpAdapter.Send(Arg.Is<Request>(x => x.RequestUri.AbsoluteUri.EndsWith("/test"))).Returns(Task.FromResult(response));

            // Act
            Should.Throw<ApiException>(async () => await _connection.Delete<object>("test"));

            // Assert
            _athenaHttpAdapter.Received(2).Send(Arg.Any<Request>());
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
            Response response = new Response(statusCode, new object(), new Dictionary<string, string>(), "", false);
            _athenaHttpAdapter.Send(Arg.Is<Request>(x => x.RequestUri.AbsoluteUri.EndsWith("/test"))).Returns(Task.FromResult(response));

            // Act
            Should.Throw<ApiException>(async () => await _connection.Post<object>("test", null));

            // Assert
            _athenaHttpAdapter.Received(2).Send(Arg.Any<Request>());
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
            Response response = new Response(statusCode, new object(), new Dictionary<string, string>(), "", false);
            _athenaHttpAdapter.Send(Arg.Is<Request>(x => x.RequestUri.AbsoluteUri.EndsWith("/test"))).Returns(Task.FromResult(response));

            // Act
            Should.Throw<ApiException>(async () => await _connection.Put<object>("test", null));

            // Assert
            _athenaHttpAdapter.Received(2).Send(Arg.Any<Request>());
        }
    }
}
