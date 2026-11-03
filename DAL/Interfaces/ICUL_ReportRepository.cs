using DAL.VM;

namespace DAL.Interfaces
{
    public interface ICUL_ReportRepository
    {
        Task<List<CUL_Report>> ColReportIndex(CUL_Report_Parameters col, string constrr);
        Task<List<CUL_Report>> CosignerReport(CUL_Report_Parameters col, string constrr);
        //Task<List<EmailReport>> CosignerEmail(CUL_Report_Parameters col, string constrr);
        Task<List<dynamic>> CosignerEmail(CUL_Report_Parameters col, string constrr);
        Task<List<dynamic>> WIPEmailCampaign(WipEmail col, string constrr);
       //Task<List<EmailReport>> WIPEmailCampaign(WipEmail col, string constrr);
        public string GetPortalToken(string FileNumber, string debtorEmail, string country, string coDescription);
        Task<List<SMSCreport>> SMSCWipCampaign(SMSCWip col, string constrr);

    }
}

