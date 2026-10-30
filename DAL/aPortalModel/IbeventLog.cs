using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class IbeventLog
    {
        public int Id { get; set; }
        public int IbId { get; set; }
        public string EventType { get; set; } = null!;
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Status { get; set; } = null!;
        public string? PatientName { get; set; }
        public string? ClientName { get; set; }
        public int? ClientId { get; set; }
    }
}
