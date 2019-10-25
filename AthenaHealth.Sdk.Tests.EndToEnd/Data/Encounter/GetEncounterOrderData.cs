using System.Collections;
using System.Collections.Generic;

// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Tests.EndToEnd.Data.Encounter
{
    public class GetEncounterOrderData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1404, 21098 };
            //yield return new object[] { 1404, 21099 };
            //yield return new object[] { 1404, 21100 };
            //yield return new object[] { 1404, 21101 };
            yield return new object[] { 1423, 21250 };
            yield return new object[] { 922, 13463 };
            yield return new object[] { 1283, 19070 };
            yield return new object[] { 1362, 20690 };
            //yield return new object[] { 1362, 20691 };
            //yield return new object[] { 1362, 20692 };
            yield return new object[] { 2563, 26011 };
            yield return new object[] { 2563, 26012 };
            yield return new object[] { 1283, 19070 };
            yield return new object[] { 1362, 20690 };
            //yield return new object[] { 1362, 20691 };
            //yield return new object[] { 1362, 20692 };
            //yield return new object[] { 2563, 26011 };
            yield return new object[] { 2563, 26012 };
            yield return new object[] { 2564, 26028 };
            //yield return new object[] { 2564, 26027 };
            //yield return new object[] { 2564, 26014 };
            //yield return new object[] { 2564, 26013 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
