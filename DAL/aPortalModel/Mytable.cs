using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class Mytable
    {
        public int DeNumber { get; set; }
        public int CoRowid { get; set; }
        public string CoMby { get; set; } = null!;
        public DateTime CoDate { get; set; }
        public string CoOriginator { get; set; } = null!;
        public string DeName { get; set; } = null!;
        public string CoCby { get; set; } = null!;
        public decimal CoAmount { get; set; }
        public string CoDescription { get; set; } = null!;
        public decimal CoCommisionRate { get; set; }
    }
}
