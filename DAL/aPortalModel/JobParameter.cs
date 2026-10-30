using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class JobParameter
    {
        public long JobId { get; set; }
        public string Name { get; set; } = null!;
        public string? Value { get; set; }
    }
}
