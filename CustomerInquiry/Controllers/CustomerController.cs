using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerInquiry.Domain.Dto;
using CustomerInquiry.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerInquiry.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET api/customer
        [HttpGet]
        public async Task<CustomerDto> Get(CustomerRequest request)
        {
            var customer = await _customerService.GetCustomerAsync(request);
            return customer;
        }
    }
}
