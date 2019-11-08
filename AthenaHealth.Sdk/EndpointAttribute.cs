using System;

namespace AthenaHealth.Sdk
{
    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public sealed class EndpointAttribute : Attribute
    {
        public string Name { get; }

        public EndpointAttribute(string name)
        {
            Name = name;
        }
    }
}
