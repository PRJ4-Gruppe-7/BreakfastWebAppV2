using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreakfastWebAppV2.Utilities
{
    /// <summary>
    /// This code is originally from
    /// https://stackoverflow.com/questions/43138659/request-isajaxrequest-alternative-in-mvc6
    /// Code has been taken from Lab 23: ASP Identity solution
    /// </summary>
    internal static class RequestHelpers
    {
        internal static bool IsAjaxRequest(this HttpRequest request)
        {
            return string.Equals(request.Query["X-Requested-With"], "XMLHttpRequest", StringComparison.Ordinal) ||
                string.Equals(request.Headers["X-Requested-With"], "XMLHttpRequest", StringComparison.Ordinal) ||
                string.Equals(request.Headers["X-Requested-With"], "Fetch", StringComparison.Ordinal);
        }
    }
}
