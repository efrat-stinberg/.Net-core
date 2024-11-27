using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace My_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {

        private readonly IDataContext _context;

        public AdminController(IDataContext context)
        {
            _context = context;
        }


        // GET: api/<AdminControllers>
        [HttpGet]
        public IEnumerable<Admin> Get()
        {
            return _context.
        }

        // GET api/<AdminControllers>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AdminControllers>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AdminControllers>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AdminControllers>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
