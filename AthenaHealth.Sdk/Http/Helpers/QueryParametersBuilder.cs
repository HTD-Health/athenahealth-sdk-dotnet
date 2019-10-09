using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json;

namespace AthenaHealth.Sdk.Http.Helpers
{
    public static class QueryParametersBuilder
    {
        public static Dictionary<string, string> Build(object obj)
        {
            var dict = new Dictionary<string, string>();
            if (obj == null)
                return dict;

            foreach (var item in obj.GetType().GetProperties())
            {
                object value = item.GetValue(obj);

                if (value == null)
                    continue;

                JsonPropertyAttribute jsonPropertyAttribute = item.GetCustomAttribute<JsonPropertyAttribute>();

                string key = item.Name;
                if (jsonPropertyAttribute != null)
                    key = jsonPropertyAttribute.PropertyName;

                dict.Add(key, value.ToString());
            }

            return dict;
        }
    }
}