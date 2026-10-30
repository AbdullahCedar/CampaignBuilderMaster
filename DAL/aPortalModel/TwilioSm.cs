using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class TwilioSm
    {
        public int SmsId { get; set; }
        public string? Direction { get; set; }
        public string? SmsBody { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }
        public DateTime? DateSent { get; set; }
        public DateTime? DateModified { get; set; }
        public string? ViewBy { get; set; }
        public bool? Seen { get; set; }
        public string? Sid { get; set; }
        public string? Disposition { get; set; }
        public int? Dispostion1 { get; set; }
    }
}
