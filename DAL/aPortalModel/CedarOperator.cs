using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class CedarOperator
    {
        public int Id { get; set; }
        public string? CopId { get; set; }
        public string? CopPassword { get; set; }
        public string? CimgUrl { get; set; }
        public DateTime? CopCdate { get; set; }
    }
}
