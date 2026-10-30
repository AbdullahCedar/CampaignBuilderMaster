using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class Qbdatum
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Data { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public DateTime? Date { get; set; }
    }
}
