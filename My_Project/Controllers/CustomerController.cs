using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace My_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly IDataContext _context;

        public CustomerController(IDataContext context)
        {
            _context = context;
        }



        // GET: api/<Customers>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _context.Customers;
        }

        // GET api/<Customers>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var customer = _context.Customers.Find(customer => customer.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        // POST api/<Customers>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Customers>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Customers>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
