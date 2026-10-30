using System;
using System.Collections.Generic;

namespace DAL.effortdb
{
    public partial class Rcvd
    {
        public string? Debtor { get; set; }
        public string? Type { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? Time { get; set; }
        public int? Priority { get; set; }
        public decimal? Processed { get; set; }
        public decimal? Attachment { get; set; }
        public string? Description { get; set; }
        public string? Collector { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Elapsed { get; set; }
        public string? Repeat { get; set; }
        public decimal? NumberOfDays { get; set; }
        public decimal? Class { get; set; }
        public string? AdvanceOverpayments { get; set; }
        public string? DoNotAutodelete { get; set; }
        public string? NoAutocomplete { get; set; }
        public string? RecordEventHistory { get; set; }
        public string? InProgress { get; set; }
        public string? Completed { get; set; }
        public string? AssignedBy { get; set; }
        public string? Done { get; set; }
        public DateTime? DoneDate { get; set; }
        public TimeSpan? DoneTime { get; set; }
        public string? DoneBy { get; set; }
        public string? Status { get; set; }
        public decimal? Client { get; set; }
        public string? Originator { get; set; }
        public DateTime? CreatedDate { get; set; }
        public TimeSpan? CreatedTime { get; set; }
        public decimal? File { get; set; }
        public string? HomePhone { get; set; }
        public string? WorkPhone { get; set; }
        public string? ClientAccount { get; set; }
        public string? Contact { get; set; }
        public string? Dl { get; set; }
        public string? Ssn { get; set; }
        public decimal? Uid { get; set; }
        public DateTime? Created { get; set; }
        public TimeSpan? Ctime { get; set; }
        public string? Cby { get; set; }
        public DateTime? Modified { get; set; }
        public TimeSpan? Mtime { get; set; }
        public string? Mby { get; set; }
        public decimal? C1 { get; set; }
        public decimal? C2 { get; set; }
        public decimal? C3 { get; set; }
        public decimal? Estimate { get; set; }
        public string? CreateCopyOnRepeat { get; set; }
        public string? LogRepeatToNotes { get; set; }
        public string? Copy { get; set; }
        public decimal? NumberOfPayments { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? Date2 { get; set; }
        public decimal? Day { get; set; }
        public decimal? Promised { get; set; }
        public decimal? RunPlanOnCompletion { get; set; }
        public string? RcvdStatus { get; set; }
    }
}
