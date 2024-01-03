using APIUsingModels.Models;
using APIUsingModels.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIUsingModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepository teacherRepository;
        public TeacherController() { 
            teacherRepository = new TeacherRepository();
        }
        //endpoints
        [HttpGet,Route("GetAllTeacher")]

        public IActionResult GetAll() 
        {
            try
            {
                List<Teacher> teachers = teacherRepository.GetAll();
                return StatusCode(200, teachers);
            }
            catch (Exception ex)
            {

               return StatusCode(501,ex);
            }
        }
        [HttpGet,Route("GetTeacherById/{id}")]
        public IActionResult GetTeacher(int id) {
            try
            {
                Teacher teacher = teacherRepository.GetTeacher(id);
                if (teacher != null) return StatusCode(200, teacher);
                else return StatusCode(404, new JsonResult("invalid teacher id"));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpGet,Route("GetTeachersBySubject/{subject}")]
        public IActionResult GetTeachersBySubject(string subject) 
        {
            try
            {
                return StatusCode(200, teacherRepository.GetTeachersBySubject(subject));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpPost,Route("AddTeacher")]
        public IActionResult Add(Teacher teacher)
        {
            try
            {
                teacherRepository.Add(teacher);
                return StatusCode(200);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpPut,Route("UpdateTeacher")]
        public IActionResult Update(Teacher teacher)
        {
            try
            {
                teacherRepository.Update(teacher);
                return StatusCode(200, teacher);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpDelete, Route("DeleteTeacher/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                teacherRepository.Delete(id);
                return StatusCode(200,new JsonResult("deleted"));
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }

    }
}
