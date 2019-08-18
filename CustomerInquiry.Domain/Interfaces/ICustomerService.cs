using CustomerInquiry.Domain.Dto;
using System.Threading.Tasks;

namespace CustomerInquiry.Domain.Interfaces
{
    public interface ICustomerService
    {
        /// <summary>
        /// Gets customer with transactions from DB
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<CustomerDto> GetCustomerAsync(CustomerRequest request);
    }
}
