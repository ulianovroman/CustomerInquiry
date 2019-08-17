using CustomerInquiry.DAL.Enums;
using System;

namespace CustomerInquiry.Domain.Dto
{
    /// <summary>
    /// Transaction data transfer object
    /// </summary>
    public class TransactionDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public TransactionStatus Status { get; set; }
    }
}