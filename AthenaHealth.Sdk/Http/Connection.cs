using System;

namespace AthenaHealth.Sdk.Http
{
    public class Connection : IConnection
    {
        Uri BaseAddress { get; }
        Credentials Credentials { get; }

        public Connection(Credentials credentials, string baseAddress)
        {
            Credentials = credentials;
            BaseAddress = new Uri(baseAddress);
        }
    }
}