using AthenaHealth.Sdk.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace AthenaHealth.Sdk.Tests
{
    public class ClientsTests
    {
        [Fact]
        public void CheckImplementation_ShouldAllHaveEndpointAttribute()
        {
            // Get collection of client types
            var types = typeof(AppointmentClient).Assembly
                .GetTypes()
                .Where(x => x.IsClass && x.Namespace == typeof(AppointmentClient).Namespace && !x.IsNested);

            foreach (var type in types)
            {
                // Find interface type for every client type
                var interfaceType = type.GetInterface($"I{type.Name}");

                var interfaceMethods = interfaceType.GetMethods()
                    .Where(x => x.IsPublic);

                foreach (var interfaceMethod in interfaceMethods)
                {
                    // Find method which implements interface
                    var implementationMethod = type.GetMethod(interfaceMethod.Name, interfaceMethod.GetParameters().Select(x => x.ParameterType).ToArray());

                    var interfaceEndpointAttributes = interfaceMethod.GetCustomAttributes<EndpointAttribute>();
                    var implementationEndpointAttributes = implementationMethod.GetCustomAttributes<EndpointAttribute>();

                    if (!interfaceEndpointAttributes.Any())
                        throw new Exception($"No endpoint attribute specified for {interfaceType.Name}.{interfaceMethod.Name}");

                    if (!implementationEndpointAttributes.Any())
                        throw new Exception($"No endpoint attribute specified for {type.Name}.{implementationMethod.Name}");

                    var endpointAttributes = interfaceEndpointAttributes.Union(implementationEndpointAttributes);

                    if (endpointAttributes.Count() != interfaceEndpointAttributes.Count() ||
                        endpointAttributes.Count() != implementationEndpointAttributes.Count())
                    {
                        throw new Exception($"Mismatching endpoint attribute specified for {type.Name}.{implementationMethod.Name}");
                    }
                }
            }
        }

        [Fact]
        public void CheckImplementation_UniqueEndpoints()
        {
            // Get collection of client types
            var types = typeof(AppointmentClient).Assembly
                .GetTypes()
                .Where(x => x.IsClass && x.Namespace == typeof(AppointmentClient).Namespace && !x.IsNested);

            foreach (var type in types)
            {
                // Find interface type for every client type
                var interfaceType = type.GetInterface($"I{type.Name}");

                var interfaceMethods = interfaceType.GetMethods()
                    .Where(x => x.IsPublic);

                List<EndpointAttribute> interfaceEndpoints = new List<EndpointAttribute>();
                List<EndpointAttribute> implementationEndpoints = new List<EndpointAttribute>();

                foreach (var interfaceMethod in interfaceMethods)
                {
                    // Find method which implements interface
                    var implementationMethod = type.GetMethod(interfaceMethod.Name, interfaceMethod.GetParameters().Select(x => x.ParameterType).ToArray());

                    interfaceEndpoints.AddRange(interfaceMethod.GetCustomAttributes<EndpointAttribute>());
                    implementationEndpoints.AddRange(implementationMethod.GetCustomAttributes<EndpointAttribute>());
                }

                // We do not count endpoints without name, as they can be repeated
                interfaceEndpoints = interfaceEndpoints
                    .Where(x => x.Name != null)
                    .ToList();

                implementationEndpoints = implementationEndpoints
                    .Where(x => x.Name != null)
                    .ToList();

                foreach (var item in interfaceEndpoints.GroupBy(x => x.Name))
                {
                    if (item.Count() > 1)
                        throw new Exception($"Endpoint attribute '{item.Key}' is already present in {interfaceType.Name}");
                }

                foreach (var item in implementationEndpoints.GroupBy(x => x.Name))
                {
                    if (item.Count() > 1)
                        throw new Exception($"Endpoint attribute '{item.Key}' is already present in {type.Name}");
                }
            }
        }
    }
}
