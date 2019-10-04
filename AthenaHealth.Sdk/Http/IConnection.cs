using System;

namespace AthenaHealth.Sdk.Http
{
    public interface IConnection
    {
        string BaseAddress { get; }
        Credentials Credentials { get; }
    }
}