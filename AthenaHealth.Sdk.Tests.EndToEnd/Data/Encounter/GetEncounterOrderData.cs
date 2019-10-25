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
            yield return new object[] { 21098 };
            yield return new object[] { 21099 };
            yield return new object[] { 21100 };
            yield return new object[] { 21101 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
