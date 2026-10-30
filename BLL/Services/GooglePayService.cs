using BLL.Interfaces;
using DAL.VM;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.Interfaces;

namespace BLL.Services
{
    public class GooglePayService : IGooglepayService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<GooglePayService> _logger;
        private readonly IGooglePayRepository _googlePayRepository; // Use the interface here

        public GooglePayService(IHttpClientFactory httpClientFactory, ILogger<GooglePayService> logger, IGooglePayRepository googlePayRepository)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
            _googlePayRepository = googlePayRepository; // Use the interface here
        }

        public async Task<string> ProcessGooglePayTokenAsync(GooglePayToken googlePayToken, Customer customer)
        {
            try
            {
                // Serialize and Base64 encode the payload
                string base64EncodedPayload = SerializeAndEncodeToken(googlePayToken);

                // Construct the XML request with dynamic customer data
                var xmlRequest = ConstructXmlRequest(base64EncodedPayload, customer);

                _logger.LogInformation("XML Request constructed: {XmlRequest}", xmlRequest);

                // Send the request to the payment repository (which handles external API interaction)
                var response = await _googlePayRepository.SendPaymentRequestAsync(xmlRequest);

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogError("Payment processing failed with status code: {StatusCode}", response.StatusCode);
                    throw new PaymentProcessingException($"Payment processing failed with status code: {response.StatusCode}");
                }

                var responseContent = await response.Content.ReadAsStringAsync();
                _logger.LogInformation("Payment processed successfully: {ResponseContent}", responseContent);
                return responseContent;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing payment");
                throw;
            }
        }

        private string SerializeAndEncodeToken(GooglePayToken googlePayToken)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            };

            string tokenJson = JsonConvert.SerializeObject(googlePayToken, settings);
            _logger.LogDebug("Serialized Google Pay Token: {TokenJson}", tokenJson);

            var plainTextBytes = Encoding.UTF8.GetBytes(tokenJson);
            string base64EncodedPayload = Convert.ToBase64String(plainTextBytes);

            _logger.LogDebug("Base64 Encoded Payload: {Base64EncodedPayload}", base64EncodedPayload);
            return base64EncodedPayload;
        }

        private string ConstructXmlRequest(string base64EncodedPayload, Customer customer)
        {
            return $@"
        <PAYMENTREQUEST>
            <TRANSACTIONHEADER>
                <PWVERSION>3</PWVERSION>
                <PWCLIENTID>10273</PWCLIENTID>
                <PWKEY>{GetPaywireKey()}</PWKEY>
                <PWUSER>{GetPaywireUser()}</PWUSER>
                <PWPASS>{GetPaywirePassword()}</PWPASS>
                <PWTRANSACTIONTYPE>SALE</PWTRANSACTIONTYPE>
                <PWSALEAMOUNT>{customer.Amount}</PWSALEAMOUNT>
                <PWINVOICENUMBER>{customer.InvoiceNumber}</PWINVOICENUMBER>
            </TRANSACTIONHEADER>
            <CUSTOMER>
                <PWMEDIA>CC</PWMEDIA>
                <COMPANYNAME>{customer.CompanyName}</COMPANYNAME>
                <FIRSTNAME>{customer.FirstName}</FIRSTNAME>
                <LASTNAME>{customer.LastName}</LASTNAME>
                <EMAIL>{customer.Email}</EMAIL>
                <ADDRESS1>{customer.Address1}</ADDRESS1>
                <CITY>{customer.City}</CITY>
                <STATE>{customer.State}</STATE>
                <ZIP>{customer.Zip}</ZIP>
                <COUNTRY>{customer.Country}</COUNTRY>
                <PRIMARYPHONE>{customer.PrimaryPhone}</PRIMARYPHONE>
                <WORKPHONE>{customer.WorkPhone}</WORKPHONE>
            </CUSTOMER>
            <DIGITALWALLET>
                <DWTYPE>{customer.PaymentMethod}</DWTYPE>
                <DWPAYLOAD>{base64EncodedPayload}</DWPAYLOAD>
            </DIGITALWALLET>
        </PAYMENTREQUEST>";
        }

        private string GetPaywireKey() => Environment.GetEnvironmentVariable("PAYWIRE_KEY") ?? "C46B3F0A-3DB0-4EA3-8313-6A8CF13272DE";
        private string GetPaywireUser() => Environment.GetEnvironmentVariable("PAYWIRE_USER") ?? "cedarAPayTestAPI";
        private string GetPaywirePassword() => Environment.GetEnvironmentVariable("PAYWIRE_PASS") ?? "avx4pCpquQ@F";

        public class PaymentProcessingException : Exception
        {
            public PaymentProcessingException()
            {
            }

            public PaymentProcessingException(string message)
                : base(message)
            {
            }

            public PaymentProcessingException(string message, Exception innerException)
                : base(message, innerException)
            {
            }
        }
    }
}
