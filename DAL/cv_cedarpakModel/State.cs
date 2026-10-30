using System;
using System.Collections.Generic;

namespace DAL.cv_cedarpakModel
{
    public partial class State
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CountryId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Flag { get; set; }

        public virtual Country Country { get; set; } = null!;
    }
}
