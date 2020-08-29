using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Didala.Web.Services
{
    public class HttpHandlerDisplaySpinner : DelegatingHandler
    {
        private readonly SpinnerService _spinnerService;

        public HttpHandlerDisplaySpinner(SpinnerService spinnerService)
        {
            _spinnerService = spinnerService;

        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            _spinnerService.Show();
            //  await Task.Delay(1000);
            var response = await base.SendAsync(request, cancellationToken);
            _spinnerService.Hide();
            return response;
        }
    }
}
