using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Repositories;
using DAL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CUL_ReportService : ICUL_ReportService
    {
        private readonly ICUL_ReportRepository _culReportRepository;

        public CUL_ReportService(ICUL_ReportRepository CULDAL)
        {
            _culReportRepository = CULDAL;
        }
        public async Task<dynamic> ColReportIndex(CUL_Report_Parameters col, string constrr)
        {
            try
            {
                var response = await _culReportRepository.ColReportIndex(col, constrr);
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<dynamic> CosignerReport(CUL_Report_Parameters col, string constrr)
        {
            try
            {
                var response = await _culReportRepository.CosignerReport(col, constrr);
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<dynamic> CosignerEmail(CUL_Report_Parameters col, string constrr)
        {
            try
            {
                var response = await _culReportRepository.CosignerEmail(col, constrr);
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } 
        public async Task<dynamic> WIPEmailCampaign(WipEmail col, string constrr)
        {
            try
            {
                var response = await _culReportRepository.WIPEmailCampaign(col, constrr);
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<dynamic> SMSCWipCampaign(SMSCWip col, string constrr)
        {
            try
            {
                var response = await _culReportRepository.SMSCWipCampaign(col, constrr);
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<dynamic> GetPortalToken(string FileNumber, string debtorEmail, string country, string coDescription)
        {
            try
            {
                var response = _culReportRepository.GetPortalToken(FileNumber, country,debtorEmail, coDescription);
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
       
    }
}
