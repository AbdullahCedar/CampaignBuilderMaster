using System;
using System.Collections.Generic;

namespace DAL.cv_demodbModel
{
    public partial class Token
    {
        public int TokenId { get; set; }
        public string? TokenText { get; set; }
        public string? TokenEmail { get; set; }
        public DateTime? TokenDate { get; set; }
    }
}
