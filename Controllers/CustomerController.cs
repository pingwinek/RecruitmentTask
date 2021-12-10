using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RecruitmentTask.Model;
using RecruitmentTask.Service;

namespace RecruitmentTask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly ICustomerService _customerService;

        public CustomerController(ILogger<CustomerController> logger, ICustomerService customerService)
        {
            _logger = logger;
            _customerService = customerService;
        }

        [HttpGet]
        public IEnumerable<Customer> GetAll()
        {
            return _customerService.GetCustomers();
        }

        [HttpGet]
        public IEnumerable<Customer> GetCustomer(int id)
        {
            return _customerService.GetCustomers().Where(x => x.Id == id);
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
