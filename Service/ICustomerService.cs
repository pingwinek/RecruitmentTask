using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecruitmentTask.Model;

namespace RecruitmentTask.Service
{
    public interface ICustomerService
    {
        public List<Customer> GetCustomers();
    }
}