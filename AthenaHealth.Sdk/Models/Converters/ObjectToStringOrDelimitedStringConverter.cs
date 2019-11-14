using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace AthenaHealth.Sdk.Models.Converters
{
    public class ObjectToStringOrDelimitedStringConverter
    {
        /// <summary>
        /// If array, converts object to string delimited with the given delimiter with or without enclosing square brackets.
        /// E.g. new int[] {1, 2} converts to "1,2" or "[1,2]"
        ///      new string[] {"a", "b"} converts to "a,b" or "[a,b]"
        /// Otherwise, performs json serialization.
        /// </summary>
        /// <param name="value">Object to be converted</param>
        /// <param name="delimiter">Delimiter</param>
        /// <param name="encloseArrayInSquareBrackets">If true, result is enclosed in square brackets, e.g. "[1,2]". If false, result would be "1,2"</param>
        /// <returns></returns>
        public static string Convert(object value, string delimiter = ",", bool encloseArrayInSquareBrackets = true)
        {
            if (value == null)
                return "";
            // Here we convert most common value types
            if (value is string stringValue)
            {
                return stringValue;
            }
            if (value is int intValue)
            {
                return intValue.ToString(CultureInfo.InvariantCulture);
            }
            if (value is double doubleValue)
            {
                return doubleValue.ToString(CultureInfo.InvariantCulture);
            }
            if (value is float floatValue)
            {
                return floatValue.ToString(CultureInfo.InvariantCulture);
            }
            if (value is decimal decimalValue)
            {
                return decimalValue.ToString(CultureInfo.InvariantCulture);
            }
            if (value is bool boolValue)
            {
                return boolValue.ToString(CultureInfo.InvariantCulture).ToLower();
            }
            if (value is DateTime dateTimeValue)
            {
                return dateTimeValue.ToString(CultureInfo.InvariantCulture);
            }
            if (value is ClockTime clockTimeValue)
            {
                return clockTimeValue.ToString();
            }
            if (value is IEnumerable collection)
            {
                var list = collection
                    .Cast<object>()
                    .Where(x => x != null)
                    .Select(x => Convert(x, delimiter, encloseArrayInSquareBrackets));

                if (list.Any())
                    return JoinStringArray(list, delimiter, encloseArrayInSquareBrackets);

                return null;
            }
            if (value is FileInfo) // FileInfos are not serialized
            {
                return null;
            }

            // Everything which does not suit rules above is converted that way
            return JsonConvert.SerializeObject(value);
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
