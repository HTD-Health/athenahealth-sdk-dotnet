using System.Collections;
using System.Collections.Generic;

// ReSharper disable IdentifierTypo
// ReSharper disable CommentTypo
// ReSharper disable StringLiteralTypo

namespace AthenaHealth.Sdk.Tests.EndToEnd.Data.Appointments
{
    public class GetNotesAppointmentsData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { 2 };
            yield return new object[] { 3 };
            //yield return new object[] { 6 };
            //yield return new object[] { 10 };
            //yield return new object[] { 11 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
