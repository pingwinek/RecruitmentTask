using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecruitmentTask.Model;

namespace RecruitmentTask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return null;
        }

        [HttpPost(nameof(InsertCustomer))]  
        public IActionResult InsertCustomer(Customer customer)  
        {  
            return Ok();  
        }  

        [HttpPut(nameof(UpdateCustomer))]  
        public IActionResult UpdateCustomer(Customer customer)  
        {  
            return Ok();  
        }  

        [HttpDelete(nameof(DeleteCustomer))]  
        public IActionResult DeleteCustomer(int Id)  
        {   
            return Ok();  
        } 
    }
}
