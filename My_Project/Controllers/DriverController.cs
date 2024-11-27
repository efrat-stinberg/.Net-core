using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace My_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {

        private readonly IDataContext _context;


        public DriverController(IDataContext context)
        {
            _context = context;
        }


        // GET: api/<StudentsController>
        [HttpGet]
        public IEnumerable<Driver> Get()
        {
            return _context.Drivers;
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var driver = _context.Drivers.Find(driver => driver.Id == id);
            if (driver == null)
            {
                return NotFound();
            }
            return Ok(driver);
        }


        // POST api/<StudentsController>
        [HttpPost]
        public void Post(int id, string name,string city)
        {
            _context.Drivers.Add(new Driver(id, name,city));
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, string name)
        {
            _context.Drivers.Find(student => student.Id == id).Name = name;
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Drivers.RemoveAll(student => student.Id == id);
        }
    }
}
