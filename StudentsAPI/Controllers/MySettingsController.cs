using DomainLayer.EF.EntityModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ICustomService;

namespace StudentsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MySettingsController : ControllerBase
    {
        private readonly ICustomService<UserOutOfOffice> _customService;
        public MySettingsController(ICustomService<UserOutOfOffice> customService)
        {
            _customService = customService;
        }
        [HttpGet(nameof(GetUserOutOfOffice))]
        public IActionResult GetUserOutOfOffice() 
        {
            var result =  _customService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost(nameof(GetUserOutOfOffice))]
        public IActionResult GetUserOutOfOffice(int id)
        {
            var result = _customService.Get(1);
            return Ok(result);
        }
        [HttpPost(nameof(AddUserOutOfOffcie))]
        public IActionResult AddUserOutOfOffcie(UserOutOfOffice userOutOfOffice)
        {
            _customService.Insert(userOutOfOffice);
            return Ok();
        }
        [HttpPost(nameof(UpdateUserOutOfOffcie))]
        public IActionResult UpdateUserOutOfOffcie(UserOutOfOffice userOutOfOffice)
        {
            _customService.Update(userOutOfOffice);
            return Ok();
        }
    }
}
