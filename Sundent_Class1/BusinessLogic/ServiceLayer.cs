using Sundent_Class1.Models;

namespace Sundent_Class1.BusinessLogic
{
    public class ServiceLayer
    {
        List<Student> students = new List<Student>();
        public ServiceLayer() {
           
            students.Add(new Student { Id = 1, Name = "James", Description = "SS 1", StudentCode = 545346536 });
            students.Add(new Student { Id = 1, Name = "Peter", Description = "SS 2", StudentCode = 545346536 });
            students.Add(new Student { Id = 1, Name = "Pual", Description = "SS 4", StudentCode = 545346536 });
            students.Add(new Student { Id = 1, Name = "Mac Peters", Description = "SS 12", StudentCode = 545346536 });
        }
        public List<Student> GetStudent()
        {
           var res = students.ToList();
            return res;
        }
    }
}
