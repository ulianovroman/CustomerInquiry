using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerInquiry.Domain.Dto
{
    /// <summary>
    /// Customer data transfer object
    /// </summary>
    public class CustomerDto
    {
        public int CustomerId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public List<TransactionDto> Transactions { get; set; }
    }
}
