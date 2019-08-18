using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerInquiry.Domain;
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
        public async Task<IActionResult> Get(CustomerRequest request)
        {
            if (request?.CustomerId == null && request?.Email == null)
            {
                return BadRequest("No inquiry criteria");
            }

            if (request.Email != null && (!Helpers.IsValidEmail(request.Email) || request.Email.Length > 25))
            {
                return BadRequest("Invalid Email");
            }

            if (request.CustomerId.HasValue && (request.CustomerId.Value <= 0 || request.CustomerId.Value > 9999999999))
            {
                return BadRequest("Invalid Customer ID");
            }

            var customer = await _customerService.GetCustomerAsync(request);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }
    }
}
