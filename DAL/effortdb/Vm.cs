using System;
using System.Collections.Generic;

namespace DAL.effortdb
{
    public partial class Vm
    {
        public int Id { get; set; }
        public string? Audio { get; set; }
        public long? CallTo { get; set; }
        public long? CallerId { get; set; }
        public DateTime? CallTime { get; set; }
        public string? DeliveryStatus { get; set; }
        public string? Carrier { get; set; }
        public string? CarrierType { get; set; }
        public string? ReasonForFailure { get; set; }
        public long? FileNum { get; set; }
        public long? DeGroupId { get; set; }
    }
}
