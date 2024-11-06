using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace My_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private static List<Student> students = new List<Student> {new Student(1,"Sara") , new Student(2,"Yael")};
        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return students.FirstOrDefault(student => student.Id == id);
        }

        // POST api/<StudentsController>
        [HttpPost]
        public void Post(int id, string name)
        {
            students.Add(new Student(id, name));
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, string name)
        {
            students.Find(student => student.Id == id).Name = name;
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            students.RemoveAll(student => student.Id == id);
        }
    }
}
