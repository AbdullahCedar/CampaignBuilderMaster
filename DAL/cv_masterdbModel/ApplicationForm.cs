using System;
using System.Collections.Generic;

namespace DAL.cv_masterdbModel
{
    public partial class ApplicationForm
    {
        public ApplicationForm()
        {
            FormRights = new HashSet<FormRight>();
        }

        public long AfRowid { get; set; }
        public long? AfUid { get; set; }
        public DateTime? AfCdate { get; set; }
        public TimeSpan? AfCtime { get; set; }
        public string? AfCby { get; set; }
        public DateTime? AfMdate { get; set; }
        public TimeSpan? AfMtime { get; set; }
        public string? AfMby { get; set; }
        public int? AfUidm { get; set; }
        public long? AfUido { get; set; }
        public string? AfFormName { get; set; }
        public string? AfAlias { get; set; }
        public string? AfPickListFile { get; set; }
        public string? AfControlFile { get; set; }
        public short? AfX { get; set; }
        public short? AfY { get; set; }
        public short? AfFormWidth { get; set; }
        public short? AfListWidth { get; set; }
        public short? AfListIndex { get; set; }
        public short? AfFormHeight { get; set; }
        public int? AfColor { get; set; }
        public short? AfAttributes1 { get; set; }
        public short? AfAttributes2 { get; set; }
        public short? AfCounter { get; set; }
        public short? AfCounterType { get; set; }
        public short? AfLogChanges { get; set; }
        public string? AfDefaultValue { get; set; }
        public int? AfFldType { get; set; }
        public string? AfFormFieldname { get; set; }
        public int? AfFormNumber { get; set; }

        public virtual ICollection<FormRight> FormRights { get; set; }
    }
}
