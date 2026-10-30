using DAL.cv_masterdbModel;
using PortalApi.VMModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Interfaces
{
    public interface IColReportRepository
    {
        // string AddContact(int FileNumber, string Description, Contact data);
        string AddContact(int fileNumber, string? description, addContactVM vM);
    }
}
