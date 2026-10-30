using System;
using System.Collections.Generic;

namespace DAL.cv_demodbModel
{
    public partial class Country
    {
        public int Id { get; set; }
        public string? Sortname { get; set; }
        public string? Name { get; set; }
        public int? Phonecode { get; set; }
    }
}
