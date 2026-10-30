using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class FilePenDataClient
    {
        public int Id { get; set; }
        public string? Sector { get; set; }
        public string? Liq { get; set; }
        public int? Clrowid { get; set; }
        public int? ClNumber { get; set; }
        public string? ClientName { get; set; }
        public int? ClientFileCount { get; set; }
        public int? EngagedCount { get; set; }
        public int? LetterCount { get; set; }
        public int? CallsCount { get; set; }
        public int? SkipTraceCount { get; set; }
        public int? Smscount { get; set; }
        public int? EmailsCount { get; set; }
        public int? LegalCount { get; set; }
        public int? Cbrcount { get; set; }
        public string? Report { get; set; }
    }
}
