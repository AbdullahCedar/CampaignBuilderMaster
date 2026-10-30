
using DAL.cv_masterdbModel;
using DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using PortalApi.VMModels;

namespace PortalApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ColReportController : ControllerBase
    {
        private readonly IColReportRepository _repo;

        public ColReportController(IColReportRepository repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult AddContact(int fileNumber, string? description, addContactVM vM)
        {
            string result = _repo.AddContact(fileNumber, description, vM);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok();
        }


    }
}