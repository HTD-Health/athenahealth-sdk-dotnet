using System;

namespace AthenaHealth.Sdk.Http
{
    public interface IConnection
    {
        Uri BaseAddress { get; }
        Credentials Credentials { get; }
    }
}