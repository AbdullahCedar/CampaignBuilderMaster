using System;
using System.Collections.Generic;

namespace DAL.cv_masterdbModel
{
    public partial class DebtorStatus
    {
        public long DsRowid { get; set; }
        public long? DsUid { get; set; }
        public DateTime? DsCdate { get; set; }
        public TimeSpan? DsCtime { get; set; }
        public string? DsCby { get; set; }
        public DateTime? DsMdate { get; set; }
        public TimeSpan? DsMtime { get; set; }
        public string? DsMby { get; set; }
        public int? DsUidm { get; set; }
        public string? DsCode { get; set; }
        public string? DsDescription { get; set; }
        public string? DsPlan { get; set; }
        public short? DsFlags { get; set; }
        public string? DsMetroStatus { get; set; }
        public string? DsState { get; set; }
        public short? DsColor { get; set; }
        public short? DsCategory { get; set; }
        public short? DsCategory1 { get; set; }
        public short? DsCategory2 { get; set; }
    }
}
