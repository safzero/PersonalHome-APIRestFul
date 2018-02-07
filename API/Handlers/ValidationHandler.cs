using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace API.Handlers
{
    public class ValidationHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var domain = "localhost";
            if (!string.Equals(request.RequestUri.Host, domain, StringComparison.OrdinalIgnoreCase))
                return request.CreateResponse(HttpStatusCode.Unauthorized);

            var response = await base.SendAsync(request, cancellationToken);
            return response;
        }
    }
}