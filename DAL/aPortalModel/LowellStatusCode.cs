using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class LowellStatusCode
    {
        public int Id { get; set; }
        public string CedarStatus { get; set; } = null!;
        public int LowellCode { get; set; }
    }
}
