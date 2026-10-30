using System;
using System.Collections.Generic;

namespace DAL.cv_cedarpakModel
{
    public partial class Country
    {
        public Country()
        {
            States = new HashSet<State>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Iso3 { get; set; }
        public string? Iso2 { get; set; }
        public string? Phonecode { get; set; }
        public string? Capital { get; set; }
        public string? Currency { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool Flag { get; set; }

        public virtual ICollection<State> States { get; set; }
    }
}
