using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AthenaHealth.Sdk.Models.Converters
{
    public class ObjectToDelimitedStringConverter
    {
        public static string Convert(object value, string delimiter = ",", bool encloseArrayInSquareBrackets = true)
        {
            if (value == null)
                return "";
            // Here we convert most common value types
            if (value is string stringValue)
            {
                return stringValue;
            }
            else if (value is int intValue)
            {
                return intValue.ToString(CultureInfo.InvariantCulture);
            }
            else if (value is double doubleValue)
            {
                return doubleValue.ToString(CultureInfo.InvariantCulture);
            }
            else if (value is float floatValue)
            {
                return floatValue.ToString(CultureInfo.InvariantCulture);
            }
            else if (value is decimal decimalValue)
            {
                return decimalValue.ToString(CultureInfo.InvariantCulture);
            }
            else if (value is bool boolValue)
            {
                return boolValue.ToString(CultureInfo.InvariantCulture);
            }
            else if (value is IEnumerable collection)
            {
                var list = collection
                    .Cast<object>()
                    .Where(x => x != null)
                    .Select(x => Convert(x, delimiter, encloseArrayInSquareBrackets));

                if (list.Any())
                    return JoinStringArray(list, delimiter, encloseArrayInSquareBrackets);

                return null;
            }

            // Everything which does not suit rules above is converted that way
            return value.ToString();
        }

        private static string JoinStringArray(IEnumerable<string> list, string delimiter, bool encloseArrayInSquareBrackets)
        {
            string joinedString = string.Join(delimiter, list);

            if (encloseArrayInSquareBrackets)
                return $"[{joinedString}]";

            return joinedString;
        }
    }
}