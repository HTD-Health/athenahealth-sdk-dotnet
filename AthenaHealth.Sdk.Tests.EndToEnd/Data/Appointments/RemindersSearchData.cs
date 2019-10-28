using System.Collections;
using System.Collections.Generic;

// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Tests.EndToEnd.Data.Appointments
{
    public class RemindersSearchData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 1 };
            yield return new object[] { 21 };
            yield return new object[] { 150 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
