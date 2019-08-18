using CustomerInquiry.DAL;
using CustomerInquiry.DAL.Models;
using CustomerInquiry.Domain.Dto;
using CustomerInquiry.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInquiry.Domain.Services
{
    public class CustomerService : ICustomerService
    {
        public CustomerContext _dbContext;
        public CustomerService(CustomerContext context)
        {
            _dbContext = context;
        }

        public async Task<CustomerDto> GetCustomerAsync(CustomerRequest request)
        {
            if(request?.CustomerId == null && request?.Email == null)
            {
                throw new ArgumentException(nameof(request));
            }

            IQueryable<Customer> query = _dbContext.Customers;
            
            if(request.CustomerId != null)
            {
                query = query.Where(x => x.Id == request.CustomerId);
            }

            if(request.Email != null)
            {
                query = query.Where(x => x.Email == request.Email);
            }

            var dto = await query.Select(x => new CustomerDto
            {
                CustomerId = x.Id,
                Name = x.Name,
                Mobile = x.Mobile,
                Email = x.Email
            })
            .FirstOrDefaultAsync();

            if(dto != null)
            {
                dto.Transactions = await _dbContext.Transactions
                .Where(x => x.CustomerId == dto.CustomerId)
                .Select(x => new TransactionDto
                {
                    Id = x.Id,
                    Amount = x.Amount,
                    Currency = x.Currency,
                    Date = x.Date,
                    Status = x.Status
                })
                .OrderByDescending(x => x.Date)
                .Take(5)
                .ToListAsync();
            }
            
            return dto;
        }
    }
}
