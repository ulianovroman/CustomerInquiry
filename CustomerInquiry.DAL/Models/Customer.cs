using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerInquiry.DAL.Models
{
    /// <summary>
    /// Customer entity model
    /// </summary>
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [StringLength(maximumLength: 25)]
        [Required]
        
        public string Email { get; set; }

        [StringLength(maximumLength: 30)]
        [Required]
        public string Name { get; set; }

        [StringLength(maximumLength: 10)]
        [Required]
        public string Mobile { get; set; }
    }
}
