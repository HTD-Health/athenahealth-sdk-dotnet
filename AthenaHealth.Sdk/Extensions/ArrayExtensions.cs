using AthenaHealth.Sdk.Exceptions;
using System;
using System.Linq;
using System.Net;

namespace AthenaHealth.Sdk.Extensions
{
    public static class ArrayExtensions
    {
        public static T FirstOrThrowException<T>(this T[] list)
        {
            if (list.Length == 0)
            {
                //For some endpoints (e.g. GetAppointmentType) if you request for non existing item, you received 200OK and empty array. For others, Athena responds with 404. Here we make it more consistent for client. 
                throw new ApiValidationException("Item not found", HttpStatusCode.NotFound);
            }
            if (list.Length > 1)
            {
                //Some unexpected case (don't know if can occur in real life)
                throw new Exception("Number of Items is greater than 1.");
            }

            return list.First();
        }
    }
}
