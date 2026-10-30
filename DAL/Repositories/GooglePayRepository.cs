using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class GooglePayRepository : IGooglePayRepository
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<GooglePayRepository> _logger;

        public GooglePayRepository(IHttpClientFactory httpClientFactory, ILogger<GooglePayRepository> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        public async Task<HttpResponseMessage> SendPaymentRequestAsync(string xmlRequest)
        {
            var client = _httpClientFactory.CreateClient();
            var xmlContent = new StringContent(xmlRequest, Encoding.UTF8, "application/xml");

            _logger.LogInformation("Sending request to Paywire API...");
            return await client.PostAsync("https://dbstage1.paywire.com/API/pwapi", xmlContent);
        }
    }
}
