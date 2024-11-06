using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace My_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Admin : ControllerBase
    {
        private static List<Admin> admin = new List<Admin> { new Admin(), new Admin() };
  


        // GET: api/<Admin>
        [HttpGet]
        public IEnumerable<Admin> Get()
        {
            return admin;
        }

        // GET api/<Admin>/5
        [HttpGet("{id}")]
        public Admin Get(int id)
        {
            return admin.FirstOrDefault(student => student.Id == id);
        }

        // POST api/<Admin>
        [HttpPost]
        public void Post(Admin admin1)
        {
            admin.Add(admin1);
        }

        // PUT api/<Admin>/5
        [HttpPut("{id}")]
        public void Put(int level)
        {
            admin.Find(admin => admin.Level == level).Level = admin.Level + 1;
        }

        // DELETE api/<Admin>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            admin.RemoveAll(admin => admin.Id == id);
        }
    }
}
