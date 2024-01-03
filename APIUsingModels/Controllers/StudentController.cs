using APIUsingModels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIUsingModels.Controllers
{
    [Route("api/[controller]")]//roue apattern
    [ApiController]
    public class StudentController : ControllerBase
    {
        //define action methods of endpoints
        static List<Student> students = new List<Student>()
        {
            new Student{Id=234,Name="ooo",Age=10,Std="3" }
        };
        //add new student
        //generally we define  [HttpPost("addstudent")]
        [HttpPost,Route("AddStudent")]
        public Student Add(Student student)
        {
            students.Add(student);
            return student;
        }
        [HttpGet,Route("GetAll")]
        public List<Student> GetStudents()
        {
            return students;
        }
        [HttpGet,Route("GetStudentById/{id}")]
        public Student GetStudent(int id)
        {
            foreach (var student in students)
            {
                if(student.Id == id) return student;
            }
            return null;
        }
        [HttpGet, Route("GetStudentByName/{name}")]
        public Student GetStudent(string name)
        {
            foreach (var student in students)
            {
                if (student.Name == name) return student;
            }
            return null;
        }
        [HttpDelete,Route("DeleteByStudent/{id}")]
        public string Delete(int id)
        {
            try
            {
                Student student = null;
                foreach(var item in students)
                {
                    if (item.Id == id)
                    {
                        student = item;
                        break;
                    }
                }
                //remove student
                if (student != null)
                {
                    students.Remove(student);
                }
                return "student is deleted";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet,Route("GetStudentByNameandAge/{name}/{age}")]
        public Student GetStudentByNameandAge(string name, int age)
        {
            foreach(var student in students)
            {
                if (student.Name == name && student.Age==age) return student;
            }
            return null;
        }
    }
}
