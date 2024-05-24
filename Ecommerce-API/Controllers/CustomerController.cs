using Microsoft.AspNetCore.Mvc;
using Proyecto_SportZone;
using Services.Customer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ecommerce_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ISvCustumer _svCustumer;
        public CustomerController(ISvCustumer svCustumer)
        {
            _svCustumer = svCustumer;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _svCustumer.GetAllcustomer();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Cliente Get(int id)
        {
            return _svCustumer.GetCostumerById(id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Cliente customer)
        {
            _svCustumer.Addcustomer(customer);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cliente customer)
        {
            _svCustumer.UpdateCustomer(id, new Cliente
            {
                Name = customer.Name,
                Email = customer.Email
            });
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _svCustumer.DeleteCustomer(id);
        }
        // GET api/<CustomerController>/5
        [HttpGet("{email}")]
        public void Search(string _mail)
        {
            _svCustumer.SearchByEmail(_mail);
        }
    }
}
