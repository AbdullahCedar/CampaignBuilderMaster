using System;
using System.Collections.Generic;

namespace DAL.effortdb
{
    public partial class Sendgridall
    {
        public string? Email { get; set; }
        public int? Click { get; set; }
        public int? Open { get; set; }
        public int? GrandTotal { get; set; }
        public DateTime? Date { get; set; }
        public long? FileNum { get; set; }
        public int Id { get; set; }
    }
}
