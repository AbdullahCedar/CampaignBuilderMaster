using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class SpamEmail
    {
        public long SeId { get; set; }
        public string SeEmail { get; set; } = null!;
        public int SeSource { get; set; }
        public DateTime SeDate { get; set; }
    }
}
