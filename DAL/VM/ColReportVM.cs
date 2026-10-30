namespace PortalApi.VMModels
{
    public class ColReportVM
    {
        public long DebtorRowId { get; set; }
    }
    public class addContactVM
    {
        public short? CoCompleted { get; set; }
        public string? CoDescription { get; set; }
        public short? CoType { get; set; }
        public short? CoClass { get; set; }
        // public DateTime? CoDate { get; set; }
        public decimal? CoAmount { get; set; }
        public short? CoPriority { get; set; }

        // public TimeSpan? CoTime { get; set; }

        public string? CoAttachment { get; set; }
        //public DateTime? CoCdate { get; set; }
        // public TimeSpan? CoCtime { get; set; }
    }
}
