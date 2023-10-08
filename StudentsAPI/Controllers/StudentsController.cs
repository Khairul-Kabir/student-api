using DomainLayer.EF.EntityModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ICustomService;

namespace StudentsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ICustomService<Student> _customService;
        public StudentsController(ICustomService<Student> customService) 
        {
            _customService = customService;
        }

        [HttpGet(nameof(GetAllStudents))]
        public IActionResult GetAllStudents()
        {
            var obj =  _customService.GetAll();
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }

        [HttpPost(nameof(AddStudent))]
        public IActionResult AddStudent(Student student)
        {
            if (student == null)
            {
                return BadRequest();
            }
            else
            {
               _customService.Insert(student);
                return Ok("Created Successfully");
            }
        }

        [HttpPost(nameof(EditStudent))]
        public IActionResult EditStudent(Student student)
        {
            try
            {
                _customService.Update(student);
                return Ok("Update Successful");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost(nameof(DeleteStudent))]
        public IActionResult DeleteStudent(Student student)
        {
            try
            {
                _customService.Delete(student);
                return Ok("Update Successful");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
