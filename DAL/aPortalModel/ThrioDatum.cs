using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class ThrioDatum
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string? Label { get; set; }
        public int? Email { get; set; }
        public int? OutboundEmail { get; set; }
        public int? InboundSms { get; set; }
        public int? OutboundSms { get; set; }
        public int? InboundCall { get; set; }
        public int? OutboundCall { get; set; }
        public int? ProgressiveCall { get; set; }
        public int? PredictiveCall { get; set; }
        public int? Chat { get; set; }
    }
}
