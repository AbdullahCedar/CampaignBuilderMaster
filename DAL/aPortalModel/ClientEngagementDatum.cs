using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class ClientEngagementDatum
    {
        public int Id { get; set; }
        public DateTime? Cdate { get; set; }
        public long? ClRowId { get; set; }
        public int? ClNumber { get; set; }
        public string? ClName { get; set; }
        public string? Operator { get; set; }
        public string? SalesOperator { get; set; }
        public string? Sector { get; set; }
        public string? Ribbon { get; set; }
        public int? Total { get; set; }
        public int? CallAtempt { get; set; }
        public int? CallEngagment { get; set; }
        public int? EmailAtempt { get; set; }
        public int? EmailEngagment { get; set; }
        public int? SmsAtempt { get; set; }
        public int? SmsEngagment { get; set; }
        public int? LetterAttempt { get; set; }
        public int? LetterEngagment { get; set; }
    }
}
