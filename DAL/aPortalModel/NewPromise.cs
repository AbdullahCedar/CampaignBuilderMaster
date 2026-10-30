using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class NewPromise
    {
        public int? DeNumber { get; set; }
        public int? CoRowid { get; set; }
        public string? CoMby { get; set; }
        public DateTime? CoDate { get; set; }
        public string? CoOriginator { get; set; }
        public string? DeName { get; set; }
        public string? CoCby { get; set; }
        public double? CoAmount { get; set; }
        public string? CoDescription { get; set; }
        public int? DeCommisionRate { get; set; }
        public string? CoWho { get; set; }
    }
}
