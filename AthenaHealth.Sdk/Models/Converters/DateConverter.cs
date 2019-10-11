using AthenaHealth.Sdk.Models.Converters.Base;
using System;
using System.Globalization;

namespace AthenaHealth.Sdk.Models.Converters
{
    public class DateConverter : Converter
    {
        public override bool CanRead => true;

        public override bool CanWrite => true;

        public override bool CanConvert(Type objectType)
        {
            return typeof(DateTime).IsAssignableFrom(objectType);
        }

        public override object Convert(object value)
        {
            DateTime dateTime = (DateTime)value;
            return dateTime.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
        }

        public override object ConvertBack(object value)
        {
            return DateTime.ParseExact((string)value, "MM/dd/yyyy", CultureInfo.InvariantCulture);
        }
    }
}
