using System;
using System.Collections.Generic;

namespace DAL.effortdb
{
    public partial class Sendgrid
    {
        public int Id { get; set; }
        public DateTime? Processed { get; set; }
        public string? MessageId { get; set; }
        public string? Event { get; set; }
        public string? ApiKeyId { get; set; }
        public string? RecvMessageId { get; set; }
        public string? CredentialId { get; set; }
        public string? Subject { get; set; }
        public string? From { get; set; }
        public string? Email { get; set; }
        public double? AsmGroupId { get; set; }
        public string? TemplateId { get; set; }
        public string? OriginatingIp { get; set; }
        public string? Reason { get; set; }
        public string? OutboundIp { get; set; }
        public string? OutboundIpType { get; set; }
        public string? Mx { get; set; }
        public string? Attempt { get; set; }
        public string? Url { get; set; }
        public string? UserAgent { get; set; }
        public string? Type { get; set; }
        public string? IsUnique { get; set; }
        public string? Username { get; set; }
        public string? Categories { get; set; }
        public double? MarketingCampaignId { get; set; }
        public string? MarketingCampaignName { get; set; }
        public string? MarketingCampaignSplitId { get; set; }
        public string? MarketingCampaignVersion { get; set; }
        public string? UniqueArgs { get; set; }
        public long? FileNum { get; set; }
        public long? DeGroupId { get; set; }
    }
}
