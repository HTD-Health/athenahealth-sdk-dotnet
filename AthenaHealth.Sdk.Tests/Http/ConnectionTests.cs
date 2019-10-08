using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using AthenaHealth.Sdk.Exceptions;
using AthenaHealth.Sdk.Http;
using AthenaHealth.Sdk.Models.Response;
using AthenaHealth.Sdk.Tests.Helpers;
using Shouldly;
using Xunit;

namespace AthenaHealth.Sdk.Tests.Http
{
    public class ConnectionTests
    {
        [Theory]
        [InlineData(400)]
        [InlineData(401)]
        [InlineData(402)]
        [InlineData(403)]
        [InlineData(404)]
        [InlineData(405)]
        [InlineData(406)]
        [InlineData(407)]
        [InlineData(408)]
        [InlineData(409)]
        [SuppressMessage("ReSharper", "StringLiteralTypo")]
        public void HttpRequest_ValidationErrorCode_ThrowsApiValidationException(int statusCode)
        {
            Connection connection = ConnectionFactory.Create(@"{""missingfields"": [""patientid""], ""error"": ""Additional fields are required.""}", 
                Enum.Parse<HttpStatusCode>(statusCode.ToString()));
            Should.Throw<ApiValidationException>(async () => await connection.GetAsync(""));
            Should.Throw<ApiValidationException>(async () => await connection.GetAsync<Patient>(""));

            Should.Throw<ApiValidationException>(async () => await connection.PostAsync("", null, null));
            Should.Throw<ApiValidationException>(async () => await connection.PostAsync<Patient>("", null, null));

            Should.Throw<ApiValidationException>(async () => await connection.PutAsync("", null, null));
            Should.Throw<ApiValidationException>(async () => await connection.PutAsync<Patient>("", null, null));

            Should.Throw<ApiValidationException>(async () => await connection.DeleteAsync(""));
            Should.Throw<ApiValidationException>(async () => await connection.DeleteAsync<Patient>(""));

            Should.Throw<ApiValidationException>(async () => await connection.PatchAsync("", null, null));
            Should.Throw<ApiValidationException>(async () => await connection.PatchAsync<Patient>("", null, null));
        }

        [Theory]
        [InlineData(500)]
        [InlineData(503)]
        [SuppressMessage("ReSharper", "StringLiteralTypo")]
        public void HttpRequest_NonValidationErrorCode_ThrowsApiException(int statusCode)
        {
            Connection connection = ConnectionFactory.Create(@"{""missingfields"": [""patientid""], ""error"": ""Additional fields are required.""}", 
                Enum.Parse<HttpStatusCode>(statusCode.ToString()));

            Should.Throw<ApiException>(async () => await connection.GetAsync(""));
            Should.Throw<ApiException>(async () => await connection.GetAsync<Patient>(""));

            Should.Throw<ApiException>(async () => await connection.PostAsync("", null, null));
            Should.Throw<ApiException>(async () => await connection.PostAsync<Patient>("", null, null));

            Should.Throw<ApiException>(async () => await connection.PutAsync("", null, null));
            Should.Throw<ApiException>(async () => await connection.PutAsync<Patient>("", null, null));

            Should.Throw<ApiException>(async () => await connection.DeleteAsync(""));
            Should.Throw<ApiException>(async () => await connection.DeleteAsync<Patient>(""));

            Should.Throw<ApiException>(async () => await connection.PatchAsync("", null, null));
            Should.Throw<ApiException>(async () => await connection.PatchAsync<Patient>("", null, null));
        }

        [Fact]
        [SuppressMessage("ReSharper", "StringLiteralTypo")]
        public void HttpRequest_ValidationErrorCode_ExceptionContainsErrorInfo()
        {
            var error = @"{""missingfields"": [""patientid""], ""error"": ""Additional fields are required.""}";
            Connection connection = ConnectionFactory.Create(error, HttpStatusCode.BadRequest);

            ApiException exc = Should.Throw<ApiException>(async () => await connection.GetAsync(""));
            exc.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
            exc.ResponseError.ShouldBe(error);
        }

        [Fact]
        public void HttpRequest_NullContent_NotThrowException()
        {
            var connection = ConnectionFactory.Create(null, HttpStatusCode.OK);
            Should.NotThrow(async () => await connection.GetAsync<Patient>(""));
        }

    }
}