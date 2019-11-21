using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System;

namespace AthenaHealth.Sdk.Models.Converters
{
    public class EnumConverter : StringEnumConverter
    {
        public EnumConverter()
        {
        }

        public EnumConverter(Type namingStrategyType)
            : base(namingStrategyType)
        {
        }

        public EnumConverter(NamingStrategy namingStrategy, bool allowIntegerValues = true)
            : base(namingStrategy, allowIntegerValues)
        {
        }

        public EnumConverter(Type namingStrategyType, object[] namingStrategyParameters)
            : base(namingStrategyType, namingStrategyParameters)
        {
        }

        public EnumConverter(Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues)
            : base(namingStrategyType, namingStrategyParameters, allowIntegerValues)
        {
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                return base.ReadJson(reader, objectType, existingValue, serializer);
            }
            catch (JsonSerializationException)
            {
                // Important: At the moment we rethrow catched exception, but code below allows to
                //            handle default value of enum if the deserialized value does not match
                //            to anything.
                throw;

                // We have to produce default value (API can return values which does not match enum values)
                if (objectType.IsValueType)
                {
                    // In the case of nullable type
                    if (objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(Nullable<>))
                        return null;

                    // Create default value
                    return Activator.CreateInstance(objectType);
                }

                // If it's reference type we should return null
                return null;
            }
        }
    }
}
