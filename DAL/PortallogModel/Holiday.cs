using System;
using System.Collections.Generic;

namespace DAL.PortallogModel
{
    public partial class Holiday
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string? Description { get; set; }
        public string? Office { get; set; }
        public string? Paid { get; set; }
        public string? Approved { get; set; }
    }
}
