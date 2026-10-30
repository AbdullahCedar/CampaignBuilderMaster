using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class PythonPromise
    {
        public int Id { get; set; }
        public int? DeNumber { get; set; }
        public int? CoRowid { get; set; }
        public DateTime? CoCdate { get; set; }
        public string? CoCby { get; set; }
        public string? CoOriginator { get; set; }
        public string? CoMby { get; set; }
        public DateTime? CoMdate { get; set; }
        public string? DeName { get; set; }
        public string? CoDescription { get; set; }
        public double? CoAmount { get; set; }
        public string? DeCommissionRate { get; set; }
        public string? CoWho { get; set; }
        public DateTime? CoDate { get; set; }
    }
}
