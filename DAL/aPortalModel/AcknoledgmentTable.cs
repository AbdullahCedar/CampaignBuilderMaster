using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class AcknoledgmentTable
    {
        public int Id { get; set; }
        public string? FeatureName { get; set; }
        public string? TesterName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? PrjCtgryPhase { get; set; }
        public string? RequestedBy { get; set; }
        public string? AssignedTo { get; set; }
        public string? Status { get; set; }
        public DateTime? EstimatedStart { get; set; }
        public string? FollowUp { get; set; }
        public DateTime? EstimatedFinish { get; set; }
        public DateTime? ActualFinish { get; set; }
        public DateTime? TesterVrfdDate { get; set; }
        public DateTime? RqstrVrfdDate { get; set; }
    }
}
