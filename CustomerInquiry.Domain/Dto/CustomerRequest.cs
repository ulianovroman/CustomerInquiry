using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerInquiry.Domain.Dto
{
    /// <summary>
    /// Customer request model
    /// </summary>
    public class CustomerRequest
    {
        public int CustomerId { get; set; }
        public string Email { get; set; }
    }
}
