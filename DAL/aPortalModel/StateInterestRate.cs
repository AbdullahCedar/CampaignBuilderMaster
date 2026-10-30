using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class StateInterestRate
    {
        public int Id { get; set; }
        public string? StateName { get; set; }
        public string? InterestRate1 { get; set; }
        public string? InterestRate2 { get; set; }
    }
}
