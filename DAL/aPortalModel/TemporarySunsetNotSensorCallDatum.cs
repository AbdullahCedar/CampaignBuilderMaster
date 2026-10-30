using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class TemporarySunsetNotSensorCallDatum
    {
        public long? DeNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? DeListedDate { get; set; }
        public string? DeStatus { get; set; }
        public double? DeOwing { get; set; }
        public long? Rpc { get; set; }
        public long? Attempts { get; set; }
    }
}
