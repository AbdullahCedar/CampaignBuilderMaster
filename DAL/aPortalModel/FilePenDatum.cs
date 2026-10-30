using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class FilePenDatum
    {
        public int Id { get; set; }
        public string? Sector { get; set; }
        public string? SubSector { get; set; }
        public string? Liq { get; set; }
        public int? FileCount { get; set; }
        public int? Letter1Count { get; set; }
        public int? Letter2Count { get; set; }
        public int? Letter3Count { get; set; }
        public int? SkipTraceCount { get; set; }
        public int? CallsCount { get; set; }
        public int? Smscount { get; set; }
        public int? EmailsCount { get; set; }
        public int? LegalCount { get; set; }
        public int? Cbrcount { get; set; }
        public int? ClientCount { get; set; }
        public DateTime? Date { get; set; }
    }
}
