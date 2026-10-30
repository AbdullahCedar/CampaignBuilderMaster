using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class DataTicketsNote
    {
        public int Id { get; set; }
        public DateTime? NoteDate { get; set; }
        public string? NoteTime { get; set; }
        public string? NoteText { get; set; }
        public string? CitationCode { get; set; }
        public string? Citation { get; set; }
        public string? DebtorName { get; set; }
        public string? Address { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? CellPhone { get; set; }
        public string? HomePhone { get; set; }
        public string? WorkPhone { get; set; }
        public string? OtherPhone { get; set; }
    }
}
