using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class SimpleLog
    {
        public int Id { get; set; }
        public string OpId { get; set; } = null!;
        public string Date { get; set; } = null!;
        public string? Time { get; set; }
        public string Type { get; set; } = null!;
        public string? Description { get; set; }
    }
}
