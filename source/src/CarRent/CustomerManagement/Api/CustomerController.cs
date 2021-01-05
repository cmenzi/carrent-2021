// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRent.CustomerManagement.Api
{
    using CarRent.CustomerManagement.Application;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<CustomerDTO> Get()
        {
            return new CustomerDTO[] { new CustomerDTO(), new CustomerDTO() };
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public CustomerDTO Get(int id)
        {
            return new CustomerDTO();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] CustomerDTO customer)
        {
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CustomerDTO customer)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
