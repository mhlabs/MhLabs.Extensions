using System.Net;

namespace MhLabs.Extensions
{
    public static class HttpStatusCodeExtension
    {
        /// <summary>
        /// Check if <see cref="HttpStatusCode"/> is between 200 and 299
        /// </summary>
        /// <param name="httpStatusCode"></param>
        public static bool IsSuccessful(this HttpStatusCode httpStatusCode)
        {
            if ((int)httpStatusCode >= 200 && (int)httpStatusCode <= 299)
            {
                return true;
            }
            return false;
        }
    }
}
