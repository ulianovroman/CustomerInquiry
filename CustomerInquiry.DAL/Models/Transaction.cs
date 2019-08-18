using CustomerInquiry.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerInquiry.DAL.Models
{
    /// <summary>
    /// Transaction entity model
    /// </summary>
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }

        [StringLength(maximumLength : 3)]
        [Required]
        public string Currency { get; set; }
        public TransactionStatus Status { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
