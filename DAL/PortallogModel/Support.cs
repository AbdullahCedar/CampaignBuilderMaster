using System;
using System.Collections.Generic;

namespace DAL.PortallogModel
{
    public partial class Support
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Activity { get; set; }
        public string? Url { get; set; }
        public string? ErrorOnLine { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public DateTime? Date { get; set; }
        public string? Time { get; set; }
        public string? Status { get; set; }
        public string? FixedBy { get; set; }
    }
}
