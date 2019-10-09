﻿using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace AthenaHealth.Sdk.Http.Adapter
{
    public class AthenaResponsePipeline
    {
        public void Execute(Response response)
        {
            HandleAthenaBodyError(response);
        }

        private void HandleAthenaBodyError(Response response)
        {
            string code = GetAthenaBodyStatusCode(response.Body);

            if (code == null)
                return;

            if (Enum.TryParse(code, out HttpStatusCode httpStatusCode))
            {
                response.StatusCode = httpStatusCode;
                //Assumed that any status code in the response (both success and failure) means some error - body couldn't be parsed
                response.IsSuccessStatusCode = false;
            }
            else
            {
                throw new InvalidCastException("AthenaHealth API response contains status code in body which cannot be parsed to HttpStatusCode: " + code);
            }
        }

        private string GetAthenaBodyStatusCode(object bodyObj)
        {
            if (!(bodyObj is string body))
                return null;

            JObject jsonBody = JObject.Parse(body);
            JToken token = jsonBody.SelectToken("status.code");
            return token?.ToString();
        }
    }
}
