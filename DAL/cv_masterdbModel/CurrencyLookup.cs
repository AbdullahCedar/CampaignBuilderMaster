using System;
using System.Collections.Generic;

namespace DAL.cv_masterdbModel
{
    public partial class CurrencyLookup
    {
        public long CuRowid { get; set; }
        public long? CuUid { get; set; }
        public DateTime? CuCdate { get; set; }
        public TimeSpan? CuCtime { get; set; }
        public string? CuCby { get; set; }
        public DateTime? CuMdate { get; set; }
        public TimeSpan? CuMtime { get; set; }
        public string? CuMby { get; set; }
        public int? CuUidm { get; set; }
        public long? CuBad { get; set; }
        public DateTime? CuDate { get; set; }
        public TimeSpan? CuTime { get; set; }
        public int? CuType1 { get; set; }
        public int? CuType2 { get; set; }
        public decimal? CuRateBuy { get; set; }
        public decimal? CuRateSell { get; set; }
        public string? CuOp1 { get; set; }
        public string? CuOp2 { get; set; }
        public string? CuId1 { get; set; }
        public string? CuId2 { get; set; }
        public short? CuCategory { get; set; }
        public short? CuCategory1 { get; set; }
        public short? CuCategory2 { get; set; }
    }
}
