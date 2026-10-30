using System;
using System.Collections.Generic;

namespace DAL.effortdb
{
    public partial class OpGoal
    {
        public int OgRowid { get; set; }
        public DateTime? OgDate { get; set; }
        public string? OgOperator { get; set; }
        public double? OgGoal { get; set; }
    }
}
