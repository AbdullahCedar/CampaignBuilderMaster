using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VM
{
    public class GooglePayRequest
    {
        public GooglePayToken GooglePayToken { get; set; }
        public Customer Customer { get; set; }
    }

    public class Customer
    {
        public string Media { get; set; } 
        public string CompanyName { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public string Email { get; set; }
        public string Address1 { get; set; } 
        public string City { get; set; } 
        public string State { get; set; } 
        public string Zip { get; set; } 
        public string Country { get; set; } 
        public string PrimaryPhone { get; set; } 
        public string WorkPhone { get; set; }
        public string Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string InvoiceNumber { get; set; }
    }
    public class GooglePayToken
    {
        public int ApiVersionMinor { get; set; }
        public int ApiVersion { get; set; }
        public PaymentMethodData PaymentMethodData { get; set; }
    }

    public class PaymentMethodData
    {
        public string Description { get; set; }
        public TokenizationData TokenizationData { get; set; }
        public string Type { get; set; }
        public PaymentMethodInfo Info { get; set; }
    }

    public class TokenizationData
    {
        public string Token { get; set; }
    }

    public class PaymentMethodInfo
    {
        public string CardNetwork { get; set; }
        public string CardDetails { get; set; }
    }
}
