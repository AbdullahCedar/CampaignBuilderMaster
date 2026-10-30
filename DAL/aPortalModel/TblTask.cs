using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class TblTask
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Department { get; set; }
        public string? TicketType { get; set; }
        public string? IssueType { get; set; }
        public string? RequestedPriority { get; set; }
        public DateTime? RequestedEta { get; set; }
        public bool? HardDeadline { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public string? Attachments { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
