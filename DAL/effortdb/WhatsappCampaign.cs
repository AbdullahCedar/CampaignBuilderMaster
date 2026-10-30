using System;
using System.Collections.Generic;

namespace DAL.effortdb
{
    public partial class WhatsappCampaign
    {
        public string? ColNameFirst { get; set; }
        public string? ColNameLast { get; set; }
        public double? ColType { get; set; }
        public long? ColPhonePoe { get; set; }
        public string? ColPhoneOther { get; set; }
        public string? ColPhoneCell { get; set; }
        public string? ColPhoneHome { get; set; }
        public string? ColEmail { get; set; }
        public string? ColAcct { get; set; }
        public int? ColFileNumber { get; set; }
        public double? ColOwing { get; set; }
        public double? ColListed { get; set; }
        public string? ColZipCode { get; set; }
        public string? ColStates { get; set; }
        public int? ColClient { get; set; }
        public long? ColClientNumber { get; set; }
        public string? ColStatus { get; set; }
        public DateTime? Date { get; set; }
        public string? ListName { get; set; }
        public int Id { get; set; }
    }
}
