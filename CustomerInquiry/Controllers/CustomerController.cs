using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerInquiry.Domain.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CustomerInquiry.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        // GET api/customer
        [HttpGet]
        public CustomerDto Get(CustomerRequest request)
        {
            return new CustomerDto();
        }
    }
}
