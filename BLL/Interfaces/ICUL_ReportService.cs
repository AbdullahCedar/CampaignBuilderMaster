using DAL.VM;

namespace BLL.Interfaces
{
    public interface ICUL_ReportService
    {
        Task<dynamic> ColReportIndex(CUL_Report_Parameters col, string constrr);

        Task<dynamic> CosignerReport(CUL_Report_Parameters col, string constrr);
        
        Task<dynamic> CosignerEmail(CUL_Report_Parameters col, string constrr);
        Task<dynamic> WIPEmailCampaign(WipEmail col, string constrr);
        Task<dynamic> SMSCWipCampaign(SMSCWip col, string constrr);
        Task<dynamic> GetPortalToken(string fileNumber, string debtorEmail, string country, string coDescription);

    }
}
