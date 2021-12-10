using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecruitmentTask.Model;

namespace RecruitmentTask.Service
{
    public class CustomerService : ICustomerService
    {
    public List<Customer> GetCustomers()
    {
        return new List<Customer>()
        {
            new Customer()
            {
                Id = 1,
                Name = "Adam Nowak",
                Age = 20,
                Email = "abcww@dsa.com",
                IsActive = true
            },
            new Customer()
            {
                Id = 1,
                Name = "Mariusz Pudzianowski",
                Age = 46,
                Email = "awdcbc@dsa.com",
                IsActive = true
            },
            new Customer()
            {
                Id = 1,
                Name = "Jan Wójcik",
                Age = 41,
                Email = "abpoilc@dsa.com",
                IsActive = false
            },
            new Customer()
            {
                Id = 1,
                Name = "Jerzy Kowalski",
                Age = 25,
                Email = "abcllll@dsa.com",
                IsActive = true
            }
        };
    }
    }
}