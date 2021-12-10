using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using RecruitmentTask.Controllers;
using RecruitmentTask.Model;
using RecruitmentTask.Service;
using Xunit;

namespace RecruitmentTask.Tests
{
    public class CustomerControllerTest
    {
        private readonly CustomerController _customerController;
        private readonly ICustomerService _customerService;
        private readonly ILogger<CustomerController> _logger;

        public CustomerControllerTest(ICustomerService customerService, ILogger<CustomerController> logger)
        {
            _customerService = customerService;
            _logger = logger;
            _customerController = new CustomerController(_logger, _customerService);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _customerController.GetAll();
            // Assert
            Assert.IsType<Customer>(okResult as Customer);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllObjects()
        {
            // Act
            var result = _customerController.GetAll() as Customer;
            // Assert
            var items = Assert.IsType<List<Customer>>(result.IsActive);
            Assert.Equal(4, items.Count);
        }

        [Fact]
        public void Add_ValidObjectPassed_ReturnsResponse()
        {
            // Arrange
            Customer customer = new Customer()
            {
                Id = 5,
                Name = "John Doe",
                Age = 50,
                Email = "qqq@ooo.com",
                IsActive = true
            };
            // Act
            var response = _customerController.InsertCustomer(customer);
            // Assert
            Assert.IsType<Customer>(response);
        }
    }
}