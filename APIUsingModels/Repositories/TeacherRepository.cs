using APIUsingModels.Models;

namespace APIUsingModels.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        public static List<Teacher>teachers = new List<Teacher>();
        public void Add(Teacher teacher)
        {
            try
            {
                teachers.Add(teacher);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                foreach (var teacher in teachers)
                {
                    if (teacher.Id == id)
                    {
                        teachers.Remove(teacher);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Teacher GetTeacher(int id)
        {
            try
            {

                foreach (var teacher in teachers)
                {
                    if (teacher.Id == id)
                        return teacher;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Teacher> GetAll()
        {
            try
            {
                return teachers;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Teacher> GetTeachersBySubject(string subject)
        {
            try
            {
                List<Teacher> teacherswithsubject = new List<Teacher>();
                foreach (var teacher in teachers)
                {
                    if (teacher.Subject == subject)
                        teacherswithsubject.Add(teacher);
                }
                return teacherswithsubject;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Teacher teacher)
        {
            try
            {
                foreach (var item in teachers)
                {
                    if (item.Id == teacher.Id)
                    {
                        item.Subject = teacher.Subject;
                        item.Name = teacher.Name;
                       // item.Stds = teacher.Stds;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
