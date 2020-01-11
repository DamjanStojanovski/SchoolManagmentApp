using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System.Collections.Generic;
using WebModels;

namespace SchoolManagmentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MuncipalityController : ControllerBase
    {
        private readonly ISchoolService _schoolService;
        private readonly IMuncipalityService _muncipalityService;

        public MuncipalityController(ISchoolService schoolService,IMuncipalityService muncipalityService)
        {
            _schoolService = schoolService;
            _muncipalityService = muncipalityService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MuncipalityViewModel>> GetMuncipalities()
        {
            var muncipalities = _muncipalityService.GetAllMuncipalities();
            return Ok(muncipalities);
        }
<<<<<<< HEAD
=======
        public ActionResult<IEnumerable<MuncipalityViewModel>> GetMuncipalityById( Guid id)
        {
            var muncipality = _muncipalityService.GetMuncipalityById(id);
            return Ok(muncipality);
        }

>>>>>>> parent of e625976... new action

      

    }
}