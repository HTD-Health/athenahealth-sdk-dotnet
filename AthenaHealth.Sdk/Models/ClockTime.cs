using System;
using System.Runtime.Serialization;

namespace AthenaHealth.Sdk.Models
{
    /// <summary>
    /// Class representing time with minutes and hours (without seconds). 
    /// </summary>
    [DataContract]
    public struct ClockTime
    {
        public int Hour => _time.Hours;
        public int Minute => _time.Minutes;

        private TimeSpan _time;

        public ClockTime(int hour, int minute)
        {
            Validate(hour, minute);

            _time = new TimeSpan(hour, minute, 0);
        }

        private static void Validate(int hour, int minute)
        {
            if (hour < 0 || hour >= 24)
                throw new ArgumentException("Incorrect hour");

            if (minute < 0 || minute > 59)
                throw new ArgumentException("Incorrect minute");
        }

        public override string ToString() => _time.ToString(@"hh\:mm");
    }
}