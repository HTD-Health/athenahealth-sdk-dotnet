using System.Collections;
using System.Collections.Generic;

// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Tests.EndToEnd.Data.Encounter
{
    public class GetEncounterOrdersData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 922 };
            yield return new object[] { 1423 };
            yield return new object[] { 1404 };
            //yield return new object[] { 1362 };
            //yield return new object[] { 2563 };
            //yield return new object[] { 1283 };
            //yield return new object[] { 1362 };
            //yield return new object[] { 2563 };
            //yield return new object[] { 2564 };
            //yield return new object[] { 2565 };
            //yield return new object[] { 2566 };
            //yield return new object[] { 2567 };
            //yield return new object[] { 2568 };
            //yield return new object[] { 2582 };
            //yield return new object[] { 2602 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
