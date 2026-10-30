using DAL.cv_masterdbModel;
using DAL.Interfaces;
using Microsoft.Extensions.Configuration;
using PortalApi.VMModels;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class ColReportRepository : IColReportRepository
    {
        private readonly cv_masterdbContext _context;
        public IConfiguration _configuration;
        public ColReportRepository(cv_masterdbContext db, IConfiguration config)
        {
            _context = db;
            _configuration = config;

        }
        //public async Task<ServiceResponse<object>> AddContact(int FileNumber, string Description, NewContactDto dtoData)
        public string AddContact(int FileNumber, string? Description, addContactVM vM)
        {
            var ObjRowid = (from m in _context.Debtors
                        join o in _context.Contacts on m.DeRowid equals o.CoRowidDebtor
                        where m.DeNumber == FileNumber && o.CoDescription == Description && o.CoDescription != null
                            select new
                        {
                            m.DeRowid
                        }).FirstOrDefault();

            if (ObjRowid != null)
            {
                
                var existingContacts = _context.Contacts.Where(x => x.CoRowidDebtor == ObjRowid.DeRowid && x.CoDescription == Description).ToList();

                foreach (var contact in existingContacts)
                {
                    contact.CoCompleted = false ? 1 : 1;// Correct the logic for assigning the value
                    contact.CoDoneDate = DateTime.Now.Date;
                    contact.CoDoneTime = DateTime.Now.TimeOfDay;
                }

                _context.Contacts.UpdateRange(existingContacts);
                _context.SaveChanges();
                return "Add successfully";
            }
            else
            {
                var newContacts = (from m in _context.Debtors
                                   where m.DeNumber == FileNumber
                                   select new 
                                   {

                                        m.DeRowid

                                   }).FirstOrDefault();

                if (newContacts != null )
                {
                    var objnewContact = new Contact
                    {
                        CoRowidDebtor = newContacts.DeRowid,
                        CoCompleted = vM.CoCompleted,
                        CoDescription = vM.CoDescription,
                        CoType = vM.CoType,
                        CoClass = vM.CoClass,
                        CoAmount = vM.CoAmount,
                        CoPriority = vM.CoPriority,
                        CoAttachment = vM.CoAttachment,
                    };

                    _context.Contacts.Add(objnewContact);
                    _context.SaveChanges();
                    return "Add successfully";
                }
            }


            return "";



        }

    }
}
