using System;
using System.Collections.Generic;

namespace DAL.cv_masterdbModel
{
    public partial class Dbtag
    {
        public long DtRowid { get; set; }
        public long? DtUid { get; set; }
        public DateTime? DtCdate { get; set; }
        public TimeSpan? DtCtime { get; set; }
        public string? DtCby { get; set; }
        public DateTime? DtMdate { get; set; }
        public TimeSpan? DtMtime { get; set; }
        public string? DtMby { get; set; }
        public int? DtUidm { get; set; }
        public short? DtUsers { get; set; }
        public short? DtDetectMode { get; set; }
        public DateTime? DtDate { get; set; }
        public string? DtText { get; set; }
        public int? DtId { get; set; }
        public string? DtCompany { get; set; }
        public string? DtUser { get; set; }
        public string? DtType { get; set; }
        public DateTime? DtUdate { get; set; }
        public string? DtUcode { get; set; }
        public TimeSpan? DtUtime { get; set; }
        public short? DtFeatures { get; set; }
        public short? DtOptions { get; set; }
        public string? DtAdapterId { get; set; }
        public DateTime? DtDetectdate { get; set; }
        public int? DtDetectModeDateSet { get; set; }
        public short? DtUdays { get; set; }
        public string? DtCnxr { get; set; }
    }
}
